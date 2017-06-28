using System.Threading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PocketSTC
{
    public partial class FormSettings : Form
    {
        public bool result;
        public FormSettings()
        {
            InitializeComponent();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public TextBox getTextBoxGroupFile()
        {
            return textBoxGroupsFile;
        }
        public TextBox getTextBoxResultsFile()
        {
            return textBoxResultsFile;
        }
        public CheckBox getCheckBoxFinishCompetitors()
        {
            return checkBoxFinishCompetitors;
        }
        public TextBox getTextBoxSimultaneousGroupsStartDeliminer()
        {
            return textBoxSimultaneousGroupsStartDeliminer;
        }
        public CheckBox getCheckBoxUseSummerTimeShifting()
        {
            return checkBoxUseSummerTimeShifting;
        }
        public CheckBox getCheckBoxFTPUpload()
        {
            return checkBoxFTPUpload;
        }
        public TextBox getTextBoxPointNumber()
        {
            return textBoxPointNumber;
        }
        public TextBox getTextBoxFTPSite()
        {
            return textBoxFTPSite;
        }
        public TextBox getTextBoxFTPDirectory()
        {
            return textBoxFTPDirectory;
        }
        public TextBox getTextBoxFTPLogin()
        {
            return textBoxFTPLogin;
        }
        public TextBox getTextBoxFTPPassword()
        {
            return textBoxFTPPassword;
        }

        private void menuItemOk_Click(object sender, EventArgs e)
        {
            result = true;
            this.Close();
        }

        private void menuItem1_Click_1(object sender, EventArgs e)
        {
            result = false;
            this.Close();
        }

        private void buttonOpenResultsFile_Click(object sender, EventArgs e)
        {
            String filePath = getFilePath("Open Results File"); 
            if(filePath != null) textBoxResultsFile.Text = filePath;
        }

        private void buttonOpenGroupsFile_Click(object sender, EventArgs e)
        {
            String filePath = getFilePath("Open Results File");
            if (filePath != null) textBoxGroupsFile.Text = filePath;
        }
        private String getFilePath(String popUpName)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            DialogResult result = openFile.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                return openFile.FileName;
            }
            else
            {
                return null;
            }
        }



    }
}