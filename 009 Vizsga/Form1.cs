using System;
using System.Drawing;
using System.Windows.Forms;

namespace _009_Vizsga
{
    public partial class Form1 : Form
    {

        private Button[,] gombok = new Button[3, 3];
        private Color[,] szinek = new Color[3, 3];
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gombok[i, j] = new Button();
                    gombok[i, j].Size = new Size(60, 60);
                    gombok[i, j].Location = new Point(i * 65 + 5, j * 65 + 5);
                    gombok[i, j].Text = "";
                    gombok[i, j].Click += new EventHandler(Kattintas);
                    this.Controls.Add(gombok[i, j]);
                }
            }
            SzinGeneralas();
        }

        private void SzinGeneralas()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gombok[i, j].BackColor = Color.White;
                    switch (rnd.Next(2))
                    {
                        case 0:
                            szinek[i, j] = Color.Red;
                            break;
                        case 1:
                            szinek[i, j] = Color.LightGreen;
                            break;
                    }
                }
            }
        }

        private void Kattintas(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Red;
            }
            else if (btn.BackColor == Color.Red)
            {
                btn.BackColor = Color.LightGreen;
            }
            else
            {
                btn.BackColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool sikeres = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (gombok[i, j].BackColor != szinek[i, j])
                    {
                        sikeres = false;
                        gombok[i, j].BackColor = Color.White;
                    }
                }
            }
            if (sikeres)
            {
                MessageBox.Show("Hurrá, sikerült kinyitnod a széfet!", "Vége", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SzinGeneralas();
            }
        }

    }
}