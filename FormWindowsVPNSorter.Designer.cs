using System.Windows.Forms;

namespace WindowsVPNSorter
{
    partial class FormWindowsVPNSorter
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
            this.lbInputVPNList = new System.Windows.Forms.ListBox();
            this.lbInput = new System.Windows.Forms.Label();
            this.lbOutputVPN = new System.Windows.Forms.Label();
            this.lbOutputVPNList = new System.Windows.Forms.ListBox();
            this.btnSortAZ = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpenDirectory = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpenBackupDirectory = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbInputVPNList
            // 
            this.lbInputVPNList.FormattingEnabled = true;
            this.lbInputVPNList.ItemHeight = 15;
            this.lbInputVPNList.Location = new System.Drawing.Point(12, 43);
            this.lbInputVPNList.Name = "lbInputVPNList";
            this.lbInputVPNList.Size = new System.Drawing.Size(288, 439);
            this.lbInputVPNList.TabIndex = 0;
            this.lbInputVPNList.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lbVPNList_Format);
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbInput.Location = new System.Drawing.Point(12, 12);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(96, 15);
            this.lbInput.TabIndex = 1;
            this.lbInput.Text = "Loaded VPN list:";
            // 
            // lbOutputVPN
            // 
            this.lbOutputVPN.AutoSize = true;
            this.lbOutputVPN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbOutputVPN.Location = new System.Drawing.Point(486, 12);
            this.lbOutputVPN.Name = "lbOutputVPN";
            this.lbOutputVPN.Size = new System.Drawing.Size(96, 15);
            this.lbOutputVPN.TabIndex = 3;
            this.lbOutputVPN.Text = "Output VPN list:";
            // 
            // lbOutputVPNList
            // 
            this.lbOutputVPNList.FormattingEnabled = true;
            this.lbOutputVPNList.ItemHeight = 15;
            this.lbOutputVPNList.Location = new System.Drawing.Point(486, 43);
            this.lbOutputVPNList.Name = "lbOutputVPNList";
            this.lbOutputVPNList.Size = new System.Drawing.Size(284, 439);
            this.lbOutputVPNList.TabIndex = 2;
            this.lbOutputVPNList.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lbVPNList_Format);
            // 
            // btnSortAZ
            // 
            this.btnSortAZ.Location = new System.Drawing.Point(306, 122);
            this.btnSortAZ.Name = "btnSortAZ";
            this.btnSortAZ.Size = new System.Drawing.Size(174, 23);
            this.btnSortAZ.TabIndex = 4;
            this.btnSortAZ.Text = "Sort A-Z";
            this.btnSortAZ.UseVisualStyleBackColor = true;
            this.btnSortAZ.Click += new System.EventHandler(this.btnSortAZ_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(306, 403);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(174, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpenDirectory
            // 
            this.btnOpenDirectory.Location = new System.Drawing.Point(306, 151);
            this.btnOpenDirectory.Name = "btnOpenDirectory";
            this.btnOpenDirectory.Size = new System.Drawing.Size(174, 23);
            this.btnOpenDirectory.TabIndex = 6;
            this.btnOpenDirectory.Text = "Open directory";
            this.btnOpenDirectory.UseVisualStyleBackColor = true;
            this.btnOpenDirectory.Click += new System.EventHandler(this.btnOpenDirectory_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(306, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(174, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpenBackupDirectory
            // 
            this.btnOpenBackupDirectory.Location = new System.Drawing.Point(306, 180);
            this.btnOpenBackupDirectory.Name = "btnOpenBackupDirectory";
            this.btnOpenBackupDirectory.Size = new System.Drawing.Size(174, 23);
            this.btnOpenBackupDirectory.TabIndex = 8;
            this.btnOpenBackupDirectory.Text = "Open backup directory";
            this.btnOpenBackupDirectory.UseVisualStyleBackColor = true;
            this.btnOpenBackupDirectory.Click += new System.EventHandler(this.btnOpenBackupDirectory_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(306, 238);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(174, 23);
            this.btnMoveUp.TabIndex = 9;
            this.btnMoveUp.Text = "Move Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(306, 267);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(174, 23);
            this.btnMoveDown.TabIndex = 10;
            this.btnMoveDown.Text = "Move Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // FormWindowsVPNSorter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 498);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnOpenBackupDirectory);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpenDirectory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSortAZ);
            this.Controls.Add(this.lbOutputVPN);
            this.Controls.Add(this.lbOutputVPNList);
            this.Controls.Add(this.lbInput);
            this.Controls.Add(this.lbInputVPNList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormWindowsVPNSorter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows VPN sorter";
            this.Shown += new System.EventHandler(this.FormWindowsVPNSorter_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbInputVPNList;
        private Label lbInput;
        private Label lbOutputVPN;
        private ListBox lbOutputVPNList;
        private Button btnSortAZ;
        private Button btnClose;
        private Button btnOpenDirectory;
        private Button btnSave;
        private Button btnOpenBackupDirectory;
        private Button btnMoveUp;
        private Button btnMoveDown;
    }
}