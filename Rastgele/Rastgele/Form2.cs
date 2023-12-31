﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Rastgele
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Form2 Form2 = new Form2();
            Form2.Hide();

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            
            LoadDataFromFile("isimler.txt");
            LoadDataFromFile2("soyadlar.txt");

        }

        private void LoadDataFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                dataGridView1.Rows.Clear();

                string[] lines = File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    dataGridView1.Rows.Add(line);
                }
            }
            else
            {
                MessageBox.Show("Dosya bulunamadı: " + fileName, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataFromFile2(string fileName)
        {
            if (File.Exists(fileName))
            {
                dataGridView2.Rows.Clear();

                string[] lines = File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    dataGridView2.Rows.Add(line);
                }
            }
            else
            {
                MessageBox.Show("Dosya bulunamadı: " + fileName, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataFromFile3(string fileName)
        {
            if (File.Exists(fileName))
            {
                dataGridView1.Rows.Clear();

                string[] lines = File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    dataGridView1.Rows.Add(line);
                }
            }
            else
            {
                MessageBox.Show("Dosya bulunamadı: " + fileName, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataFromFile4(string fileName)
        {
            if (File.Exists(fileName))
            {
                dataGridView2.Rows.Clear();

                string[] lines = File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    dataGridView2.Rows.Add(line);
                }
            }
            else
            {
                MessageBox.Show("Dosya bulunamadı: " + fileName, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CopyFileToIsimler(string sourceFilePath)
        {
            string targetFilePath = "isimler.txt";

            if (File.Exists(targetFilePath))
            {
                DialogResult result = MessageBox.Show("Mevcut dosyanın üzerine yazmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return; 
                }
            }

            try
            {
                File.Copy(sourceFilePath, targetFilePath, true);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Dosya kopyalanırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CopyFileToIsimler2(string sourceFilePath)
        {
            string targetFilePath = "soyadlar.txt";

            if (File.Exists(targetFilePath))
            {
                DialogResult result = MessageBox.Show("Mevcut dosyanın üzerine yazmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            try
            {
                File.Copy(sourceFilePath, targetFilePath, true);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Dosya kopyalanırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CopyFileToIsimler3(string sourceFilePath)
        {
            string targetFilePath = "isimler.txt";

            if (File.Exists(targetFilePath))
            {
                DialogResult result = MessageBox.Show("Mevcut dosyanın üzerine yazmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            try
            {
                File.Copy(sourceFilePath, targetFilePath, true);
                LoadDataFromFile("Default_txt\\isimler.txt");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Dosya kopyalanırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CopyFileToIsimler4(string sourceFilePath)
        {
            string targetFilePath = "soyadlar.txt";

            if (File.Exists(targetFilePath))
            {
                DialogResult result = MessageBox.Show("Mevcut dosyanın üzerine yazmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            try
            {
                File.Copy(sourceFilePath, targetFilePath, true);
                LoadDataFromFile2("Default_txt\\soyadlar.txt");

            }
            catch (IOException ex)
            {
                MessageBox.Show("Dosya kopyalanırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IsimTxtDegis_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
            openFileDialog.Title = "Bir Dosya Seçin";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;
                CopyFileToIsimler(selectedFileName);
                LoadDataFromFile3("isimler.txt");
            }
        }


        private void SoyadTxtDegis_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
            openFileDialog.Title = "Bir Dosya Seçin";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;
                CopyFileToIsimler2(selectedFileName);
                LoadDataFromFile4("soyadlar.txt");
            }
        }

        private void DefaultIsim_Click(object sender, EventArgs e)
        {
            CopyFileToIsimler3("Default_txt\\isimler.txt");

        }

        private void DefaultSoyad_Click(object sender, EventArgs e)
        {
            CopyFileToIsimler4("Default_txt\\soyadlar.txt");
        }

    }
}
