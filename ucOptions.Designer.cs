namespace VTools
{
    partial class ucOptions
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucOptions));
            this.TS = new System.Windows.Forms.ToolStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.OptionsBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.preferencesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.resourcesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.folderRestoreTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSMQPurgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.limsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.explorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TS.SuspendLayout();
            this.SuspendLayout();
            // 
            // TS
            // 
            this.TS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.TS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.OptionsBtn,
            this.toolStripSeparator13,
            this.Save,
            this.toolStripSeparator1,
            this.helpToolStripMenuItem2});
            this.TS.Location = new System.Drawing.Point(0, 0);
            this.TS.Name = "TS";
            this.TS.Size = new System.Drawing.Size(670, 46);
            this.TS.TabIndex = 6;
            this.TS.Text = "toolStrip4";
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.Black;
            this.progressBar.Maximum = 0;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 43);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // OptionsBtn
            // 
            this.OptionsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OptionsBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesTSMI,
            this.resourcesTSMI,
            this.toolStripSeparator2,
            this.databaseToolStripMenuItem,
            this.connectionsTSMI,
            this.limsTSMI,
            this.explorerToolStripMenuItem,
            this.toolStripSeparator4,
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem,
            this.aboutTSMI});
            this.OptionsBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsBtn.ForeColor = System.Drawing.Color.Orange;
            this.OptionsBtn.Image = ((System.Drawing.Image)(resources.GetObject("OptionsBtn.Image")));
            this.OptionsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OptionsBtn.Name = "OptionsBtn";
            this.OptionsBtn.ShowDropDownArrow = false;
            this.OptionsBtn.Size = new System.Drawing.Size(99, 43);
            this.OptionsBtn.Text = "OPTIONS";
            // 
            // preferencesTSMI
            // 
            this.preferencesTSMI.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.preferencesTSMI.Name = "preferencesTSMI";
            this.preferencesTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.preferencesTSMI.Size = new System.Drawing.Size(257, 30);
            this.preferencesTSMI.Text = "Preferences";
            // 
            // resourcesTSMI
            // 
            this.resourcesTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderRestoreTSMI,
            this.sQLDatabaseToolStripMenuItem,
            this.mSMQPurgeToolStripMenuItem});
            this.resourcesTSMI.Name = "resourcesTSMI";
            this.resourcesTSMI.Size = new System.Drawing.Size(257, 30);
            this.resourcesTSMI.Text = "Restore";
            // 
            // folderRestoreTSMI
            // 
            this.folderRestoreTSMI.Name = "folderRestoreTSMI";
            this.folderRestoreTSMI.Size = new System.Drawing.Size(205, 30);
            this.folderRestoreTSMI.Text = "Resources";
            // 
            // sQLDatabaseToolStripMenuItem
            // 
            this.sQLDatabaseToolStripMenuItem.Enabled = false;
            this.sQLDatabaseToolStripMenuItem.Name = "sQLDatabaseToolStripMenuItem";
            this.sQLDatabaseToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.sQLDatabaseToolStripMenuItem.Text = "SQL Database";
            // 
            // mSMQPurgeToolStripMenuItem
            // 
            this.mSMQPurgeToolStripMenuItem.Enabled = false;
            this.mSMQPurgeToolStripMenuItem.Name = "mSMQPurgeToolStripMenuItem";
            this.mSMQPurgeToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.mSMQPurgeToolStripMenuItem.Text = "MSMQ Purge";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(254, 6);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.databaseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.databaseToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.databaseToolStripMenuItem.Text = "Database";
            this.databaseToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // connectionsTSMI
            // 
            this.connectionsTSMI.Name = "connectionsTSMI";
            this.connectionsTSMI.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.connectionsTSMI.Size = new System.Drawing.Size(257, 30);
            this.connectionsTSMI.Text = "Connections";
            // 
            // limsTSMI
            // 
            this.limsTSMI.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limsTSMI.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.limsTSMI.Name = "limsTSMI";
            this.limsTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.limsTSMI.Size = new System.Drawing.Size(257, 30);
            this.limsTSMI.Text = "LIMS";
            // 
            // explorerToolStripMenuItem
            // 
            this.explorerToolStripMenuItem.Name = "explorerToolStripMenuItem";
            this.explorerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F3)));
            this.explorerToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.explorerToolStripMenuItem.Text = "Explorer";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(254, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(257, 30);
            this.toolStripMenuItem1.Text = "Help";
            this.toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.helpToolStripMenuItem.Text = "User Guide";
            // 
            // aboutTSMI
            // 
            this.aboutTSMI.Name = "aboutTSMI";
            this.aboutTSMI.Size = new System.Drawing.Size(257, 30);
            this.aboutTSMI.Text = "About";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 46);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.Aquamarine;
            this.Save.Name = "Save";
            this.Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Save.Size = new System.Drawing.Size(70, 46);
            this.Save.Text = "SAVE";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // helpToolStripMenuItem2
            // 
            this.helpToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.helpToolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem2.Name = "helpToolStripMenuItem2";
            this.helpToolStripMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpToolStripMenuItem2.Size = new System.Drawing.Size(71, 46);
            this.helpToolStripMenuItem2.Text = "HELP";
            // 
            // ucOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TS);
            this.Name = "ucOptions";
            this.Size = new System.Drawing.Size(670, 46);
            this.TS.ResumeLayout(false);
            this.TS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TS;
        private System.Windows.Forms.ToolStripDropDownButton OptionsBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem preferencesTSMI;
        private System.Windows.Forms.ToolStripMenuItem connectionsTSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem limsTSMI;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem resourcesTSMI;
        private System.Windows.Forms.ToolStripMenuItem explorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutTSMI;
        private System.Windows.Forms.ToolStripMenuItem folderRestoreTSMI;
        private System.Windows.Forms.ToolStripMenuItem sQLDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSMQPurgeToolStripMenuItem;
    }
}
