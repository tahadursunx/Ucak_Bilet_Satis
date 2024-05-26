using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UcakBiletRezervasyon
{
    public partial class Form4 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HG6TKLO;Initial Catalog=OT;Integrated Security=True");
        SqlCommand komut;
        string tc;
        string sirketKodu;

        public Form4()
        {
            InitializeComponent();
        }

        void listele()
        {
            try
            {
                baglanti.Open();
                komut = new SqlCommand("SELECT * FROM bilet WHERE bilet_id = @bilet_id", baglanti);
                komut.Parameters.AddWithValue("@bilet_id", textBox1.Text);
                SqlDataReader reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    textUcusKodu.Text = reader["ucus_no"].ToString();
                    textKoltuk.Text = reader["koltuk_numarasi"].ToString();
                    textTarife.Text = reader["koltuk_sinifi"].ToString();
                    tc = reader["musteri_id"].ToString();
                }
                else
                {
                    MessageBox.Show("Bilet bulunamadı.");
                    return;
                }

                reader.Close();
                baglanti.Close();

                baglanti.Open();
                komut = new SqlCommand("SELECT * FROM musteri WHERE musteri_id = @musteri_id", baglanti);
                komut.Parameters.AddWithValue("@musteri_id", tc);
                SqlDataReader reader1 = komut.ExecuteReader();

                if (reader1.Read())
                {
                    textisim.Text = reader1["ad"].ToString();
                    textSoyisim.Text = reader1["soyad"].ToString();
                }
                else
                {
                    MessageBox.Show("Müşteri bulunamadı.");
                    return;
                }

                reader1.Close();
                baglanti.Close();

                baglanti.Open();
                komut = new SqlCommand("SELECT * FROM ucus WHERE ucus_no = @ucus_no", baglanti);
                komut.Parameters.AddWithValue("@ucus_no", textUcusKodu.Text);
                SqlDataReader reader2 = komut.ExecuteReader();

                if (reader2.Read())
                {
                    textKalkis.Text = reader2["kalkis_noktasi"].ToString();
                    textInis.Text = reader2["varis_noktasi"].ToString();
                    textUcakKodu.Text = reader2["ucak_kodu"].ToString();
                    textTarih.Text = Convert.ToDateTime(reader2["kalkis_tarihi"]).ToString("dd.MM.yyyy");
                    textSaat.Text = reader2["kalkis_saati"].ToString();
                    sirketKodu = reader2["sirket_kodu"].ToString();
                }
                else
                {
                    MessageBox.Show("Uçuş bulunamadı.");
                    return;
                }

                reader2.Close();
                baglanti.Close();

                baglanti.Open();
                komut = new SqlCommand("SELECT * FROM havayolu_sirketi WHERE sirket_kodu = @sirket_kodu", baglanti);
                komut.Parameters.AddWithValue("@sirket_kodu", sirketKodu);
                SqlDataReader reader3 = komut.ExecuteReader();

                if (reader3.Read())
                {
                    textSirket.Text = reader3["sirket_adi"].ToString();
                }
                else
                {
                    MessageBox.Show("Havayolu şirketi bulunamadı.");
                    return;
                }

                reader3.Close();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == System.Data.ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void Biletiniz_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label12_Click(object sender, EventArgs e) { }
    }
}
