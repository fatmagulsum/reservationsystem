using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace rezarvasyon_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-SM1J2IO3;Initial Catalog=otelkayıt;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            mskodano.Text = "107";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            mskodano.Text = "203";
        }


        private void button3_Click(object sender, EventArgs e)
        {
            mskodano.Text = "101";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (msktxttel.Text.Length == 11)
            {
                msktxttel.Text = msktxttel.Text;
            }
            else
            {
                errorProvider1.SetError(msktxttel, "Telefon numarasını giriniz.");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn108_Click(object sender, EventArgs e)
        {
            mskodano.Text = "108";
        }

        private void btnoda102_Click(object sender, EventArgs e)
        {
            mskodano.Text = "102";
        }

        private void btnoda103_Click(object sender, EventArgs e)
        {
            mskodano.Text = "103";
        }

        private void btnoda104_Click(object sender, EventArgs e)
        {
            mskodano.Text = "104";
        }

        private void btnoda105_Click(object sender, EventArgs e)
        {
            mskodano.Text = "105";
        }

        private void btnoda106_Click(object sender, EventArgs e)
        {
            mskodano.Text = "106";
        }

        private void btn109_Click(object sender, EventArgs e)
        {
            mskodano.Text = "109";
        }

        private void btnoda201_Click(object sender, EventArgs e)
        {
            mskodano.Text = "201";
        }

        private void btnoda202_Click(object sender, EventArgs e)
        {
            mskodano.Text = "202";
        }

        private void btndoluoda_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Kırmızı renkli butonlar dolu odaları göstermektedir.");
        }

        private void btnbosoda_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Sarı renkli butonlar boş odaları göstermektedir.");
        }

        private void dtpgiris_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpcikis_ValueChanged(object sender, EventArgs e)
        {
            int ucret;

            DateTime kucuktarih = Convert.ToDateTime(dtpgiristarihi.Text);

            DateTime buyuktarih = Convert.ToDateTime(dtpcikistarihi.Text);

            TimeSpan sonuc;

            sonuc = buyuktarih - kucuktarih;

            label11.Text = sonuc.TotalDays.ToString();

            ucret = Convert.ToInt32(label11.Text) * 70;

            txtucret.Text = ucret.ToString();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtadi.Text + " " + txtsoyadi.Text +" " + comboBox1.Text+" "+msktxttel.Text+" "+txtmail.Text+" "+mskkimlik.Text+" "+mskodano.Text+" "+dtpgiristarihi.Text+" "+dtpcikistarihi.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtadi.Clear();
            txtsoyadi.Clear();
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            msktxttel.Clear();
            txtmail.Clear();
            mskkimlik.Clear();
            mskodano.Clear();
            dtpgiristarihi.Value = DateTime.Now;
            dtpcikistarihi.Value = DateTime.Now;
        }

        private void txtadi_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtadi.Text))
            {
               errorProvider1.SetError(txtadi, "Lütfen müşteri adını giriniz...");

            }
            else
            {
                txtadi.Text =txtadi.Text;
            }
        }

        private void txtsoyadi_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsoyadi.Text))
            {
                errorProvider1.SetError(txtsoyadi, "Lütfen müşteri soyadını  giriniz...");

            }
            else
            {
                txtsoyadi.Text = txtsoyadi.Text;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void mskkimlik_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mskkimlik.Text.Length == 11)
            {
                mskkimlik.Text = mskkimlik.Text;
            }
            else
            {
                errorProvider1.SetError( mskkimlik, "tc no Geçersizdir.");
            }
        }
    }
}

