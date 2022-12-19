using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace emlak
{
    public partial class Form3 : Form
    {
        public static string gidenbilgi = "";
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "argos")
            {
                button1.ForeColor = Color.Yellow;
                button2.ForeColor = Color.White;
                button3.ForeColor = Color.White;
                button4.ForeColor = Color.White;
                button1.BackColor = Color.Red;
            }



            if (comboBox1.Text == "truva")
            {
                button2.ForeColor = Color.Yellow;
                button1.ForeColor = Color.White;
                button3.ForeColor = Color.White;
                button4.ForeColor = Color.White;


            }


            if (comboBox1.Text == "olipos")
            {
                button3.ForeColor = Color.Yellow;

                button2.ForeColor = Color.White;
                button1.ForeColor = Color.White;
                button4.ForeColor = Color.White;

            }



            if (comboBox1.Text == "titan")
            {
                button4.ForeColor = Color.Yellow;
                button2.ForeColor = Color.White;
                button3.ForeColor = Color.White;
                button1.ForeColor = Color.White;


            }





        }

        SqlConnection bağlan = new SqlConnection("Data Source=DESKTOP-8RDP7SG;Initial Catalog=emlak;Integrated Security=True");
        private void verilerigöster()
        {
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
                listView1.Items.Add("ekle");


            }
            bağlan.Close();





        }

        private void button5_Click(object sender, EventArgs e)
        {


            bağlan.Open();







            SqlCommand komut = new SqlCommand("insert into emlak2(ıd,site,oda ,metre,fiyat,blok,no,adsoyad,telefon,notlar,satılıkkiralık)values('" + textBox9.Text.ToString() + "','" + comboBox1.Text.ToString() + "','" + comboBox2.Text.ToString() + "','" + comboBox3.Text.ToString() + "','" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + comboBox4.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + textBox7.Text.ToString() + "')", bağlan);



            komut.ExecuteNonQuery();
            bağlan.Close();
            verilerigöster();




            



        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
            this.Hide();
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
      
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ıd = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            textBox9.Text = listView1.SelectedItems[0].SubItems[0].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            comboBox2.Text = listView1.SelectedItems[0].SubItems[0].Text;
            comboBox3.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[0].Text;
            comboBox4.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[0].Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Visible = false;
        }
    }

}
