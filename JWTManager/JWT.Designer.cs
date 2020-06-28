using System.Windows.Forms;

namespace JWTManager
{
    partial class JWT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JWT));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroButtonOk = new MetroFramework.Controls.MetroButton();
            this.metroButtonCopy = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxToken = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackgroundImage = global::JWTManager.Properties.Resources.info_4_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 105);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroButtonOk
            // 
            this.metroButtonOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButtonOk.Location = new System.Drawing.Point(185, 84);
            this.metroButtonOk.Name = "metroButtonOk";
            this.metroButtonOk.Size = new System.Drawing.Size(75, 23);
            this.metroButtonOk.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButtonOk.TabIndex = 2;
            this.metroButtonOk.Text = "OK";
            this.metroButtonOk.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonOk.UseSelectable = true;
            this.metroButtonOk.Click += new System.EventHandler(this.metroButtonOk_Click);
            // 
            // metroButtonCopy
            // 
            this.metroButtonCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButtonCopy.Location = new System.Drawing.Point(436, 84);
            this.metroButtonCopy.Name = "metroButtonCopy";
            this.metroButtonCopy.Size = new System.Drawing.Size(75, 23);
            this.metroButtonCopy.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButtonCopy.TabIndex = 3;
            this.metroButtonCopy.Text = "Copy";
            this.metroButtonCopy.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonCopy.UseSelectable = true;
            this.metroButtonCopy.Click += new System.EventHandler(this.metroButtonCopy_Click);
            // 
            // metroTextBoxToken
            // 
            // 
            // 
            // 
            this.metroTextBoxToken.CustomButton.Image = null;
            this.metroTextBoxToken.CustomButton.Location = new System.Drawing.Point(264, 1);
            this.metroTextBoxToken.CustomButton.Name = "";
            this.metroTextBoxToken.CustomButton.Size = new System.Drawing.Size(61, 61);
            this.metroTextBoxToken.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxToken.CustomButton.TabIndex = 1;
            this.metroTextBoxToken.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxToken.CustomButton.UseSelectable = true;
            this.metroTextBoxToken.CustomButton.Visible = false;
            this.metroTextBoxToken.Lines = new string[0];
            this.metroTextBoxToken.Location = new System.Drawing.Point(185, 3);
            this.metroTextBoxToken.MaxLength = 32767;
            this.metroTextBoxToken.Multiline = true;
            this.metroTextBoxToken.Name = "metroTextBoxToken";
            this.metroTextBoxToken.PasswordChar = '\0';
            this.metroTextBoxToken.ReadOnly = true;
            this.metroTextBoxToken.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxToken.SelectedText = "";
            this.metroTextBoxToken.SelectionLength = 0;
            this.metroTextBoxToken.SelectionStart = 0;
            this.metroTextBoxToken.ShortcutsEnabled = true;
            this.metroTextBoxToken.Size = new System.Drawing.Size(326, 63);
            this.metroTextBoxToken.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBoxToken.TabIndex = 4;
            this.metroTextBoxToken.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxToken.UseSelectable = true;
            this.metroTextBoxToken.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxToken.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Controls.Add(this.metroTextBoxToken);
            this.metroPanel1.Controls.Add(this.metroButtonCopy);
            this.metroPanel1.Controls.Add(this.metroButtonOk);
            this.metroPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(514, 111);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // JWT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 197);
            this.Controls.Add(this.metroPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JWT";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "JSON Web Token";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JWT_FormClosing);
            this.Load += new System.EventHandler(this.JWT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton metroButtonOk;
        private MetroFramework.Controls.MetroButton metroButtonCopy;
        private MetroFramework.Controls.MetroTextBox metroTextBoxToken;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}