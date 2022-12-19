using System;
using System.Windows.Forms;

namespace emlak
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 emlakkayıt = new Form3();
            emlakkayıt.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 emlakkayıt = new Form4();
            emlakkayıt.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 emlakkayıt = new Form5();
            emlakkayıt.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 emlakkayıt = new Form1();
            emlakkayıt.Show();
            this.Hide();
        }
    }
}
