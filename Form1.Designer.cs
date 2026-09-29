namespace HW_T04_28_09_2026
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
            lstBlackList = new ListBox();
            btnStartProcess = new Button();
            label1 = new Label();
            btnRemove = new Button();
            btnAdd = new Button();
            txtProcessName = new TextBox();
            label2 = new Label();
            txtStartProcessPath = new TextBox();
            btnUpdate = new Button();
            btnStop = new Button();
            lstProcesses = new ListBox();
            txtProcessInfo = new TextBox();
            label3 = new Label();
            btnStartStop = new Button();
            SuspendLayout();
            // 
            // lstBlackList
            // 
            lstBlackList.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lstBlackList.FormattingEnabled = true;
            lstBlackList.Location = new Point(207, 206);
            lstBlackList.Name = "lstBlackList";
            lstBlackList.Size = new Size(120, 94);
            lstBlackList.TabIndex = 0;
            // 
            // btnStartProcess
            // 
            btnStartProcess.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnStartProcess.Location = new Point(648, 341);
            btnStartProcess.Name = "btnStartProcess";
            btnStartProcess.Size = new Size(75, 23);
            btnStartProcess.TabIndex = 2;
            btnStartProcess.Text = "Start";
            btnStartProcess.UseVisualStyleBackColor = true;
            btnStartProcess.Click += btnStartProcess_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(207, 188);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 3;
            label1.Text = "Black list";
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemove.Location = new Point(648, 222);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.Location = new Point(648, 251);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtProcessName
            // 
            txtProcessName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtProcessName.Location = new Point(333, 277);
            txtProcessName.Name = "txtProcessName";
            txtProcessName.Size = new Size(390, 23);
            txtProcessName.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(207, 314);
            label2.Name = "label2";
            label2.Size = new Size(140, 15);
            label2.TabIndex = 8;
            label2.Text = "Process name of file path";
            // 
            // txtStartProcessPath
            // 
            txtStartProcessPath.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtStartProcessPath.Location = new Point(207, 342);
            txtStartProcessPath.Name = "txtStartProcessPath";
            txtStartProcessPath.Size = new Size(435, 23);
            txtStartProcessPath.TabIndex = 9;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(12, 23);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(93, 23);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 11;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // lstProcesses
            // 
            lstProcesses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lstProcesses.FormattingEnabled = true;
            lstProcesses.Location = new Point(12, 52);
            lstProcesses.Name = "lstProcesses";
            lstProcesses.Size = new Size(156, 319);
            lstProcesses.TabIndex = 12;
            lstProcesses.SelectedIndexChanged += lstProcesses_SelectedIndexChanged;
            // 
            // txtProcessInfo
            // 
            txtProcessInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtProcessInfo.Location = new Point(207, 52);
            txtProcessInfo.Multiline = true;
            txtProcessInfo.Name = "txtProcessInfo";
            txtProcessInfo.Size = new Size(516, 122);
            txtProcessInfo.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 27);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 14;
            label3.Text = "Process Information";
            // 
            // btnStartStop
            // 
            btnStartStop.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnStartStop.Location = new Point(333, 206);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(143, 54);
            btnStartStop.TabIndex = 15;
            btnStartStop.Text = "Start apps detection";
            btnStartStop.UseVisualStyleBackColor = true;
            btnStartStop.Click += btnStartStop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 377);
            Controls.Add(btnStartStop);
            Controls.Add(label3);
            Controls.Add(txtProcessInfo);
            Controls.Add(lstProcesses);
            Controls.Add(btnStop);
            Controls.Add(btnUpdate);
            Controls.Add(txtStartProcessPath);
            Controls.Add(label2);
            Controls.Add(txtProcessName);
            Controls.Add(btnAdd);
            Controls.Add(btnRemove);
            Controls.Add(label1);
            Controls.Add(btnStartProcess);
            Controls.Add(lstBlackList);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstBlackList;
        private Button btnStartProcess;
        private Label label1;
        private Button btnRemove;
        private Button btnAdd;
        private TextBox txtProcessName;
        private Label label2;
        private TextBox txtStartProcessPath;
        private Button btnUpdate;
        private Button btnStop;
        private ListBox lstProcesses;
        private TextBox txtProcessInfo;
        private Label label3;

        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Timer timerProcessMonitor;
    }
}
