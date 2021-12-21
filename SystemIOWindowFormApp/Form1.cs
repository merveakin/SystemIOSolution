using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemIOWindowFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //GLOBAL ALAN (class içindeyiz.)
        VeriIslemleri veriIslemleri = new VeriIslemleri();
        Personel secilenPersonel = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPersonelGetir.Click += new EventHandler(btnPersonelGetir_Click);

            listBoxPersoneller.DoubleClick += new EventHandler(listBoxPersoneller_DoubleClick);

            btnPersonelKaydet.Click += new EventHandler(btnPersonelKaydet_Click);

            //GERİ DÖNECEĞİM...

            foreach (var item in this.Controls)
            {
                var theItem = item.GetType();
                if (theItem.Name == "GroupBox" && ((GroupBox)item).Name=="groupBoxPersonelDetay")
                {
                    foreach (var subitems in ((GroupBox)item).Controls)
                    {
                        if (subitems is TextBox)
                        {
                            ((TextBox)subitems).ReadOnly = true;
                        }
                    }
                }
            }
        }

        private void btnPersonelKaydet_Click(object sender, EventArgs e)
        {
            //dosyaYolu
            if (secilenPersonel!=null)
            {
                string kayıtolduguYolBilgisi = string.Empty;
                bool kontrol=
                veriIslemleri.PersoneliKaydet("C:\\Merve", secilenPersonel, out kayıtolduguYolBilgisi);
                try
                {
                    if (kontrol)
                    {
                        MessageBox.Show($"{secilenPersonel.ToString()} bilgisayara kayıt oldu... \n Yol {kayıtolduguYolBilgisi}");
                    }

                    else
                    {
                        throw new Exception($"HATA : {secilenPersonel.ToString()} bilgisayara kayıt olamadı...");
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

            else
            {
                MessageBox.Show("Lütfen listeden personel seçiniz...");
                //GENEL TEMİZLİK---> textler ve listbox

            }
        }

        private void btnPersonelGetir_Click(object sender, EventArgs e)
        {
            //FakeData'dan 5 personel aldık.
            listBoxPersoneller.DataSource = veriIslemleri.PersonelleriGetir();
        }

        private void listBoxPersoneller_DoubleClick(object sender, EventArgs e)
        {
            //1. Yöntem
         secilenPersonel = listBoxPersoneller.SelectedItem as Personel;

            txtIsim.Text = secilenPersonel.Isim;
            txtSoyisim.Text = secilenPersonel.Soyisim;
            txtEmail.Text = secilenPersonel.Email;
            txtFirma.Text = secilenPersonel.Firma;
            txtUlke.Text = secilenPersonel.Ulke;
        }



    }
}
