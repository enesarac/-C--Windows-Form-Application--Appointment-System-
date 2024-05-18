using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Randevu
{
    public partial class Randevu : Form
    {
        private Dictionary<DateTime, string> randevular;
        public Randevu()
        {
            InitializeComponent();
            randevular = new Dictionary<DateTime, string>();
            RandevulariDosyadanOku();
        }
        private void RandevulariDosyayaKaydet()
        {
            string dosyaYolu = "randevular.txt";
            using (StreamWriter sw = new StreamWriter(dosyaYolu)) //bin debug klasorune randevular.txt seklinde kayit oluyor.
            {
                foreach (var randevu in randevular)
                {
                    sw.WriteLine($"{randevu.Key.ToShortDateString()} - {randevu.Value}");
                }
            }
        }
        private void RandevulariDosyadanOku()
        {
            string dosyaYolu = "randevular.txt";
            if (File.Exists(dosyaYolu))
            {
                using (StreamReader sr = new StreamReader(dosyaYolu))
                {
                    while (!sr.EndOfStream)
                    {
                        string satir = sr.ReadLine();
                        string[] parcalar = satir.Split(new[] { " - " }, StringSplitOptions.None);
                        DateTime tarih = DateTime.Parse(parcalar[0]);
                        string adSoyad = parcalar[1];

                        randevular.Add(tarih, adSoyad);
                        listBoxRandevular.Items.Add($"{tarih.ToShortDateString()} - {adSoyad}");
                    }
                }
            }
        }


        private void bntRandevuEkle_Click(object sender, EventArgs e)
        {
            DateTime tarih = dateTimePicker1.Value.Date;
            string adSoyad = txtAdSoyad.Text;

            if (string.IsNullOrWhiteSpace(adSoyad))
            {
                MessageBox.Show("Lütfen ad ve soyad girin.");
                return;
            }

            if (randevular.ContainsKey(tarih))
            {
                MessageBox.Show("Bu tarih için zaten bir randevu mevcut.");
            }
            else
            {
                randevular.Add(tarih, adSoyad);
                listBoxRandevular.Items.Add($"{tarih.ToShortDateString()} - {adSoyad}");
                txtAdSoyad.Clear();
                MessageBox.Show("Randevu başarıyla eklendi.");
                RandevulariDosyayaKaydet();
            }
        }
    }
}
