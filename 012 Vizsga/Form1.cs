using System;
using System.Drawing;
using System.Windows.Forms;

namespace _012_Vizsga
{
    public partial class Form1 : Form
    {

        private Button[,] gombok = new Button[16, 16];
        private int feher = 256;
        private int fekete = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    gombok[i, j] = new Button();
                    gombok[i, j].Size = new Size(30, 30);
                    gombok[i, j].Location = new Point(j * 30, i * 30);
                    gombok[i, j].BackColor = Color.White;
                    gombok[i, j].Click += new EventHandler(Kattintas);
                    this.Controls.Add(gombok[i, j]);
                }
            }
        }

        private void Kattintas(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Black;
                feher--;
                fekete++;
            }
            else
            {
                btn.BackColor = Color.White;
                feher++;
                fekete--;
            }
            label1.Text = "Fehér képpontok száma: " + feher;
            label2.Text = "Fekete képpontok száma: " + fekete;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    gombok[i, j].BackColor = Color.White;
                }
            }
            feher = 256;
            fekete = 0;
            label1.Text = "Fehér képpontok száma: " + feher;
            label2.Text = "Fekete képpontok száma: " + fekete;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    gombok[i, j].BackColor = Color.Black;
                }
            }
            feher = 0;
            fekete = 256;
            label1.Text = "Fehér képpontok száma: " + feher;
            label2.Text = "Fekete képpontok száma: " + fekete;
        }

    }
}
