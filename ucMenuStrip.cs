using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace VTools
{
    public partial class ucMenuStrip : UserControl, IMenu
    {
        private void dGV_Enter(object sender, EventArgs e)
        {
            BindingSource bs = ((DataGridView)sender).DataSource as BindingSource;
            this.BN.BindingSource = bs;
        }

        public void SetMenues(string label, ref EventHandler handler)
        {
            ToolStripMenuItem TSMI = new ToolStripMenuItem();
                       TSMI.Size = new System.Drawing.Size(170, 22);
            TSMI.Text = label;
            TSMI.Click += handler;

            this.toolStripMenuItem1.DropDownItems.Add(
           TSMI);
          
        }

        public event EventHandler Refresher
        {
            add
            {
                this.refreshItem.Click += value;//
            }
            remove
            {
                this.refreshItem.Click -= value;//
            }
        }

        public event EventHandler Saver
        {
            add
            {
                this.SaveBtn.Click += value;//
            }
            remove
            {
                this.SaveBtn.Click -= value;//
            }
        }



        public void SetDGVs(ref DataGridView dgv)
        {
       
            dgv.MouseHover += this.dGV_Enter;
        }

      

        public BindingSource BS
        {
          
            get;
            set;
        }
        public BindingNavigator BN
        {

            get;
            set;
        }

        public ucMenuStrip()
        {
            InitializeComponent();

            makeBN();
        }

        private void makeBN()
        {
            this.SuspendLayout();
            BN = new BindingNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.BN)).BeginInit();
            this.BN.AddNewItem = this.bindingNavigatorAddNewItem;
            this.BN.CountItem = this.bindingNavigatorCountItem;
            this.BN.DeleteItem = this.bindingNavigatorDeleteItem;
            this.BN.Dock = System.Windows.Forms.DockStyle.None;
            this.BN.Location = new System.Drawing.Point(597, 41);
            this.BN.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BN.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BN.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BN.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BN.Name = "prefBN";
            this.BN.PositionItem = this.bindingNavigatorPositionItem;
            this.BN.Size = new System.Drawing.Size(43, 25);
            this.BN.TabIndex = 4;
            this.BN.Text = "bindingNavigator1";

            // this.Controls.Add(this.prefBN);
            ((System.ComponentModel.ISupportInitialize)(this.BN)).EndInit();
            this.ResumeLayout();
        }

        private dynamic[] tableAM;

        /// <summary>
        /// THIS IS A TABLE ADAPTER MANAGER
        /// </summary>
        public dynamic[] TableAM
        {
            get
            {
                if (tableAM == null)
                {
                    tableAM = new dynamic[2];
                }
                return tableAM;
            }
            set { tableAM = value; }
        }

        public Hashtable HashTA { get; set; }



        /*
        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.ParentForm.Validate();

            if (BN.BindingSource == null) return;

            try
            {

                this.BN.BindingSource.EndEdit();

                DataSet data = (DataSet)this.BN.BindingSource.DataSource;
                string member = this.BN.BindingSource.DataMember;

                tableAM[0].UpdateAll((DataSet)data);
                tableAM[1].UpdateAll((DataSet)data);
            }
            catch (Exception ex)
            {

             //   throw;
            }
        
        }
        */
     

        public new void Load()
        {
            //base.OnLoad(e);
            this.refreshItem.PerformClick();
        //    this.SaveBtn.Click += new System.EventHandler(this.saveBtn_Click);

        }


    }
}