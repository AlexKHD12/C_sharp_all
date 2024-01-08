using System;
using System.Drawing;
using System.Windows.Forms;

namespace _005_Vizsga
{
    public partial class Form1 : Form
    {
        private int szam1, szam2, helyes = 0, helytelen = 0;
        private Random rnd = new Random();
        private SolidBrush piros = new SolidBrush(Color.Red);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            UjFeladat();
        }

        private void UjFeladat()
        {
            szam1 = rnd.Next(1, 11);
            szam2 = rnd.Next(1, 11);
            label1.Text = "Mennyi " + szam1 + " x " + szam2 + " ?";
            // gombokra a szamok kigeneralasa
            int[] a = new int[4];
            a[0] = szam1 * szam2;
            for (int i = 1; i < 4; i++)
            {
                bool volt;
                do
                {
                    a[i] = rnd.Next(1, 101);
                    volt = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (a[i] == a[j])
                        {
                            volt = true;
                        }
                    }
                } while (volt);
            }
            // szamok oszekeverese
            for (int i = 0; i < 4; i++)
            {
                int j = rnd.Next(i, 4);
                int tmp = a[i];
                a[i] = a[j];
                a[j] = tmp;
            }
            // szamok rairasa a gombokra
            button1.Text = a[0].ToString();
            button2.Text = a[1].ToString();
            button3.Text = a[2].ToString();
            button4.Text = a[3].ToString();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            // ujrarajzolas
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < szam2; i++)
            {
                for (int j = 0; j < szam1; j++)
                {
                    Rectangle negyzet = new Rectangle(i * 40 + 5, j * 40 + 5, 38, 38);
                    g.FillRectangle(piros, negyzet);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (Convert.ToInt32(btn.Text) == szam1 * szam2)
            {
                UjFeladat();
                helyes++;
                label2.Text = "Helyes válaszok száma: " + helyes;
            }
            else
            {
                btn.Enabled = false;
                helytelen++;
                label3.Text = "Helytelen válaszok száma: " + helytelen;
            }
        }
    }
}
