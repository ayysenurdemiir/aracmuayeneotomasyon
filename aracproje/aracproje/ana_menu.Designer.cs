
namespace aracproje
{
    partial class ana_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ana_menu));
            this.panelButtons = new System.Windows.Forms.Panel();
            this.fiyatListe = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.servisözeti = new System.Windows.Forms.Button();
            this.aracbilgi = new System.Windows.Forms.Button();
            this.AracRandevu = new System.Windows.Forms.Button();
            this.Randevular = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.kucultBtn = new System.Windows.Forms.PictureBox();
            this.buyutBtn = new System.Windows.Forms.PictureBox();
            this.kapatBtn = new System.Windows.Forms.PictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kucultBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyutBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapatBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.LightCoral;
            this.panelButtons.Controls.Add(this.fiyatListe);
            this.panelButtons.Controls.Add(this.pictureBox2);
            this.panelButtons.Controls.Add(this.servisözeti);
            this.panelButtons.Controls.Add(this.aracbilgi);
            this.panelButtons.Controls.Add(this.AracRandevu);
            this.panelButtons.Controls.Add(this.Randevular);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 62);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(262, 674);
            this.panelButtons.TabIndex = 2;
            this.panelButtons.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // fiyatListe
            // 
            this.fiyatListe.BackColor = System.Drawing.Color.Lavender;
            this.fiyatListe.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyatListe.Location = new System.Drawing.Point(37, 473);
            this.fiyatListe.Name = "fiyatListe";
            this.fiyatListe.Size = new System.Drawing.Size(177, 57);
            this.fiyatListe.TabIndex = 9;
            this.fiyatListe.Text = "Fiyat Listesi";
            this.fiyatListe.UseVisualStyleBackColor = false;
            this.fiyatListe.Click += new System.EventHandler(this.fiyatListe_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightCoral;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(12, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(235, 147);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // servisözeti
            // 
            this.servisözeti.BackColor = System.Drawing.Color.Lavender;
            this.servisözeti.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.servisözeti.Location = new System.Drawing.Point(37, 221);
            this.servisözeti.Name = "servisözeti";
            this.servisözeti.Size = new System.Drawing.Size(177, 57);
            this.servisözeti.TabIndex = 5;
            this.servisözeti.Text = "Servis Özeti";
            this.servisözeti.UseVisualStyleBackColor = false;
            this.servisözeti.Click += new System.EventHandler(this.muayeneozeti_Click);
            // 
            // aracbilgi
            // 
            this.aracbilgi.BackColor = System.Drawing.Color.Lavender;
            this.aracbilgi.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aracbilgi.Location = new System.Drawing.Point(37, 410);
            this.aracbilgi.Name = "aracbilgi";
            this.aracbilgi.Size = new System.Drawing.Size(177, 57);
            this.aracbilgi.TabIndex = 4;
            this.aracbilgi.Text = "Araç Bilgileri";
            this.aracbilgi.UseVisualStyleBackColor = false;
            this.aracbilgi.Click += new System.EventHandler(this.PlakaSorgulama_Click);
            // 
            // AracRandevu
            // 
            this.AracRandevu.BackColor = System.Drawing.Color.Lavender;
            this.AracRandevu.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AracRandevu.Location = new System.Drawing.Point(37, 284);
            this.AracRandevu.Name = "AracRandevu";
            this.AracRandevu.Size = new System.Drawing.Size(177, 57);
            this.AracRandevu.TabIndex = 3;
            this.AracRandevu.Text = "Araç Randevu Geçmişi";
            this.AracRandevu.UseVisualStyleBackColor = false;
            this.AracRandevu.Click += new System.EventHandler(this.button5_Click);
            // 
            // Randevular
            // 
            this.Randevular.BackColor = System.Drawing.Color.Lavender;
            this.Randevular.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Randevular.Location = new System.Drawing.Point(37, 347);
            this.Randevular.Name = "Randevular";
            this.Randevular.Size = new System.Drawing.Size(177, 57);
            this.Randevular.TabIndex = 2;
            this.Randevular.Text = "Randevular";
            this.Randevular.UseVisualStyleBackColor = false;
            this.Randevular.Click += new System.EventHandler(this.Randevular_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.LightCoral;
            this.panelTitleBar.Controls.Add(this.kucultBtn);
            this.panelTitleBar.Controls.Add(this.buyutBtn);
            this.panelTitleBar.Controls.Add(this.kapatBtn);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1063, 62);
            this.panelTitleBar.TabIndex = 4;
            // 
            // kucultBtn
            // 
            this.kucultBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kucultBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kucultBtn.BackgroundImage")));
            this.kucultBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kucultBtn.Location = new System.Drawing.Point(916, 9);
            this.kucultBtn.Name = "kucultBtn";
            this.kucultBtn.Size = new System.Drawing.Size(45, 45);
            this.kucultBtn.TabIndex = 6;
            this.kucultBtn.TabStop = false;
            this.kucultBtn.Click += new System.EventHandler(this.kucultBtn_Click);
            // 
            // buyutBtn
            // 
            this.buyutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buyutBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buyutBtn.BackgroundImage")));
            this.buyutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buyutBtn.Location = new System.Drawing.Point(967, 9);
            this.buyutBtn.Name = "buyutBtn";
            this.buyutBtn.Size = new System.Drawing.Size(45, 45);
            this.buyutBtn.TabIndex = 5;
            this.buyutBtn.TabStop = false;
            this.buyutBtn.Click += new System.EventHandler(this.buyutBtn_Click);
            // 
            // kapatBtn
            // 
            this.kapatBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kapatBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kapatBtn.BackgroundImage")));
            this.kapatBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kapatBtn.Location = new System.Drawing.Point(1018, 9);
            this.kapatBtn.Name = "kapatBtn";
            this.kapatBtn.Size = new System.Drawing.Size(45, 45);
            this.kapatBtn.TabIndex = 4;
            this.kapatBtn.TabStop = false;
            this.kapatBtn.Click += new System.EventHandler(this.kapatBtn_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Lavender;
            this.panelDesktop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDesktop.BackgroundImage")));
            this.panelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(262, 62);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(801, 674);
            this.panelDesktop.TabIndex = 1;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // ana_menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1063, 736);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ana_menu";
            this.Text = "AnaMenü";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ana_menu_Load);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kucultBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyutBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapatBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button Randevular;
        private System.Windows.Forms.Button aracbilgi;
        private System.Windows.Forms.Button servisözeti;
        private System.Windows.Forms.Button AracRandevu;
        private System.Windows.Forms.PictureBox kapatBtn;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox kucultBtn;
        private System.Windows.Forms.PictureBox buyutBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button fiyatListe;
        private System.Windows.Forms.Panel panelDesktop;
    }
}