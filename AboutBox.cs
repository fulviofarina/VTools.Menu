using System;
using System.Reflection;
using System.Windows.Forms;

namespace VTools
{
    public partial class AboutBox : Form, IAboutBox
    {
      

    public AboutBox()
    {
            InitializeComponent();

            this.Load += AboutBox_Load;
            this.ControlBox = false;

        }

        private void AboutBox_Load(object sender, EventArgs e)
        {

            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;
            this.labelVersion.Text = AssemblyVersion;
            this.labelProductName.Text = AssemblyProduct;
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
    {
      get
      {
        object[] attributes = assemblyToProvide.GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
        if (attributes.Length > 0)
        {
          AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
          if (titleAttribute.Title != "")
          {
            return titleAttribute.Title;
          }
        }
        return System.IO.Path.GetFileNameWithoutExtension(assemblyToProvide.CodeBase);
      }
    }

    public string AssemblyVersion
    {
      get
      {
        return assemblyToProvide.GetName().Version.ToString();
      }
    }

    public string AssemblyDescription
    {
      get
      {
        object[] attributes = assemblyToProvide.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
        if (attributes.Length == 0)
        {
          return "";
        }
        return ((AssemblyDescriptionAttribute)attributes[0]).Description;
      }
    }

    public string AssemblyProduct
    {
      get
      {
        object[] attributes = assemblyToProvide.GetCustomAttributes(typeof(AssemblyProductAttribute), false);
        if (attributes.Length == 0)
        {
          return "";
        }
        return ((AssemblyProductAttribute)attributes[0]).Product;
      }
    }

    public string AssemblyCopyright
    {
      get
      {
        object[] attributes = assemblyToProvide.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
        if (attributes.Length == 0)
        {
          return "";
        }
        return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
      }
    }

    public string AssemblyCompany
    {
      get
      {
        object[] attributes = assemblyToProvide.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
        if (attributes.Length == 0)
        {
          return "";
        }
        return ((AssemblyCompanyAttribute)attributes[0]).Company;
      }
    }
        private Assembly assemblyToProvide;
        public Assembly AssemblyToProvide
        {
            get
            {
                return assemblyToProvide;
            }

            set
            {
                assemblyToProvide = value;
            }
        }

        #endregion Assembly Attribute Accessors

        private void okButton_Click(object sender, EventArgs e)
    {
            this.Visible = false;
    }
  }
}