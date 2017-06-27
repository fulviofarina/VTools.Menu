namespace VTools
{
    partial class ucCalculate
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
            this.SCMENU = new System.Windows.Forms.SplitContainer();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SCMENU)).BeginInit();
            this.SCMENU.Panel1.SuspendLayout();
            this.SCMENU.Panel2.SuspendLayout();
            this.SCMENU.SuspendLayout();
            this.SuspendLayout();
            // 
            // SCMENU
            // 
            this.SCMENU.BackColor = System.Drawing.Color.Black;
            this.SCMENU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SCMENU.Location = new System.Drawing.Point(0, 0);
            this.SCMENU.Name = "SCMENU";
            // 
            // SCMENU.Panel1
            // 
            this.SCMENU.Panel1.Controls.Add(this.CalcBtn);
            // 
            // SCMENU.Panel2
            // 
            this.SCMENU.Panel2.Controls.Add(this.cancelBtn);
            this.SCMENU.Size = new System.Drawing.Size(536, 42);
            this.SCMENU.SplitterDistance = 272;
            this.SCMENU.TabIndex = 10;
            // 
            // CalcBtn
            // 
            this.CalcBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.CalcBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalcBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcBtn.ForeColor = System.Drawing.Color.PaleGreen;
            this.CalcBtn.Location = new System.Drawing.Point(0, 0);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(272, 42);
            this.CalcBtn.TabIndex = 0;
            this.CalcBtn.Text = "CALCULATE";
            this.CalcBtn.UseVisualStyleBackColor = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.Coral;
            this.cancelBtn.Location = new System.Drawing.Point(0, 0);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(260, 42);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // ucCalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SCMENU);
            this.Name = "ucCalculate";
            this.Size = new System.Drawing.Size(536, 42);
            this.SCMENU.Panel1.ResumeLayout(false);
            this.SCMENU.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SCMENU)).EndInit();
            this.SCMENU.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SCMENU;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}
