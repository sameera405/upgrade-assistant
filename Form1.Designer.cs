namespace UpgradeAssistant_UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblUpgradeAssistantPath = new System.Windows.Forms.Label();
            lblSolutionPath = new System.Windows.Forms.Label();
            dlgUpgAsstPath = new System.Windows.Forms.OpenFileDialog();
            btnUpgAssPath = new System.Windows.Forms.Button();
            btnSolutionPath = new System.Windows.Forms.Button();
            btnSubmit = new System.Windows.Forms.Button();
            txtUpgradeAssistantPath = new System.Windows.Forms.TextBox();
            txtSolutionPath = new System.Windows.Forms.TextBox();
            dlgSoluPath = new System.Windows.Forms.OpenFileDialog();
            mnustripModes = new System.Windows.Forms.MenuStrip();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            howItWorksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btnAnalyze = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lblUpgradeMode = new System.Windows.Forms.Label();
            rbtnInteractive = new System.Windows.Forms.RadioButton();
            rbtnNonInteractive = new System.Windows.Forms.RadioButton();
            lblBackup = new System.Windows.Forms.Label();
            rbtnBackupYes = new System.Windows.Forms.RadioButton();
            rbtnBackupNo = new System.Windows.Forms.RadioButton();
            groupBox1 = new System.Windows.Forms.GroupBox();
            lblTrgetFrmWrk = new System.Windows.Forms.Label();
            ddlTargetFramework = new System.Windows.Forms.ComboBox();
            lblAnalysisLog = new System.Windows.Forms.Label();
            btnAnalysisLog = new System.Windows.Forms.Button();
            txtAnalysisLog = new System.Windows.Forms.TextBox();
            fldrBrowseAnalysisLog = new System.Windows.Forms.FolderBrowserDialog();
            errProvider = new System.Windows.Forms.ErrorProvider(components);
            lblAnalysisPath = new System.Windows.Forms.Label();
            lblErrorLogPath = new System.Windows.Forms.Label();
            mnustripModes.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // lblUpgradeAssistantPath
            // 
            lblUpgradeAssistantPath.AutoSize = true;
            lblUpgradeAssistantPath.Location = new System.Drawing.Point(51, 63);
            lblUpgradeAssistantPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUpgradeAssistantPath.Name = "lblUpgradeAssistantPath";
            lblUpgradeAssistantPath.Size = new System.Drawing.Size(244, 25);
            lblUpgradeAssistantPath.TabIndex = 0;
            lblUpgradeAssistantPath.Text = "Upgrade Assistant Path(.exe)*";
            // 
            // lblSolutionPath
            // 
            lblSolutionPath.AutoSize = true;
            lblSolutionPath.Location = new System.Drawing.Point(51, 125);
            lblSolutionPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSolutionPath.Name = "lblSolutionPath";
            lblSolutionPath.Size = new System.Drawing.Size(166, 25);
            lblSolutionPath.TabIndex = 1;
            lblSolutionPath.Text = "Solution Path (.sln)*";
            // 
            // dlgUpgAsstPath
            // 
            dlgUpgAsstPath.FileName = "dlgUpgradeAssistantFile";
            // 
            // btnUpgAssPath
            // 
            btnUpgAssPath.Location = new System.Drawing.Point(331, 63);
            btnUpgAssPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnUpgAssPath.Name = "btnUpgAssPath";
            btnUpgAssPath.Size = new System.Drawing.Size(107, 38);
            btnUpgAssPath.TabIndex = 2;
            btnUpgAssPath.Text = "Browse";
            btnUpgAssPath.UseVisualStyleBackColor = true;
            btnUpgAssPath.Click += btnUpgAssPath_Click;
            // 
            // btnSolutionPath
            // 
            btnSolutionPath.Location = new System.Drawing.Point(331, 125);
            btnSolutionPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnSolutionPath.Name = "btnSolutionPath";
            btnSolutionPath.Size = new System.Drawing.Size(107, 38);
            btnSolutionPath.TabIndex = 3;
            btnSolutionPath.Text = "Browse";
            btnSolutionPath.UseVisualStyleBackColor = true;
            btnSolutionPath.Click += btnSolutionPath_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new System.Drawing.Point(729, 500);
            btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(107, 38);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Upgrade";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtUpgradeAssistantPath
            // 
            txtUpgradeAssistantPath.Location = new System.Drawing.Point(496, 62);
            txtUpgradeAssistantPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtUpgradeAssistantPath.Name = "txtUpgradeAssistantPath";
            txtUpgradeAssistantPath.Size = new System.Drawing.Size(365, 31);
            txtUpgradeAssistantPath.TabIndex = 5;
            // 
            // txtSolutionPath
            // 
            txtSolutionPath.Location = new System.Drawing.Point(496, 125);
            txtSolutionPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtSolutionPath.Name = "txtSolutionPath";
            txtSolutionPath.Size = new System.Drawing.Size(365, 31);
            txtSolutionPath.TabIndex = 6;
            // 
            // dlgSoluPath
            // 
            dlgSoluPath.FileName = "dlgSolutionPath";
            // 
            // mnustripModes
            // 
            mnustripModes.ImageScalingSize = new System.Drawing.Size(24, 24);
            mnustripModes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { helpToolStripMenuItem });
            mnustripModes.Location = new System.Drawing.Point(0, 0);
            mnustripModes.Name = "mnustripModes";
            mnustripModes.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            mnustripModes.Size = new System.Drawing.Size(1143, 35);
            mnustripModes.TabIndex = 7;
            mnustripModes.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { howItWorksToolStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // howItWorksToolStripMenuItem
            // 
            howItWorksToolStripMenuItem.Name = "howItWorksToolStripMenuItem";
            howItWorksToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            howItWorksToolStripMenuItem.Text = "How it works";
            howItWorksToolStripMenuItem.Click += howItWorksToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // btnAnalyze
            // 
            btnAnalyze.Location = new System.Drawing.Point(576, 500);
            btnAnalyze.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new System.Drawing.Size(107, 38);
            btnAnalyze.TabIndex = 8;
            btnAnalyze.Text = "Analyze";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(66, 658);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 25);
            label1.TabIndex = 9;
            label1.Text = "Note:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(116, 658);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(500, 25);
            label2.TabIndex = 10;
            label2.Text = "Upgrade Assistant Path - Enter the upgrade assistant exe path";
            // 
            // lblUpgradeMode
            // 
            lblUpgradeMode.AutoSize = true;
            lblUpgradeMode.Location = new System.Drawing.Point(51, 187);
            lblUpgradeMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUpgradeMode.Name = "lblUpgradeMode";
            lblUpgradeMode.Size = new System.Drawing.Size(133, 25);
            lblUpgradeMode.TabIndex = 11;
            lblUpgradeMode.Text = "Upgrade Mode";
            // 
            // rbtnInteractive
            // 
            rbtnInteractive.AutoSize = true;
            rbtnInteractive.Checked = true;
            rbtnInteractive.Location = new System.Drawing.Point(9, 33);
            rbtnInteractive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            rbtnInteractive.Name = "rbtnInteractive";
            rbtnInteractive.Size = new System.Drawing.Size(253, 29);
            rbtnInteractive.TabIndex = 12;
            rbtnInteractive.TabStop = true;
            rbtnInteractive.Text = "Interactive (Recommended)";
            rbtnInteractive.UseVisualStyleBackColor = true;
            // 
            // rbtnNonInteractive
            // 
            rbtnNonInteractive.AutoSize = true;
            rbtnNonInteractive.Location = new System.Drawing.Point(293, 37);
            rbtnNonInteractive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            rbtnNonInteractive.Name = "rbtnNonInteractive";
            rbtnNonInteractive.Size = new System.Drawing.Size(159, 29);
            rbtnNonInteractive.TabIndex = 13;
            rbtnNonInteractive.TabStop = true;
            rbtnNonInteractive.Text = "Non-Interactive";
            rbtnNonInteractive.UseVisualStyleBackColor = true;
            // 
            // lblBackup
            // 
            lblBackup.AutoSize = true;
            lblBackup.Location = new System.Drawing.Point(51, 298);
            lblBackup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblBackup.Name = "lblBackup";
            lblBackup.Size = new System.Drawing.Size(69, 25);
            lblBackup.TabIndex = 14;
            lblBackup.Text = "Backup";
            // 
            // rbtnBackupYes
            // 
            rbtnBackupYes.AutoSize = true;
            rbtnBackupYes.Checked = true;
            rbtnBackupYes.Location = new System.Drawing.Point(340, 292);
            rbtnBackupYes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            rbtnBackupYes.Name = "rbtnBackupYes";
            rbtnBackupYes.Size = new System.Drawing.Size(197, 29);
            rbtnBackupYes.TabIndex = 15;
            rbtnBackupYes.TabStop = true;
            rbtnBackupYes.Text = "Yes (Recommended)";
            rbtnBackupYes.UseVisualStyleBackColor = true;
            // 
            // rbtnBackupNo
            // 
            rbtnBackupNo.AutoSize = true;
            rbtnBackupNo.Location = new System.Drawing.Point(624, 292);
            rbtnBackupNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            rbtnBackupNo.Name = "rbtnBackupNo";
            rbtnBackupNo.Size = new System.Drawing.Size(61, 29);
            rbtnBackupNo.TabIndex = 16;
            rbtnBackupNo.TabStop = true;
            rbtnBackupNo.Text = "No";
            rbtnBackupNo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnInteractive);
            groupBox1.Controls.Add(rbtnNonInteractive);
            groupBox1.Location = new System.Drawing.Point(331, 187);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.Size = new System.Drawing.Size(531, 75);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modes";
            // 
            // lblTrgetFrmWrk
            // 
            lblTrgetFrmWrk.AutoSize = true;
            lblTrgetFrmWrk.Location = new System.Drawing.Point(51, 350);
            lblTrgetFrmWrk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTrgetFrmWrk.Name = "lblTrgetFrmWrk";
            lblTrgetFrmWrk.Size = new System.Drawing.Size(153, 25);
            lblTrgetFrmWrk.TabIndex = 18;
            lblTrgetFrmWrk.Text = "Target Framework";
            // 
            // ddlTargetFramework
            // 
            ddlTargetFramework.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ddlTargetFramework.FormattingEnabled = true;
            ddlTargetFramework.Items.AddRange(new object[] { "Long Term Support", "Standard Term Support", "Preview" });
            ddlTargetFramework.Location = new System.Drawing.Point(331, 350);
            ddlTargetFramework.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ddlTargetFramework.Name = "ddlTargetFramework";
            ddlTargetFramework.Size = new System.Drawing.Size(318, 33);
            ddlTargetFramework.TabIndex = 19;
            // 
            // lblAnalysisLog
            // 
            lblAnalysisLog.AutoSize = true;
            lblAnalysisLog.Location = new System.Drawing.Point(51, 422);
            lblAnalysisLog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAnalysisLog.Name = "lblAnalysisLog";
            lblAnalysisLog.Size = new System.Drawing.Size(119, 25);
            lblAnalysisLog.TabIndex = 20;
            lblAnalysisLog.Text = "Analysis Log*";
            // 
            // btnAnalysisLog
            // 
            btnAnalysisLog.Location = new System.Drawing.Point(331, 415);
            btnAnalysisLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnAnalysisLog.Name = "btnAnalysisLog";
            btnAnalysisLog.Size = new System.Drawing.Size(107, 38);
            btnAnalysisLog.TabIndex = 21;
            btnAnalysisLog.Text = "Browse";
            btnAnalysisLog.UseVisualStyleBackColor = true;
            btnAnalysisLog.Click += btnAnalysisLog_Click;
            // 
            // txtAnalysisLog
            // 
            txtAnalysisLog.Location = new System.Drawing.Point(510, 413);
            txtAnalysisLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtAnalysisLog.Name = "txtAnalysisLog";
            txtAnalysisLog.Size = new System.Drawing.Size(351, 31);
            txtAnalysisLog.TabIndex = 22;
            // 
            // errProvider
            // 
            errProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            errProvider.ContainerControl = this;
            // 
            // lblAnalysisPath
            // 
            lblAnalysisPath.AutoSize = true;
            lblAnalysisPath.Location = new System.Drawing.Point(890, 418);
            lblAnalysisPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAnalysisPath.Name = "lblAnalysisPath";
            lblAnalysisPath.Size = new System.Drawing.Size(141, 25);
            lblAnalysisPath.TabIndex = 23;
            lblAnalysisPath.Text = "hdnAnalysisPath";
            lblAnalysisPath.Visible = false;
            // 
            // lblErrorLogPath
            // 
            lblErrorLogPath.AutoSize = true;
            lblErrorLogPath.Location = new System.Drawing.Point(1037, 418);
            lblErrorLogPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblErrorLogPath.Name = "lblErrorLogPath";
            lblErrorLogPath.Size = new System.Drawing.Size(98, 25);
            lblErrorLogPath.TabIndex = 24;
            lblErrorLogPath.Text = "hdnErrPath";
            lblErrorLogPath.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1143, 750);
            Controls.Add(lblErrorLogPath);
            Controls.Add(lblAnalysisPath);
            Controls.Add(txtAnalysisLog);
            Controls.Add(btnAnalysisLog);
            Controls.Add(lblAnalysisLog);
            Controls.Add(ddlTargetFramework);
            Controls.Add(lblTrgetFrmWrk);
            Controls.Add(groupBox1);
            Controls.Add(rbtnBackupNo);
            Controls.Add(rbtnBackupYes);
            Controls.Add(lblBackup);
            Controls.Add(lblUpgradeMode);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAnalyze);
            Controls.Add(txtSolutionPath);
            Controls.Add(txtUpgradeAssistantPath);
            Controls.Add(btnSubmit);
            Controls.Add(btnSolutionPath);
            Controls.Add(btnUpgAssPath);
            Controls.Add(lblSolutionPath);
            Controls.Add(lblUpgradeAssistantPath);
            Controls.Add(mnustripModes);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Upgrade Assistant";
            mnustripModes.ResumeLayout(false);
            mnustripModes.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblUpgradeAssistantPath;
        private System.Windows.Forms.Label lblSolutionPath;
        private System.Windows.Forms.OpenFileDialog dlgUpgAsstPath;
        private System.Windows.Forms.Button btnUpgAssPath;
        private System.Windows.Forms.Button btnSolutionPath;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtUpgradeAssistantPath;
        private System.Windows.Forms.TextBox txtSolutionPath;
        private System.Windows.Forms.OpenFileDialog dlgSoluPath;
        private System.Windows.Forms.MenuStrip mnustripModes;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUpgradeMode;
        private System.Windows.Forms.RadioButton rbtnInteractive;
        private System.Windows.Forms.RadioButton rbtnNonInteractive;
        private System.Windows.Forms.Label lblBackup;
        private System.Windows.Forms.RadioButton rbtnBackupYes;
        private System.Windows.Forms.RadioButton rbtnBackupNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTrgetFrmWrk;
        private System.Windows.Forms.ComboBox ddlTargetFramework;
        private System.Windows.Forms.Label lblAnalysisLog;
        private System.Windows.Forms.Button btnAnalysisLog;
        private System.Windows.Forms.TextBox txtAnalysisLog;
        private System.Windows.Forms.FolderBrowserDialog fldrBrowseAnalysisLog;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.Label lblAnalysisPath;
        private System.Windows.Forms.Label lblErrorLogPath;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howItWorksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

