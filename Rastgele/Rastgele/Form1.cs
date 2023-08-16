using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rastgele
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Text = "";
            dataGridView1.AllowUserToAddRows = false;
        }

        private void Tekli_Uret_Click(object sender, EventArgs e)
        {
            listBox1.BackColor = Color.White;
            int s2, s3, s4, s5, s6, s7, s8, s9, i1, i2;
            Random random = new Random();

            int[] s1 = { 501, 505, 506, 507, 551, 552, 553, 554, 555, 559, 516, 530, 531, 532, 533, 534, 535, 536, 537, 538, 539, 561, 541, 542, 543, 544, 545, 546, 547, 548, 549 };

            s2 = random.Next(0, s1.Length);
            s3 = random.Next(0, 10);
            s4 = random.Next(0, 10);
            s5 = random.Next(0, 10);
            s6 = random.Next(0, 10);
            s7 = random.Next(0, 10);
            s8 = random.Next(0, 10);
            s9 = random.Next(0, 10);

            string[] isimler = File.ReadAllLines("isimler.txt");
            string[] soyadlar = File.ReadAllLines("soyadlar.txt");

            i1 = random.Next(0, isimler.Length);
            i2 = random.Next(0, soyadlar.Length);

            dataGridView1.Rows.Add(isimler[i1], soyadlar[i2], s1[s2] + "" + s3 + "" + s4 + "" + s5 + "" + s6 + "" + s7 + "" + s8 + "" + s9);

            label2.Text = "Kayıt Sayısı : " + dataGridView1.Rows.Count;

            if (dataGridView1.Rows.Count > 0)
            {
                int sonSatirIndex = dataGridView1.Rows.Count - 1;
                dataGridView1.CurrentCell = dataGridView1.Rows[sonSatirIndex].Cells[0];
            }
        }
        private void Coklu_Uret_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("1-10000 Arası Değer Girmelisiniz");
            }
            else if (textBox2.Text =="0")
            {
                MessageBox.Show("0 Adet Kayıt Üretilemez");
            }
            else
            {
                int txt2 = Convert.ToInt32(textBox2.Text);
                listBox1.BackColor = Color.White;
                Random random = new Random();

                progressBar1.Minimum = 0;
                progressBar1.Maximum = txt2;
                progressBar1.Value = 0;

                Stopwatch stopwatch = new Stopwatch();

                for (int z = 0; z < txt2; z++)

                {

                    int s2, s3, s4, s5, s6, s7, s8, s9, i1, i2;

                    int[] s1 = { 501, 505, 506, 507, 551, 552, 553, 554, 555, 559, 516, 530, 531, 532, 533, 534, 535, 536, 537, 538, 539, 561, 541, 542, 543, 544, 545, 546, 547, 548, 549 };

                    s2 = random.Next(0, s1.Length);
                    s3 = random.Next(0, 10);
                    s4 = random.Next(0, 10);
                    s5 = random.Next(0, 10);
                    s6 = random.Next(0, 10);
                    s7 = random.Next(0, 10);
                    s8 = random.Next(0, 10);
                    s9 = random.Next(0, 10);

                    string[] isimler = File.ReadAllLines("isimler.txt");
                    string[] soyadlar = File.ReadAllLines("soyadlar.txt");

                    i1 = random.Next(0, isimler.Length);
                    i2 = random.Next(0, soyadlar.Length);



                    dataGridView1.Rows.Add(isimler[i1], soyadlar[i2], s1[s2] + "" + s3 + "" + s4 + "" + s5 + "" + s6 + "" + s7 + "" + s8 + "" + s9);

                    label2.Text = "Kayıt Sayısı " + dataGridView1.Rows.Count;

                    if (dataGridView1.Rows.Count > 0)
                    {
                        int sonSatirIndex = dataGridView1.Rows.Count - 1;
                        dataGridView1.CurrentCell = dataGridView1.Rows[sonSatirIndex].Cells[0];
                    }
                    stopwatch.Stop(); // Zaman ölçümünü durdur

                    progressBar1.Value = z + 1;



                }
                MessageBox.Show(txt2 + " Adet Kayıt Üretildi");
            }
        
        }
        private void Grid_Temizle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            label2.Text = "Kayıt Sayısı : 0";
        }
        private async void Aktar_Click(object sender, EventArgs e)
        {
            int rowCount = dataGridView1.Rows.Count;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = rowCount;
            progressBar1.Value = 0;

            listBox1.Items.Clear(); 
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string Ad = row.Cells["Ad"]?.Value?.ToString() ?? "";
                string Soyad = row.Cells["Soyad"]?.Value?.ToString() ?? "";
                string Telefon = row.Cells["Telefon"]?.Value?.ToString() ?? "";

                listBox1.Items.Add("INSERT INTO" + " " + textBox1.Text + " " + "VALUES" + " " + "(" + "'" + Ad + "'" + "," + "'" + Soyad + "'" + ", " + Telefon + ")");
            
                progressBar1.Value++; 
                await Task.Delay(0); 
                Application.DoEvents();
                label3.Text = "Kayıt Sayısı : " + listBox1.Items.Count;

            }
            MessageBox.Show(dataGridView1.Rows.Count + " Adet Kayıt Aktarıldı");
        }
            private void Kopyala_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("ListBox Boş Kopyalama İşlemi Yapılamaz ! ");
            }
            else
            {
                string combinedData = string.Join(Environment.NewLine, listBox1.Items.Cast<string>());
                Clipboard.SetText(combinedData);
                listBox1.BackColor = Color.LightGreen;
                MessageBox.Show(listBox1.Items.Count+" Adet Kayıt Kopyalandı !");
            }
        }
        private void Listbox_Temizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.BackColor = Color.White;
            label3.Text = "Kayıt Sayısı : 0";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            { 

            int txt2 = Convert.ToInt32(textBox2.Text);

            if(txt2>10000)
            {
                MessageBox.Show("Maksimum 10000 Değerini Verebilirsiniz");
                textBox2.Text = "10000";
            }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
