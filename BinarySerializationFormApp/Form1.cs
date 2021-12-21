using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySerializationFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //
        MemoryStream ms = new MemoryStream();
        byte[] resimArray = new byte[64];   //Bir kerede 64 byte taşıması/okuması amacıyla dizinin length özelliğine 64 verdik. Buradaki işlemi buffersize gibi düşünebilirsiniiz.

        private void btnAc_Click(object sender, EventArgs e)
        {
            //
            openFileDialog1.Title = "Bir Resim Dosyası Seçiniz";

            openFileDialog1.Filter = "JPG Dosyaları | *.jpg";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.Multiselect = false;
            openFileDialog1.FileName = string.Empty;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName,FileMode.OpenOrCreate);

                while (fs.Read(resimArray,0,resimArray.Length)!=0)
                {
                    ms.Write(resimArray,0,resimArray.Length);
                }
                fs.Close();
                fs.Dispose();
                pictureBox1.Image = new Bitmap(ms);
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (ms.Length == 0)
                {
                    pictureBox1.Image = null;
                    MessageBox.Show("HATA : MemoryStream nesnesi ile RAM'de herhangi bir resim açılmamıştır!");
                    //else yazmak istemezsek erturn yazabiliriz.
                    //return kelimesini görünce program bu metodun yaşam döngüsünün bittiği süslü paranteze gider.Böylece else bloğuna gerek kalmaz.
                    return; //ÖNEMLİ ÜÇ YILDIZ...       //FAKE RETURN
                }

                saveFileDialog1.Title = "KAYIT İŞLEMİ";
                //saveFileDialog1.Filter = "(*.*)|*.*";
                saveFileDialog1.Filter = "(*.jpg)|*.jpg";
                saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                //İsim boş gelecek...
                //saveFileDialog1.FileName = string.Empty;
                
                //Guid ile oluşturulacak Tireleri var.
                //saveFileDialog1.FileName =Guid.NewGuid().ToString();
                //***************************************************************************************
                
                //Guid ' de tireleri yok etme
                string dosyaAdiGuid = Guid.NewGuid().ToString();
                //Oluşturulan Guid'in tirelerini sildik.
                dosyaAdiGuid = dosyaAdiGuid.Replace("-","");

                saveFileDialog1.FileName = dosyaAdiGuid;
                //***************************************************************************************


                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = File.Create(saveFileDialog1.FileName))
                    {
                        ms.Seek(0, SeekOrigin.Begin);
                        while (ms.Read(resimArray, 0, resimArray.Length) != 0)
                        {
                            fs.Write(resimArray, 0, resimArray.Length);
                        }
                        MessageBox.Show($"Resminiz bilgisayara kaydedildi. \n Yol  : {saveFileDialog1.FileName}");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
