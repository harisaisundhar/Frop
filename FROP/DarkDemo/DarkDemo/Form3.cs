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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dash_Click(object sender, EventArgs e)
        {
            Form1 dash = new Form1();
            this.Hide();
            dash.ShowDialog();
        }

        private void chat_Click(object sender, EventArgs e)
        {
            Form2 chat = new Form2();
            this.Hide();
            chat.ShowDialog();
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

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
