namespace Rastgele
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.İsimler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Soyadlar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.İsimDegis = new System.Windows.Forms.Button();
            this.SoyadDegis = new System.Windows.Forms.Button();
            this.DefaultIsim = new System.Windows.Forms.Button();
            this.DefaultSoyad = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanılan Veriler Aşağıdadır.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(75, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "isimler.txt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(297, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "soyadlar.txt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(384, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bu Verilere Müdahale Etmek İçin İlgili Butonlara Tıklayabilirsiniz.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.İsimler});
            this.dataGridView1.Location = new System.Drawing.Point(22, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(165, 236);
            this.dataGridView1.TabIndex = 7;
            // 
            // İsimler
            // 
            this.İsimler.HeaderText = "İsimler";
            this.İsimler.Name = "İsimler";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Soyadlar});
            this.dataGridView2.Location = new System.Drawing.Point(254, 88);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(168, 236);
            this.dataGridView2.TabIndex = 8;
            // 
            // Soyadlar
            // 
            this.Soyadlar.HeaderText = "Soyadlar";
            this.Soyadlar.Name = "Soyadlar";
            // 
            // İsimDegis
            // 
            this.İsimDegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İsimDegis.Location = new System.Drawing.Point(22, 330);
            this.İsimDegis.Name = "İsimDegis";
            this.İsimDegis.Size = new System.Drawing.Size(165, 37);
            this.İsimDegis.TabIndex = 9;
            this.İsimDegis.Text = "İsimleri Değiştir";
            this.İsimDegis.UseVisualStyleBackColor = true;
            this.İsimDegis.Click += new System.EventHandler(this.IsimTxtDegis_Click);
            // 
            // SoyadDegis
            // 
            this.SoyadDegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SoyadDegis.Location = new System.Drawing.Point(254, 330);
            this.SoyadDegis.Name = "SoyadDegis";
            this.SoyadDegis.Size = new System.Drawing.Size(168, 37);
            this.SoyadDegis.TabIndex = 11;
            this.SoyadDegis.Text = "Soyadları Değiştir";
            this.SoyadDegis.UseVisualStyleBackColor = true;
            this.SoyadDegis.Click += new System.EventHandler(this.SoyadTxtDegis_Click);
            // 
            // DefaultIsim
            // 
            this.DefaultIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DefaultIsim.Location = new System.Drawing.Point(22, 369);
            this.DefaultIsim.Name = "DefaultIsim";
            this.DefaultIsim.Size = new System.Drawing.Size(165, 37);
            this.DefaultIsim.TabIndex = 12;
            this.DefaultIsim.Text = "Default İsimler.txt";
            this.DefaultIsim.UseVisualStyleBackColor = true;
            this.DefaultIsim.Click += new System.EventHandler(this.DefaultIsim_Click);
            // 
            // DefaultSoyad
            // 
            this.DefaultSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DefaultSoyad.Location = new System.Drawing.Point(254, 369);
            this.DefaultSoyad.Name = "DefaultSoyad";
            this.DefaultSoyad.Size = new System.Drawing.Size(168, 37);
            this.DefaultSoyad.TabIndex = 13;
            this.DefaultSoyad.Text = "Default Soyadlar.txt";
            this.DefaultSoyad.UseVisualStyleBackColor = true;
            this.DefaultSoyad.Click += new System.EventHandler(this.DefaultSoyad_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(416, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "Eğer Verileri Değiştirdiyseniz İlk Kurulduğundaki Verileri Default İsimli \r\nButto" +
    "nlardan Geriye Getirtebilirsiniz.";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(441, 467);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DefaultSoyad);
            this.Controls.Add(this.DefaultIsim);
            this.Controls.Add(this.SoyadDegis);
            this.Controls.Add(this.İsimDegis);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn İsimler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyadlar;
        private System.Windows.Forms.Button İsimDegis;
        private System.Windows.Forms.Button SoyadDegis;
        private System.Windows.Forms.Button DefaultIsim;
        private System.Windows.Forms.Button DefaultSoyad;
        private System.Windows.Forms.Label label5;
    }
}