using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace XML_Serialization_Deserialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Ogrenci> ListOgrenci = new List<Ogrenci>();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci()
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                DogumTarih = dtpDogumTarihi.Value
            };
            lstBoxOgrenci.Items.Add(ogrenci.Ad + "   " + ogrenci.Soyad + "   " + ogrenci.DogumTarih);
            ListOgrenci.Add(ogrenci);
        }

        private void btnDis_Click(object sender, EventArgs e)
        {
            saveFileOgrenci.Title = "XML Dosyasını Kaydet";
            saveFileOgrenci.Filter = "(*.xml)|*.xlm";
            saveFileOgrenci.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            XmlSerializer serializer = new XmlSerializer(typeof(List<Ogrenci>));
            if (saveFileOgrenci.ShowDialog() == DialogResult.OK)
            {
                TextWriter writer = new StreamWriter(saveFileOgrenci.FileName);
                serializer.Serialize(writer, ListOgrenci);
                writer.Close();
                MessageBox.Show("Dosya kaydedildi.");
            }
        }

        private void btnIc_Click(object sender, EventArgs e)
        {
            List<Ogrenci> okunanOgrenciler = new List<Ogrenci>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Ogrenci>));
            if (openFileXml.ShowDialog() == DialogResult.OK)
            {
                TextReader reader = new StreamReader(openFileXml.FileName);
                okunanOgrenciler = (List<Ogrenci>)serializer.Deserialize(reader);

                ListOgrenci.AddRange(okunanOgrenciler);
                ListeyiDoldur(ListOgrenci);
                reader.Close();
            }
        }
        private void ListeyiDoldur(List<Ogrenci> OgrenciList)
        {
            lstBoxOgrenci.Items.Clear();
            for (int i = 0; i <= OgrenciList.Count - 1; i++)
            {
                lstBoxOgrenci.Items.Add(OgrenciList[i]);
            }
        }

        private void lstBoxOgrenci_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxOgrenci.SelectedItem != null)
            {
                txtAd.Text = ((Ogrenci)(lstBoxOgrenci.SelectedItem)).Ad;
                txtSoyad.Text = (lstBoxOgrenci.SelectedItem as Ogrenci).Soyad;
                dtpDogumTarihi.Value = (lstBoxOgrenci.SelectedItem as Ogrenci).DogumTarih;
            }
        }
    }
}
