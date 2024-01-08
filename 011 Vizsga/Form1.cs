using System;
using System.Drawing;
using System.Windows.Forms;

namespace _011_Vizsga
{
    public partial class Form1 : Form
    {

        private Button[] gombok = new Button[10];
        private Random rnd = new Random();
        private string kitalalandoSzam, eddigKitalaltSzam;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                gombok[i] = new Button();
                gombok[i].Size = new Size(30, 30);
                gombok[i].Location = new Point(i * 35 + 15, 120);
                gombok[i].BackColor = Color.White;
                gombok[i].Text = i.ToString();
                gombok[i].Click += new EventHandler(Kattintas);
                this.Controls.Add(gombok[i]);
            }
            UjSzamGeneralasa();
        }

        private void UjSzamGeneralasa()
        {
            kitalalandoSzam = rnd.Next(1000000, 10000000).ToString();
            for (int i = 0; i < 10; i++)
            {
                gombok[i].BackColor = Color.White;
            }
            eddigKitalaltSzam = "*******";
            label2.Text = eddigKitalaltSzam;
        }

        private void Kattintas(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            bool vanTalalat = false;
            string s = "";
            for (int i = 0; i < kitalalandoSzam.Length; i++)
            {
                if (b.Text == kitalalandoSzam[i].ToString())
                {
                    s = s + kitalalandoSzam[i];
                    vanTalalat = true;
                }
                else
                {
                    s = s + eddigKitalaltSzam[i];
                }
            }
            eddigKitalaltSzam = s;
            label2.Text = eddigKitalaltSzam;
            if (vanTalalat)
            {
                b.BackColor = Color.Green;
            }
            else
            {
                b.BackColor = Color.Red;
            }
            if (eddigKitalaltSzam == kitalalandoSzam)
            {
                MessageBox.Show("Sikerült kitalálnod a számot!", "Vége", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UjSzamGeneralasa();
            }
        }
    }
}
