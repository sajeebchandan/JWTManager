using JWT;
using JWT.Builder;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
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
                var json = new JwtBuilder()
                     .WithSecret(encryptionkey)
                     .MustVerifySignature()
                     .Decode(metroTextBoxToken.Text.ToString());
                MetroFramework.MetroMessageBox.Show(this, "Signature Validated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
            }
            catch (TokenExpiredException)
            {
                Debug.WriteLine("Token has expired");
                MetroFramework.MetroMessageBox.Show(this, "Token Expired", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }
            catch (SignatureVerificationException)
            {
                Debug.WriteLine("Token has invalid signature");
                MetroFramework.MetroMessageBox.Show(this, "Invalid Signature", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            }
        }

        private void metroButtonLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                var _JwtSecurityToken = new JwtSecurityTokenHandler().ReadJwtToken(metroTextBoxToken.Text.ToString()) as JwtSecurityToken;
                var ClaimList = _JwtSecurityToken.Claims.Select(x => new
                {
                    Name = x.Type,
                    Value = x.Value
                });
                metroTextBoxHashingAlgorithm.Text = _JwtSecurityToken.SignatureAlgorithm;
                metroTextBoxClaims.Text = JsonConvert.SerializeObject(ClaimList, Formatting.Indented);
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
    }
}
