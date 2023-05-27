using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTDGP_uyg1
{
    public partial class FRMOGRENCIANAFORM : Form
    {
        public FRMOGRENCIANAFORM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FRMOGRENCIANAFORM_Load(object sender, EventArgs e)
        {
            Panel_Genel.Visible = false;//kapalı

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LBL_DonemOrt_Click(object sender, EventArgs e)
        {

        }

        private void Panel_Bilgi_Ekrani_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pb_Ogrenci_Bilgi_Ekrani_Click(object sender, EventArgs e)
        {
          if(Panel_Genel.Visible==false)//kapalıysa....

            {
                Panel_Genel.Visible = true;//aç
            }
          else//kapalı değilse,açıksa
            {
                Panel_Genel.Visible = false;//kapat

            }

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Pb_Ogrenci_Bilgi_Ekrani_MouseMove(object sender, MouseEventArgs e)
        {
            // Pb_Ogrenci_Bilgi_Ekrani.ImageLocation = @"resmin bulunduğu konumun /yerin adresini";//Desktop//Images//Icons//image.png
            Pb_Ogrenci_Bilgi_Ekrani.Image = Properties.Resources.AboutGreen;
        }

        private void Pb_Ogrenci_Bilgi_Ekrani_MouseLeave(object sender, EventArgs e)
        {
            // Pb_Ogrenci_Bilgi_Ekrani.Image = Properties.Resources.AboutWhite;
            if (Panel_Genel.Visible==false)
            {
                Pb_Ogrenci_Bilgi_Ekrani.Image = Properties.Resources.AboutWhite;
            }
            else
            {
                Pb_Ogrenci_Bilgi_Ekrani.Image = Properties.Resources.AboutGreen;

            }
        }
    }
}
