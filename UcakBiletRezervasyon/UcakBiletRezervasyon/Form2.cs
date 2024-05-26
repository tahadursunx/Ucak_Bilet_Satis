using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakBiletRezervasyon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HG6TKLO;Initial Catalog=OT;Integrated Security=True");

        void Listele()
        {
            // SQL sorgusunu filtreleme şartlarıyla birlikte oluştur
            string sqlQuery = "SELECT * FROM ucus WHERE kalkis_noktasi = @KalkisYeri and varis_noktasi = @Inisyeri  and kalkis_tarihi = @KalkisTarihi  and kalkis_saati = @KalkisSaati";

            // Komutu oluştur ve bağlantıyı kullan
            SqlCommand komut = new SqlCommand(sqlQuery, baglanti);

            // Parametreleri ekle
            komut.Parameters.AddWithValue("@KalkisYeri", comboBox1.Text);
            komut.Parameters.AddWithValue("@InisYeri", comboBox4.Text);
            DateTime kalkisTarihi;
            if (DateTime.TryParse(comboBox2.Text, out kalkisTarihi))
            {
                komut.Parameters.AddWithValue("@KalkisTarihi", kalkisTarihi);
            }
            else
            {
                // Tarih dönüştürülemezse uygun bir hata mesajı gösterme veya işleme yapma
                MessageBox.Show("Lütfen geçerli bir tarih seçin.");
                return;
            }
            TimeSpan kalkisSaati;
            if (TimeSpan.TryParse(comboBox3.Text, out kalkisSaati))
            {
                komut.Parameters.AddWithValue("@KalkisSaati", kalkisSaati);
            }
            else
            {
                // Saat dönüştürülemezse uygun bir hata mesajı gösterme veya işleme yapma
                MessageBox.Show("Lütfen geçerli bir saat seçin.");
                return;
            }


            // Data adapter ve data table oluştur
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();

            // Data table'ı doldur
            da.Fill(dt);

            // DataGridView'in veri kaynağını ata
            dataGridView1.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String temp = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = temp;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'oTDataSet4.ucus' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ucusTableAdapter3.Fill(this.oTDataSet4.ucus);
            // TODO: Bu kod satırı 'oTDataSet3.ucus' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ucusTableAdapter2.Fill(this.oTDataSet3.ucus);
            // TODO: Bu kod satırı 'oTDataSet2.ucus' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ucusTableAdapter1.Fill(this.oTDataSet2.ucus);
            // TODO: Bu kod satırı 'oTDataSet1.ucus' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ucusTableAdapter.Fill(this.oTDataSet1.ucus);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ucusTableAdapter.FillBy(this.oTDataSet1.ucus);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.ucusTableAdapter1.FillBy(this.oTDataSet2.ucus);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.ucusTableAdapter2.FillBy(this.oTDataSet3.ucus);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                this.ucusTableAdapter3.FillBy(this.oTDataSet4.ucus);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
