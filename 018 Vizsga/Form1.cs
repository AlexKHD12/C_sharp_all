using System;
using System.Windows.Forms;

namespace _018_Vizsga
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private string mertekegysegGeneralas()
        {
            string m = "";
            do
            {
                switch (rnd.Next(5))
                {
                    case 0:
                        if (checkBox1.Checked)
                        {
                            m = "mm";
                        }
                        break;
                    case 1:
                        if (checkBox2.Checked)
                        {
                            m = "cm";
                        }
                        break;
                    case 2:
                        if (checkBox3.Checked)
                        {
                            m = "dm";
                        }
                        break;
                    case 3:
                        if (checkBox4.Checked)
                        {
                            m = "m";
                        }
                        break;
                    case 4:
                        if (checkBox5.Checked)
                        {
                            m = "km";
                        }
                        break;
                }
            }
            while (m == "");
            return m;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            for (int i = 1; i <= 10; i++)
            {
                int szam1 = rnd.Next(1, (int)numericUpDown1.Value + 1);
                int szam2 = rnd.Next(1, (int)numericUpDown2.Value + 1);
                Feladat f = new Feladat(szam1, mertekegysegGeneralas(),
                                        szam2, mertekegysegGeneralas());
                textBox1.AppendText(i + ". " + f + "\r\n");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked
                || checkBox4.Checked || checkBox5.Checked)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
