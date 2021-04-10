using JWT;
using JWT.Algorithms;
using JWT.Builder;
using JWT.Exceptions;
using JWT.Serializers;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JWTManager
{
    public partial class ValidateJWT : MetroFramework.Forms.MetroForm
    {
        string encryptionkey;
        public ValidateJWT()
        {
            InitializeComponent();
        }

        private void ValidateJWT_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            JWTManager _JWTManager = new JWTManager();
            _JWTManager.ShowDialog();
        }

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

        private static TokenValidationParameters GetValidationParameters(string key)
        {
            return new TokenValidationParameters()
            {
                ValidateLifetime = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key)) // The same key as the one that generate the token
            };
        }

        private static bool ValidateToken(string authToken, string key)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var validationParameters = GetValidationParameters(key);

                SecurityToken validatedToken;
                IPrincipal principal = tokenHandler.ValidateToken(authToken, validationParameters, out validatedToken);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void metroButtonValidateJwt_Click(object sender, EventArgs e)
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
            try
            {
                if (ValidateToken(metroTextBoxToken.Text, encryptionkey))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Token Validation Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Signature Validated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            catch (TokenExpiredException)
            {
                Debug.WriteLine("Token has expired");
                MetroFramework.MetroMessageBox.Show(this, "Token Expired", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SignatureVerificationException)
            {
                Debug.WriteLine("Token has invalid signature");
                MetroFramework.MetroMessageBox.Show(this, "Invalid Signature", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButtonLoadData_Click(object sender, EventArgs e)
        {
            metroTextBoxClaims.Text = "";
            try
            {
                var _JwtSecurityToken = new JwtSecurityTokenHandler().ReadJwtToken(metroTextBoxToken.Text.ToString()) as JwtSecurityToken;
                var ClaimList = _JwtSecurityToken.Claims.Select(x => new
                {
                    Name = x.Type,
                    Value = x.Value
                });
                metroComboBoxHashingAlgorithm.SelectedItem = _JwtSecurityToken.SignatureAlgorithm;
                metroTextBoxClaims.Text = JsonConvert.SerializeObject(ClaimList, Formatting.Indented);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ValidateJWT_Load(object sender, EventArgs e)
        {
            LoadHashingAlgorithm();
        }
    }
}
