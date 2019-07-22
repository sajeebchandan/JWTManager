using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JWT.Builder;
using JWT.Algorithms;
using JWT;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Security.Claims;
using JWT.Serializers;
using Newtonsoft.Json;

namespace JWTManager
{
    public partial class GenerateJWT : MetroFramework.Forms.MetroForm
    {
        IDictionary<string, object> payload = new Dictionary<string, object>();
        string encryptionkey;
        public GenerateJWT()
        {
            InitializeComponent();
        }

        private void GenerateJWT_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.Hide();
                JWTManager _JWTManager = new JWTManager();
                _JWTManager.ShowDialog();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }
        }

        private void GenerateJWT_Load(object sender, EventArgs e)
        {
            try
            {
                LoadHashingAlgorithm();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }
        }

        private void metroButtonAddClaim_Click(object sender, EventArgs e)
        {
            try
            {
                payload.Add(metroTextBoxClaimName.Text.ToString(), metroTextBoxClaimValue.Text.ToString());
                metroTextBoxClaims.Text = JsonConvert.SerializeObject(payload, Formatting.Indented);
                metroTextBoxClaimName.Text = string.Empty;
                metroTextBoxClaimValue.Text = string.Empty;
                metroTextBoxClaimName.Focus();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }
        }

        private void metroButtonGenerateJey_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBoxEncryptionKey.Text != string.Empty && metroTextBoxEncryptionKey.Enabled == true)
                {
                    encryptionkey = metroTextBoxEncryptionKey.Text.ToString();
                }
                else if (metroCheckBoxUseDefault.Checked)
                {
                    encryptionkey = "KwkQ37eYtFJ94mpsuoWuyVph5vLpDmeX9FYFsSLqsUTzMvyeW2dZcN7PW2eQKJzQEDJ9JDL3LpKki9eDtDkDDHgiyroMNb7zcfysdXat";
                }
                else
                    encryptionkey = null;
                IJwtAlgorithm algorithm;
                if (metroComboBoxHashingAlgorithm.SelectedItem.ToString() == "HS256")
                {
                    algorithm = new HMACSHA256Algorithm();
                }
                else if (metroComboBoxHashingAlgorithm.SelectedItem.ToString() == "HS384")
                {
                    algorithm = new HMACSHA384Algorithm();
                }
                else if (metroComboBoxHashingAlgorithm.SelectedItem.ToString() == "HS512")
                {
                    algorithm = new HMACSHA512Algorithm();
                }
                else if (metroComboBoxHashingAlgorithm.SelectedItem.ToString() == "RS256")
                {
                    algorithm = new HMACSHA256Algorithm();
                }
                else
                    algorithm = new HMACSHA256Algorithm();
                IJsonSerializer serializer = new JsonNetSerializer();
                IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
                IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
                payload.Add("exp", DateTimeOffset.UtcNow.AddMinutes(Convert.ToInt32(metroTextBox1.Text.ToString())).ToUnixTimeSeconds());

                var token = encoder.Encode(payload, encryptionkey);
                JWT _JWT = new JWT(token);
                _JWT.ShowDialog();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }
        }

        private void metroCheckBoxUseDefault_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (metroCheckBoxUseDefault.Checked)
                {
                    metroTextBoxEncryptionKey.Text = string.Empty;
                    metroTextBoxEncryptionKey.Enabled = false;
                }
                else
                {
                    metroTextBoxEncryptionKey.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }
        }

        //Private Methods
        private void LoadHashingAlgorithm()
        {
            try
            {
                foreach (var item in Enum.GetValues(typeof(JwtHashAlgorithm)).Cast<JwtHashAlgorithm>().ToList())
                {
                    metroComboBoxHashingAlgorithm.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }
        }
        //private void AddClaimToListView(string claimName, string claimValue)
        //{
        //    try
        //    {
        //        ListViewItem item = listViewClaims.Items.Add(claimName);
        //        item.SubItems.Add(claimValue);
        //    }
        //    catch (Exception ex)
        //    {
        //        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
        //    }
        //}

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }
        }
    }
}
