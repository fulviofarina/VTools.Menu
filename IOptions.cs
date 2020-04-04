using System;
using System.Windows.Forms;

namespace VTools
{
    public interface IOptions
    {
        bool EnableConnections { set; }
        bool EnableAdv { set; }
        EventHandler ShowProgress { get; }
        int Type { set; get; }

        event EventHandler AboutClick;

        event EventHandler ConnectionsClick;

        event EventHandler DatabaseInterfaceClick;

       // event EventHandler DropDownClicked;

        event EventHandler ExplorerClick;

        event EventHandler HelpClick;

        event EventHandler PreferencesClick;

        event EventHandler RestoreFoldersClick;

        event EventHandler SaveClick;

        void ClickSave();

        void ResetProgress(int max);

        void Set();
    }

}