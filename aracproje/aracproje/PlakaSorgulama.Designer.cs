
namespace aracproje
{
    partial class PlakaSorgulama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlakaSorgulama));
            this.button1 = new System.Windows.Forms.Button();
            this.PlakaSor = new System.Windows.Forms.TextBox();
            this.AracPlaka = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sorguPanel = new System.Windows.Forms.Panel();
            this.sahibLBL = new System.Windows.Forms.Label();
            this.plakaLbl = new System.Windows.Forms.Label();
            this.tarihLbl = new System.Windows.Forms.Label();
            this.renkLbl = new System.Windows.Forms.Label();
            this.modelLbl = new System.Windows.Forms.Label();
            this.markalbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sorguPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(727, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "ARA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlakaSor
            // 
            this.PlakaSor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PlakaSor.Location = new System.Drawing.Point(674, 463);
            this.PlakaSor.Multiline = true;
            this.PlakaSor.Name = "PlakaSor";
            this.PlakaSor.Size = new System.Drawing.Size(400, 33);
            this.PlakaSor.TabIndex = 4;
            // 
            // AracPlaka
            // 
            this.AracPlaka.AutoSize = true;
            this.AracPlaka.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AracPlaka.Location = new System.Drawing.Point(382, 463);
            this.AracPlaka.Name = "AracPlaka";
            this.AracPlaka.Size = new System.Drawing.Size(230, 25);
            this.AracPlaka.TabIndex = 3;
            this.AracPlaka.Text = "Araç Plaka Sorgulama:";
            this.AracPlaka.Click += new System.EventHandler(this.AracPlaka_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(173, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1067, 309);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // sorguPanel
            // 
            this.sorguPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sorguPanel.Controls.Add(this.sahibLBL);
            this.sorguPanel.Controls.Add(this.plakaLbl);
            this.sorguPanel.Controls.Add(this.tarihLbl);
            this.sorguPanel.Controls.Add(this.renkLbl);
            this.sorguPanel.Controls.Add(this.modelLbl);
            this.sorguPanel.Controls.Add(this.markalbl);
            this.sorguPanel.Location = new System.Drawing.Point(173, 61);
            this.sorguPanel.Name = "sorguPanel";
            this.sorguPanel.Size = new System.Drawing.Size(515, 309);
            this.sorguPanel.TabIndex = 7;
            this.sorguPanel.Visible = false;
            // 
            // sahibLBL
            // 
            this.sahibLBL.AutoSize = true;
            this.sahibLBL.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sahibLBL.Location = new System.Drawing.Point(37, 90);
            this.sahibLBL.Name = "sahibLBL";
            this.sahibLBL.Size = new System.Drawing.Size(103, 19);
            this.sahibLBL.TabIndex = 9;
            this.sahibLBL.Text = "Araç Sahibi : ";
            // 
            // plakaLbl
            // 
            this.plakaLbl.AutoSize = true;
            this.plakaLbl.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plakaLbl.Location = new System.Drawing.Point(37, 56);
            this.plakaLbl.Name = "plakaLbl";
            this.plakaLbl.Size = new System.Drawing.Size(63, 19);
            this.plakaLbl.TabIndex = 8;
            this.plakaLbl.Text = "Plaka : ";
            // 
            // tarihLbl
            // 
            this.tarihLbl.AutoSize = true;
            this.tarihLbl.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarihLbl.Location = new System.Drawing.Point(37, 215);
            this.tarihLbl.Name = "tarihLbl";
            this.tarihLbl.Size = new System.Drawing.Size(138, 19);
            this.tarihLbl.TabIndex = 3;
            this.tarihLbl.Text = "Aracı Alış Tarihi : ";
            // 
            // renkLbl
            // 
            this.renkLbl.AutoSize = true;
            this.renkLbl.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.renkLbl.Location = new System.Drawing.Point(37, 185);
            this.renkLbl.Name = "renkLbl";
            this.renkLbl.Size = new System.Drawing.Size(57, 19);
            this.renkLbl.TabIndex = 2;
            this.renkLbl.Text = "Renk : ";
            // 
            // modelLbl
            // 
            this.modelLbl.AutoSize = true;
            this.modelLbl.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.modelLbl.Location = new System.Drawing.Point(37, 155);
            this.modelLbl.Name = "modelLbl";
            this.modelLbl.Size = new System.Drawing.Size(65, 19);
            this.modelLbl.TabIndex = 1;
            this.modelLbl.Text = "Model : ";
            // 
            // markalbl
            // 
            this.markalbl.AutoSize = true;
            this.markalbl.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.markalbl.Location = new System.Drawing.Point(37, 125);
            this.markalbl.Name = "markalbl";
            this.markalbl.Size = new System.Drawing.Size(68, 19);
            this.markalbl.TabIndex = 0;
            this.markalbl.Text = "Marka : ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(21, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PlakaSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1299, 666);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.sorguPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PlakaSor);
            this.Controls.Add(this.AracPlaka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlakaSorgulama";
            this.Text = "PlakaSorgulama";
            this.Load += new System.EventHandler(this.PlakaSorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sorguPanel.ResumeLayout(false);
            this.sorguPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PlakaSor;
        private System.Windows.Forms.Label AracPlaka;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel sorguPanel;
        private System.Windows.Forms.Label plakaLbl;
        private System.Windows.Forms.Label tarihLbl;
        private System.Windows.Forms.Label renkLbl;
        private System.Windows.Forms.Label modelLbl;
        private System.Windows.Forms.Label markalbl;
        private System.Windows.Forms.Label sahibLBL;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}