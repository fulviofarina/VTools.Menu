using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace VTools
{
   
    public partial class ucGenericCBox : UserControl, IGenericBox
    {
        protected internal Binding binding;
        protected internal string bindingField = string.Empty;
        protected internal Action callBack;
        protected internal bool enterPressed;
        protected internal Action hideChildControl;

        protected internal int keyValue = 0;
        protected internal bool offline = false;

        public string BindingField
        {
            get
            {
                return bindingField;
            }

            set
            {
                bindingField = value;
            }
        }

        /// <summary>
        /// NOT EMPLOYED BUT COULD BE
        /// </summary>
        public Action CallBack
        {
            get
            {
                return callBack;
            }

            set
            {
                callBack = value;
            }
        }

        public new bool Enabled
        {
            get
            {
                return this.projectbox.Enabled;
            }
            set
            {
                this.projectbox.Enabled = value;
            }
        }

        public bool EnterPressed
        {
            get
            {
                return enterPressed;
            }

            set
            {
                enterPressed = value;
            }
        }

        public Action HideChildControl
        {
            set
            {
                hideChildControl = value;
            }
        }

        public string[] InputProjects
        {
            get
            {
                return projectbox.Items.OfType<string>().ToArray();
            }

            set
            {
                projectbox.Items.Clear();
                projectbox.Items.AddRange(value);
                // Rsx.Dumb.UIControl.FillABox(projectbox, value, true, false);
            }
        }

        public int KeyValue
        {
            get
            {
                return keyValue;
            }

            set
            {
                keyValue = value;
            }
        }

        public string Label
        {
            get
            {
                return projectlabel.Text;
            }

            set
            {
                projectlabel.Text = value;
            }
        }

        public bool Offline
        {
            get { return offline; }
            set { offline = value; }
        }

        public string TextContent
        {
            get
            {
                return projectbox.Text.Trim().ToUpper();
            }
            set
            {
                EventHandler hdl = delegate
                {
                    projectbox.Text = value.Trim().ToUpper();

                    PopulateListMethod?.Invoke(null, EventArgs.Empty);

                    this.keyUpPressed(this.projectbox, new KeyEventArgs(Keys.Enter));
                };
                hdl.Invoke(null, EventArgs.Empty);
                //this.Invoke(hdl);
            }
        }

        public Color TextBackColor
        {
            get
            {
                return this.projectbox.BackColor;
            }

            set
            {
                this.projectbox.BackColor = value;
            }
        }

        public Color TextForeColor
        {
            get
            {
                return this.projectbox.ForeColor;
            }

            set
            {
                this.projectbox.ForeColor = value;
            }
        }

        public Color LabelBackColor
        {
            get
            {
                return this.projectlabel.BackColor;
            }

            set
            {
                this.projectlabel.BackColor = value;
            }
        }

        public Color LabelForeColor
        {
            get
            {
                return this.projectlabel.ForeColor;
            }

            set
            {
                this.projectlabel.ForeColor = value;
            }
        }

        private bool rejected = false;// { get; set; }

        public bool Rejected
        {
            get { return rejected; }

            set { rejected = value; }
        }

        private bool wasRefreshed = false;// { get; set; }

        public bool WasRefreshed
        {
            get { return wasRefreshed; }

            set { wasRefreshed = value; }
        }

        public event EventHandler AddMethod;

        // public bool WasRefreshed { get; set; }

        public event EventHandler DeveloperMethod;

        public event EventHandler PopulateListMethod;

        /// <summary>
        /// </summary>
        public event EventHandler RefreshMethod;

        protected internal bool shouldUpdate = false;

        public void SetBindingSource(ref BindingSource bsSample, bool ShouldUpdate)
        {
            shouldUpdate = ShouldUpdate;

            DataSourceUpdateMode mo = DataSourceUpdateMode.OnPropertyChanged;
            bool t = true;
            // format = string.Empty; string text = "Text";
            binding = new Binding("Text", bsSample, bindingField, t, mo, DBNull.Value, string.Empty);
            binding.ControlUpdateMode = ControlUpdateMode.OnPropertyChanged;

            projectbox.DataBindings.Add(binding);

            PopulateListMethod?.Invoke(null, EventArgs.Empty);
            this.projectlabel.Click += openDropDown;
            this.projectbox.DropDownClosed += dropDownClosed;
            this.projectbox.DropDown += setReceiveUpdates;
        }

        public void SetNoBindingSource()
        {
            PopulateListMethod?.Invoke(null, EventArgs.Empty);
            this.projectlabel.Click += openDropDown;
            this.projectbox.DropDownClosed += dropDownClosed;

            this.projectbox.DropDown += setNoUpdates;
        }

        protected internal void dropDownClosed(object sender, EventArgs e)
        {
            // ComboBox box = sender as ComboBox; if (!box.IsOnDropDown) return;
            if (projectbox.SelectedItem != null)
            {
                string selectedName = projectbox.SelectedItem.ToString();
                //string col = Interface.IDB.SubSamples.SubSampleNameColumn.ColumnName;
                BindingSource bs = binding?.DataSource as BindingSource;
                if (bs != null)
                {
                    int pos = bs.Find(bindingField, selectedName);
                    bs.Position = pos;
                    // setReceiveUpdates();
                }
                else TextContent = selectedName;
            }
        }

        /// <summary>
        /// This could be outside since it does not depend on anything
        /// </summary>
        /// <param name="ProjectOrOrder"></param>
        protected internal void keyUpPressed(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            this.enterPressed = (key == Keys.Enter);

            this.keyValue = e.KeyValue;

            bool noEnter = key != Keys.Enter;

            noEnter = noEnter && (keyValue < 47 || keyValue > 105);

            rejected = true;
            wasRefreshed = false;

            if (noEnter)
            {
                return;
            }

            // setNoUpdates(sender, e);

            if (TextContent.Equals("DEV"))
            {
                DeveloperMethod?.Invoke(sender, EventArgs.Empty);
                return;
            }
            RefreshMethod?.Invoke(sender, e);
            //end edit
            (binding?.DataSource as BindingSource)?.EndEdit();

            if (enterPressed)
            {
                AddMethod?.Invoke(sender, e);
                // setReceiveUpdates();
                //the items list
                PopulateListMethod?.Invoke(sender, e);
            }

            callBack?.Invoke();
        }

        public void RejectChanges()
        {
            this.projectbox.ResetText();
        }

        // private Color color;
        protected internal void openDropDown(object sender, EventArgs e)
        {
            // if (projectbox.DroppedDown)
            {
                hideChildControl?.Invoke();
            }
            if (!projectbox.DroppedDown)
            {
                // hideChildControl?.Invoke();

                projectbox.DroppedDown = true;
            }
            else
            {
                projectbox.DroppedDown = false;
            }
        }

        protected internal void setNoUpdates(object sender, EventArgs e)
        {
            // ComboBox box = sender as ComboBox;

            projectbox
                .DataBindings
                .DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
        }

        protected internal void setReceiveUpdates(object sender, EventArgs e)
        {
            projectbox
               .DataBindings
               .DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
        }

        public ucGenericCBox()
        {
            InitializeComponent();

            this.projectbox.KeyUp += keyUpPressed;

            // this.projectlabel.MouseEnter += Projectlabel_MouseEnter;

            // this.projectbox.GotFocus += Projectbox_GotFocus; this.projectbox.LostFocus += Projectbox_LostFocus;
        }

        // private void Projectbox_LostFocus(object sender, EventArgs e) { setReceiveUpdates(); }

        // private void Projectbox_GotFocus(object sender, EventArgs e) { setNoUpdates(sender, e); }
    }
}