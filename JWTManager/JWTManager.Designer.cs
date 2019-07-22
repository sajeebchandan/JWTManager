namespace JWTManager
{
    partial class JWTManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JWTManager));
            this.metroTileGenerateJWT = new MetroFramework.Controls.MetroTile();
            this.metroTileValidateJWT = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTileGenerateJWT
            // 
            this.metroTileGenerateJWT.ActiveControl = null;
            this.metroTileGenerateJWT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileGenerateJWT.Location = new System.Drawing.Point(23, 139);
            this.metroTileGenerateJWT.Name = "metroTileGenerateJWT";
            this.metroTileGenerateJWT.Size = new System.Drawing.Size(131, 86);
            this.metroTileGenerateJWT.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileGenerateJWT.TabIndex = 0;
            this.metroTileGenerateJWT.Text = "Generate JWT";
            this.metroTileGenerateJWT.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileGenerateJWT.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileGenerateJWT.UseSelectable = true;
            this.metroTileGenerateJWT.Click += new System.EventHandler(this.metroTileGenerateJWT_Click);
            // 
            // metroTileValidateJWT
            // 
            this.metroTileValidateJWT.ActiveControl = null;
            this.metroTileValidateJWT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileValidateJWT.Location = new System.Drawing.Point(196, 139);
            this.metroTileValidateJWT.Name = "metroTileValidateJWT";
            this.metroTileValidateJWT.Size = new System.Drawing.Size(131, 86);
            this.metroTileValidateJWT.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileValidateJWT.TabIndex = 1;
            this.metroTileValidateJWT.Text = "Validate JWT";
            this.metroTileValidateJWT.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileValidateJWT.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTileValidateJWT.UseSelectable = true;
            this.metroTileValidateJWT.Click += new System.EventHandler(this.metroTileValidateJWT_Click);
            // 
            // JWTManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.metroTileValidateJWT);
            this.Controls.Add(this.metroTileGenerateJWT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "JWTManager";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "JWT Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JWTManager_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileGenerateJWT;
        private MetroFramework.Controls.MetroTile metroTileValidateJWT;
    }
}