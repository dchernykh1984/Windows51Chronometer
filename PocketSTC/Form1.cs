using System.Threading;
using System.IO;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FTP_component;

namespace PocketSTC
{

    public partial class FormCompetitors : Form
    {
        static String currentPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
        List<string> listOfStringsToWrite;
        bool resultsFileUploaded = true;
        bool resultsFileUploadInProgress = false;
        String filePathGroups = currentPath + "\\groups.txt";
        String filePathResults = currentPath + "\\results.txt";
        String simultaneousGroupsStartDeliminer = ",;#";
        bool useTimeSummerTimeShifting = false;
        bool finishCompetitors = false;
        static String pointNumber = "1";
        bool useFTP = true;
        String ftpSite = "pulse-sports.ru";
        String ftpDirectory = "ftpDirectory";
        String ftpLogin = "ftpLogin";
        String ftpPassword = "ftpPassword";
        String fileFTPName = "results_" + pointNumber + ".txt";

        public FormCompetitors()
        {
            InitializeComponent();
            listOfStringsToWrite = new List<string>();
        }

        private void buttonNextCompetitor_Click(object sender, EventArgs e)
        {
            nextCompetitorClicked();
        }
        private bool writeToFile(String fileName, String value)
        {
            return writeToFile(fileName, value, true);
        }

        private bool writeToFile(String fileName, String value, bool writeToListBox)
        {
            if (fileName.Equals(string.Empty))
            {
                MessageBox.Show("File was not opened!");
                return false;
            }
            else
            {
                System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(fileName, true);
                streamWriter.WriteLine(value);
                streamWriter.Close();
                if (writeToListBox)
                {
                    listBoxEvents.Items.Insert(0, value);
                }
                if (fileName == filePathResults)
                {
                    listOfStringsToWrite.Insert(listOfStringsToWrite.Count, value);
                }
                return true;
            }
        }
        private void saveStringIntoFileForUploading()
        {
            try
            {
                while (listOfStringsToWrite.Count != 0)
                {
                    System.IO.StreamWriter streamTranslationWriter = new System.IO.StreamWriter(currentPath + "\\" + fileFTPName, true);
                    streamTranslationWriter.WriteLine(listOfStringsToWrite.ToArray()[0]);
                    streamTranslationWriter.Close();
                    listOfStringsToWrite.RemoveAt(0);
                    resultsFileUploaded = false;
                }
            }
            catch (Exception e)
            {
            }
    }

        private void timerFTPUpload_Tick(object sender, EventArgs e)
        {
            if (useFTP && !resultsFileUploadInProgress)
            {
                Thread uploadThread = new Thread(ftpUpload);
                uploadThread.Start();
            }
        }



        private void ftpUpload()
        {
            resultsFileUploadInProgress = true;
            try
            {
                saveStringIntoFileForUploading();

                if (!resultsFileUploaded)
                {
                    ftpUpload(currentPath + "\\" + fileFTPName,
                            fileFTPName,
                            ftpSite,
                            ftpDirectory);
                }
            }
            catch (Exception e)
            {
            }
            resultsFileUploadInProgress = false;
        }
        private void ftpUpload(String localFilePath/*local file path with full address /Карта Памяти/timer/results_1.txt*/,
    String remoteFileName/*filename only - without full path*/
    , String remoteSite/*site only without directory or something else, i.e. pulse-sports.ru*/,
    String remoteDirectory/*i.e. for example /home/d2011611-1/www/dchernykh/ */)
        {
            FTP_component.MyFTP MyFTP = new FTP_component.MyFTP();

            if (MyFTP.ConnectToNet("http://" + remoteSite))
            {
                if (MyFTP.InternetAttemptConnect())
                {
                    IntPtr Handle1 = MyFTP.InternetOpen();
                    if (Handle1 != IntPtr.Zero)
                    {
                        IntPtr Handle2 = MyFTP.InternetConnect(Handle1, remoteSite, 21, ftpLogin, ftpPassword);
                        if (Handle2 != IntPtr.Zero)
                        {
                            if (MyFTP.ChangeDirectory(Handle2, remoteDirectory))
                            {
                                if (MyFTP.GetNamesFilesInDir(Handle2, remoteFileName).Count == 0)
                                {
                                    if (MyFTP.UploadFile(Handle2, localFilePath, remoteFileName))
                                    {
                                        resultsFileUploaded = true;
                                    }
                                }
                            }
                            MyFTP.CloseConnection(Handle2);
                        }
                        MyFTP.CloseConnection(Handle1);
                    }
                }
            }
        }


