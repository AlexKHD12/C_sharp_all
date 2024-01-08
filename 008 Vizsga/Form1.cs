using System;
using System.Drawing;
using System.Windows.Forms;

namespace _008_Vizsga
{
    public partial class Form1 : Form
    {
        private Button[] gombok = new Button[20];
        private int szam1 = 0;
        private int szam2 = 0;
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void UjFeladat()
        {
            szam1 = rnd.Next(10) + 1;
            szam2 = rnd.Next(10) + 1;
            label1.Text = "Első szám: " + szam1;
            label2.Text = "Második szám: " + szam2;
            for (int i = 0; i < 20; i++)
            {
                gombok[i].BackColor = Color.White;
            }
            this.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int k = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    gombok[k] = new Button();
                    gombok[k].Size = new Size(50, 50);
                    gombok[k].Location = new Point(i * 55 + 5, j * 55 + 250);
                    gombok[k].Text = (i + j * 10 + 1).ToString();
                    gombok[k].Click += new EventHandler(Kattintas);
                    this.Controls.Add(gombok[k]);
                    k++;
                }
            }
            UjFeladat();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush zold = new SolidBrush(Color.Green);
            for (int i = 0; i < szam1; i++)
            {
                g.FillEllipse(zold, i * 45 + 10, 40, 40, 40);
            }
            for (int i = 0; i < szam2; i++)
            {
                g.FillEllipse(zold, i * 45 + 10, 137, 40, 40);
            }
        }

        private void Kattintas(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (Convert.ToInt32(b.Text) == szam1 + szam2)
            {
                UjFeladat();
            }
            else
            {
                b.BackColor = Color.Red;
            }
        }

    }
}
