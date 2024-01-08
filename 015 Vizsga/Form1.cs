using System;
using System.Windows.Forms;

namespace _015_Vizsga
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
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
            textBox1.Clear();
            textBox2.Clear();
            for (int i = 1; i <= 10; i++)
            {
                int elsoSzam = rnd.Next((int)numericUpDown1.Value, (int)numericUpDown2.Value + 1);
                int masodikSzam = rnd.Next((int)numericUpDown1.Value, (int)numericUpDown2.Value + 1);
                char muveletiJel;
                if (checkBox1.Checked && checkBox2.Checked)
                {
                    if (rnd.Next(2) == 0)
                    {
                        muveletiJel = '+';
                    }
                    else
                    {
                        muveletiJel = '-';
                    }
                }
                else if (checkBox1.Checked)
                {
                    muveletiJel = '+';
                }
                else
                {
                    muveletiJel = '-';
                }
                Feladat f = new Feladat(elsoSzam, masodikSzam, muveletiJel);
                textBox1.AppendText(f + "\r\n");
                textBox2.AppendText(f.Eredmeny() + "\r\n");
            }
        }
    }
}
