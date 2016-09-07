using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace VTools
{
    public partial class ucMenuStrip : UserControl
    {
        private void dGV_Enter(object sender, EventArgs e)
        {
            BindingSource bs = ((DataGridView)sender).DataSource as BindingSource;
            this.prefBN.BindingSource = bs;
        }

        public void SetMenues(string label, ref EventHandler handler)
        {
            System.Windows.Forms.ToolStripMenuItem TSMI = new System.Windows.Forms.ToolStripMenuItem();
            //   this.genListTSMI = new System.Windows.Forms.ToolStripMenuItem();

            ///   this.TSMI.Name = "genExaTSMI";
            TSMI.Size = new System.Drawing.Size(170, 22);
            TSMI.Text = label;
            TSMI.Click += handler;

            this.toolStripMenuItem1.DropDownItems.Add(
           TSMI);
            //
            // genListTSMI
        }

        public void SetReload(ref EventHandler handler)
        {
            this.refreshItem.Click += handler;//
            // genListTSMI
        }

        private EventHandler dgvSelectionChanged;

        public EventHandler DgvSelectionChanged
        {
            // get { return dgvSelectionChanged; }
            set { dgvSelectionChanged = value; }
        }

        public void SetDGVs(ref DataGridView dgv)
        {
            dgv.SelectionChanged += dgvSelectionChanged;
            dgv.MouseHover += this.dGV_Enter;
        }

        private System.Windows.Forms.BindingNavigator prefBN;

        public BindingSource BS
        {
            //  get { return prefBN; }
            set { prefBN.BindingSource = value; }
        }

        public ucMenuStrip()
        {
            InitializeComponent();

            BindingNavigator();
        }

        private void BindingNavigator()
        {
            this.SuspendLayout();
            this.prefBN = new System.Windows.Forms.BindingNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.prefBN)).BeginInit();
            this.prefBN.AddNewItem = this.bindingNavigatorAddNewItem;
            this.prefBN.CountItem = this.bindingNavigatorCountItem;
            this.prefBN.DeleteItem = this.bindingNavigatorDeleteItem;
            this.prefBN.Dock = System.Windows.Forms.DockStyle.None;
            this.prefBN.Location = new System.Drawing.Point(597, 41);
            this.prefBN.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.prefBN.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.prefBN.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.prefBN.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.prefBN.Name = "prefBN";
            this.prefBN.PositionItem = this.bindingNavigatorPositionItem;
            this.prefBN.Size = new System.Drawing.Size(43, 25);
            this.prefBN.TabIndex = 4;
            this.prefBN.Text = "bindingNavigator1";

            //   this.Controls.Add(this.prefBN);
            ((System.ComponentModel.ISupportInitialize)(this.prefBN)).EndInit();
            this.ResumeLayout();
        }

        private dynamic tableAM;

        /// <summary>
        /// THIS IS A TABLE ADAPTER MANAGER
        /// </summary>
        public dynamic TableAM
        {
            get { return tableAM; }
            set { tableAM = value; }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            this.ParentForm.Validate();
            this.prefBN.BindingSource.EndEdit();
            dynamic db = this.prefBN.BindingSource.DataSource;
            DataSet data = db;

            //  DataTable dt = db.Tables[this.prefBN.BindingSource.DataMember];

            foreach (DataTable dt in data.Tables)
            {
                IEnumerable<DataRow> changes = dt.Rows.OfType<DataRow>();
                // changes = Dumb.GetRowsWithChanges(changes);
                changes = changes.Where(o => o.RowState == DataRowState.Modified);

                foreach (DataRow r in changes)
                {
                    IEnumerable<DataColumn> dtes = dt.Columns.OfType<DataColumn>().Where(o => o.DataType == typeof(DateTime));
                    foreach (DataColumn d in dtes)
                    {
                        r.SetField(d, DateTime.Now); //update the dates
                    }
                }
            }

            tableAM.UpdateAll(db);
        }
    }
}