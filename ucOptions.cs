using System;
using System.Windows.Forms;

namespace VTools
{
  
    public partial class ucOptions : UserControl, IOptions
    {
        private int type = 0;

        public bool EnableConnections
        {
            set
            {
                if (connectionsTSMI != null) connectionsTSMI.Enabled = value;
              
            }
        }

        public bool EnableAdv
        {
            set
            {
                if (this.explorerToolStripMenuItem != null) this.explorerToolStripMenuItem.Enabled = value;
                if (this.limsTSMI != null) this.limsTSMI.Enabled = value;
            }
        }

        public EventHandler ShowProgress
        {
            get
            {
                EventHandler pros = delegate
                {
                    this.progressBar?.PerformStep();
                    Application.DoEvents();
                };

                return pros;
            }
        }

        public int Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public event EventHandler AboutClick
        {
            add
            {
                if (aboutTSMI != null) aboutTSMI.Click += value;
            }

            remove
            {
                if (aboutTSMI != null) aboutTSMI.Click -= value;
            }
        }

        public event EventHandler ConnectionsClick
        {
            add
            {
                if (connectionsTSMI != null) connectionsTSMI.Click += value;
            }
            remove
            {
                if (connectionsTSMI != null) connectionsTSMI.Click -= value;
            }
        }

        public event EventHandler DatabaseInterfaceClick
        {
            add
            {
                if (limsTSMI != null) limsTSMI.Click += value;
            }
            remove
            {
                if (limsTSMI != null) limsTSMI.Click -= value;
            }
        }
        /*
        public event EventHandler DropDownClicked
        {
            add
            {
                if (OptionsBtn != null) this.OptionsBtn.DropDownOpened += value;
            }

            remove
            {
                if (OptionsBtn != null) this.OptionsBtn.DropDownOpened -= value;
            }
        }
        */
        public event EventHandler ExplorerClick
        {
            add
            {
                if (explorerToolStripMenuItem != null) explorerToolStripMenuItem.Click += value;
            }
            remove
            {
                if (explorerToolStripMenuItem != null) explorerToolStripMenuItem.Click -= value;
            }
        }

        public event EventHandler HelpClick
        {
            add
            {
                if (helpToolStripMenuItem2 != null) helpToolStripMenuItem2.Click += value;
                if (helpToolStripMenuItem != null) helpToolStripMenuItem.Click += value;
            }
            remove
            {
                if (helpToolStripMenuItem2 != null) helpToolStripMenuItem2.Click -= value;
                if (helpToolStripMenuItem != null) helpToolStripMenuItem.Click -= value;
            }
        }

        public event EventHandler PreferencesClick
        {
            add
            {
                if (preferencesTSMI != null) this.preferencesTSMI.Click += value;
                if (setup != null) this.setup.Click += value;
            }

            remove
            {
                if (preferencesTSMI != null) this.preferencesTSMI.Click -= value;
                if (setup != null) this.setup.Click -= value;
            }
        }

        public event EventHandler RestoreFoldersClick
        {
            add
            {
                if (folderRestoreTSMI != null) this.folderRestoreTSMI.Click += value;
            }
            remove
            {
                if (folderRestoreTSMI != null) this.folderRestoreTSMI.Click -= value;
            }
        }

        public event EventHandler SaveClick
        {
            add
            {
                if (Save != null) this.Save.Click += value;
                if (save2 != null) this.save2.Click += value;
            }

            remove
            {
                if (Save != null) this.Save.Click -= value;
                if (save2 != null) this.save2.Click -= value;
            }
        }

        public void ClickSave()
        {
            if (this.Save!=null) this.Save.PerformClick();
            else this.save2.PerformClick();
        }

        public void ResetProgress(int max)
        {
            if (this.progressBar == null) return;
            this.progressBar.Minimum = 0;
            this.progressBar.Step = 1;
            if (max == 0)
            {
                this.progressBar.Maximum = 0;
                this.progressBar.Value = 0;
            }
            else this.progressBar.Maximum += max;
        }

        public void Set()
        {
            this.Save.Click += delegate
            {
                this.ParentForm?.Validate();
            };
        }

        public ucOptions()
        {
            InitializeComponent();
        }

        public ucOptions(int tipo)
        {
            InitializeComponent();
            type = tipo;
        }
    }
}