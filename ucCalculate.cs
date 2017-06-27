using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VTools
{
    public partial class ucCalculate : UserControl
    {
        public ucCalculate()
        {
            InitializeComponent();
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
