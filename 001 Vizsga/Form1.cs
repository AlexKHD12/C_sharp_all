using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _001_Vizsga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                listBox1.Items.Add(new Kutya(textBox1.Text));
            } else
            {
                listBox1.Items.Add(new Macska(textBox1.Text));
            }
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length > 0)
            {
                button1.Enabled = true;
            } else
            {
                button1.Enabled = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                button2.Enabled = false;
                pictureBox1.Image = null;
                label2.Text = "";
            } else
            {
                button2.Enabled = true;
                if (listBox1.SelectedItem is Kutya)
                {
                    pictureBox1.Image = Properties.Resources.kutya;
                    label2.Text = (listBox1.SelectedItem as Kutya).Ugat();
                } else
                {
                    pictureBox1.Image = Properties.Resources.macska;
                    label2.Text = (listBox1.SelectedItem as Macska).Nyavog();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
