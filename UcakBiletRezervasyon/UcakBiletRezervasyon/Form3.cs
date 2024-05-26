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


namespace UcakBiletRezervasyon
{

    
    public partial class Form3 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HG6TKLO;Initial Catalog=OT;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        String cinsiyet;
        int biletİd; 

        

       

        public Form3()
        {
            InitializeComponent();
            




        }



        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (comboBox3.Text == "Ödendi")
            {
                baglanti.Open();
                string sorgu = "insert into musteri (musteri_id, ad, soyad" +
                    ", cinsiyet, dogum_tarihi, telefon_numarasi, e_posta, adres) values(@p1, @p2, @p3, @p4, @p5, @p6, @p7 ,@p8)";

                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", maskedTextBox2.Text);
                komut.Parameters.AddWithValue("@p2", textAd.Text);
                komut.Parameters.AddWithValue("@p3", textSoyad.Text);
                komut.Parameters.AddWithValue("@p4", cinsiyet);
                komut.Parameters.AddWithValue("@p5", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@p6", maskedTextBox3.Text);
                komut.Parameters.AddWithValue("@p7", textEposta.Text);
                komut.Parameters.AddWithValue("@p8", textAdres.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("müşteri eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Random rastgele = new Random();
                biletİd = rastgele.Next(100000, 999999);
                baglanti.Open();

                string sorgu2 = "insert into bilet (bilet_id, ucus_no, bilet_fiyati ,koltuk_numarasi, musteri_id, koltuk_sinifi) values(@p1, @p2, @p3, @p4, @p5, @p6)";

                komut = new SqlCommand(sorgu2, baglanti);
                komut.Parameters.AddWithValue("@p1", biletİd);
                komut.Parameters.AddWithValue("@p2", textUcusKodu.Text);
                komut.Parameters.AddWithValue("@p3", maskedTextBox4.Text);
                komut.Parameters.AddWithValue("@p4", maskedTextBox1.Text);
                komut.Parameters.AddWithValue("@p5", maskedTextBox2.Text);
                komut.Parameters.AddWithValue("@p6", comboBox1.Text);
                MessageBox.Show("Bilet eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                komut.ExecuteNonQuery();
                baglanti.Close();

                textBiletId.Text = biletİd.ToString();
            }
            else { MessageBox.Show("Ödeme yapmadan alamazsınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "Kadın";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "Erkek";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();

            form2.ShowDialog();
        }
    }
}
