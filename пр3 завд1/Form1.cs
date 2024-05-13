using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace пр3_завд1
{
    public partial class Form1 : Form
    {
        Form2 fr2;
        public Form1()
        {
            InitializeComponent();
            fr2 = new Form2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double k = Convert.ToDouble(textBox1.Text);
            double x = Math.Pow(k, 2);
            double y = Math.Sin(k);
            double f = x + y;
            textBox2.Text = x.ToString();
            textBox3.Text = y.ToString();
            textBox4.Text = f.ToString();
            CheckBox ch1 = (CheckBox)fr2.Controls["checkBox1"];
            CheckBox ch2 = (CheckBox)fr2.Controls["checkBox2"];
            textBox2.Visible = ch1.Checked;
            textBox3.Visible = ch2.Checked;
            label3.Visible = ch1.Checked;
            label4.Visible = ch2.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fr2.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fr2.Show();
        }
    }
}
