using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JWTManager
{
    public partial class AboutForm : MetroFramework.Forms.MetroForm
    {
        private FileVersionInfo fileVersion = null;
        public AboutForm()
        {
            InitializeComponent();
            fileVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
            labelVersion.Text = fileVersion.ProductName + " " + fileVersion.FileVersion;
        }

        private void linkLabelSajeebChandanSaha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/sajeebchandan");
        }

        private void buttonFiverr_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.fiverr.com/sajeeb_chandan");
        }

        private void buttonLinkedin_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/sajeeb-chandan-saha-0b15b7b0/");
        }

        private void buttonGithub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/sajeebchandan");
        }

        private void linkLabelAppName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/sajeebchandan/JWTManager");
        }
    }
}
