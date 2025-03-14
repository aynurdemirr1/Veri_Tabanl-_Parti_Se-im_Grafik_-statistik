using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Veri_Tabanlı_Parti_Seçim_Grafik_İstatistik
{
    public partial class FrmOyGiris : Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-LG0ARO8\SQLEXPRESS;Initial Catalog=DPSECİMPROJE;Integrated Security=True"); 

        private void BtnOyGirisi_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLILCE(İLCEAD,APARTİ, BPARTİ, CPARTİ, DPARTİ, EPARTİ) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtİlceAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtAParti.Text);
            komut.Parameters.AddWithValue("@p3", TxtBParti.Text);
            komut.Parameters.AddWithValue("@p4", TxtCParti.Text);
            komut.Parameters.AddWithValue("@p5", TxtDParti.Text);
            komut.Parameters.AddWithValue("@p6", TxtEParti.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girişi Yapıldı");



        }

        private void BtnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr=new FrmGrafikler();
            fr.Show();
            
        }

        private void BtnÇıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
