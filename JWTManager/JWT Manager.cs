using JWT;
using JWT.Algorithms;
using JWT.Builder;
using JWT.Serializers;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
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
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void JWTManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            //try
            //{
            //    DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //    if (result == DialogResult.Yes)
            //    {
            //        System.Environment.Exit(0);
            //    }
            //    else if (result == DialogResult.No)
            //    {
            //        e.Cancel = true;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void metroTileGenerateQuickJWT_Click(object sender, EventArgs e)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("KwkQ37eYtFJ94mpsuoWuyVph5vLpDmeX9FYFsSLqsUTzMvyeW2dZcN7PW2eQKJzQEDJ9JDL3LpKki9eDtDkDDHgiyroMNb7zcfysdXat"));
            var secToken = new JwtSecurityToken(
            signingCredentials: new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256),
            issuer: "JWT Manager (https://github.com/sajeebchandan/JWTManager)",
            audience: "JWT Manager (https://github.com/sajeebchandan/JWTManager)",

            expires: DateTime.UtcNow.AddDays(30));
            var handler = new JwtSecurityTokenHandler();

            JWT _JWT = new JWT(handler.WriteToken(secToken));
            _JWT.ShowDialog();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            using (AboutForm about = new AboutForm())
            {
                about.StartPosition = FormStartPosition.CenterParent;
                DialogResult dr = about.ShowDialog();
            }
        }
    }
}
