using System;
using System.Drawing;
using System.Windows.Forms;

namespace VTools
{
    public interface IGenericBox
    {
        string BindingField { get; set; }
        Action CallBack { get; set; }
        bool Enabled { get; set; }
        bool EnterPressed { get; set; }
        Action HideChildControl { set; }
        string[] InputProjects { get; set; }
        int KeyValue { get; set; }
        string Label { get; set; }
        Color LabelBackColor { get; set; }
        Color LabelForeColor { get; set; }
        bool Offline { get; set; }
        bool Rejected { get; set; }
        bool WasRefreshed { get; set; }
        Color TextBackColor { get; set; }
        string TextContent { get; set; }
        Color TextForeColor { get; set; }

        event EventHandler AddMethod;

        event EventHandler DeveloperMethod;

        event EventHandler PopulateListMethod;

        event EventHandler RefreshMethod;

        void SetNoBindingSource();

        void SetBindingSource(ref BindingSource bsSample, bool shouldUpdate);
    }


}