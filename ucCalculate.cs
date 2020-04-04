using System;
using System.Windows.Forms;

namespace VTools
{
    public partial class ucCalculate : UserControl
    {
        public ucCalculate()
        {
            InitializeComponent();
        }

        public bool EnableCalculate
        {
            set
            {
                this.CalcBtn.Enabled = value;
                this.cancelBtn.Enabled = !value;
            }
        }

        public bool EnableCancel
        {
            set
            {
                this.cancelBtn.Enabled = value;
                this.CalcBtn.Enabled = !value;
            }
        }

        public new bool Enabled
        {
            set
            {
                this.CalcBtn.Enabled = value;
                this.cancelBtn.Enabled = value;
            }
        }

        public event EventHandler CalculateMethod
        {
            add
            {
                CalcBtn.Click += value;
            }
            remove

            {
                CalcBtn.Click -= value;
            }
        }

        public event EventHandler CancelMethod
        {
            add
            {
                cancelBtn.Click += value;
            }
            remove
            {
                cancelBtn.Click -= value;
            }
        }
    }
}