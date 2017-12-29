namespace plakatanima
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
            this.resim1 = new System.Windows.Forms.PictureBox();
            this.resim2 = new System.Windows.Forms.PictureBox();
            this.plakaboyut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.yeni_plakayeri = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.resim1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resim2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // resim1
            // 
            this.resim1.Location = new System.Drawing.Point(12, 12);
            this.resim1.Name = "resim1";
            this.resim1.Size = new System.Drawing.Size(288, 173);
            this.resim1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resim1.TabIndex = 0;
            this.resim1.TabStop = false;
            this.resim1.Click += new System.EventHandler(this.resim1_Click);
            // 
            // resim2
            // 
            this.resim2.Location = new System.Drawing.Point(442, 322);
            this.resim2.Name = "resim2";
            this.resim2.Size = new System.Drawing.Size(110, 27);
            this.resim2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.resim2.TabIndex = 17;
            this.resim2.TabStop = false;
            this.resim2.Visible = false;
            this.resim2.Click += new System.EventHandler(this.resim2_Click);
            // 
            // plakaboyut
            // 
            this.plakaboyut.BackColor = System.Drawing.Color.SeaShell;
            this.plakaboyut.Location = new System.Drawing.Point(399, 29);
            this.plakaboyut.Name = "plakaboyut";
            this.plakaboyut.Size = new System.Drawing.Size(109, 41);
            this.plakaboyut.TabIndex = 29;
            this.plakaboyut.Text = "Karakterleri Oku";
            this.plakaboyut.UseVisualStyleBackColor = false;
            this.plakaboyut.Visible = false;
            this.plakaboyut.Click += new System.EventHandler(this.plakaboyut_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.Location = new System.Drawing.Point(387, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 41);
            this.button1.TabIndex = 31;
            this.button1.Text = "Resim seç";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(442, 513);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 32;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(439, 481);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Plaka Text";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(439, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Plaka Görüntüsü";
            this.label13.Visible = false;
            // 
            // yeni_plakayeri
            // 
            this.yeni_plakayeri.BackColor = System.Drawing.Color.SeaShell;
            this.yeni_plakayeri.Location = new System.Drawing.Point(514, 39);
            this.yeni_plakayeri.Name = "yeni_plakayeri";
            this.yeni_plakayeri.Size = new System.Drawing.Size(109, 45);
            this.yeni_plakayeri.TabIndex = 35;
            this.yeni_plakayeri.Text = "Plakayý Bul";
            this.yeni_plakayeri.UseVisualStyleBackColor = false;
            this.yeni_plakayeri.Visible = false;
            this.yeni_plakayeri.Click += new System.EventHandler(this.yeni_plakayeri_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(387, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 203);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 412);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(288, 223);
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(672, 647);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.yeni_plakayeri);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.plakaboyut);
            this.Controls.Add(this.resim2);
            this.Controls.Add(this.resim1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resim1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resim2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox resim1;
        private System.Windows.Forms.PictureBox resim2;
        private System.Windows.Forms.Button plakaboyut;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button yeni_plakayeri;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

