
namespace aracproje
{
    partial class sifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sifremiUnuttum));
            this.mailTxtbx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.gndrBtn = new MetroFramework.Controls.MetroButton();
            this.mesajLbl = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mailTxtbx
            // 
            // 
            // 
            // 
            this.mailTxtbx.CustomButton.Image = null;
            this.mailTxtbx.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.mailTxtbx.CustomButton.Name = "";
            this.mailTxtbx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mailTxtbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mailTxtbx.CustomButton.TabIndex = 1;
            this.mailTxtbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mailTxtbx.CustomButton.UseSelectable = true;
            this.mailTxtbx.CustomButton.Visible = false;
            this.mailTxtbx.Lines = new string[0];
            this.mailTxtbx.Location = new System.Drawing.Point(236, 129);
            this.mailTxtbx.MaxLength = 32767;
            this.mailTxtbx.Name = "mailTxtbx";
            this.mailTxtbx.PasswordChar = '\0';
            this.mailTxtbx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mailTxtbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mailTxtbx.SelectedText = "";
            this.mailTxtbx.SelectionLength = 0;
            this.mailTxtbx.SelectionStart = 0;
            this.mailTxtbx.ShortcutsEnabled = true;
            this.mailTxtbx.Size = new System.Drawing.Size(196, 23);
            this.mailTxtbx.TabIndex = 0;
            this.mailTxtbx.UseSelectable = true;
            this.mailTxtbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mailTxtbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(96, 127);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "E-Mail :";
            // 
            // gndrBtn
            // 
            this.gndrBtn.BackColor = System.Drawing.Color.Thistle;
            this.gndrBtn.Location = new System.Drawing.Point(488, 129);
            this.gndrBtn.Name = "gndrBtn";
            this.gndrBtn.Size = new System.Drawing.Size(129, 23);
            this.gndrBtn.TabIndex = 2;
            this.gndrBtn.Text = "Gönder";
            this.gndrBtn.UseSelectable = true;
            this.gndrBtn.Click += new System.EventHandler(this.gndrBtn_Click);
            // 
            // mesajLbl
            // 
            this.mesajLbl.AutoSize = true;
            this.mesajLbl.BackColor = System.Drawing.Color.SlateBlue;
            this.mesajLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mesajLbl.Location = new System.Drawing.Point(187, 75);
            this.mesajLbl.Name = "mesajLbl";
            this.mesajLbl.Size = new System.Drawing.Size(294, 19);
            this.mesajLbl.TabIndex = 3;
            this.mesajLbl.Text = "Şifrenizi göndermemiz için bir mail adresi giriniz.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.mesajLbl);
            this.panel1.Controls.Add(this.gndrBtn);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.mailTxtbx);
            this.panel1.Location = new System.Drawing.Point(88, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 279);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(904, 543);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sifremiUnuttum";
            this.Text = "sifremiUnuttum";
            this.Load += new System.EventHandler(this.sifremiUnuttum_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox mailTxtbx;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton gndrBtn;
        private MetroFramework.Controls.MetroLabel mesajLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}