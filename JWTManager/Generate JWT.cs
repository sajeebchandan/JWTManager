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
using Microsoft.IdentityModel.Tokens;

namespace JWTManager
{
    public partial class GenerateJWT : MetroFramework.Forms.MetroForm
    {
        IList<Claim> payload = new List<Claim>();
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
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButtonAddClaim_Click(object sender, EventArgs e)
        {
            try
            {
                payload.Add(new Claim(metroTextBoxClaimName.Text.ToString(), metroTextBoxClaimValue.Text.ToString()));
                metroTextBoxClaims.Text = JsonConvert.SerializeObject(
                    new
                    {
                        type = metroTextBoxClaimName.Text.ToString(),
                        value = metroTextBoxClaimValue.Text.ToString(),
                    }, Formatting.Indented);
                metroTextBoxClaimName.Text = string.Empty;
                metroTextBoxClaimValue.Text = string.Empty;
                metroTextBoxClaimName.Focus();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(encryptionkey));
                var secToken = new JwtSecurityToken(
                signingCredentials: new SigningCredentials(securityKey, metroComboBoxHashingAlgorithm.SelectedItem.ToString()),
                issuer: "JWT Manager (https://github.com/sajeebchandan/JWTManager)",
                audience: "JWT Manager (https://github.com/sajeebchandan/JWTManager)",
                claims: payload,
                expires: DateTime.UtcNow.AddDays(30));
                var handler = new JwtSecurityTokenHandler();

                JWT _JWT = new JWT(handler.WriteToken(secToken));
                _JWT.ShowDialog();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "One or more field required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Private Methods
        private void LoadHashingAlgorithm()
        {
            try
            {
                foreach (var item in Enum.GetValues(typeof(JwtAlgorithmName)).Cast<JwtAlgorithmName>().ToList())
                {
                    metroComboBoxHashingAlgorithm.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        //        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