        private void nextCompetitorClicked()
        {
            String newResult = getResultLogStringByActionAndID(finishCompetitors ? "finish" : "nextLap", textBoxCompetitorNumber.Text, getCurrentTime());
            bool infoInFile = false;
            if (textBoxCompetitorSecond.Text.Equals(String.Empty))
            {
                textBoxCompetitorSecond.Text = newResult;
                textBoxCompetitorNumber.Text = String.Empty;
            }
            else if (textBoxCompetitorFirst.Text.Equals(String.Empty))
            {
                textBoxCompetitorFirst.Text = newResult;
                textBoxCompetitorNumber.Text = String.Empty;
            }
            else
            {
                infoInFile = writeToFile(filePathResults, textBoxCompetitorSecond.Text);
                if (infoInFile)
                {
                    textBoxCompetitorSecond.Text = textBoxCompetitorFirst.Text;
                    textBoxCompetitorFirst.Text = newResult;
                }
            }
            if (infoInFile)
            {
                textBoxCompetitorNumber.Text = String.Empty;
            }
            textBoxCompetitorNumber.Focus();
        }

        private String getResultLogStringByActionAndID(String action, String objectId, String currentTime)
        {
            return objectId + "#" + currentTime + "#" + action + "#";
        }
        private String getCurrentTime() {

            DateTime time = DateTime.Now;
            if (!useTimeSummerTimeShifting && time.IsDaylightSavingTime())
            {
                time.AddHours(-1);
            }
            String currentTime = getDaysFrom1970(time) + " " + time.Hour.ToString() + ":" + time.Minute.ToString() + ":" + time.Second.ToString() + "." + time.Millisecond.ToString();
            return currentTime;
		 }
        private String getDaysFrom1970(DateTime time)
        {
            int dayFrom1970 = time.DayOfYear-1;
            for (int i = 1970; i < time.Year; i++)
            {
                dayFrom1970 += DateTime.IsLeapYear(i) ? 366 : 365;
            }
            return dayFrom1970.ToString();

        }

