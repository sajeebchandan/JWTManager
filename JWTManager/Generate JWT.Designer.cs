using System.Windows.Forms;

namespace JWTManager
{
    partial class GenerateJWT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateJWT));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxClaims = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxExpireAfter = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBoxUseDefault = new MetroFramework.Controls.MetroCheckBox();
            this.metroButtonGenerateJey = new MetroFramework.Controls.MetroButton();
            this.metroButtonAddClaim = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxClaimValue = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxClaimName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelClaims = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxHashingAlgorithm = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelHashingAlgorithm = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxEncryptionKey = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelEncryptionKey = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroTextBoxClaims);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroTextBoxExpireAfter);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroCheckBoxUseDefault);
            this.metroPanel1.Controls.Add(this.metroButtonGenerateJey);
            this.metroPanel1.Controls.Add(this.metroButtonAddClaim);
            this.metroPanel1.Controls.Add(this.metroTextBoxClaimValue);
            this.metroPanel1.Controls.Add(this.metroTextBoxClaimName);
            this.metroPanel1.Controls.Add(this.metroLabelClaims);
            this.metroPanel1.Controls.Add(this.metroComboBoxHashingAlgorithm);
            this.metroPanel1.Controls.Add(this.metroLabelHashingAlgorithm);
            this.metroPanel1.Controls.Add(this.metroTextBoxEncryptionKey);
            this.metroPanel1.Controls.Add(this.metroLabelEncryptionKey);
            this.metroPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(754, 405);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(105, 270);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(93, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Claims (JSON)";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxClaims
            // 
            // 
            // 
            // 
            this.metroTextBoxClaims.CustomButton.Image = null;
            this.metroTextBoxClaims.CustomButton.Location = new System.Drawing.Point(297, 1);
            this.metroTextBoxClaims.CustomButton.Name = "";
            this.metroTextBoxClaims.CustomButton.Size = new System.Drawing.Size(107, 107);
            this.metroTextBoxClaims.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxClaims.CustomButton.TabIndex = 1;
            this.metroTextBoxClaims.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxClaims.CustomButton.UseSelectable = true;
            this.metroTextBoxClaims.CustomButton.Visible = false;
            this.metroTextBoxClaims.Lines = new string[0];
            this.metroTextBoxClaims.Location = new System.Drawing.Point(240, 228);
            this.metroTextBoxClaims.MaxLength = 32767;
            this.metroTextBoxClaims.Multiline = true;
            this.metroTextBoxClaims.Name = "metroTextBoxClaims";
            this.metroTextBoxClaims.PasswordChar = '\0';
            this.metroTextBoxClaims.ReadOnly = true;
            this.metroTextBoxClaims.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.metroTextBoxClaims.SelectedText = "";
            this.metroTextBoxClaims.SelectionLength = 0;
            this.metroTextBoxClaims.SelectionStart = 0;
            this.metroTextBoxClaims.ShortcutsEnabled = true;
            this.metroTextBoxClaims.Size = new System.Drawing.Size(405, 109);
            this.metroTextBoxClaims.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxClaims.TabIndex = 8;
            this.metroTextBoxClaims.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxClaims.UseSelectable = true;
            this.metroTextBoxClaims.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxClaims.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(579, 184);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Minute (s)";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxExpireAfter
            // 
            // 
            // 
            // 
            this.metroTextBoxExpireAfter.CustomButton.Image = null;
            this.metroTextBoxExpireAfter.CustomButton.Location = new System.Drawing.Point(294, 1);
            this.metroTextBoxExpireAfter.CustomButton.Name = "";
            this.metroTextBoxExpireAfter.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxExpireAfter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxExpireAfter.CustomButton.TabIndex = 1;
            this.metroTextBoxExpireAfter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxExpireAfter.CustomButton.UseSelectable = true;
            this.metroTextBoxExpireAfter.CustomButton.Visible = false;
            this.metroTextBoxExpireAfter.Lines = new string[0];
            this.metroTextBoxExpireAfter.Location = new System.Drawing.Point(240, 184);
            this.metroTextBoxExpireAfter.MaxLength = 32767;
            this.metroTextBoxExpireAfter.Name = "metroTextBoxExpireAfter";
            this.metroTextBoxExpireAfter.PasswordChar = '\0';
            this.metroTextBoxExpireAfter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxExpireAfter.SelectedText = "";
            this.metroTextBoxExpireAfter.SelectionLength = 0;
            this.metroTextBoxExpireAfter.SelectionStart = 0;
            this.metroTextBoxExpireAfter.ShortcutsEnabled = true;
            this.metroTextBoxExpireAfter.Size = new System.Drawing.Size(316, 23);
            this.metroTextBoxExpireAfter.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxExpireAfter.TabIndex = 7;
            this.metroTextBoxExpireAfter.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxExpireAfter.UseSelectable = true;
            this.metroTextBoxExpireAfter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxExpireAfter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxExpireAfter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox1_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(105, 184);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Expire After";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroCheckBoxUseDefault
            // 
            this.metroCheckBoxUseDefault.AutoSize = true;
            this.metroCheckBoxUseDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroCheckBoxUseDefault.Location = new System.Drawing.Point(562, 47);
            this.metroCheckBoxUseDefault.Name = "metroCheckBoxUseDefault";
            this.metroCheckBoxUseDefault.Size = new System.Drawing.Size(83, 15);
            this.metroCheckBoxUseDefault.Style = MetroFramework.MetroColorStyle.Green;
            this.metroCheckBoxUseDefault.TabIndex = 2;
            this.metroCheckBoxUseDefault.Text = "Use Default";
            this.metroCheckBoxUseDefault.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBoxUseDefault.UseSelectable = true;
            this.metroCheckBoxUseDefault.CheckedChanged += new System.EventHandler(this.metroCheckBoxUseDefault_CheckedChanged);
            // 
            // metroButtonGenerateJey
            // 
            this.metroButtonGenerateJey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButtonGenerateJey.Location = new System.Drawing.Point(509, 351);
            this.metroButtonGenerateJey.Name = "metroButtonGenerateJey";
            this.metroButtonGenerateJey.Size = new System.Drawing.Size(136, 37);
            this.metroButtonGenerateJey.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButtonGenerateJey.TabIndex = 9;
            this.metroButtonGenerateJey.Text = "Generate JWT";
            this.metroButtonGenerateJey.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonGenerateJey.UseSelectable = true;
            this.metroButtonGenerateJey.Click += new System.EventHandler(this.metroButtonGenerateJey_Click);
            // 
            // metroButtonAddClaim
            // 
            this.metroButtonAddClaim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButtonAddClaim.Location = new System.Drawing.Point(570, 141);
            this.metroButtonAddClaim.Name = "metroButtonAddClaim";
            this.metroButtonAddClaim.Size = new System.Drawing.Size(75, 23);
            this.metroButtonAddClaim.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButtonAddClaim.TabIndex = 6;
            this.metroButtonAddClaim.Text = "Add Claim";
            this.metroButtonAddClaim.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonAddClaim.UseSelectable = true;
            this.metroButtonAddClaim.Click += new System.EventHandler(this.metroButtonAddClaim_Click);
            // 
            // metroTextBoxClaimValue
            // 
            // 
            // 
            // 
            this.metroTextBoxClaimValue.CustomButton.Image = null;
            this.metroTextBoxClaimValue.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.metroTextBoxClaimValue.CustomButton.Name = "";
            this.metroTextBoxClaimValue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxClaimValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxClaimValue.CustomButton.TabIndex = 1;
            this.metroTextBoxClaimValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxClaimValue.CustomButton.UseSelectable = true;
            this.metroTextBoxClaimValue.CustomButton.Visible = false;
            this.metroTextBoxClaimValue.Lines = new string[0];
            this.metroTextBoxClaimValue.Location = new System.Drawing.Point(406, 140);
            this.metroTextBoxClaimValue.MaxLength = 32767;
            this.metroTextBoxClaimValue.Name = "metroTextBoxClaimValue";
            this.metroTextBoxClaimValue.PasswordChar = '\0';
            this.metroTextBoxClaimValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxClaimValue.SelectedText = "";
            this.metroTextBoxClaimValue.SelectionLength = 0;
            this.metroTextBoxClaimValue.SelectionStart = 0;
            this.metroTextBoxClaimValue.ShortcutsEnabled = true;
            this.metroTextBoxClaimValue.Size = new System.Drawing.Size(147, 23);
            this.metroTextBoxClaimValue.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxClaimValue.TabIndex = 5;
            this.metroTextBoxClaimValue.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxClaimValue.UseSelectable = true;
            this.metroTextBoxClaimValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxClaimValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxClaimName
            // 
            // 
            // 
            // 
            this.metroTextBoxClaimName.CustomButton.Image = null;
            this.metroTextBoxClaimName.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.metroTextBoxClaimName.CustomButton.Name = "";
            this.metroTextBoxClaimName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxClaimName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxClaimName.CustomButton.TabIndex = 1;
            this.metroTextBoxClaimName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxClaimName.CustomButton.UseSelectable = true;
            this.metroTextBoxClaimName.CustomButton.Visible = false;
            this.metroTextBoxClaimName.Lines = new string[0];
            this.metroTextBoxClaimName.Location = new System.Drawing.Point(240, 140);
            this.metroTextBoxClaimName.MaxLength = 32767;
            this.metroTextBoxClaimName.Name = "metroTextBoxClaimName";
            this.metroTextBoxClaimName.PasswordChar = '\0';
            this.metroTextBoxClaimName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxClaimName.SelectedText = "";
            this.metroTextBoxClaimName.SelectionLength = 0;
            this.metroTextBoxClaimName.SelectionStart = 0;
            this.metroTextBoxClaimName.ShortcutsEnabled = true;
            this.metroTextBoxClaimName.Size = new System.Drawing.Size(147, 23);
            this.metroTextBoxClaimName.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxClaimName.TabIndex = 4;
            this.metroTextBoxClaimName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxClaimName.UseSelectable = true;
            this.metroTextBoxClaimName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxClaimName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelClaims
            // 
            this.metroLabelClaims.AutoSize = true;
            this.metroLabelClaims.Location = new System.Drawing.Point(105, 140);
            this.metroLabelClaims.Name = "metroLabelClaims";
            this.metroLabelClaims.Size = new System.Drawing.Size(48, 19);
            this.metroLabelClaims.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabelClaims.TabIndex = 0;
            this.metroLabelClaims.Text = "Claims";
            this.metroLabelClaims.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroComboBoxHashingAlgorithm
            // 
            this.metroComboBoxHashingAlgorithm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroComboBoxHashingAlgorithm.FormattingEnabled = true;
            this.metroComboBoxHashingAlgorithm.ItemHeight = 23;
            this.metroComboBoxHashingAlgorithm.Location = new System.Drawing.Point(240, 89);
            this.metroComboBoxHashingAlgorithm.Name = "metroComboBoxHashingAlgorithm";
            this.metroComboBoxHashingAlgorithm.Size = new System.Drawing.Size(405, 29);
            this.metroComboBoxHashingAlgorithm.Style = MetroFramework.MetroColorStyle.Green;
            this.metroComboBoxHashingAlgorithm.TabIndex = 3;
            this.metroComboBoxHashingAlgorithm.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBoxHashingAlgorithm.UseSelectable = true;
            // 
            // metroLabelHashingAlgorithm
            // 
            this.metroLabelHashingAlgorithm.AutoSize = true;
            this.metroLabelHashingAlgorithm.Location = new System.Drawing.Point(105, 89);
            this.metroLabelHashingAlgorithm.Name = "metroLabelHashingAlgorithm";
            this.metroLabelHashingAlgorithm.Size = new System.Drawing.Size(118, 19);
            this.metroLabelHashingAlgorithm.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabelHashingAlgorithm.TabIndex = 0;
            this.metroLabelHashingAlgorithm.Text = "Hashing Algorithm";
            this.metroLabelHashingAlgorithm.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxEncryptionKey
            // 
            // 
            // 
            // 
            this.metroTextBoxEncryptionKey.CustomButton.Image = null;
            this.metroTextBoxEncryptionKey.CustomButton.Location = new System.Drawing.Point(294, 1);
            this.metroTextBoxEncryptionKey.CustomButton.Name = "";
            this.metroTextBoxEncryptionKey.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxEncryptionKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxEncryptionKey.CustomButton.TabIndex = 1;
            this.metroTextBoxEncryptionKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxEncryptionKey.CustomButton.UseSelectable = true;
            this.metroTextBoxEncryptionKey.CustomButton.Visible = false;
            this.metroTextBoxEncryptionKey.Lines = new string[0];
            this.metroTextBoxEncryptionKey.Location = new System.Drawing.Point(240, 43);
            this.metroTextBoxEncryptionKey.MaxLength = 32767;
            this.metroTextBoxEncryptionKey.Name = "metroTextBoxEncryptionKey";
            this.metroTextBoxEncryptionKey.PasswordChar = '\0';
            this.metroTextBoxEncryptionKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxEncryptionKey.SelectedText = "";
            this.metroTextBoxEncryptionKey.SelectionLength = 0;
            this.metroTextBoxEncryptionKey.SelectionStart = 0;
            this.metroTextBoxEncryptionKey.ShortcutsEnabled = true;
            this.metroTextBoxEncryptionKey.Size = new System.Drawing.Size(316, 23);
            this.metroTextBoxEncryptionKey.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxEncryptionKey.TabIndex = 1;
            this.metroTextBoxEncryptionKey.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxEncryptionKey.UseSelectable = true;
            this.metroTextBoxEncryptionKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxEncryptionKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelEncryptionKey
            // 
            this.metroLabelEncryptionKey.AutoSize = true;
            this.metroLabelEncryptionKey.Location = new System.Drawing.Point(105, 43);
            this.metroLabelEncryptionKey.Name = "metroLabelEncryptionKey";
            this.metroLabelEncryptionKey.Size = new System.Drawing.Size(95, 19);
            this.metroLabelEncryptionKey.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabelEncryptionKey.TabIndex = 0;
            this.metroLabelEncryptionKey.Text = "Encryption Key";
            this.metroLabelEncryptionKey.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // GenerateJWT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.metroPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GenerateJWT";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Generate JWT";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GenerateJWT_FormClosing);
            this.Load += new System.EventHandler(this.GenerateJWT_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroComboBox metroComboBoxHashingAlgorithm;
        private MetroFramework.Controls.MetroLabel metroLabelHashingAlgorithm;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEncryptionKey;
        private MetroFramework.Controls.MetroLabel metroLabelEncryptionKey;
        private MetroFramework.Controls.MetroTextBox metroTextBoxClaimValue;
        private MetroFramework.Controls.MetroTextBox metroTextBoxClaimName;
        private MetroFramework.Controls.MetroLabel metroLabelClaims;
        private MetroFramework.Controls.MetroButton metroButtonGenerateJey;
        private MetroFramework.Controls.MetroButton metroButtonAddClaim;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxUseDefault;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxExpireAfter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxClaims;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}