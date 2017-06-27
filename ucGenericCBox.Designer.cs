namespace VTools
{
    partial class ucGenericCBox
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.projectlabel = new System.Windows.Forms.Label();
            this.projectbox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.04207F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.957929F));
            this.tableLayoutPanel1.Controls.Add(this.projectlabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.projectbox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(341, 45);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // projectlabel
            // 
            this.projectlabel.AutoSize = true;
            this.projectlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectlabel.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.projectlabel.ForeColor = System.Drawing.Color.Thistle;
            this.projectlabel.Location = new System.Drawing.Point(3, 0);
            this.projectlabel.Name = "projectlabel";
            this.projectlabel.Size = new System.Drawing.Size(107, 45);
            this.projectlabel.TabIndex = 0;
            this.projectlabel.Text = "PROJECT";
            this.projectlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // projectbox
            // 
            this.projectbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.projectbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.projectbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.projectbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectbox.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.projectbox.ForeColor = System.Drawing.Color.LemonChiffon;
            this.projectbox.Location = new System.Drawing.Point(116, 3);
            this.projectbox.Name = "projectbox";
            this.projectbox.Size = new System.Drawing.Size(206, 38);
            this.projectbox.TabIndex = 1;
            // 
            // ucGenericCBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucGenericCBox";
            this.Size = new System.Drawing.Size(341, 45);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label projectlabel;
        private System.Windows.Forms.ComboBox projectbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
