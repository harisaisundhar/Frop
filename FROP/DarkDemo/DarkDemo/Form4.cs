using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DarkDemo
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void trend_Click(object sender, EventArgs e)
        {
            Form4 trend = new Form4();
            this.Hide();
            trend.ShowDialog();
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

        private void share_Click(object sender, EventArgs e)
        {
            Form3 trans = new Form3();
            this.Hide();
            trans.ShowDialog();
        }

        private void Fileq_Click(object sender, EventArgs e)
        {
            Form3 trans = new Form3();
            this.Hide();
            trans.ShowDialog();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                webBrowser1.Navigate(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://mail.google.com");
        }
    }
}
