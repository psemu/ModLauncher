namespace PS2ModLauncher
{
    partial class LauncherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label10 = new System.Windows.Forms.Label();
            this.launchArgs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.domainBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.launchGame = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.applyMethod = new System.Windows.Forms.ComboBox();
            this.selectDirectory = new System.Windows.Forms.Button();
            this.planetside2PathTextField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.loginWebBrowser = new System.Windows.Forms.WebBrowser();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ps2_consoleOutput = new System.Windows.Forms.TextBox();
            this.findPTRDirDialogue = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.findUFPButton = new System.Windows.Forms.Button();
            this.generateUFPButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ufpTextBox = new System.Windows.Forms.TextBox();
            this.deleteExtraPackButton = new System.Windows.Forms.Button();
            this.createPackButton = new System.Windows.Forms.Button();
            this.removeItemFromPackButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.addFileToPackButton = new System.Windows.Forms.Button();
            this.filesToPackBox = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.luaFileName = new System.Windows.Forms.TextBox();
            this.luaBox = new System.Windows.Forms.RichTextBox();
            this.luaApplyButton = new System.Windows.Forms.Button();
            this.savePackDialogue = new System.Windows.Forms.SaveFileDialog();
            this.selectFileForPack = new System.Windows.Forms.OpenFileDialog();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.loggingCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.loggingCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.launchArgs);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.domainBox);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.launchGame);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.applyMethod);
            this.splitContainer1.Panel1.Controls.Add(this.selectDirectory);
            this.splitContainer1.Panel1.Controls.Add(this.planetside2PathTextField);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Size = new System.Drawing.Size(770, 430);
            this.splitContainer1.SplitterDistance = 256;
            this.splitContainer1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Extra launch options";
            // 
            // launchArgs
            // 
            this.launchArgs.Location = new System.Drawing.Point(15, 262);
            this.launchArgs.Name = "launchArgs";
            this.launchArgs.Size = new System.Drawing.Size(200, 20);
            this.launchArgs.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Domain";
            // 
            // domainBox
            // 
            this.domainBox.FormattingEnabled = true;
            this.domainBox.Items.AddRange(new object[] {
            "Test",
            "PSG_Test"});
            this.domainBox.Location = new System.Drawing.Point(15, 96);
            this.domainBox.Name = "domainBox";
            this.domainBox.Size = new System.Drawing.Size(121, 21);
            this.domainBox.TabIndex = 11;
            this.domainBox.SelectedValueChanged += new System.EventHandler(this.domainBox_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 39);
            this.label5.TabIndex = 9;
            this.label5.Text = "None - Launch default install\r\nLoose Files - Path for unpacked Files\r\nExtra Asset" +
    " - Load specific Assets_256.pack ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Path to Test Directory";
            // 
            // launchGame
            // 
            this.launchGame.Location = new System.Drawing.Point(48, 402);
            this.launchGame.Name = "launchGame";
            this.launchGame.Size = new System.Drawing.Size(133, 23);
            this.launchGame.TabIndex = 6;
            this.launchGame.Text = "Launch Planetside 2";
            this.launchGame.UseVisualStyleBackColor = true;
            this.launchGame.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mod Apply Method";
            // 
            // applyMethod
            // 
            this.applyMethod.Items.AddRange(new object[] {
            "None",
            "Loose Files",
            "Extra Assets"});
            this.applyMethod.Location = new System.Drawing.Point(15, 136);
            this.applyMethod.Name = "applyMethod";
            this.applyMethod.Size = new System.Drawing.Size(121, 21);
            this.applyMethod.TabIndex = 3;
            this.applyMethod.SelectionChangeCommitted += new System.EventHandler(this.ApplyMethod_SelectionChangeCommitted);
            // 
            // selectDirectory
            // 
            this.selectDirectory.Location = new System.Drawing.Point(164, 54);
            this.selectDirectory.Name = "selectDirectory";
            this.selectDirectory.Size = new System.Drawing.Size(75, 23);
            this.selectDirectory.TabIndex = 2;
            this.selectDirectory.Text = "Select Dir";
            this.selectDirectory.UseVisualStyleBackColor = true;
            this.selectDirectory.Click += new System.EventHandler(this.button1_Click);
            // 
            // planetside2PathTextField
            // 
            this.planetside2PathTextField.Location = new System.Drawing.Point(15, 57);
            this.planetside2PathTextField.Name = "planetside2PathTextField";
            this.planetside2PathTextField.Size = new System.Drawing.Size(143, 20);
            this.planetside2PathTextField.TabIndex = 1;
            this.planetside2PathTextField.Text = "Path to Test Directory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log In over there ->";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(510, 430);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.loginWebBrowser);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(502, 404);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "LoginFrame";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // loginWebBrowser
            // 
            this.loginWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginWebBrowser.Location = new System.Drawing.Point(3, 3);
            this.loginWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.loginWebBrowser.Name = "loginWebBrowser";
            this.loginWebBrowser.Size = new System.Drawing.Size(496, 398);
            this.loginWebBrowser.TabIndex = 0;
            this.loginWebBrowser.Url = new System.Uri("https://lp.soe.com/ps2/test/", System.UriKind.Absolute);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ps2_consoleOutput);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(502, 404);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Output";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ps2_consoleOutput
            // 
            this.ps2_consoleOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ps2_consoleOutput.Location = new System.Drawing.Point(3, 3);
            this.ps2_consoleOutput.Multiline = true;
            this.ps2_consoleOutput.Name = "ps2_consoleOutput";
            this.ps2_consoleOutput.ReadOnly = true;
            this.ps2_consoleOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ps2_consoleOutput.Size = new System.Drawing.Size(496, 398);
            this.ps2_consoleOutput.TabIndex = 0;
            // 
            // findPTRDirDialogue
            // 
            this.findPTRDirDialogue.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 462);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Launcher";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.findUFPButton);
            this.splitContainer2.Panel1.Controls.Add(this.generateUFPButton);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.ufpTextBox);
            this.splitContainer2.Panel1.Controls.Add(this.deleteExtraPackButton);
            this.splitContainer2.Panel1.Controls.Add(this.createPackButton);
            this.splitContainer2.Panel1.Controls.Add(this.removeItemFromPackButton);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.addFileToPackButton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.filesToPackBox);
            this.splitContainer2.Size = new System.Drawing.Size(770, 430);
            this.splitContainer2.SplitterDistance = 256;
            this.splitContainer2.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 26);
            this.label9.TabIndex = 16;
            this.label9.Text = "Cleans up the extra Assets_256.pack \r\n in the game directory";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Generate - Create a new user fingerprint\r\nFind - Scour the logs for your user fin" +
    "gerprint";
            // 
            // findUFPButton
            // 
            this.findUFPButton.Location = new System.Drawing.Point(90, 199);
            this.findUFPButton.Name = "findUFPButton";
            this.findUFPButton.Size = new System.Drawing.Size(75, 23);
            this.findUFPButton.TabIndex = 14;
            this.findUFPButton.Text = "Find";
            this.findUFPButton.UseVisualStyleBackColor = true;
            this.findUFPButton.Click += new System.EventHandler(this.findUFP_Click);
            // 
            // generateUFPButton
            // 
            this.generateUFPButton.Enabled = false;
            this.generateUFPButton.Location = new System.Drawing.Point(8, 198);
            this.generateUFPButton.Name = "generateUFPButton";
            this.generateUFPButton.Size = new System.Drawing.Size(75, 23);
            this.generateUFPButton.TabIndex = 13;
            this.generateUFPButton.Text = "Generate";
            this.generateUFPButton.UseVisualStyleBackColor = true;
            this.generateUFPButton.Click += new System.EventHandler(this.GenerateUFP_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "User Fingerprint";
            // 
            // ufpTextBox
            // 
            this.ufpTextBox.Location = new System.Drawing.Point(0, 172);
            this.ufpTextBox.Name = "ufpTextBox";
            this.ufpTextBox.Size = new System.Drawing.Size(253, 20);
            this.ufpTextBox.TabIndex = 11;
            // 
            // deleteExtraPackButton
            // 
            this.deleteExtraPackButton.Location = new System.Drawing.Point(8, 298);
            this.deleteExtraPackButton.Name = "deleteExtraPackButton";
            this.deleteExtraPackButton.Size = new System.Drawing.Size(113, 23);
            this.deleteExtraPackButton.TabIndex = 10;
            this.deleteExtraPackButton.Text = "Clean Up Directory";
            this.deleteExtraPackButton.UseVisualStyleBackColor = true;
            this.deleteExtraPackButton.Click += new System.EventHandler(this.deleteExtraPacks_Click);
            // 
            // createPackButton
            // 
            this.createPackButton.Location = new System.Drawing.Point(75, 55);
            this.createPackButton.Name = "createPackButton";
            this.createPackButton.Size = new System.Drawing.Size(75, 23);
            this.createPackButton.TabIndex = 4;
            this.createPackButton.Text = "Create Pack";
            this.createPackButton.UseVisualStyleBackColor = true;
            this.createPackButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // removeItemFromPackButton
            // 
            this.removeItemFromPackButton.Location = new System.Drawing.Point(116, 26);
            this.removeItemFromPackButton.Name = "removeItemFromPackButton";
            this.removeItemFromPackButton.Size = new System.Drawing.Size(107, 23);
            this.removeItemFromPackButton.TabIndex = 3;
            this.removeItemFromPackButton.Text = "Remove Selected";
            this.removeItemFromPackButton.UseVisualStyleBackColor = true;
            this.removeItemFromPackButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Pack Creator";
            // 
            // addFileToPackButton
            // 
            this.addFileToPackButton.Location = new System.Drawing.Point(3, 26);
            this.addFileToPackButton.Name = "addFileToPackButton";
            this.addFileToPackButton.Size = new System.Drawing.Size(107, 23);
            this.addFileToPackButton.TabIndex = 0;
            this.addFileToPackButton.Text = "Add File To Pack";
            this.addFileToPackButton.UseVisualStyleBackColor = true;
            this.addFileToPackButton.Click += new System.EventHandler(this.AddFileToPack_Click);
            // 
            // filesToPackBox
            // 
            this.filesToPackBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.filesToPackBox.FormattingEnabled = true;
            this.filesToPackBox.Location = new System.Drawing.Point(0, 10);
            this.filesToPackBox.Name = "filesToPackBox";
            this.filesToPackBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.filesToPackBox.Size = new System.Drawing.Size(510, 420);
            this.filesToPackBox.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.luaFileName);
            this.tabPage5.Controls.Add(this.luaBox);
            this.tabPage5.Controls.Add(this.luaApplyButton);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(776, 436);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Lua";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(654, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "File Name";
            // 
            // luaFileName
            // 
            this.luaFileName.Location = new System.Drawing.Point(657, 22);
            this.luaFileName.Name = "luaFileName";
            this.luaFileName.Size = new System.Drawing.Size(100, 20);
            this.luaFileName.TabIndex = 3;
            this.luaFileName.Text = "hax.lua";
            // 
            // luaBox
            // 
            this.luaBox.Location = new System.Drawing.Point(8, 3);
            this.luaBox.Name = "luaBox";
            this.luaBox.Size = new System.Drawing.Size(640, 425);
            this.luaBox.TabIndex = 2;
            this.luaBox.Text = "";
            this.luaBox.WordWrap = false;
            // 
            // luaApplyButton
            // 
            this.luaApplyButton.Location = new System.Drawing.Point(654, 405);
            this.luaApplyButton.Name = "luaApplyButton";
            this.luaApplyButton.Size = new System.Drawing.Size(75, 23);
            this.luaApplyButton.TabIndex = 1;
            this.luaApplyButton.Text = "Apply";
            this.luaApplyButton.UseVisualStyleBackColor = true;
            this.luaApplyButton.Click += new System.EventHandler(this.luaApplyButton_Click);
            // 
            // savePackDialogue
            // 
            this.savePackDialogue.FileName = "Assets_256";
            this.savePackDialogue.Filter = "Pack Files (*.pack)|*.pack";
            // 
            // selectFileForPack
            // 
            this.selectFileForPack.FileName = "openFileDialog1";
            this.selectFileForPack.Multiselect = true;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // loggingCheckBox
            // 
            this.loggingCheckBox.AutoSize = true;
            this.loggingCheckBox.Location = new System.Drawing.Point(15, 216);
            this.loggingCheckBox.Name = "loggingCheckBox";
            this.loggingCheckBox.Size = new System.Drawing.Size(64, 17);
            this.loggingCheckBox.TabIndex = 15;
            this.loggingCheckBox.Text = "Logging";
            this.loggingCheckBox.UseVisualStyleBackColor = true;
            this.loggingCheckBox.CheckedChanged += new System.EventHandler(this.loggingCheckBox_CheckedChanged);
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.tabControl1);
            this.Name = "LauncherForm";
            this.Text = "Planetside 2 Mod Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser loginWebBrowser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox applyMethod;
        private System.Windows.Forms.Button selectDirectory;
        private System.Windows.Forms.TextBox planetside2PathTextField;
        private System.Windows.Forms.FolderBrowserDialog findPTRDirDialogue;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button createPackButton;
        private System.Windows.Forms.Button removeItemFromPackButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addFileToPackButton;
        private System.Windows.Forms.ListBox filesToPackBox;
        private System.Windows.Forms.SaveFileDialog savePackDialogue;
        private System.Windows.Forms.OpenFileDialog selectFileForPack;
        private System.Windows.Forms.Button launchGame;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox ps2_consoleOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button deleteExtraPackButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button findUFPButton;
        private System.Windows.Forms.Button generateUFPButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ufpTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox domainBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox launchArgs;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button luaApplyButton;
        private System.Windows.Forms.RichTextBox luaBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox luaFileName;
        private System.Windows.Forms.CheckBox loggingCheckBox;
    }
}

