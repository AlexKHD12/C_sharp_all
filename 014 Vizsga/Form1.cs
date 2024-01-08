using System;
using System.Windows.Forms;

namespace _014_Vizsga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Szopar sz = new Szopar(textBox1.Text, textBox2.Text);
            listBox1.Items.Add(sz);
            listBox1.SelectedItem = sz;
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            Szopar sz = new Szopar(textBox1.Text, textBox2.Text);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.Add(sz);
            listBox1.SelectedItem = sz;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            textBox1.Clear();
            textBox2.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                Szopar sz = (Szopar)listBox1.SelectedItem;
                textBox1.Text = sz.GetMagyar();
                textBox2.Text = sz.GetAngol();
                button2.Enabled = true;                
                button3.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length > 0 && textBox2.Text.Trim().Length > 0)
            {
                button1.Enabled = true;
                if (listBox1.SelectedIndex >= 0)
                {
                    button2.Enabled = true;
                }
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }
    }
}
