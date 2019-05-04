using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 chat = new Form2();
            this.Hide();
            chat.ShowDialog();
 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dash_Click(object sender, EventArgs e)
        {

        }

        private void share_Click(object sender, EventArgs e)
        {
            Form3 trans = new Form3();
            this.Hide();
            trans.ShowDialog();
        }

        private void trend_Click(object sender, EventArgs e)
        {
            Form4 trend = new Form4();
            this.Hide();
            trend.ShowDialog();
        }

        private void Chatq_Click(object sender, EventArgs e)
        {
            Form2 chat = new Form2();
            this.Hide();
            chat.ShowDialog();
        }

        private void Fileq_Click(object sender, EventArgs e)
        {
            Form3 trans = new Form3();
            this.Hide();
            trans.ShowDialog();
        }
    }
}
