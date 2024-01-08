using System;
using System.Drawing;
using System.Windows.Forms;

namespace _004_Vizsga
{
    public partial class Form1 : Form
    {
        private Button[,] gombok = new Button[10, 10];
        private Random rnd = new Random();
        private int eredmeny, helyes = 0, helytelen = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void UjFeladat()
        {
            int a = rnd.Next(1, 11);
            int b = rnd.Next(1, 11);
            eredmeny = a * b;
            label1.Text = "Mennyi " + a + " x " + b + " ?";
        }

        private void GombokFeherreSzinezese()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    gombok[i, j].BackColor = Color.White;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    gombok[i, j] = new Button();
                    gombok[i, j].Size = new Size(50, 50);
                    gombok[i, j].Location = new Point(j * 50, i * 50 + 50);
                    gombok[i, j].Font = new Font("Arial", 12);
                    gombok[i, j].Text = ((i + 1) * (j + 1)).ToString();
                    gombok[i, j].BackColor = Color.White;
                    gombok[i, j].Click += new EventHandler(Kattintas);
                    this.Controls.Add(gombok[i, j]);
                }
            }
            this.ClientSize = new Size(500, 550);
            GombokFeherreSzinezese();
            UjFeladat();
        }

        private void Kattintas(object sender, EventArgs args)
        {
            Button btn = (Button)sender;
            GombokFeherreSzinezese();
            if (eredmeny.ToString() == btn.Text)
            {
                int x = btn.Location.X / 50;
                int y = (btn.Location.Y - 50) / 50;
                for (int i = 0; i <= y; i++)
                {
                    for (int j = 0; j <= x; j++)
                    {
                        gombok[i, j].BackColor = Color.Orange;
                    }
                }
                helyes++;
                label2.Text = "Helyes válaszok száma: " + helyes;
                if (helyes == 10)
                {
                    if (MessageBox.Show("Hurrá, sikerült 10 feladatot helyesen megoldanod! Szeretnél játszani még egyet?",
                        "Vége", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        GombokFeherreSzinezese();
                        helyes = 0;
                        helytelen = 0;
                        label2.Text = "Helyes válaszok száma: " + helyes;
                        label3.Text = "Helytelen válaszok száma: " + helytelen;
                    }
                    else
                    {
                        this.Close();
                    }
                }
                UjFeladat();
            }
            else
            {
                helytelen++;
                label3.Text = "Helytelen válaszok száma: " + helytelen;               
            }            
        }
    }
}