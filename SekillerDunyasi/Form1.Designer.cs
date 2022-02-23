namespace SekillerDunyasi
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbOpacity = new System.Windows.Forms.TrackBar();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cboTur = new System.Windows.Forms.ComboBox();
            this.pboRenk = new System.Windows.Forms.PictureBox();
            this.nudYuk = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudGen = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAsagi = new System.Windows.Forms.Button();
            this.btnYukari = new System.Windows.Forms.Button();
            this.cdiRenk = new System.Windows.Forms.ColorDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstSekiller = new System.Windows.Forms.ListBox();
            this.pnlCizim = new System.Windows.Forms.Panel();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.JPEGYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümünüSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nasılÇalışırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdJpeg = new System.Windows.Forms.SaveFileDialog();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboRenk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbOpacity);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.cboTur);
            this.groupBox1.Controls.Add(this.pboRenk);
            this.groupBox1.Controls.Add(this.nudYuk);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudGen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudY);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(758, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Şekil";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Transparanlık:";
            // 
            // tbOpacity
            // 
            this.tbOpacity.Location = new System.Drawing.Point(295, 50);
            this.tbOpacity.Maximum = 100;
            this.tbOpacity.Name = "tbOpacity";
            this.tbOpacity.Size = new System.Drawing.Size(116, 45);
            this.tbOpacity.TabIndex = 16;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(198, 101);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(80, 23);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Renk:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tür:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(309, 101);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(73, 23);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cboTur
            // 
            this.cboTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTur.FormattingEnabled = true;
            this.cboTur.Items.AddRange(new object[] {
            "Dikdörtgen",
            "Elips"});
            this.cboTur.Location = new System.Drawing.Point(54, 101);
            this.cboTur.Name = "cboTur";
            this.cboTur.Size = new System.Drawing.Size(93, 21);
            this.cboTur.TabIndex = 9;
            // 
            // pboRenk
            // 
            this.pboRenk.BackColor = System.Drawing.Color.Black;
            this.pboRenk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboRenk.Location = new System.Drawing.Point(295, 19);
            this.pboRenk.Name = "pboRenk";
            this.pboRenk.Size = new System.Drawing.Size(20, 20);
            this.pboRenk.TabIndex = 8;
            this.pboRenk.TabStop = false;
            this.pboRenk.Click += new System.EventHandler(this.pboRenk_Click);
            // 
            // nudYuk
            // 
            this.nudYuk.Location = new System.Drawing.Point(153, 64);
            this.nudYuk.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudYuk.Name = "nudYuk";
            this.nudYuk.Size = new System.Drawing.Size(46, 20);
            this.nudYuk.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Yuk:";
            // 
            // nudGen
            // 
            this.nudGen.Location = new System.Drawing.Point(53, 64);
            this.nudGen.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudGen.Name = "nudGen";
            this.nudGen.Size = new System.Drawing.Size(46, 20);
            this.nudGen.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gen:";
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(153, 24);
            this.nudY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(46, 20);
            this.nudY.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y:";
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(53, 23);
            this.nudX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(46, 20);
            this.nudX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // btnAsagi
            // 
            this.btnAsagi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAsagi.BackgroundImage = global::SekillerDunyasi.Properties.Resources.down;
            this.btnAsagi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAsagi.Location = new System.Drawing.Point(1164, 396);
            this.btnAsagi.Name = "btnAsagi";
            this.btnAsagi.Size = new System.Drawing.Size(41, 34);
            this.btnAsagi.TabIndex = 14;
            this.btnAsagi.UseVisualStyleBackColor = true;
            this.btnAsagi.Click += new System.EventHandler(this.btnAsagi_Click);
            // 
            // btnYukari
            // 
            this.btnYukari.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnYukari.BackgroundImage = global::SekillerDunyasi.Properties.Resources.up;
            this.btnYukari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYukari.Location = new System.Drawing.Point(1162, 313);
            this.btnYukari.Name = "btnYukari";
            this.btnYukari.Size = new System.Drawing.Size(41, 34);
            this.btnYukari.TabIndex = 13;
            this.btnYukari.UseVisualStyleBackColor = true;
            this.btnYukari.Click += new System.EventHandler(this.btnYukari_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lstSekiller);
            this.groupBox2.Location = new System.Drawing.Point(758, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 557);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şekiller";
            // 
            // lstSekiller
            // 
            this.lstSekiller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSekiller.FormattingEnabled = true;
            this.lstSekiller.Location = new System.Drawing.Point(3, 16);
            this.lstSekiller.Name = "lstSekiller";
            this.lstSekiller.ScrollAlwaysVisible = true;
            this.lstSekiller.Size = new System.Drawing.Size(392, 538);
            this.lstSekiller.TabIndex = 0;
            this.lstSekiller.SelectedIndexChanged += new System.EventHandler(this.lstSekiller_SelectedIndexChanged);
            this.lstSekiller.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstSekiller_KeyDown);
            this.lstSekiller.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstSekiller_MouseDoubleClick);
            // 
            // pnlCizim
            // 
            this.pnlCizim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCizim.BackColor = System.Drawing.Color.White;
            this.pnlCizim.Location = new System.Drawing.Point(13, 31);
            this.pnlCizim.Name = "pnlCizim";
            this.pnlCizim.Size = new System.Drawing.Size(739, 685);
            this.pnlCizim.TabIndex = 2;
            this.pnlCizim.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCizim_Paint);
            this.pnlCizim.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlCizim_MouseClick);
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.JPEGYapToolStripMenuItem,
            this.tümünüSilToolStripMenuItem,
            this.nasılÇalışırToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(1217, 24);
            this.msMenu.TabIndex = 3;
            this.msMenu.Text = "menuStrip1";
            // 
            // JPEGYapToolStripMenuItem
            // 
            this.JPEGYapToolStripMenuItem.Name = "JPEGYapToolStripMenuItem";
            this.JPEGYapToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.JPEGYapToolStripMenuItem.Text = "JPEG Yap";
            this.JPEGYapToolStripMenuItem.Click += new System.EventHandler(this.JPEGYapToolStripMenuItem_Click);
            // 
            // tümünüSilToolStripMenuItem
            // 
            this.tümünüSilToolStripMenuItem.Name = "tümünüSilToolStripMenuItem";
            this.tümünüSilToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.tümünüSilToolStripMenuItem.Text = "Tümünü Sil";
            this.tümünüSilToolStripMenuItem.Click += new System.EventHandler(this.tümünüSilToolStripMenuItem_Click);
            // 
            // nasılÇalışırToolStripMenuItem
            // 
            this.nasılÇalışırToolStripMenuItem.Name = "nasılÇalışırToolStripMenuItem";
            this.nasılÇalışırToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.nasılÇalışırToolStripMenuItem.Text = "Nasıl Çalışır ?";
            this.nasılÇalışırToolStripMenuItem.Click += new System.EventHandler(this.nasılÇalışırToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 728);
            this.Controls.Add(this.btnYukari);
            this.Controls.Add(this.btnAsagi);
            this.Controls.Add(this.pnlCizim);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "Form1";
            this.Text = "Sekiller Dünyası";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboRenk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cboTur;
        private System.Windows.Forms.PictureBox pboRenk;
        private System.Windows.Forms.NumericUpDown nudYuk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudGen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog cdiRenk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstSekiller;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlCizim;
        private System.Windows.Forms.Button btnYukari;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem JPEGYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümünüSilToolStripMenuItem;
        private System.Windows.Forms.Button btnAsagi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.SaveFileDialog sfdJpeg;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar tbOpacity;
        private System.Windows.Forms.ToolStripMenuItem nasılÇalışırToolStripMenuItem;
    }
}

