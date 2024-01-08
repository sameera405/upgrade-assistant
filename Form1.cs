using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.DataFormats;

namespace UpgradeAssistant_UI
{
    public partial class Form1 : Form
    {
        private Label errorSummaryLabel;
        public Form1()
        {
            InitializeComponent();
            InitializeErrorSummaryLabel();
            ddlTargetFramework.SelectedIndex = 0;
        }

        private void InitializeErrorSummaryLabel()
        {
            errorSummaryLabel = new Label
            {
                ForeColor = System.Drawing.Color.Red,
                AutoSize = true,
                Visible = false
            };
            errorSummaryLabel.Location = new System.Drawing.Point(10, 10);
            this.Controls.Add(errorSummaryLabel);
        }

        private void btnUpgAssPath_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgUpgAsstPath.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtUpgradeAssistantPath.Text = dlgUpgAsstPath.FileName;
            }
        }

        private void btnSolutionPath_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgSoluPath.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtSolutionPath.Text = dlgSoluPath.FileName;
            }
        }

        private List<string> ValidateRequiredFields()
        {
            List<string> errorMessages = new List<string>();

            if (IsTextBoxEmpty(txtUpgradeAssistantPath))
            {
                errorMessages.Add("Upgrade assistant path is required!");
            }
            if (IsTextBoxEmpty(txtSolutionPath))
            {
                errorMessages.Add("Solution path is required!");
            }
            if (IsTextBoxEmpty(txtAnalysisLog))
            {
                errorMessages.Add("Please select a folder to save the Logs");
            }

            return errorMessages;
        }

        private bool IsTextBoxEmpty(System.Windows.Forms.TextBox textBox)
        {
            bool isEmpty = string.IsNullOrWhiteSpace(textBox.Text);
            if (isEmpty)
            {
                errProvider.SetError(textBox, "This field is required!");
            }
            return isEmpty;
        }

        private void ShowErrorSummary(List<string> errorMessages)
        {
            errorSummaryLabel.Visible = true;
            string summaryMessage = string.Join(Environment.NewLine, errorMessages);
            MessageBox.Show(summaryMessage, "Error Summary", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            errProvider.Clear();
            List<string> errorMessages = ValidateRequiredFields();
            if (errorMessages.Count > 0)
            {
                ShowErrorSummary(errorMessages);
            }
            else
            {
                string upgradeassistantpath = txtUpgradeAssistantPath.Text;
                string script = "UpgradeAssitant.ps1";
                string scriptPath = Path.Combine(Directory.GetCurrentDirectory(), script);
                string projectpath = txtSolutionPath.Text;
                string logFilePath = lblErrorLogPath.Text;

                bool backupNotRequired = rbtnBackupNo.Checked;
                bool upgradeNonInteractive = rbtnNonInteractive.Checked;

                string targetFramework = ddlTargetFramework.Text;
                try
                {

                    string skipBackup = backupNotRequired ? "Yes" : "";
                    string nonInteractive = upgradeNonInteractive ? "Yes" : "";
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = "powershell",
                        Arguments = $"-File \"{scriptPath}\" -upgradeAssistantPath \"{upgradeassistantpath}\" -solutionPath \"{projectpath}\" -skipBackup \"{skipBackup}\" -nonInteractive \"{nonInteractive}\" -targetFramework \"{targetFramework}\" -logFilePath \"{logFilePath}\"",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false
                    };

                    using (Process process = new Process())
                    {
                        process.StartInfo = startInfo;
                        process.OutputDataReceived += (sender, e) => Console.WriteLine(e.Data);
                        process.ErrorDataReceived += (sender, e) => Console.WriteLine(e.Data);
                        process.Start();
                        process.BeginOutputReadLine();
                        process.BeginErrorReadLine();
                        process.WaitForExit();
                        MessageBox.Show("Upgrade Completed");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception occurreed: {ex.Message}");
                }
            }
        }
        private async void btnAnalyze_Click(object sender, EventArgs e)
        {
            errProvider.Clear();
            List<string> errorMessages = ValidateRequiredFields();
            if (errorMessages.Count > 0)
            {
                ShowErrorSummary(errorMessages);
            }
            else
            {
                string upgradeassistantpath = txtUpgradeAssistantPath.Text;
                string script = "UpgradeAnalysis.ps1";
                string scriptPath = Path.Combine(Directory.GetCurrentDirectory(), script);
                string projectpath = txtSolutionPath.Text;
                try
                {
                    //Give your local paths
                    string logFilePath = lblErrorLogPath.Text;
                    string logAnalysisPath = lblAnalysisPath.Text;
                    MessageBox.Show("Analysis Started");
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = "powershell",
                        Arguments = $"-File \"{scriptPath}\" -upgradeAssistantPath \"{upgradeassistantpath}\" -solutionPath \"{projectpath}\" -logFilePath \"{logFilePath}\" -logAnalysis \"{logAnalysisPath}\" ",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    using (Process process = new Process())
                    {
                        process.StartInfo = startInfo;
                        process.OutputDataReceived += (sender, e) => Console.WriteLine(e.Data);
                        process.ErrorDataReceived += (sender, e) => Console.WriteLine(e.Data);
                        Task processTask = Task.Run(() =>
                        {
                            process.Start();
                            process.BeginOutputReadLine();
                            process.BeginErrorReadLine();
                            process.WaitForExit();
                        });
                        await processTask;
                        MessageBox.Show("Analysis Completed");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception occurreed: {ex.Message}");
                }
            }
        }


        private void btnAnalysisLog_Click(object sender, EventArgs e)
        {
            DialogResult result = fldrBrowseAnalysisLog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fldrBrowseAnalysisLog.SelectedPath))
            {
                string ErrorLogPath = Path.Combine(fldrBrowseAnalysisLog.SelectedPath, "logFile.txt");
                string logAnalysisFilePath = Path.Combine(fldrBrowseAnalysisLog.SelectedPath, "logAnalysis.txt");
                if (!File.Exists(logAnalysisFilePath))
                {
                    File.WriteAllText(logAnalysisFilePath, string.Empty);
                }
                if (!File.Exists(ErrorLogPath))
                {
                    File.WriteAllText(ErrorLogPath, string.Empty);
                }
                lblAnalysisPath.Text = logAnalysisFilePath;
                lblErrorLogPath.Text = ErrorLogPath;
                txtAnalysisLog.Text = fldrBrowseAnalysisLog.SelectedPath;
            }
        }

     private void howItWorksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instantiate the second form
            aboutapp secondForm = new aboutapp();

            // Show the second form
            secondForm.Show();
        }
    }
}
