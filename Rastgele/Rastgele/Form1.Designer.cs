namespace Rastgele
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Tekli_Uret = new System.Windows.Forms.Button();
            this.Uret = new System.Windows.Forms.Button();
            this.Kopyala = new System.Windows.Forms.Button();
            this.TemizleGrid = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Aktar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TemizleListbox = new System.Windows.Forms.Button();
            this.DegerTxt = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.VeriDegis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tekli_Uret
            // 
            this.Tekli_Uret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tekli_Uret.Location = new System.Drawing.Point(26, 294);
            this.Tekli_Uret.Name = "Tekli_Uret";
            this.Tekli_Uret.Size = new System.Drawing.Size(101, 32);
            this.Tekli_Uret.TabIndex = 0;
            this.Tekli_Uret.Text = "Tekli Üret";
            this.Tekli_Uret.UseVisualStyleBackColor = true;
            this.Tekli_Uret.Click += new System.EventHandler(this.Tekli_Uret_Click);
            // 
            // Uret
            // 
            this.Uret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Uret.Location = new System.Drawing.Point(214, 294);
            this.Uret.Name = "Uret";
            this.Uret.Size = new System.Drawing.Size(46, 32);
            this.Uret.TabIndex = 2;
            this.Uret.Text = "Üret";
            this.Uret.UseVisualStyleBackColor = true;
            this.Uret.Click += new System.EventHandler(this.Coklu_Uret_Click);
            // 
            // Kopyala
            // 
            this.Kopyala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kopyala.Location = new System.Drawing.Point(26, 604);
            this.Kopyala.Name = "Kopyala";
            this.Kopyala.Size = new System.Drawing.Size(113, 32);
            this.Kopyala.TabIndex = 3;
            this.Kopyala.Text = "Kopyala";
            this.Kopyala.UseVisualStyleBackColor = true;
            this.Kopyala.Click += new System.EventHandler(this.Kopyala_Click);
            // 
            // TemizleGrid
            // 
            this.TemizleGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TemizleGrid.Location = new System.Drawing.Point(270, 294);
            this.TemizleGrid.Name = "TemizleGrid";
            this.TemizleGrid.Size = new System.Drawing.Size(101, 32);
            this.TemizleGrid.TabIndex = 4;
            this.TemizleGrid.Text = "Temizle Grid";
            this.TemizleGrid.UseVisualStyleBackColor = true;
            this.TemizleGrid.Click += new System.EventHandler(this.Grid_Temizle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ad,
            this.Soyad,
            this.Telefon});
            this.dataGridView1.Location = new System.Drawing.Point(25, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 262);
            this.dataGridView1.TabIndex = 5;
            // 
            // Ad
            // 
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            // 
            // Soyad
            // 
            this.Soyad.HeaderText = "Soyad";
            this.Soyad.Name = "Soyad";
            // 
            // Telefon
            // 
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(26, 402);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(345, 196);
            this.listBox1.TabIndex = 6;
            // 
            // Aktar
            // 
            this.Aktar.Location = new System.Drawing.Point(270, 361);
            this.Aktar.Name = "Aktar";
            this.Aktar.Size = new System.Drawing.Size(101, 31);
            this.Aktar.TabIndex = 7;
            this.Aktar.Text = "Aktar";
            this.Aktar.UseVisualStyleBackColor = true;
            this.Aktar.Click += new System.EventHandler(this.Aktar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(97, 365);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tablo Adı :";
            // 
            // TemizleListbox
            // 
            this.TemizleListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TemizleListbox.Location = new System.Drawing.Point(258, 604);
            this.TemizleListbox.Name = "TemizleListbox";
            this.TemizleListbox.Size = new System.Drawing.Size(113, 32);
            this.TemizleListbox.TabIndex = 10;
            this.TemizleListbox.Text = "Temizle Listbox";
            this.TemizleListbox.UseVisualStyleBackColor = true;
            this.TemizleListbox.Click += new System.EventHandler(this.Listbox_Temizle_Click);
            // 
            // DegerTxt
            // 
            this.DegerTxt.Location = new System.Drawing.Point(134, 301);
            this.DegerTxt.Name = "DegerTxt";
            this.DegerTxt.Size = new System.Drawing.Size(74, 20);
            this.DegerTxt.TabIndex = 11;
            this.DegerTxt.TextChanged += new System.EventHandler(this.DegerTxt_TextChanged);
            this.DegerTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DegerTxt_KeyPress);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(27, 332);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(344, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // VeriDegis
            // 
            this.VeriDegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VeriDegis.Location = new System.Drawing.Point(134, 642);
            this.VeriDegis.Name = "VeriDegis";
            this.VeriDegis.Size = new System.Drawing.Size(126, 32);
            this.VeriDegis.TabIndex = 12;
            this.VeriDegis.Text = "Verileri Değiştir";
            this.VeriDegis.UseVisualStyleBackColor = true;
            this.VeriDegis.Click += new System.EventHandler(this.VeriDegis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 614);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(397, 677);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.VeriDegis);
            this.Controls.Add(this.DegerTxt);
            this.Controls.Add(this.TemizleListbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Aktar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TemizleGrid);
            this.Controls.Add(this.Kopyala);
            this.Controls.Add(this.Uret);
            this.Controls.Add(this.Tekli_Uret);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kullanıcı Oluştur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Tekli_Uret;
        private System.Windows.Forms.Button Uret;
        private System.Windows.Forms.Button Kopyala;
        private System.Windows.Forms.Button TemizleGrid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Aktar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TemizleListbox;
        private System.Windows.Forms.TextBox DegerTxt;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button VeriDegis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

