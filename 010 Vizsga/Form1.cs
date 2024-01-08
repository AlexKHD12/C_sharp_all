using System;
using System.Windows.Forms;

namespace _010_Vizsga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Szemely sz = (Szemely)listBox1.SelectedItem;
                textBox1.Text = sz.GetNev();
                textBox2.Text = sz.GetTelefonszam();
                button2.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Szemely beszurando = new Szemely(textBox1.Text, textBox2.Text);
            listBox1.Items.Add(beszurando);
            listBox1.SelectedItem = beszurando;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Szemely torlendo = (Szemely)listBox1.SelectedItem;
            Szemely beszurando = new Szemely(textBox1.Text, textBox2.Text);
            listBox1.Items.Remove(torlendo);
            listBox1.Items.Add(beszurando);
            listBox1.SelectedItem = beszurando;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

    }
}