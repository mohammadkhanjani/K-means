namespace k_means
{
    partial class back
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(back));
            this.office2007BlackTheme1 = new Telerik.WinControls.Themes.Office2007BlackTheme();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.glassButton3 = new Glass.GlassButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // glassButton3
            // 
            this.glassButton3.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.glassButton3.GlowColor = System.Drawing.Color.Lime;
            this.glassButton3.Location = new System.Drawing.Point(169, 241);
            this.glassButton3.Name = "glassButton3";
            this.glassButton3.OuterBorderColor = System.Drawing.Color.Black;
            this.glassButton3.Size = new System.Drawing.Size(121, 35);
            this.glassButton3.TabIndex = 32;
            this.glassButton3.Text = "برگشت";
            this.glassButton3.Click += new System.EventHandler(this.glassButton3_Click);
            // 
            // back
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(449, 286);
            this.Controls.Add(this.glassButton3);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "back";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "back";
            this.ThemeName = "Office2007Black";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Office2007BlackTheme office2007BlackTheme1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Glass.GlassButton glassButton3;
    }
}
