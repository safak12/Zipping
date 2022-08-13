using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using zipleme_form.Models;

namespace zipleme_form
{
    public partial class Form1 : Form
    {
        public static string kaydedilen;
        public static DateTime saniye;
        public string secilenDosya;
        private object icerik;
        

        public Form1()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            
            if (result == DialogResult.OK)      // Seçip OK butonuna basılınca
            {
                var files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                foreach (var file in files)
                {
                    checkedListBox1.Items.Add(Path.GetFileName(file));
                }


            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            

            if (result == DialogResult.OK)
            {
                
                secilenDosya = openFileDialog1.FileName;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog3.ShowDialog();
            var dt = DateTime.Now;
            var files = ZİPLEME_VE_CIKARMA.UncompressFile(File.ReadAllBytes(secilenDosya));
           

            if (result == DialogResult.OK)      
            {
                foreach (var file in files)
                {   
                    
                    File.WriteAllBytes(folderBrowserDialog3.SelectedPath + @"\" + file.Key, file.Value);
                    listBox1.Items.Add(file.Key);
                    listBox1.Refresh();
                    
                }
            }
            
            MessageBox.Show("BAŞARIYLA OKUNDU********    " + (DateTime.Now - dt).TotalSeconds + "   saniye sürdü");
            //if (files.Count == 1)
            //{
            //    //var baslama = DateTime.Now;
            //    //Form f1 = new Form3();
            //    //f1.Show();
            //    //Form yakala = Application.OpenForms["Form3"];
            //    //RichTextBox r1 = (RichTextBox)yakala.Controls["richTextBox1"];
            //    Form f1 = new Form4();
            //    f1.Show();
            //    Form yakala = Application.OpenForms["Form4"];
            //    DataGridView v1 = (DataGridView)yakala.Controls["dataGridView1"];
            //    foreach (var file in files)
            //    {
            //        //r1.Text = Encoding.UTF8.GetString(file.Value);
            //        string b = Encoding.UTF8.GetString(file.Value);
            //        icerik = JsonConvert.DeserializeObject<IEnumerable<JsonModel>>(b);
            //    }
            //    v1.DataSource = icerik;
            //    //MessageBox.Show((DateTime.Now - baslama).TotalSeconds + "    SANİYEDE OKUNDU");

            //}

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            DialogResult result = folderBrowserDialog2.ShowDialog();
            

            var dict = new Dictionary<string, byte[]>();
            var files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
            foreach (var file in files)
            {
                dict.Add(Path.GetFileName(file), File.ReadAllBytes(file));
            }

            if (result == DialogResult.OK)
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
                var zipFile = ZİPLEME_VE_CIKARMA.CompressFile(dict);
                File.WriteAllBytes(folderBrowserDialog2.SelectedPath + @"\" + kaydedilen, zipFile);
                listBox2.Items.Add(folderBrowserDialog2.SelectedPath + @"\" + kaydedilen);
                MessageBox.Show("BAŞARIYLA ZİPLENDİ" + "*******    " + (DateTime.Now - saniye).TotalSeconds + "  saniye sürdü");
            }
        
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    
    }
}
