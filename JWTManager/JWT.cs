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
    public partial class JWT : MetroFramework.Forms.MetroForm
    {
        string Token;
        bool isCopied = false;
        public JWT(string token)
        {
            InitializeComponent();
            Token = token;
        }

        private void metroButtonCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(metroTextBoxToken.Text);
                isCopied = true;
                MetroFramework.MetroMessageBox.Show(this, "Token copied to clipboard", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButtonOk_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void JWT_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(metroTextBoxToken.Text))
                {
                    if (isCopied == false)
                    {
                        DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Do you want to copy the text?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            //code for Yes
                            e.Cancel = true;
                            try
                            {
                                metroButtonCopy.Focus();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else if (result == DialogResult.No)
                        {
                            this.Hide();
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            //code for Cancel
                            e.Cancel = true;
                        }
                    }
                    else
                    {
                        this.Hide();
                    }
                }
                else
                {
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void JWT_Load(object sender, EventArgs e)
        {
            try
            {
                metroTextBoxToken.Text = Token;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
