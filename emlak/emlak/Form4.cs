using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace emlak
{

    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection bağlan = new SqlConnection("Data Source=DESKTOP-8RDP7SG;Initial Catalog=emlak;Integrated Security=True");
        private void verilerigöster()
        {
            listView1.Items.Clear();
            bağlan.Open();
            SqlCommand komut = new SqlCommand("select *from emlak2", bağlan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ıd"].ToString();
                ekle.SubItems.Add(oku["site"].ToString());


                ekle.SubItems.Add(oku["oda"].ToString());
                ekle.SubItems.Add(oku["metre"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                ekle.SubItems.Add(oku["blok"].ToString());
                ekle.SubItems.Add(oku["no"].ToString());
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["notlar"].ToString());
                ekle.SubItems.Add(oku["satılıkkiralık"].ToString());

                listView1.Items.Add(ekle);

            }
            bağlan.Close();

        }


        private void button1_Click(object sender, EventArgs e)
        {






            verilerigöster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {







        }
        int ıd = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            bağlan.Open();
            SqlCommand komut = new SqlCommand("delete from emlak2 where ıd=(" + ıd + ")", bağlan);
            komut.ExecuteNonQuery();
            bağlan.Close();
            verilerigöster();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ıd = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

          
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }

}
