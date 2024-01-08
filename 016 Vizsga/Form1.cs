using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _016_Vizsga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tesztkerdes tk = new Tesztkerdes(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value);
            listBox1.Items.Add(tk);
            listBox1.SelectedItem = tk;
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            Tesztkerdes tk = new Tesztkerdes(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value);
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox1.Items.Add(tk);
            listBox1.SelectedItem = tk;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >=0 )
            {
                Tesztkerdes tk = (Tesztkerdes)listBox1.SelectedItem;
                textBox1.Text = tk.GetKerdes();
                textBox2.Text = tk.GetHelyesValasz();
                numericUpDown1.Value = tk.GetPontszam();
                if (textBox1.Text.Trim().Length > 0 && textBox2.Text.Trim().Length > 0)
                {
                    button2.Enabled = true;
                }
                button3.Enabled = true;
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                numericUpDown1.Value = 1;
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length>0 && textBox2.Text.Trim().Length>0)
            {
                button1.Enabled = true;
                if (listBox1.SelectedIndex >=0)
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