        private void textBoxCompetitorNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.Equals(Keys.Enter)) {
                nextCompetitorClicked();
            }
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                saveAllFields();
                Application.Exit();
            }
        }

        private void menuItemSettings_Click(object sender, EventArgs e)
        {
            FormSettings settings = new FormSettings();
            settings = new FormSettings();
            settings.getTextBoxGroupFile().Text = filePathGroups;
            settings.getTextBoxResultsFile().Text = filePathResults;
            settings.getTextBoxSimultaneousGroupsStartDeliminer().Text = simultaneousGroupsStartDeliminer;
            settings.getCheckBoxFinishCompetitors().Checked = finishCompetitors;
            settings.getCheckBoxUseSummerTimeShifting().Checked = useTimeSummerTimeShifting;
            settings.getCheckBoxFTPUpload().Checked = useFTP;
            settings.getTextBoxPointNumber().Text = pointNumber;
            settings.getTextBoxFTPDirectory().Text = ftpDirectory;
            settings.getTextBoxFTPSite().Text = ftpSite;
            settings.getTextBoxFTPLogin().Text = ftpLogin;
            settings.getTextBoxFTPPassword().Text = ftpPassword;

            bool result = (DialogResult.OK == settings.ShowDialog());
            if (settings.result || result)
            {
                finishCompetitors = settings.getCheckBoxFinishCompetitors().Checked;
                useTimeSummerTimeShifting = settings.getCheckBoxUseSummerTimeShifting().Checked;
                filePathGroups = settings.getTextBoxGroupFile().Text;
                filePathResults = settings.getTextBoxResultsFile().Text;
                simultaneousGroupsStartDeliminer = settings.getTextBoxSimultaneousGroupsStartDeliminer().Text;
                useFTP = settings.getCheckBoxFTPUpload().Checked;
                pointNumber = settings.getTextBoxPointNumber().Text;
                ftpDirectory = settings.getTextBoxFTPDirectory().Text;
                ftpSite = settings.getTextBoxFTPSite().Text;
                ftpLogin = settings.getTextBoxFTPLogin().Text;
                ftpPassword = settings.getTextBoxFTPPassword().Text;
                fileFTPName = "results_" + pointNumber + ".txt";
                saveConfiguration();
            }
        }

        private void buttonStartGroup_Click(object sender, EventArgs e)
        {
            saveGroups();
            textBoxGroupID.Focus();
        }
        private void saveGroups()
        {
            String time = getCurrentTime();
            String[] startedGroups = textBoxGroupID.Text.Split(simultaneousGroupsStartDeliminer.ToCharArray());
            bool infoInFile = true;
            for (int i = 0; i < startedGroups.Length; i++)
            {
                infoInFile &= writeToFile(filePathGroups, startedGroups[i] + "#" + time + "#");
            }
            if (infoInFile)
            {
                textBoxGroupID.Text = String.Empty;
            }
        }

        private void saveAllFields()
        {
            if (textBoxCompetitorSecond.Text != String.Empty)
            {
                if (writeToFile(filePathResults, textBoxCompetitorSecond.Text))
                {
                    textBoxCompetitorSecond.Text = String.Empty;
                }
                else
                {
                    return;
                }
            }
            if (textBoxCompetitorFirst.Text != String.Empty)
            {
                if (writeToFile(filePathResults, textBoxCompetitorFirst.Text))
                {
                    textBoxCompetitorFirst.Text = String.Empty;
                }
                else
                {
                    return;
                }
            }
        }
        
        private void buttonSaveAllFields_Click(object sender, EventArgs e)
        {
            saveAllFields();
        }

        private void textBoxGroupID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Keys.Enter))
            {
                saveGroups();
            }
        }

        private void checkBoxGroupCompetitor_CheckStateChanged(object sender, EventArgs e)
        {
            textBoxGroupID.Visible = checkBoxGroupCompetitor.Checked;
            textBoxCompetitorNumber.Visible = !checkBoxGroupCompetitor.Checked;
            labelGroup.Visible = checkBoxGroupCompetitor.Checked;
            labelNumber.Visible = !checkBoxGroupCompetitor.Checked;
            buttonNextCompetitor.Visible = !checkBoxGroupCompetitor.Checked;
            buttonStartGroup.Visible = checkBoxGroupCompetitor.Checked;
            textBoxCompetitorFirst.ReadOnly = checkBoxGroupCompetitor.Checked;
            textBoxCompetitorSecond.ReadOnly = checkBoxGroupCompetitor.Checked;
            buttonSaveAllFields.Enabled = !checkBoxGroupCompetitor.Checked;
            buttonZero.Enabled = !checkBoxGroupCompetitor.Checked;
            button1.Enabled = !checkBoxGroupCompetitor.Checked;
            button2.Enabled = !checkBoxGroupCompetitor.Checked;
            button3.Enabled = !checkBoxGroupCompetitor.Checked;
            button4.Enabled = !checkBoxGroupCompetitor.Checked;
            button5.Enabled = !checkBoxGroupCompetitor.Checked;
            button6.Enabled = !checkBoxGroupCompetitor.Checked;
            button7.Enabled = !checkBoxGroupCompetitor.Checked;
            button8.Enabled = !checkBoxGroupCompetitor.Checked;
            button9.Enabled = !checkBoxGroupCompetitor.Checked;
            buttonBackSpace.Enabled = !checkBoxGroupCompetitor.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonDigitClicked("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonDigitClicked("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonDigitClicked("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonDigitClicked("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonDigitClicked("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonDigitClicked("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttonDigitClicked("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttonDigitClicked("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buttonDigitClicked("9");
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            buttonDigitClicked("0");
        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            int startPosition = textBoxCompetitorNumber.SelectionStart;
            int endPosition = startPosition + textBoxCompetitorNumber.SelectionLength;
            if (endPosition == startPosition)
            {
                if (startPosition >= 1)
                {
                    textBoxCompetitorNumber.Text = textBoxCompetitorNumber.Text.Substring(0, startPosition - 1) + textBoxCompetitorNumber.Text.Substring(endPosition);
                    textBoxCompetitorNumber.Focus();
                    textBoxCompetitorNumber.SelectionStart = startPosition - 1;
                    textBoxCompetitorNumber.SelectionLength = 0;
                }
                else
                {
                    textBoxCompetitorNumber.Focus();
                    textBoxCompetitorNumber.SelectionStart = 0;
                    textBoxCompetitorNumber.SelectionLength = 0;
                }
            }
            else
            {
                textBoxCompetitorNumber.Text = textBoxCompetitorNumber.Text.Substring(0, startPosition) + textBoxCompetitorNumber.Text.Substring(endPosition);
                textBoxCompetitorNumber.Focus();
                textBoxCompetitorNumber.SelectionStart = startPosition;
                textBoxCompetitorNumber.SelectionLength = 0;
            }
        }
        private void buttonDigitClicked(String digit)
        {
            int startPosition = textBoxCompetitorNumber.SelectionStart;
            int endPosition = startPosition + textBoxCompetitorNumber.SelectionLength;
            textBoxCompetitorNumber.Text = textBoxCompetitorNumber.Text.Substring(0,startPosition) + digit + textBoxCompetitorNumber.Text.Substring(endPosition);
            textBoxCompetitorNumber.Focus();
            textBoxCompetitorNumber.SelectionStart = startPosition + 1;
            textBoxCompetitorNumber.SelectionLength = 0;
        }

        private void FormCompetitors_Load(object sender, EventArgs e)
        {
            loadConfiguration();
        }
        private void loadConfiguration()
        {
            try
            {
                System.IO.StreamReader streamReader = new System.IO.StreamReader(currentPath + "\\configuration.txt");

                filePathGroups = streamReader.ReadLine();
                filePathResults = streamReader.ReadLine();
                simultaneousGroupsStartDeliminer = streamReader.ReadLine();
                useTimeSummerTimeShifting = streamReader.ReadLine().Equals("true");
                finishCompetitors = streamReader.ReadLine().Equals("true");
                pointNumber = streamReader.ReadLine();
                useFTP = streamReader.ReadLine().Equals("true");
                ftpSite = streamReader.ReadLine();
                ftpDirectory = streamReader.ReadLine();
                ftpLogin = streamReader.ReadLine();
                ftpPassword = streamReader.ReadLine();
                fileFTPName = "results_" + pointNumber + ".txt";
                
                streamReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Impossible to open configuration: " + e.Message);
            }
        }
        private void saveConfiguration()
        {
            if(System.IO.File.Exists(currentPath + "\\configuration.txt")) {
                System.IO.File.Delete(currentPath + "\\configuration.txt");
            }
            writeToFile(currentPath + "\\configuration.txt", filePathGroups, false);
            writeToFile(currentPath + "\\configuration.txt", filePathResults, false);
            writeToFile(currentPath + "\\configuration.txt", simultaneousGroupsStartDeliminer, false);
            writeToFile(currentPath + "\\configuration.txt", useTimeSummerTimeShifting ? "true" : "false", false);
            writeToFile(currentPath + "\\configuration.txt", finishCompetitors ? "true" : "false", false);
            writeToFile(currentPath + "\\configuration.txt", pointNumber, false);
            writeToFile(currentPath + "\\configuration.txt", useFTP ? "true" : "false", false);
            writeToFile(currentPath + "\\configuration.txt", ftpSite, false);
            writeToFile(currentPath + "\\configuration.txt", ftpDirectory, false);
            writeToFile(currentPath + "\\configuration.txt", ftpLogin, false);
            writeToFile(currentPath + "\\configuration.txt", ftpPassword, false);
        }


    }
}



 
 
namespace FTP_component
{
 
public class MyFTP : Component
{
[DllImport("cellcore.dll", EntryPoint = "ConnMgrReleaseConnection", SetLastError = true)]
internal static extern int ConnMgrReleaseConnection(IntPtr hConnection, int bCache);
 
[DllImport("cellcore.dll", EntryPoint = "ConnMgrEstablishConnection", SetLastError = true)]
internal static extern int ConnMgrEstablishConnection(IntPtr pConnInfo, out IntPtr phConnection);
 
[DllImport("cellcore.dll", EntryPoint = "ConnMgrEstablishConnectionSync", SetLastError = true)]
internal static extern int ConnMgrEstablishConnectionSync(ref ConnectionInfo ci, ref IntPtr phConnection, uint dwTimeout, ref uint dwStatus);
 
[DllImport("cellcore.dll", EntryPoint = "ConnMgrEnumDestinations", SetLastError = true)]
internal static extern int ConnMgrEnumDestinations(int nIndex, IntPtr pDestinationInfo);
 
[DllImport("cellcore.dll", EntryPoint = "ConnMgrMapURL", SetLastError = true)]
internal static extern int ConnMgrMapURL(string pwszUrl, ref Guid pguid, IntPtr pdwIndex);
 
[DllImport("cellcore.dll", EntryPoint = "ConnMgrConnectionStatus", SetLastError = true)]
internal static extern int ConnMgrConnectionStatus(IntPtr hConnection, out int pdwStatus);
 
const int S_OK = 0;
const uint CONNMGR_PARAM_GUIDDESTNET = 0x1;
const uint CONNMGR_FLAG_PROXY_HTTP = 0x1;
const uint CONNMGR_PRIORITY_USERINTERACTIVE = 0x08000;
const uint INFINITE = 0xffffffff;
const uint CONNMGR_STATUS_CONNECTED = 0x10;
 
[StructLayout(LayoutKind.Sequential)]
public struct ConnectionInfo
{
public uint cbSize;
public uint dwParams;
public uint dwFlags;
public uint dwPriority;
public int bExclusive;
public int bDisabled;
public Guid guidDestNet;
public IntPtr hWnd;
public uint uMsg;
public uint lParam;
public uint ulMaxCost;
public uint ulMinRcvBw;
public uint ulMaxConnLatency;
}
 
 
 
//**********************************************************************************************************************************
const int ERROR_SUCCESS = 0;
const int INTERNET_OPEN_TYPE_DIRECT = 1;
const int INTERNET_SERVICE_FTP = 1;
const int INTERNET_FLAG_NO_CACHE_WRITE = 0x04000000;
const int INTERNET_FLAG_HYPERLINK = 0x00000400;
 
WIN32_FIND_DATA pData = new WIN32_FIND_DATA();
 
[DllImport("WININET", EntryPoint = "InternetAttemptConnect",
SetLastError = true, CharSet = CharSet.Auto)]
static extern int __InternetAttemptConnect(int dwReserved);
 
[DllImport("WININET", EntryPoint = "InternetOpen",
SetLastError = true, CharSet = CharSet.Auto)]
static extern IntPtr __InternetOpen(
string lpszAgent,
int dwAccessType,
string lpszProxyName,
string lpszProxyBypass,
int dwFlags);
 
[DllImport("WININET", EntryPoint = "InternetCloseHandle",
SetLastError = true, CharSet = CharSet.Auto)]
static extern bool __InternetCloseHandle(IntPtr hInternet);
 
[DllImport("WININET", EntryPoint = "InternetConnect",
SetLastError = true, CharSet = CharSet.Auto)]
static extern IntPtr __InternetConnect(
IntPtr hInternet,
string lpszServerName,
int nServerPort,
string lpszUsername,
string lpszPassword,
int dwService,
int dwFlags,
int dwContext);
 
[DllImport("WININET", EntryPoint = "FtpSetCurrentDirectory",
SetLastError = true, CharSet = CharSet.Auto)]
static extern bool __FtpSetCurrentDirectory(
IntPtr hConnect,
string lpszDirectory);
 
 
[DllImport("WININET", EntryPoint = "FtpFindFirstFile",
SetLastError = true, CharSet = CharSet.Auto)]
static extern IntPtr __FtpFindFirstFile(
IntPtr hConnect,
string lpszSearchFile,
ref WIN32_FIND_DATA lpFindFileData,
int dwFlags,
int dwContent);
 
[DllImport("WININET", EntryPoint = "InternetFindNextFile",
SetLastError = true, CharSet = CharSet.Auto)]
static extern bool __InternetFindNextFile(
IntPtr hFind,
ref WIN32_FIND_DATA lpvFindData);
 
[DllImport("WININET", EntryPoint = "FtpGetFile",
SetLastError = true, CharSet = CharSet.Auto)]
static extern bool __FtpGetFile(
IntPtr hConnect,
string lpszRemoteFile,
string lpszNewFile,
bool fFailIfExists,
FileAttributes dwFlagsAndAttributes,
int dwFlags,
int dwContext);
 
[DllImport("WININET", EntryPoint = "FtpPutFile",
SetLastError = true, CharSet = CharSet.Auto)]
static extern bool __FtpPutFile
(IntPtr hConnect,
string lpszLocalFile,
string lpszNewRemoteFile,
int dwFlags,
int dwContext);
 
 
 
public struct FILETIME
{
public int dwLowDateTime;
public int dwHighDateTime;
}
 
public struct WIN32_FIND_DATA
{
public int dwFileAttributes;
public FILETIME ftCreationTime;
public FILETIME ftLastAccessTime;
public FILETIME ftLastWriteTime;
public int nFileSizeHigh;
public int nFileSizeLow;
public int dwOID;
[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
public string cFileName;
}
 
public bool InternetAttemptConnect()
{
if (__InternetAttemptConnect(0) == ERROR_SUCCESS)
{
return true;
}
else
{
return false;
}
}
 
public IntPtr InternetOpen()
{
return __InternetOpen("billyboy FTP", INTERNET_OPEN_TYPE_DIRECT, null, null, 0);
}
 
public IntPtr InternetConnect(IntPtr  inetHandle, string Server, int Port, string UserName, string Password)
{
return __InternetConnect(inetHandle, Server, Port, UserName, Password, INTERNET_SERVICE_FTP, 0, 0);
}
 
public bool CloseConnection(IntPtr Handle)
{
return __InternetCloseHandle(Handle);
}
 
public bool ChangeDirectory(IntPtr Handle, string PathDir)
{
return __FtpSetCurrentDirectory(Handle, PathDir);
}
 
public System.Collections.ArrayList GetNamesFilesInDir(IntPtr Handle, string Mask)
{
System.Collections.ArrayList FilesList = new System.Collections.ArrayList();
 
IntPtr ftpFileHandle = __FtpFindFirstFile(Handle, Mask, ref pData, INTERNET_FLAG_NO_CACHE_WRITE, 0);
if (ftpFileHandle != IntPtr.Zero)
{
FilesList.Add(pData.cFileName.ToString());
}
while (__InternetFindNextFile(ftpFileHandle, ref pData))
{
FilesList.Add(pData.cFileName);
}
__InternetCloseHandle(ftpFileHandle);
return FilesList;
}
 
public bool DownloadFile(IntPtr Handle, string FileNameRemote, string FileNameLocal)
{
return __FtpGetFile(Handle, FileNameRemote, FileNameLocal, false, 0, INTERNET_FLAG_NO_CACHE_WRITE, 0);
}
 
public bool UploadFile(IntPtr Handle, string FileNameLocal, string FileNameRemote)
{
return __FtpPutFile(Handle, FileNameLocal, FileNameRemote, INTERNET_FLAG_NO_CACHE_WRITE, 0);
}
 
 
/// <summary>Получить GUID для соединения с URL.</summary>
/// <param name="url">URL</param>
/// <returns>GUID</returns>
public bool  ConnectToNet(string url)
{
ConnectionInfo ci = new ConnectionInfo();
IntPtr phConnection = IntPtr.Zero;
uint status = 0;
 
if (ConnMgrMapURL(url, ref ci.guidDestNet, IntPtr.Zero) != S_OK)
return false;
ci.cbSize = (uint)Marshal.SizeOf(ci);
ci.dwParams = CONNMGR_PARAM_GUIDDESTNET;
ci.dwFlags = CONNMGR_FLAG_PROXY_HTTP;
ci.dwPriority = CONNMGR_PRIORITY_USERINTERACTIVE;
ci.bExclusive = 0;
ci.bDisabled = 0;
ci.hWnd = IntPtr.Zero;
ci.uMsg = 0;
ci.lParam = 0;
 
if (ConnMgrEstablishConnectionSync(ref ci, ref phConnection, INFINITE, ref status) != S_OK && status != CONNMGR_STATUS_CONNECTED)
return false;
return true;
}
}
}
