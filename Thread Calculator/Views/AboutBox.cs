using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thread_Calculator
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            Text = String.Format("About");
            labelProductName.Text = AssemblyProduct;
            labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            labelCopyright.Text = AssemblyCopyright;
            labelCompanyName.Text = AssemblyCompany;
            textBoxDescription.Text = AssemblyDescription;
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length != 0)
                {
                    return "Reference: \r\nBS 1580-1:2007\r\nBS 1580-3:2007\r\nBS 1936-1:1952 AMD4923\r\nASME Y14.6-2001\r\n\r\nContact: \r\nThomas W\r\nTel: 0000 0000 000\r\nE-mail: xxx@yourdomain.com" +
                        "\r\n\r\nv.1.1.0.0:\r\nAn add-on for Screw Threads with diameters below 0.25\" implemented as per BS 1580-3:2007 excluding size/code #0 and #1." +
                         "\r\n\"BEFORE COATING\" text moved before coating sizes." +
                        "\r\n\"BEFORE COATING\" text added for all threads when any coating type is specified." +
                        "\r\n\"AFTER COATING\" note and sizes removed." +
                        "\r\nPS309 allowance option revised, other thick plating types added." +
                         "\r\n\r\nv.1.0.0.21:\r\nTabs removed from the results text and replaced with blank spaces - NX could not handle tabs properly." +
                        "\r\nResults text for female threads below 0.5\" amended after being formatted incorrectly." +
                        "\r\n\"BS1936 Sizes and Grade 2 tolerance\" changed to \"Undercuts to: BS1936 Sizes and Grade 2 tolerance\". ";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
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
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
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
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
