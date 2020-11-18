namespace Customer
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
            this.label4 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.KotakMenu = new System.Windows.Forms.DataGridView();
            this.KotakBest = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.daftarMeja = new System.Windows.Forms.ComboBox();
            this.grpbxPesan = new System.Windows.Forms.GroupBox();
            this.TombolPesan = new System.Windows.Forms.Button();
            this.nudBanyaknya = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.TombolBayar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.KotakPesanan = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.KotakMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KotakBest)).BeginInit();
            this.grpbxPesan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBanyaknya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KotakPesanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kaufmann BT", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 28);
            this.label4.TabIndex = 41;
            this.label4.Text = "Daftar Pesanan";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Exotc350 Bd BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(512, 275);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(50, 16);
            this.Total.TabIndex = 40;
            this.Total.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Exotc350 Bd BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(418, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Total Harga :";
            // 
            // KotakMenu
            // 
            this.KotakMenu.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.KotakMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KotakMenu.Location = new System.Drawing.Point(8, 218);
            this.KotakMenu.Name = "KotakMenu";
            this.KotakMenu.Size = new System.Drawing.Size(242, 156);
            this.KotakMenu.TabIndex = 30;
            this.KotakMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KotakMenu_CellClick);
            // 
            // KotakBest
            // 
            this.KotakBest.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.KotakBest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KotakBest.Location = new System.Drawing.Point(8, 40);
            this.KotakBest.MultiSelect = false;
            this.KotakBest.Name = "KotakBest";
            this.KotakBest.ReadOnly = true;
            this.KotakBest.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.KotakBest.Size = new System.Drawing.Size(243, 135);
            this.KotakBest.TabIndex = 38;
            this.KotakBest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KotakBest_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kaufmann BT", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 28);
            this.label1.TabIndex = 29;
            this.label1.Text = "Menu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kaufmann BT", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 28);
            this.label5.TabIndex = 37;
            this.label5.Text = "Our Best Seller";
            // 
            // daftarMeja
            // 
            this.daftarMeja.FormattingEnabled = true;
            this.daftarMeja.Location = new System.Drawing.Point(363, 13);
            this.daftarMeja.Name = "daftarMeja";
            this.daftarMeja.Size = new System.Drawing.Size(52, 21);
            this.daftarMeja.TabIndex = 36;
            this.daftarMeja.SelectedIndexChanged += new System.EventHandler(this.daftarMeja_SelectedIndexChanged);
            // 
            // grpbxPesan
            // 
            this.grpbxPesan.BackColor = System.Drawing.Color.Transparent;
            this.grpbxPesan.Controls.Add(this.TombolPesan);
            this.grpbxPesan.Controls.Add(this.nudBanyaknya);
            this.grpbxPesan.Controls.Add(this.label2);
            this.grpbxPesan.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxPesan.Location = new System.Drawing.Point(256, 198);
            this.grpbxPesan.Name = "grpbxPesan";
            this.grpbxPesan.Size = new System.Drawing.Size(150, 176);
            this.grpbxPesan.TabIndex = 35;
            this.grpbxPesan.TabStop = false;
            // 
            // TombolPesan
            // 
            this.TombolPesan.BackColor = System.Drawing.Color.Pink;
            this.TombolPesan.Font = new System.Drawing.Font("News701 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TombolPesan.Location = new System.Drawing.Point(24, 116);
            this.TombolPesan.Name = "TombolPesan";
            this.TombolPesan.Size = new System.Drawing.Size(100, 39);
            this.TombolPesan.TabIndex = 4;
            this.TombolPesan.Text = "Pesan";
            this.TombolPesan.UseVisualStyleBackColor = false;
            this.TombolPesan.Click += new System.EventHandler(this.TombolPesan_Click);
            // 
            // nudBanyaknya
            // 
            this.nudBanyaknya.Location = new System.Drawing.Point(24, 59);
            this.nudBanyaknya.Name = "nudBanyaknya";
            this.nudBanyaknya.Size = new System.Drawing.Size(100, 20);
            this.nudBanyaknya.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Exotc350 DmBd BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Banyaknya";
            // 
            // TombolBayar
            // 
            this.TombolBayar.BackColor = System.Drawing.Color.Pink;
            this.TombolBayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TombolBayar.Font = new System.Drawing.Font("News701 BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TombolBayar.ForeColor = System.Drawing.Color.Black;
            this.TombolBayar.Location = new System.Drawing.Point(555, 331);
            this.TombolBayar.Name = "TombolBayar";
            this.TombolBayar.Size = new System.Drawing.Size(109, 43);
            this.TombolBayar.TabIndex = 33;
            this.TombolBayar.Text = "Bayar";
            this.TombolBayar.UseVisualStyleBackColor = false;
            this.TombolBayar.Click += new System.EventHandler(this.TombolBayar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Exotc350 DmBd BT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nomor Meja";
            // 
            // KotakPesanan
            // 
            this.KotakPesanan.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.KotakPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KotakPesanan.Location = new System.Drawing.Point(421, 40);
            this.KotakPesanan.MultiSelect = false;
            this.KotakPesanan.Name = "KotakPesanan";
            this.KotakPesanan.ReadOnly = true;
            this.KotakPesanan.Size = new System.Drawing.Size(243, 232);
            this.KotakPesanan.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(256, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(675, 384);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.KotakMenu);
            this.Controls.Add(this.KotakBest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.daftarMeja);
            this.Controls.Add(this.grpbxPesan);
            this.Controls.Add(this.TombolBayar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KotakPesanan);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KotakMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KotakBest)).EndInit();
            this.grpbxPesan.ResumeLayout(false);
            this.grpbxPesan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBanyaknya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KotakPesanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView KotakMenu;
        private System.Windows.Forms.DataGridView KotakBest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox daftarMeja;
        private System.Windows.Forms.GroupBox grpbxPesan;
        private System.Windows.Forms.Button TombolPesan;
        private System.Windows.Forms.NumericUpDown nudBanyaknya;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TombolBayar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView KotakPesanan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

