using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JWTManager
{
    public partial class JWTManager : MetroFramework.Forms.MetroForm
    {
        public JWTManager()
        {
            InitializeComponent();
        }

        private void metroTileGenerateJWT_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                GenerateJWT _GenerateJWT = new GenerateJWT();
                _GenerateJWT.ShowDialog();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }
        }

        private void metroTileValidateJWT_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                ValidateJWT _ValidateJWT = new ValidateJWT();
                _ValidateJWT.ShowDialog();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }
        }

        private void JWTManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100);
                if (result == DialogResult.Yes)
                {
                    System.Environment.Exit(0);
                }
                else if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }
        }
    }
}
