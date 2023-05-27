using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

//using System.Data.SqlClient; // sql kutuphanemiz
//using System.Data.OleDb;//Access kütüphanesi

namespace VTDGP_uyg1
{
    public partial class FRMOGRENCİGİRİS : Form
    {
       //SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=UNIBILGISISTEMIVT;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=UNIBILGISISTEMIVT;Integrated Security=True");
        public FRMOGRENCİGİRİS()
        {
            InitializeComponent();
        }

        private void FRMOGRENCİGİRİS_Load(object sender, EventArgs e)
        {
            
            GuvenliKoduOlustur();
        }
        void GuvenliKoduOlustur()
        {
            Random rastgele = new Random();
            string karakterler = "0123456789qwertyuıopğüasdfghjklşizxcvbnmöçQWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇ";
            string olustur = "";
            for(int i=0; i<4; i++)
            {
                olustur += karakterler[rastgele.Next(karakterler.Length)];

            }
            LblGuvenlikKodu.Text = olustur.ToString(); 
            TxtGuvenlik.Text= olustur.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (TxtSifre.UseSystemPasswordChar==true)
            {
                TxtSifre.UseSystemPasswordChar = false;
            }
            else
            {
                TxtSifre.UseSystemPasswordChar = true;
            }
        }

        private void PbDegistir_Click(object sender, EventArgs e)
        {
            GuvenliKoduOlustur();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (TxtOgrNo.Text!="" && TxtSifre.Text!="" && TxtGuvenlik.Text!="")
            {
                if (TxtOgrNo.TextLength < 9)
                    {
                    MessageBox.Show("Öğrenci Numarası 9 Haneli Olmalıdır!");
                }
                else
                {
                    if(TxtGuvenlik.Text==LblGuvenlikKodu.Text)
                    {
                        // Sql Tabanlı Kullanıcı Giriş İşlemleri
                        //select
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Ogrenciler WHERE OGRNO=@P1 AND OGRSIFRE =@P2",baglanti);
                        komut.Parameters.AddWithValue("@P1",TxtOgrNo.Text);
                        komut.Parameters.AddWithValue("P2", TxtSifre.Text);
                        SqlDataReader oku = komut.ExecuteReader();
                        if (oku.Read())//OKUMA BAŞARILIYSA DEMEK VERİTABANINDAKİ BİLGİLER DOĞRU DEMEK.
                        {
                            // MessageBox.Show(oku[3].ToString());//TEK BİR ALANA ULAŞIM SAĞLANDIYSA,DİĞER TÜM ALANLARA DA ULAŞIM SAĞLAYABİLİRİZ
                            // MessageBox.Show(oku[3].ToString() + "  " + oku[4].ToString());
                            // MessageBox.Show(oku["OGRAD"].ToString() + " " + oku["OGRSOYAD"].ToString());
                            String ogrenciAdi = oku["OGRAD"].ToString();
                            String ogrenciSoyadi = oku["OGRSOYAD"].ToString();
                            String ogrenciNumarasi = oku["OGRNO"].ToString();



                            //bu alanları kullanıcaz

                            FRMOGRENCIANAFORM frm = new FRMOGRENCIANAFORM();
                            frm.Show();//bağımsız
                                       // frm.ShowDialog();//ilişki,bağlantılı.
                            this.Hide();//üzerinde bulunduğumuz formu HİDE yapar,gizler.
                           //this.Close();//üzerinde bulunduğumuz formu kapatır.
                            //Application.Exit();//Tüm programı kapatır.
                                
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı Bulunamadı!!");
                        }



                        baglanti.Close();
                    }
                    else
                    {
                        MessageBox.Show("Güvenlik kodunu doğru giriniz!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!");
            }
        }

        private void BtnGiris_MouseMove(object sender, MouseEventArgs e)
        {
            BtnGiris.BackColor = Color.WhiteSmoke;
        }

        private void BtnGiris_MouseLeave(object sender, EventArgs e)
        {
            BtnGiris.BackColor = Color.GhostWhite;
        }
    }
}
