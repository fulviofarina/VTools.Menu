using System.Reflection;

namespace VTools
{
    public interface IAboutBox
    {
        string AssemblyCompany { get; }
        string AssemblyCopyright { get; }
        string AssemblyDescription { get; }
        string AssemblyProduct { get; }
        string AssemblyTitle { get; }
        Assembly AssemblyToProvide { get; set; }
        string AssemblyVersion { get; }
        void Show();
    }
}