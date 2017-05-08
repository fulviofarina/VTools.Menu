using System;


namespace VTools
{
    public interface IucOptions
    {
        //  Action AboutBoxAction { set; }
        Action DatabaseClick { set; }
        Action ExplorerClick { set; }
        Action PreferencesClick { set; }
        Action AboutBoxAction { set; }
        Action ConnectionBox { set; }
        Action SaveClick { set; }
        void ResetProgress(int max);
        void Set();
        void ShowProgress();
    }
}