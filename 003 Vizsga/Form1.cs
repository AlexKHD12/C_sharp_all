using System;
using System.Windows.Forms;

namespace _003_Vizsga
{
    public partial class Form1 : Form
    {
        private string beirtKod = "";
        private string kitalalandoKod = "";
        private int tipp;
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void kodGeneralas()
        {
            kitalalandoKod = "";
            for (int i = 0; i < 4; i++)
            {
                kitalalandoKod += (char)rnd.Next(65, 70);
            }
            tipp = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kodGeneralas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            beirtKod = beirtKod + btn.Text;
            label1.Text = "Kód: " + beirtKod;
            if (beirtKod.Length == 4)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            tipp++;
            string s = tipp + ". tipp: ";
            for (int i = 0; i < 4; i++)
            {
                if (kitalalandoKod[i] == beirtKod[i])
                {
                    s += kitalalandoKod[i];
                }
                else
                {
                    s += "*";
                }
            }
            listBox1.Items.Insert(0, s);
            listBox1.SelectedIndex = 0;
            if (kitalalandoKod == beirtKod || tipp==5)
            {
                DialogResult valasz;
                if (kitalalandoKod == beirtKod)
                {
                    valasz = MessageBox.Show("Sikerült kitalálnod! Szeretnél még egyet játszani?",
                        "Játék vége", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
                else
                {
                    valasz = MessageBox.Show("Nem sikerült 5 próbálkozásból kitalálnod! Szeretnél még egyet játszani?",
                        "Játék vége", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
                if (valasz == DialogResult.Yes)
                {
                    listBox1.Items.Clear();
                    kodGeneralas();
                }
                else
                {
                    this.Close();
                }
            }
            beirtKod = "";
            label1.Text = "Kód: ";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
        }

    }
}