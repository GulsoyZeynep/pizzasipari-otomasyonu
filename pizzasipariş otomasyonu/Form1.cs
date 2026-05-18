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

namespace pizzasipariş_otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-LHVETO7\\SQLEXPRESS01;Initial Catalog=pizzadb;Integrated Security=True;");
        private void Form1_Load(object sender, EventArgs e)
        {
        
            MusterileriYukle();
            PizzalariYukle();
            SiparisleriListele();
        
        }
        void MusterileriYukle()
        {
            cmbMusteri.Items.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT MusteriID, AdSoyad FROM Musteriler", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbMusteri.Items.Add(new ComboboxItem(dr["AdSoyad"].ToString(), dr["MusteriID"]));
            }
            baglanti.Close();
        }

        void PizzalariYukle()
        {
            cmbPizza.Items.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT PizzaID, PizzaAdi FROM Pizzalar", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbPizza.Items.Add(new ComboboxItem(dr["PizzaAdi"].ToString(), dr["PizzaID"]));
            }
           baglanti.Close();
        }

        void SiparisleriListele()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(@"
        SELECT S.SiparisID, M.AdSoyad, S.SiparisTarihi, S.ToplamTutar
        FROM Siparisler S
        INNER JOIN Musteriler M ON S.MusteriID = M.MusteriID", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSiparisler.DataSource = dt;
            baglanti.Close();
        }


        private void btnMusteriKaydet_Click(object sender, EventArgs e)
        {

        
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Musteriler (AdSoyad, Telefon, Adres, Email) VALUES (@ad, @tel, @adr, @mail)", baglanti);
            cmd.Parameters.AddWithValue("@ad", txtAdSoyad.Text);
            cmd.Parameters.AddWithValue("@tel", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@adr", txtAdres.Text);
            cmd.Parameters.AddWithValue("@mail", txtEmail.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri kaydedildi.");
            MusterileriYukle();
            

            
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
        
            var pizza = (ComboboxItem)cmbPizza.SelectedItem;
            int adet = (int)nudAdet.Value;

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT Fiyat FROM Pizzalar WHERE PizzaID = @id", baglanti);
            cmd.Parameters.AddWithValue("@id", pizza.Value);
            decimal fiyat = Convert.ToDecimal(cmd.ExecuteScalar());
            baglanti.Close();

            decimal tutar = fiyat * adet;

            ListViewItem item = new ListViewItem(new[] {
        pizza.Text,
        adet.ToString(),
        fiyat.ToString("C"),
        tutar.ToString("C"),
        pizza.Value.ToString() // saklı pizzaid
    });
            lvSiparis.Items.Add(item);
        }

        private void btnsiptam_Click(object sender, EventArgs e)
        {
        
            decimal toplamTutar = 0;
            foreach (ListViewItem item in lvSiparis.Items)
            {
                toplamTutar += decimal.Parse(item.SubItems[3].Text, System.Globalization.NumberStyles.Currency);
            }

            var musteri = (ComboboxItem)cmbMusteri.SelectedItem;

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Siparisler (MusteriID, ToplamTutar) OUTPUT INSERTED.SiparisID VALUES (@mid, @tutar)", baglanti);
            cmd.Parameters.AddWithValue("@mid", musteri.Value);
            cmd.Parameters.AddWithValue("@tutar", toplamTutar);
            int siparisID = (int)cmd.ExecuteScalar();

            foreach (ListViewItem item in lvSiparis.Items)
            {
                int pizzaID = int.Parse(item.SubItems[4].Text);
                int adet = int.Parse(item.SubItems[1].Text);
                decimal tutar = decimal.Parse(item.SubItems[3].Text, System.Globalization.NumberStyles.Currency);

                SqlCommand cmdDetay = new SqlCommand("INSERT INTO SiparisDetaylari (SiparisID, PizzaID, Adet, Tutar) VALUES (@sid, @pid, @adet, @tutar)", baglanti);
                cmdDetay.Parameters.AddWithValue("@sid", siparisID);
                cmdDetay.Parameters.AddWithValue("@pid", pizzaID);
                cmdDetay.Parameters.AddWithValue("@adet", adet);
                cmdDetay.Parameters.AddWithValue("@tutar", tutar);
                cmdDetay.ExecuteNonQuery();
            }
            baglanti.Close();

            MessageBox.Show("Sipariş başarıyla kaydedildi.");
            lvSiparis.Items.Clear();
            SiparisleriListele();
        }
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public ComboboxItem(string text, object value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

    }
}


