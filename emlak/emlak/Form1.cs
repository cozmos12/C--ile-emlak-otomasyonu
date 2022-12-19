using System;
using System.Windows.Forms;

namespace emlak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "zeus" && textBox2.Text == "12419")
            {
                Form2 emlakkayıt = new Form2();
                emlakkayıt.Show();
                this.Hide();

            }



        }
    }
}
