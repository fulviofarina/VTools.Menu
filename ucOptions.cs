using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;


namespace VTools
{
    public partial class ucOptions : UserControl, IucOptions
    {
        public ucOptions()
        {
            InitializeComponent();

           
        }



   //     private Interface Interface;
        public void Set()
        {
            //    Interface = inter;

            this.connectionsTSMI.Click += (this.connectionsTSMI_Click);
            this.aboutToolStripMenuItem.Click += (this.aboutToolStripMenuItem_Click);


            this.Save.Click += Save_Click;

            this.limsTSMI.Click += LimsTSMI_Click;

            this.preferencesTSMI.Click += PreferencesTSMI_Click;
           

        }

        private void LimsTSMI_Click(object sender, EventArgs e)
        {
            databaseClick?.Invoke();
        }

        private void PreferencesTSMI_Click(object sender, EventArgs e)
        {
            preferencesClick?.Invoke();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.ParentForm.Validate();

            saveClick?.Invoke();
        }

        private Action preferencesClick;
        private Action databaseClick;


        public Action PreferencesClick
        {


            set
            {
                preferencesClick = value;
            }
        }
        public Action DatabaseClick
        {


            set
            {
                databaseClick = value;
            }
        }

        private   Action aboutBox;

        public Action AboutBoxAction
        {
          

            set
            {
                aboutBox = value;
            }
        }
        private Action saveClick;

        public Action SaveClick
        {


            set
            {
                saveClick = value;
            }
        }

        private Action connectionBox;

        public Action ConnectionBox
        {


            set
            {
                connectionBox = value;
            }
        }
        private Action explorer;

        public Action ExplorerClick
        {


            set
            {
                explorer = value;
            }
        }
        public void  ShowProgress()
        {
            Application.DoEvents();
                this.progressBar.PerformStep();
            Application.DoEvents();

        }


        public void ResetProgress (int max)
        {

            this.progressBar.Minimum = 0;
            this.progressBar.Step = 1;
            this.progressBar.Maximum = max;
            this.progressBar.Value = 0;

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutBox?.Invoke();
        }

        private void connectionsTSMI_Click(object sender, EventArgs e)
        {
            connectionBox?.Invoke();
        }

        private void explorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            explorer?.Invoke();
        }
    }
}