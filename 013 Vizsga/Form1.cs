using System;
using System.Windows.Forms;

namespace _013_Vizsga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length>0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Termek t = new Termek(textBox1.Text);
            listBox1.Items.Add(t);
            textBox1.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                Termek t = (Termek)listBox1.SelectedItem;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;                
            }
            else
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Termek t = (Termek)listBox1.SelectedItem;
            t.RaktarbaErkezett(Convert.ToInt32(numericUpDown1.Value));
            numericUpDown1.Value = 0;
            listBox1.Items[listBox1.SelectedIndex] = listBox1.Items[listBox1.SelectedIndex];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Termek t = (Termek)listBox1.SelectedItem;
            if (t.RaktarbolKiadas(Convert.ToInt32(numericUpDown2.Value)))
            {
                numericUpDown2.Value = 0;
                listBox1.Items[listBox1.SelectedIndex] = listBox1.Items[listBox1.SelectedIndex];
            }
            else
            {
                MessageBox.Show("Ennyit nem lehet elvinni, nincs ennyi darab a raktáron!", "Hiba",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
