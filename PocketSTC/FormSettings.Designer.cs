namespace PocketSTC
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItemOk = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.textBoxResultsFile = new System.Windows.Forms.TextBox();
            this.textBoxGroupsFile = new System.Windows.Forms.TextBox();
            this.labelSimultaneousGroupsDeliminer = new System.Windows.Forms.Label();
            this.textBoxSimultaneousGroupsStartDeliminer = new System.Windows.Forms.TextBox();
            this.checkBoxFinishCompetitors = new System.Windows.Forms.CheckBox();
            this.checkBoxUseSummerTimeShifting = new System.Windows.Forms.CheckBox();
            this.buttonOpenResultsFile = new System.Windows.Forms.Button();
            this.buttonOpenGroupsFile = new System.Windows.Forms.Button();
            this.textBoxFTPSite = new System.Windows.Forms.TextBox();
            this.textBoxFTPLogin = new System.Windows.Forms.TextBox();
            this.textBoxFTPPassword = new System.Windows.Forms.TextBox();
            this.textBoxPointNumber = new System.Windows.Forms.TextBox();
            this.labelPointNumber = new System.Windows.Forms.Label();
            this.checkBoxFTPUpload = new System.Windows.Forms.CheckBox();
            this.textBoxFTPDirectory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItemOk);
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItemOk
            // 
            this.menuItemOk.Text = "Ok";
            this.menuItemOk.Click += new System.EventHandler(this.menuItemOk_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Cancel";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click_1);
            // 
            // textBoxResultsFile
            // 
            this.textBoxResultsFile.Location = new System.Drawing.Point(3, 3);
            this.textBoxResultsFile.Name = "textBoxResultsFile";
            this.textBoxResultsFile.Size = new System.Drawing.Size(232, 23);
            this.textBoxResultsFile.TabIndex = 0;
            // 
            // textBoxGroupsFile
            // 
            this.textBoxGroupsFile.Location = new System.Drawing.Point(3, 58);
            this.textBoxGroupsFile.Name = "textBoxGroupsFile";
            this.textBoxGroupsFile.Size = new System.Drawing.Size(232, 23);
            this.textBoxGroupsFile.TabIndex = 1;
            this.textBoxGroupsFile.Text = "results.txt";
            // 
            // labelSimultaneousGroupsDeliminer
            // 
            this.labelSimultaneousGroupsDeliminer.Location = new System.Drawing.Point(3, 110);
            this.labelSimultaneousGroupsDeliminer.Name = "labelSimultaneousGroupsDeliminer";
            this.labelSimultaneousGroupsDeliminer.Size = new System.Drawing.Size(235, 20);
            this.labelSimultaneousGroupsDeliminer.Text = "Simultaneous Groups Start Deliminers";
            // 
            // textBoxSimultaneousGroupsStartDeliminer
            // 
            this.textBoxSimultaneousGroupsStartDeliminer.Location = new System.Drawing.Point(3, 133);
            this.textBoxSimultaneousGroupsStartDeliminer.Name = "textBoxSimultaneousGroupsStartDeliminer";
            this.textBoxSimultaneousGroupsStartDeliminer.Size = new System.Drawing.Size(229, 23);
            this.textBoxSimultaneousGroupsStartDeliminer.TabIndex = 5;
            this.textBoxSimultaneousGroupsStartDeliminer.Text = "groups.txt";
            // 
            // checkBoxFinishCompetitors
            // 
            this.checkBoxFinishCompetitors.Location = new System.Drawing.Point(3, 162);
            this.checkBoxFinishCompetitors.Name = "checkBoxFinishCompetitors";
            this.checkBoxFinishCompetitors.Size = new System.Drawing.Size(229, 20);
            this.checkBoxFinishCompetitors.TabIndex = 7;
            this.checkBoxFinishCompetitors.Text = "Finish Competitors";
            // 
            // checkBoxUseSummerTimeShifting
            // 
            this.checkBoxUseSummerTimeShifting.Checked = true;
            this.checkBoxUseSummerTimeShifting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUseSummerTimeShifting.Location = new System.Drawing.Point(3, 188);
            this.checkBoxUseSummerTimeShifting.Name = "checkBoxUseSummerTimeShifting";
            this.checkBoxUseSummerTimeShifting.Size = new System.Drawing.Size(232, 20);
            this.checkBoxUseSummerTimeShifting.TabIndex = 8;
            this.checkBoxUseSummerTimeShifting.Text = "Use Summer Time Shifting";
            // 
            // buttonOpenResultsFile
            // 
            this.buttonOpenResultsFile.Location = new System.Drawing.Point(123, 32);
            this.buttonOpenResultsFile.Name = "buttonOpenResultsFile";
            this.buttonOpenResultsFile.Size = new System.Drawing.Size(112, 20);
            this.buttonOpenResultsFile.TabIndex = 10;
            this.buttonOpenResultsFile.Text = "Open Results File";
            this.buttonOpenResultsFile.Click += new System.EventHandler(this.buttonOpenResultsFile_Click);
            // 
            // buttonOpenGroupsFile
            // 
            this.buttonOpenGroupsFile.Location = new System.Drawing.Point(123, 87);
            this.buttonOpenGroupsFile.Name = "buttonOpenGroupsFile";
            this.buttonOpenGroupsFile.Size = new System.Drawing.Size(112, 20);
            this.buttonOpenGroupsFile.TabIndex = 11;
            this.buttonOpenGroupsFile.Text = "Open Groups File";
            this.buttonOpenGroupsFile.Click += new System.EventHandler(this.buttonOpenGroupsFile_Click);
            // 
            // textBoxFTPSite
            // 
            this.textBoxFTPSite.Location = new System.Drawing.Point(7, 269);
            this.textBoxFTPSite.Name = "textBoxFTPSite";
            this.textBoxFTPSite.Size = new System.Drawing.Size(82, 23);
            this.textBoxFTPSite.TabIndex = 14;
            this.textBoxFTPSite.Text = "pulse-sports.ru";
            // 
            // textBoxFTPLogin
            // 
            this.textBoxFTPLogin.Location = new System.Drawing.Point(123, 240);
            this.textBoxFTPLogin.Name = "textBoxFTPLogin";
            this.textBoxFTPLogin.Size = new System.Drawing.Size(109, 23);
            this.textBoxFTPLogin.TabIndex = 15;
            this.textBoxFTPLogin.Text = "Login";
            // 
            // textBoxFTPPassword
            // 
            this.textBoxFTPPassword.Location = new System.Drawing.Point(213, 269);
            this.textBoxFTPPassword.Name = "textBoxFTPPassword";
            this.textBoxFTPPassword.Size = new System.Drawing.Size(19, 23);
            this.textBoxFTPPassword.TabIndex = 16;
            this.textBoxFTPPassword.Text = "Password";
            // 
            // textBoxPointNumber
            // 
            this.textBoxPointNumber.Location = new System.Drawing.Point(162, 214);
            this.textBoxPointNumber.Name = "textBoxPointNumber";
            this.textBoxPointNumber.Size = new System.Drawing.Size(70, 23);
            this.textBoxPointNumber.TabIndex = 17;
            this.textBoxPointNumber.Text = "1";
            // 
            // labelPointNumber
            // 
            this.labelPointNumber.Location = new System.Drawing.Point(4, 214);
            this.labelPointNumber.Name = "labelPointNumber";
            this.labelPointNumber.Size = new System.Drawing.Size(100, 20);
            this.labelPointNumber.Text = "Point Number";
            // 
            // checkBoxFTPUpload
            // 
            this.checkBoxFTPUpload.Location = new System.Drawing.Point(3, 243);
            this.checkBoxFTPUpload.Name = "checkBoxFTPUpload";
            this.checkBoxFTPUpload.Size = new System.Drawing.Size(114, 20);
            this.checkBoxFTPUpload.TabIndex = 20;
            this.checkBoxFTPUpload.Text = "FTP Settings";
            // 
            // textBoxFTPDirectory
            // 
            this.textBoxFTPDirectory.Location = new System.Drawing.Point(107, 269);
            this.textBoxFTPDirectory.Name = "textBoxFTPDirectory";
            this.textBoxFTPDirectory.Size = new System.Drawing.Size(100, 23);
            this.textBoxFTPDirectory.TabIndex = 23;
            this.textBoxFTPDirectory.Text = "/home/d2011611-1/www/dchernykh/";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.Controls.Add(this.textBoxFTPDirectory);
            this.Controls.Add(this.checkBoxFTPUpload);
            this.Controls.Add(this.labelPointNumber);
            this.Controls.Add(this.textBoxPointNumber);
            this.Controls.Add(this.textBoxFTPPassword);
            this.Controls.Add(this.textBoxFTPLogin);
            this.Controls.Add(this.textBoxFTPSite);
            this.Controls.Add(this.buttonOpenGroupsFile);
            this.Controls.Add(this.buttonOpenResultsFile);
            this.Controls.Add(this.checkBoxUseSummerTimeShifting);
            this.Controls.Add(this.checkBoxFinishCompetitors);
            this.Controls.Add(this.textBoxSimultaneousGroupsStartDeliminer);
            this.Controls.Add(this.labelSimultaneousGroupsDeliminer);
            this.Controls.Add(this.textBoxGroupsFile);
            this.Controls.Add(this.textBoxResultsFile);
            this.Menu = this.mainMenu1;
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

         #endregion

        private System.Windows.Forms.MenuItem menuItemOk;
        private System.Windows.Forms.TextBox textBoxResultsFile;
        private System.Windows.Forms.TextBox textBoxGroupsFile;
        private System.Windows.Forms.Label labelSimultaneousGroupsDeliminer;
        private System.Windows.Forms.TextBox textBoxSimultaneousGroupsStartDeliminer;
        private System.Windows.Forms.CheckBox checkBoxFinishCompetitors;
        private System.Windows.Forms.CheckBox checkBoxUseSummerTimeShifting;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.Button buttonOpenResultsFile;
        private System.Windows.Forms.Button buttonOpenGroupsFile;
        private System.Windows.Forms.TextBox textBoxFTPSite;
        private System.Windows.Forms.TextBox textBoxFTPLogin;
        private System.Windows.Forms.TextBox textBoxFTPPassword;
        private System.Windows.Forms.TextBox textBoxPointNumber;
        private System.Windows.Forms.Label labelPointNumber;
        private System.Windows.Forms.CheckBox checkBoxFTPUpload;
        private System.Windows.Forms.TextBox textBoxFTPDirectory;
    }
}