using System;
using System.Windows.Forms;

namespace VTools
{
    public interface IMenu
    {
        BindingNavigator BN { get; set; }
        BindingSource BS { get; set; }
        dynamic[] TableAM { get; set; }

        event EventHandler Refresher;

        void SetDGVs(ref DataGridView dgv);
        void SetMenues(string label, ref EventHandler handler);
        void Load();
    }
}