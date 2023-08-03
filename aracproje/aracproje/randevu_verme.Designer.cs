
namespace aracproje
{
    partial class randevu_verme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(randevu_verme));
            this.randevutbl = new System.Windows.Forms.ListView();
            this.plaka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aracTuru = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.muayeneTur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.silmeBtn = new System.Windows.Forms.Button();
            this.saati = new System.Windows.Forms.ComboBox();
            this.aracTur = new System.Windows.Forms.ComboBox();
            this.muaTur = new System.Windows.Forms.ComboBox();
            this.tarihi = new System.Windows.Forms.DateTimePicker();
            this.plakaTxt = new System.Windows.Forms.TextBox();
            this.onayla = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.arama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // randevutbl
            // 
            this.randevutbl.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.randevutbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.randevutbl.BackColor = System.Drawing.Color.Pink;
            this.randevutbl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.plaka,
            this.aracTuru,
            this.muayeneTur,
            this.tarih,
            this.saat});
            this.randevutbl.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevutbl.FullRowSelect = true;
            this.randevutbl.GridLines = true;
            this.randevutbl.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.randevutbl.HideSelection = false;
            this.randevutbl.Location = new System.Drawing.Point(12, 359);
            this.randevutbl.MultiSelect = false;
            this.randevutbl.Name = "randevutbl";
            this.randevutbl.ShowGroups = false;
            this.randevutbl.Size = new System.Drawing.Size(1416, 527);
            this.randevutbl.TabIndex = 0;
            this.randevutbl.TabStop = false;
            this.randevutbl.UseCompatibleStateImageBehavior = false;
            this.randevutbl.View = System.Windows.Forms.View.Details;
            this.randevutbl.SelectedIndexChanged += new System.EventHandler(this.randevutbl_SelectedIndexChanged);
            // 
            // plaka
            // 
            this.plaka.Text = "Plaka";
            this.plaka.Width = 250;
            // 
            // aracTuru
            // 
            this.aracTuru.Text = "Araç Türü";
            this.aracTuru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.aracTuru.Width = 250;
            // 
            // muayeneTur
            // 
            this.muayeneTur.Text = "Hizmet Türü";
            this.muayeneTur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.muayeneTur.Width = 250;
            // 
            // tarih
            // 
            this.tarih.Text = "Randevu Tarihi";
            this.tarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tarih.Width = 250;
            // 
            // saat
            // 
            this.saat.Text = "Randevu Saati";
            this.saat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.saat.Width = 250;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.silmeBtn);
            this.groupBox1.Controls.Add(this.saati);
            this.groupBox1.Controls.Add(this.aracTur);
            this.groupBox1.Controls.Add(this.muaTur);
            this.groupBox1.Controls.Add(this.tarihi);
            this.groupBox1.Controls.Add(this.plakaTxt);
            this.groupBox1.Controls.Add(this.onayla);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(78, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 227);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Randevu";
            // 
            // silmeBtn
            // 
            this.silmeBtn.Location = new System.Drawing.Point(558, 159);
            this.silmeBtn.Name = "silmeBtn";
            this.silmeBtn.Size = new System.Drawing.Size(127, 30);
            this.silmeBtn.TabIndex = 26;
            this.silmeBtn.Text = "Randevu Silme";
            this.silmeBtn.UseVisualStyleBackColor = true;
            this.silmeBtn.Click += new System.EventHandler(this.silmeBtn_Click);
            // 
            // saati
            // 
            this.saati.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.saati.FormattingEnabled = true;
            this.saati.Location = new System.Drawing.Point(660, 97);
            this.saati.Name = "saati";
            this.saati.Size = new System.Drawing.Size(185, 27);
            this.saati.TabIndex = 25;
            // 
            // aracTur
            // 
            this.aracTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aracTur.FormattingEnabled = true;
            this.aracTur.Location = new System.Drawing.Point(208, 92);
            this.aracTur.Name = "aracTur";
            this.aracTur.Size = new System.Drawing.Size(197, 27);
            this.aracTur.TabIndex = 24;
            this.aracTur.SelectedIndexChanged += new System.EventHandler(this.aracTur_SelectedIndexChanged);
            // 
            // muaTur
            // 
            this.muaTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.muaTur.FormattingEnabled = true;
            this.muaTur.Location = new System.Drawing.Point(208, 156);
            this.muaTur.Name = "muaTur";
            this.muaTur.Size = new System.Drawing.Size(197, 27);
            this.muaTur.TabIndex = 23;
            this.muaTur.SelectedIndexChanged += new System.EventHandler(this.muaTur_SelectedIndexChanged);
            // 
            // tarihi
            // 
            this.tarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarihi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tarihi.Location = new System.Drawing.Point(660, 31);
            this.tarihi.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.tarihi.Name = "tarihi";
            this.tarihi.Size = new System.Drawing.Size(185, 26);
            this.tarihi.TabIndex = 22;
            this.tarihi.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.tarihi.ValueChanged += new System.EventHandler(this.tarihi_ValueChanged_1);
            // 
            // plakaTxt
            // 
            this.plakaTxt.Location = new System.Drawing.Point(208, 24);
            this.plakaTxt.Name = "plakaTxt";
            this.plakaTxt.Size = new System.Drawing.Size(197, 26);
            this.plakaTxt.TabIndex = 21;
            // 
            // onayla
            // 
            this.onayla.Font = new System.Drawing.Font("Cambria", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onayla.Location = new System.Drawing.Point(743, 158);
            this.onayla.Name = "onayla";
            this.onayla.Size = new System.Drawing.Size(102, 31);
            this.onayla.TabIndex = 20;
            this.onayla.Text = "Onayla";
            this.onayla.UseVisualStyleBackColor = true;
            this.onayla.Click += new System.EventHandler(this.onayla_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(528, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Randevu Saati :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(521, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Randevu Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(77, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Hizmet Türü :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(106, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Araç Türü :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(136, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Plaka :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "RANDEVULAR :";
            // 
            // arama
            // 
            this.arama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.arama.Location = new System.Drawing.Point(1266, 307);
            this.arama.Name = "arama";
            this.arama.Size = new System.Drawing.Size(162, 20);
            this.arama.TabIndex = 18;
            this.arama.TextChanged += new System.EventHandler(this.arama_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(1165, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "ARAMA:";
            // 
            // randevu_verme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1440, 898);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.arama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.randevutbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "randevu_verme";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.randevu_verme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView randevutbl;
        private System.Windows.Forms.ColumnHeader plaka;
        private System.Windows.Forms.ColumnHeader aracTuru;
        private System.Windows.Forms.ColumnHeader muayeneTur;
        private System.Windows.Forms.ColumnHeader tarih;
        private System.Windows.Forms.ColumnHeader saat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox saati;
        private System.Windows.Forms.ComboBox aracTur;
        private System.Windows.Forms.ComboBox muaTur;
        private System.Windows.Forms.DateTimePicker tarihi;
        private System.Windows.Forms.TextBox plakaTxt;
        private System.Windows.Forms.Button onayla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox arama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button silmeBtn;
    }
}