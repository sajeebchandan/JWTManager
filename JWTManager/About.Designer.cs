namespace JWTManager
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.buttonOk = new System.Windows.Forms.Button();
            this.linkLabelAppName = new System.Windows.Forms.LinkLabel();
            this.linkLabelSajeebChandanSaha = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.buttonFiverr = new System.Windows.Forms.Button();
            this.buttonLinkedin = new System.Windows.Forms.Button();
            this.buttonGithub = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.buttonOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.FlatAppearance.BorderSize = 0;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.ForeColor = System.Drawing.Color.Transparent;
            this.buttonOk.Location = new System.Drawing.Point(3, 242);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(333, 21);
            this.buttonOk.TabIndex = 20;
            this.buttonOk.Text = "OK";
            this.buttonOk.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonOk.UseVisualStyleBackColor = false;
            // 
            // linkLabelAppName
            // 
            this.linkLabelAppName.ActiveLinkColor = System.Drawing.Color.Lime;
            this.linkLabelAppName.AutoSize = true;
            this.linkLabelAppName.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelAppName.DisabledLinkColor = System.Drawing.Color.Teal;
            this.linkLabelAppName.LinkColor = System.Drawing.Color.Aquamarine;
            this.linkLabelAppName.Location = new System.Drawing.Point(9, 159);
            this.linkLabelAppName.Name = "linkLabelAppName";
            this.linkLabelAppName.Size = new System.Drawing.Size(75, 13);
            this.linkLabelAppName.TabIndex = 18;
            this.linkLabelAppName.TabStop = true;
            this.linkLabelAppName.Text = "JWT Manager";
            this.linkLabelAppName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAppName_LinkClicked);
            // 
            // linkLabelSajeebChandanSaha
            // 
            this.linkLabelSajeebChandanSaha.ActiveLinkColor = System.Drawing.Color.Lime;
            this.linkLabelSajeebChandanSaha.AutoSize = true;
            this.linkLabelSajeebChandanSaha.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelSajeebChandanSaha.DisabledLinkColor = System.Drawing.Color.Teal;
            this.linkLabelSajeebChandanSaha.LinkColor = System.Drawing.Color.Aquamarine;
            this.linkLabelSajeebChandanSaha.Location = new System.Drawing.Point(128, 107);
            this.linkLabelSajeebChandanSaha.Name = "linkLabelSajeebChandanSaha";
            this.linkLabelSajeebChandanSaha.Size = new System.Drawing.Size(114, 13);
            this.linkLabelSajeebChandanSaha.TabIndex = 17;
            this.linkLabelSajeebChandanSaha.TabStop = true;
            this.linkLabelSajeebChandanSaha.Text = "Sajeeb Chandan Saha";
            this.linkLabelSajeebChandanSaha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSajeebChandanSaha_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(4, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 129);
            this.label1.TabIndex = 16;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.labelVersion.Location = new System.Drawing.Point(83, 84);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(169, 18);
            this.labelVersion.TabIndex = 15;
            this.labelVersion.Text = "JWT Manager 1.0.0.0";
            // 
            // buttonFiverr
            // 
            this.buttonFiverr.BackColor = System.Drawing.Color.Transparent;
            this.buttonFiverr.BackgroundImage = global::JWTManager.Properties.Resources.fiverr;
            this.buttonFiverr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFiverr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFiverr.FlatAppearance.BorderSize = 0;
            this.buttonFiverr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonFiverr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonFiverr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFiverr.ForeColor = System.Drawing.Color.Transparent;
            this.buttonFiverr.Location = new System.Drawing.Point(276, 216);
            this.buttonFiverr.Name = "buttonFiverr";
            this.buttonFiverr.Size = new System.Drawing.Size(15, 15);
            this.buttonFiverr.TabIndex = 23;
            this.buttonFiverr.TabStop = false;
            this.buttonFiverr.UseVisualStyleBackColor = false;
            this.buttonFiverr.Click += new System.EventHandler(this.buttonFiverr_Click);
            // 
            // buttonLinkedin
            // 
            this.buttonLinkedin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLinkedin.BackgroundImage = global::JWTManager.Properties.Resources.linkedin;
            this.buttonLinkedin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLinkedin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLinkedin.FlatAppearance.BorderSize = 0;
            this.buttonLinkedin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLinkedin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLinkedin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLinkedin.ForeColor = System.Drawing.Color.Transparent;
            this.buttonLinkedin.Location = new System.Drawing.Point(297, 216);
            this.buttonLinkedin.Name = "buttonLinkedin";
            this.buttonLinkedin.Size = new System.Drawing.Size(15, 15);
            this.buttonLinkedin.TabIndex = 22;
            this.buttonLinkedin.TabStop = false;
            this.buttonLinkedin.UseVisualStyleBackColor = false;
            this.buttonLinkedin.Click += new System.EventHandler(this.buttonLinkedin_Click);
            // 
            // buttonGithub
            // 
            this.buttonGithub.BackColor = System.Drawing.Color.Transparent;
            this.buttonGithub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGithub.BackgroundImage")));
            this.buttonGithub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGithub.FlatAppearance.BorderSize = 0;
            this.buttonGithub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonGithub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonGithub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGithub.ForeColor = System.Drawing.Color.Transparent;
            this.buttonGithub.Location = new System.Drawing.Point(318, 216);
            this.buttonGithub.Name = "buttonGithub";
            this.buttonGithub.Size = new System.Drawing.Size(15, 15);
            this.buttonGithub.TabIndex = 21;
            this.buttonGithub.TabStop = false;
            this.buttonGithub.UseVisualStyleBackColor = false;
            this.buttonGithub.Click += new System.EventHandler(this.buttonGithub_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::JWTManager.Properties.Resources.JWT_Manager;
            this.pictureBox1.Location = new System.Drawing.Point(131, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 266);
            this.Controls.Add(this.buttonFiverr);
            this.Controls.Add(this.buttonLinkedin);
            this.Controls.Add(this.buttonGithub);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.linkLabelAppName);
            this.Controls.Add(this.linkLabelSajeebChandanSaha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "AboutForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFiverr;
        private System.Windows.Forms.Button buttonLinkedin;
        private System.Windows.Forms.Button buttonGithub;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.LinkLabel linkLabelAppName;
        private System.Windows.Forms.LinkLabel linkLabelSajeebChandanSaha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}