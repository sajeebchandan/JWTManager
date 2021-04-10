using System.Windows.Forms;

namespace JWTManager
{
    partial class ValidateJWT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValidateJWT));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxClaims = new MetroFramework.Controls.MetroTextBox();
            this.metroCheckBoxUseDefault = new MetroFramework.Controls.MetroCheckBox();
            this.metroTextBoxEncryptionKey = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelEncryptionKey = new MetroFramework.Controls.MetroLabel();
            this.metroButtonLoadData = new MetroFramework.Controls.MetroButton();
            this.metroButtonValidateJwt = new MetroFramework.Controls.MetroButton();
            this.metroLabelHashingAlgorithm = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxToken = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelToken = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxHashingAlgorithm = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroComboBoxHashingAlgorithm);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroTextBoxClaims);
            this.metroPanel1.Controls.Add(this.metroCheckBoxUseDefault);
            this.metroPanel1.Controls.Add(this.metroTextBoxEncryptionKey);
            this.metroPanel1.Controls.Add(this.metroLabelEncryptionKey);
            this.metroPanel1.Controls.Add(this.metroButtonLoadData);
            this.metroPanel1.Controls.Add(this.metroButtonValidateJwt);
            this.metroPanel1.Controls.Add(this.metroLabelHashingAlgorithm);
            this.metroPanel1.Controls.Add(this.metroTextBoxToken);
            this.metroPanel1.Controls.Add(this.metroLabelToken);
            this.metroPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(754, 364);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(105, 225);
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
            this.metroTextBoxClaims.CustomButton.Location = new System.Drawing.Point(283, 1);
            this.metroTextBoxClaims.CustomButton.Name = "";
            this.metroTextBoxClaims.CustomButton.Size = new System.Drawing.Size(121, 121);
            this.metroTextBoxClaims.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxClaims.CustomButton.TabIndex = 1;
            this.metroTextBoxClaims.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxClaims.CustomButton.UseSelectable = true;
            this.metroTextBoxClaims.CustomButton.Visible = false;
            this.metroTextBoxClaims.Lines = new string[0];
            this.metroTextBoxClaims.Location = new System.Drawing.Point(240, 172);
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
            this.metroTextBoxClaims.Size = new System.Drawing.Size(405, 123);
            this.metroTextBoxClaims.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxClaims.TabIndex = 5;
            this.metroTextBoxClaims.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxClaims.UseSelectable = true;
            this.metroTextBoxClaims.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxClaims.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // metroButtonLoadData
            // 
            this.metroButtonLoadData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButtonLoadData.Location = new System.Drawing.Point(240, 310);
            this.metroButtonLoadData.Name = "metroButtonLoadData";
            this.metroButtonLoadData.Size = new System.Drawing.Size(136, 37);
            this.metroButtonLoadData.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButtonLoadData.TabIndex = 6;
            this.metroButtonLoadData.Text = "Load Data";
            this.metroButtonLoadData.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonLoadData.UseSelectable = true;
            this.metroButtonLoadData.Click += new System.EventHandler(this.metroButtonLoadData_Click);
            // 
            // metroButtonValidateJwt
            // 
            this.metroButtonValidateJwt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButtonValidateJwt.Location = new System.Drawing.Point(509, 310);
            this.metroButtonValidateJwt.Name = "metroButtonValidateJwt";
            this.metroButtonValidateJwt.Size = new System.Drawing.Size(136, 37);
            this.metroButtonValidateJwt.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButtonValidateJwt.TabIndex = 7;
            this.metroButtonValidateJwt.Text = "Validate JWT";
            this.metroButtonValidateJwt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonValidateJwt.UseSelectable = true;
            this.metroButtonValidateJwt.Click += new System.EventHandler(this.metroButtonValidateJwt_Click);
            // 
            // metroLabelHashingAlgorithm
            // 
            this.metroLabelHashingAlgorithm.AutoSize = true;
            this.metroLabelHashingAlgorithm.Location = new System.Drawing.Point(105, 133);
            this.metroLabelHashingAlgorithm.Name = "metroLabelHashingAlgorithm";
            this.metroLabelHashingAlgorithm.Size = new System.Drawing.Size(118, 19);
            this.metroLabelHashingAlgorithm.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabelHashingAlgorithm.TabIndex = 0;
            this.metroLabelHashingAlgorithm.Text = "Hashing Algorithm";
            this.metroLabelHashingAlgorithm.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxToken
            // 
            // 
            // 
            // 
            this.metroTextBoxToken.CustomButton.Image = null;
            this.metroTextBoxToken.CustomButton.Location = new System.Drawing.Point(383, 1);
            this.metroTextBoxToken.CustomButton.Name = "";
            this.metroTextBoxToken.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxToken.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxToken.CustomButton.TabIndex = 1;
            this.metroTextBoxToken.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxToken.CustomButton.UseSelectable = true;
            this.metroTextBoxToken.CustomButton.Visible = false;
            this.metroTextBoxToken.Lines = new string[0];
            this.metroTextBoxToken.Location = new System.Drawing.Point(240, 87);
            this.metroTextBoxToken.MaxLength = 32767;
            this.metroTextBoxToken.Name = "metroTextBoxToken";
            this.metroTextBoxToken.PasswordChar = '\0';
            this.metroTextBoxToken.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxToken.SelectedText = "";
            this.metroTextBoxToken.SelectionLength = 0;
            this.metroTextBoxToken.SelectionStart = 0;
            this.metroTextBoxToken.ShortcutsEnabled = true;
            this.metroTextBoxToken.Size = new System.Drawing.Size(405, 23);
            this.metroTextBoxToken.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxToken.TabIndex = 3;
            this.metroTextBoxToken.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxToken.UseSelectable = true;
            this.metroTextBoxToken.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxToken.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelToken
            // 
            this.metroLabelToken.AutoSize = true;
            this.metroLabelToken.Location = new System.Drawing.Point(105, 87);
            this.metroLabelToken.Name = "metroLabelToken";
            this.metroLabelToken.Size = new System.Drawing.Size(42, 19);
            this.metroLabelToken.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabelToken.TabIndex = 0;
            this.metroLabelToken.Text = "Token";
            this.metroLabelToken.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroComboBoxHashingAlgorithm
            // 
            this.metroComboBoxHashingAlgorithm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroComboBoxHashingAlgorithm.FormattingEnabled = true;
            this.metroComboBoxHashingAlgorithm.ItemHeight = 23;
            this.metroComboBoxHashingAlgorithm.Location = new System.Drawing.Point(240, 123);
            this.metroComboBoxHashingAlgorithm.Name = "metroComboBoxHashingAlgorithm";
            this.metroComboBoxHashingAlgorithm.Size = new System.Drawing.Size(405, 29);
            this.metroComboBoxHashingAlgorithm.Style = MetroFramework.MetroColorStyle.Green;
            this.metroComboBoxHashingAlgorithm.TabIndex = 8;
            this.metroComboBoxHashingAlgorithm.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBoxHashingAlgorithm.UseSelectable = true;
            // 
            // ValidateJWT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.metroPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ValidateJWT";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Validate JWT";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ValidateJWT_FormClosing);
            this.Load += new System.EventHandler(this.ValidateJWT_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton metroButtonValidateJwt;
        private MetroFramework.Controls.MetroLabel metroLabelHashingAlgorithm;
        private MetroFramework.Controls.MetroTextBox metroTextBoxToken;
        private MetroFramework.Controls.MetroLabel metroLabelToken;
        private MetroFramework.Controls.MetroButton metroButtonLoadData;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxUseDefault;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEncryptionKey;
        private MetroFramework.Controls.MetroLabel metroLabelEncryptionKey;
        private MetroFramework.Controls.MetroTextBox metroTextBoxClaims;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox metroComboBoxHashingAlgorithm;
    }
}