using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace HW_T04_28_09_2026
{
    public partial class Form1 : Form
    {
        private bool isMonitoring = false;

        public Form1()
        {
            InitializeComponent();

            this.MinimumSize = new System.Drawing.Size(750, 450);

            timerProcessMonitor = new System.Windows.Forms.Timer();
            timerProcessMonitor.Interval = 2000;
            timerProcessMonitor.Tick += timerProcessMonitor_Tick;
        }

        private void btnStartProcess_Click(object sender, EventArgs e)
        {
            ProcessHelper.Start(txtStartProcessPath.Text);
            btnUpdate_Click(sender, e);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (GetActualSelected() is ProcessWraper processWraper)
            {
                ProcessHelper.Stop(processWraper.GetInnerProcess().ProcessName);
                btnUpdate_Click(sender, e);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lstProcesses.Items.Clear();

            Process[] allProcesses = Process.GetProcesses();

            for (int i = 0; i < allProcesses.Length; i++)
            {
                lstProcesses.Items.Add(new ProcessWraper(allProcesses[i]));
            }
        }

        private void lstProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProcessInfo.Text = GetActualSelected()?.GetProcessInfo() ?? string.Empty;
        }

        private ProcessWraper GetActualSelected()
        {
            if (lstProcesses.SelectedIndex >= 0)
            {
                if (lstProcesses.SelectedItem is ProcessWraper processWraper)
                {
                    return processWraper;
                }
            }

            return null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string processName = txtProcessName.Text.Trim();

            if (!string.IsNullOrEmpty(processName))
            {
                if (processName.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
                {
                    processName = processName.Substring(0, processName.Length - 4);
                }

                if (!lstBlackList.Items.Contains(processName))
                {
                    lstBlackList.Items.Add(processName);
                    txtProcessName.Clear();
                }
                else
                {
                    MessageBox.Show("This process is already in the black list!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstBlackList.SelectedItem != null)
            {
                lstBlackList.Items.Remove(lstBlackList.SelectedItem);
            }
            else
            {
                MessageBox.Show("Select a process from the black list to remove!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            isMonitoring = !isMonitoring;

            if (isMonitoring)
            {
                timerProcessMonitor.Start();
                btnStartStop.Text = "Stop apps detection";
            }
            else
            {
                timerProcessMonitor.Stop();
                btnStartStop.Text = "Start apps detection";
            }
        }

        private void timerProcessMonitor_Tick(object sender, EventArgs e)
        {
            foreach (var item in lstBlackList.Items)
            {
                string forbiddenProcess = item.ToString();
                ProcessHelper.Stop(forbiddenProcess, all: true);
            }
        }
    }
}