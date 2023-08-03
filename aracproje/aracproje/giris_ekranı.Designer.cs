
namespace aracproje
{
    partial class giris_ekranı
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris_ekranı));
            this.kullaniciad_TXT = new MetroFramework.Controls.MetroTextBox();
            this.sifre_TXT = new MetroFramework.Controls.MetroTextBox();
            this.giris_BTN = new MetroFramework.Controls.MetroButton();
            this.sifremiUnuttum_BTN = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gizle = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.kapatBtn = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapatBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBox1.InitialImage = global::aracproje.Properties.Resources.images;
            pictureBox1.Location = new System.Drawing.Point(52, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(275, 290);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // kullaniciad_TXT
            // 
            // 
            // 
            // 
            this.kullaniciad_TXT.CustomButton.Image = null;
            this.kullaniciad_TXT.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.kullaniciad_TXT.CustomButton.Name = "";
            this.kullaniciad_TXT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.kullaniciad_TXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.kullaniciad_TXT.CustomButton.TabIndex = 1;
            this.kullaniciad_TXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.kullaniciad_TXT.CustomButton.UseSelectable = true;
            this.kullaniciad_TXT.CustomButton.Visible = false;
            this.kullaniciad_TXT.Lines = new string[0];
            this.kullaniciad_TXT.Location = new System.Drawing.Point(157, 78);
            this.kullaniciad_TXT.MaxLength = 32767;
            this.kullaniciad_TXT.Name = "kullaniciad_TXT";
            this.kullaniciad_TXT.PasswordChar = '\0';
            this.kullaniciad_TXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kullaniciad_TXT.SelectedText = "";
            this.kullaniciad_TXT.SelectionLength = 0;
            this.kullaniciad_TXT.SelectionStart = 0;
            this.kullaniciad_TXT.ShortcutsEnabled = true;
            this.kullaniciad_TXT.Size = new System.Drawing.Size(161, 23);
            this.kullaniciad_TXT.TabIndex = 18;
            this.kullaniciad_TXT.UseSelectable = true;
            this.kullaniciad_TXT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.kullaniciad_TXT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.kullaniciad_TXT.Click += new System.EventHandler(this.kullaniciad_TXT_Click);
            // 
            // sifre_TXT
            // 
            // 
            // 
            // 
            this.sifre_TXT.CustomButton.Image = null;
            this.sifre_TXT.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.sifre_TXT.CustomButton.Name = "";
            this.sifre_TXT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.sifre_TXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sifre_TXT.CustomButton.TabIndex = 1;
            this.sifre_TXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sifre_TXT.CustomButton.UseSelectable = true;
            this.sifre_TXT.CustomButton.Visible = false;
            this.sifre_TXT.Lines = new string[0];
            this.sifre_TXT.Location = new System.Drawing.Point(157, 125);
            this.sifre_TXT.MaxLength = 32767;
            this.sifre_TXT.Name = "sifre_TXT";
            this.sifre_TXT.PasswordChar = '*';
            this.sifre_TXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sifre_TXT.SelectedText = "";
            this.sifre_TXT.SelectionLength = 0;
            this.sifre_TXT.SelectionStart = 0;
            this.sifre_TXT.ShortcutsEnabled = true;
            this.sifre_TXT.Size = new System.Drawing.Size(161, 23);
            this.sifre_TXT.TabIndex = 19;
            this.sifre_TXT.UseSelectable = true;
            this.sifre_TXT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sifre_TXT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // giris_BTN
            // 
            this.giris_BTN.BackgroundImage = global::aracproje.Properties.Resources.Yeni_Proje__1_;
            this.giris_BTN.Location = new System.Drawing.Point(157, 175);
            this.giris_BTN.Name = "giris_BTN";
            this.giris_BTN.Size = new System.Drawing.Size(159, 36);
            this.giris_BTN.TabIndex = 21;
            this.giris_BTN.Text = "Giriş";
            this.giris_BTN.UseSelectable = true;
            this.giris_BTN.Click += new System.EventHandler(this.giris_BTN_Click);
            // 
            // sifremiUnuttum_BTN
            // 
            this.sifremiUnuttum_BTN.BackColor = System.Drawing.Color.GhostWhite;
            this.sifremiUnuttum_BTN.BackgroundImage = global::aracproje.Properties.Resources.Yeni_Proje__1_;
            this.sifremiUnuttum_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sifremiUnuttum_BTN.Location = new System.Drawing.Point(157, 217);
            this.sifremiUnuttum_BTN.Name = "sifremiUnuttum_BTN";
            this.sifremiUnuttum_BTN.Size = new System.Drawing.Size(159, 40);
            this.sifremiUnuttum_BTN.TabIndex = 22;
            this.sifremiUnuttum_BTN.Text = "Şifremi Unuttum";
            this.sifremiUnuttum_BTN.UseSelectable = true;
            this.sifremiUnuttum_BTN.Click += new System.EventHandler(this.sifremiUnuttum_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(71, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(71, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Şifre  : ";
            // 
            // gizle
            // 
            this.gizle.AutoSize = true;
            this.gizle.Location = new System.Drawing.Point(335, 125);
            this.gizle.Name = "gizle";
            this.gizle.Size = new System.Drawing.Size(92, 29);
            this.gizle.TabIndex = 25;
            this.gizle.Text = "Göster";
            this.gizle.UseVisualStyleBackColor = true;
            this.gizle.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 458);
            this.panel1.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gizle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.kullaniciad_TXT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sifre_TXT);
            this.groupBox1.Controls.Add(this.sifremiUnuttum_BTN);
            this.groupBox1.Controls.Add(this.giris_BTN);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(451, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 298);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GİRİŞ ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(791, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(842, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 45);
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // kapatBtn
            // 
            this.kapatBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kapatBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kapatBtn.BackgroundImage")));
            this.kapatBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kapatBtn.Location = new System.Drawing.Point(893, 12);
            this.kapatBtn.Name = "kapatBtn";
            this.kapatBtn.Size = new System.Drawing.Size(45, 45);
            this.kapatBtn.TabIndex = 31;
            this.kapatBtn.TabStop = false;
            this.kapatBtn.Click += new System.EventHandler(this.kapatBtn_Click);
            // 
            // giris_ekranı
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(953, 458);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.kapatBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "giris_ekranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Muayene";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapatBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox kullaniciad_TXT;
        private MetroFramework.Controls.MetroTextBox sifre_TXT;
        private MetroFramework.Controls.MetroButton giris_BTN;
        private MetroFramework.Controls.MetroButton sifremiUnuttum_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox gizle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox kapatBtn;
    }
}

