namespace PocketSTC
{
    partial class FormCompetitors
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
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItemSettings = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.buttonNextCompetitor = new System.Windows.Forms.Button();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.textBoxCompetitorNumber = new System.Windows.Forms.TextBox();
            this.buttonStartGroup = new System.Windows.Forms.Button();
            this.textBoxGroupID = new System.Windows.Forms.TextBox();
            this.textBoxCompetitorFirst = new System.Windows.Forms.TextBox();
            this.textBoxCompetitorSecond = new System.Windows.Forms.TextBox();
            this.buttonSaveAllFields = new System.Windows.Forms.Button();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.checkBoxGroupCompetitor = new System.Windows.Forms.CheckBox();
            this.buttonBackSpace = new System.Windows.Forms.Button();
            this.timerFTPUpload = new System.Windows.Forms.Timer();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItemSettings);
            this.menuItem1.MenuItems.Add(this.menuItem4);
            this.menuItem1.Text = "Menu";
            // 
            // menuItemSettings
            // 
            this.menuItemSettings.Text = "Settings";
            this.menuItemSettings.Click += new System.EventHandler(this.menuItemSettings_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "Exit";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // buttonNextCompetitor
            // 
            this.buttonNextCompetitor.Location = new System.Drawing.Point(159, 307);
            this.buttonNextCompetitor.Name = "buttonNextCompetitor";
            this.buttonNextCompetitor.Size = new System.Drawing.Size(72, 39);
            this.buttonNextCompetitor.TabIndex = 0;
            this.buttonNextCompetitor.Text = "Next";
            this.buttonNextCompetitor.Visible = false;
            this.buttonNextCompetitor.Click += new System.EventHandler(this.buttonNextCompetitor_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Location = new System.Drawing.Point(4, 116);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(227, 50);
            this.listBoxEvents.TabIndex = 1;
            // 
            // textBoxCompetitorNumber
            // 
            this.textBoxCompetitorNumber.Location = new System.Drawing.Point(64, 29);
            this.textBoxCompetitorNumber.Name = "textBoxCompetitorNumber";
            this.textBoxCompetitorNumber.Size = new System.Drawing.Size(167, 23);
            this.textBoxCompetitorNumber.TabIndex = 2;
            this.textBoxCompetitorNumber.Visible = false;
            this.textBoxCompetitorNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCompetitorNumber_KeyPress);
            // 
            // buttonStartGroup
            // 
            this.buttonStartGroup.Location = new System.Drawing.Point(159, 307);
            this.buttonStartGroup.Name = "buttonStartGroup";
            this.buttonStartGroup.Size = new System.Drawing.Size(72, 39);
            this.buttonStartGroup.TabIndex = 3;
            this.buttonStartGroup.Text = "Start";
            this.buttonStartGroup.Click += new System.EventHandler(this.buttonStartGroup_Click);
            // 
            // textBoxGroupID
            // 
            this.textBoxGroupID.Location = new System.Drawing.Point(64, 29);
            this.textBoxGroupID.Name = "textBoxGroupID";
            this.textBoxGroupID.Size = new System.Drawing.Size(167, 23);
            this.textBoxGroupID.TabIndex = 4;
            this.textBoxGroupID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGroupID_KeyPress);
            // 
            // textBoxCompetitorFirst
            // 
            this.textBoxCompetitorFirst.Location = new System.Drawing.Point(3, 58);
            this.textBoxCompetitorFirst.Name = "textBoxCompetitorFirst";
            this.textBoxCompetitorFirst.ReadOnly = true;
            this.textBoxCompetitorFirst.Size = new System.Drawing.Size(228, 23);
            this.textBoxCompetitorFirst.TabIndex = 5;
            // 
            // textBoxCompetitorSecond
            // 
            this.textBoxCompetitorSecond.Location = new System.Drawing.Point(3, 87);
            this.textBoxCompetitorSecond.Name = "textBoxCompetitorSecond";
            this.textBoxCompetitorSecond.ReadOnly = true;
            this.textBoxCompetitorSecond.Size = new System.Drawing.Size(228, 23);
            this.textBoxCompetitorSecond.TabIndex = 6;
            // 
            // buttonSaveAllFields
            // 
            this.buttonSaveAllFields.Enabled = false;
            this.buttonSaveAllFields.Location = new System.Drawing.Point(4, 3);
            this.buttonSaveAllFields.Name = "buttonSaveAllFields";
            this.buttonSaveAllFields.Size = new System.Drawing.Size(71, 23);
            this.buttonSaveAllFields.TabIndex = 8;
            this.buttonSaveAllFields.Text = "Save All";
            this.buttonSaveAllFields.Click += new System.EventHandler(this.buttonSaveAllFields_Click);
            // 
            // labelNumber
            // 
            this.labelNumber.Location = new System.Drawing.Point(3, 29);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(55, 20);
            this.labelNumber.Text = "Number";
            this.labelNumber.Visible = false;
            // 
            // labelGroup
            // 
            this.labelGroup.Location = new System.Drawing.Point(3, 29);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(55, 20);
            this.labelGroup.Text = "Group";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(4, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "1";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(82, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 39);
            this.button2.TabIndex = 12;
            this.button2.Text = "2";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(160, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 39);
            this.button3.TabIndex = 13;
            this.button3.Text = "3";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(4, 217);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 39);
            this.button4.TabIndex = 14;
            this.button4.Text = "4";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(82, 217);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 39);
            this.button5.TabIndex = 15;
            this.button5.Text = "5";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(160, 217);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 39);
            this.button6.TabIndex = 16;
            this.button6.Text = "6";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(4, 262);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 39);
            this.button7.TabIndex = 17;
            this.button7.Text = "7";
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(82, 262);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 39);
            this.button8.TabIndex = 18;
            this.button8.Text = "8";
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(160, 262);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(72, 39);
            this.button9.TabIndex = 19;
            this.button9.Text = "9";
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.Enabled = false;
            this.buttonZero.Location = new System.Drawing.Point(81, 307);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(72, 39);
            this.buttonZero.TabIndex = 20;
            this.buttonZero.Text = "0";
            this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click);
            // 
            // checkBoxGroupCompetitor
            // 
            this.checkBoxGroupCompetitor.Checked = true;
            this.checkBoxGroupCompetitor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGroupCompetitor.Location = new System.Drawing.Point(81, 3);
            this.checkBoxGroupCompetitor.Name = "checkBoxGroupCompetitor";
            this.checkBoxGroupCompetitor.Size = new System.Drawing.Size(142, 20);
            this.checkBoxGroupCompetitor.TabIndex = 21;
            this.checkBoxGroupCompetitor.Text = "Show Groups Start";
            this.checkBoxGroupCompetitor.CheckStateChanged += new System.EventHandler(this.checkBoxGroupCompetitor_CheckStateChanged);
            // 
            // buttonBackSpace
            // 
            this.buttonBackSpace.Enabled = false;
            this.buttonBackSpace.Location = new System.Drawing.Point(4, 308);
            this.buttonBackSpace.Name = "buttonBackSpace";
            this.buttonBackSpace.Size = new System.Drawing.Size(72, 38);
            this.buttonBackSpace.TabIndex = 24;
            this.buttonBackSpace.Text = "<-";
            this.buttonBackSpace.Click += new System.EventHandler(this.buttonBackSpace_Click);
            // 
            // timerFTPUpload
            // 
            this.timerFTPUpload.Enabled = true;
            this.timerFTPUpload.Interval = 10000;
            this.timerFTPUpload.Tick += new System.EventHandler(this.timerFTPUpload_Tick);
            // 
            // FormCompetitors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 356);
            this.Controls.Add(this.buttonBackSpace);
            this.Controls.Add(this.checkBoxGroupCompetitor);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.buttonSaveAllFields);
            this.Controls.Add(this.textBoxCompetitorSecond);
            this.Controls.Add(this.textBoxCompetitorFirst);
            this.Controls.Add(this.textBoxGroupID);
            this.Controls.Add(this.buttonStartGroup);
            this.Controls.Add(this.textBoxCompetitorNumber);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.buttonNextCompetitor);
            this.Menu = this.mainMenu1;
            this.Name = "FormCompetitors";
            this.Text = "SportTimer";
            this.Load += new System.EventHandler(this.FormCompetitors_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNextCompetitor;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.TextBox textBoxCompetitorNumber;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItemSettings;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.Button buttonStartGroup;
        private System.Windows.Forms.TextBox textBoxGroupID;
        private System.Windows.Forms.TextBox textBoxCompetitorFirst;
        private System.Windows.Forms.TextBox textBoxCompetitorSecond;
        private System.Windows.Forms.Button buttonSaveAllFields;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.CheckBox checkBoxGroupCompetitor;
        private System.Windows.Forms.Button buttonBackSpace;
        private System.Windows.Forms.Timer timerFTPUpload;
    }
}

