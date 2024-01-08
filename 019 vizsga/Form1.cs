using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _019_vizsga
{
    public partial class Form1 : Form
    {
        private Button[,] gombok = new Button[3,4];
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Keveres()
        {
            for (int i=0; i<4; i++)
            {
                int r = rnd.Next(0, 3);
                for (int j=0; j<=r; j++)
                {
                    Szinvaltas(i);
                }
            }
        }

        private void Szinvaltas(int oszlop)
        {
            if (gombok[0, oszlop].BackColor == Color.Red
               && gombok[1, oszlop].BackColor == Color.Black)
            {
                gombok[1, oszlop].BackColor = Color.Yellow;
            }
            else if (gombok[0, oszlop].BackColor == Color.Red
                && gombok[1, oszlop].BackColor == Color.Yellow)
            {
                gombok[0, oszlop].BackColor = Color.Black;
                gombok[1, oszlop].BackColor = Color.Black;
                gombok[2, oszlop].BackColor = Color.Green;
            }
            else if (gombok[2, oszlop].BackColor == Color.Green)
            {
                gombok[1, oszlop].BackColor = Color.Yellow;
                gombok[2, oszlop].BackColor = Color.Black;
            }
            else
            {
                gombok[0, oszlop].BackColor = Color.Red;
                gombok[1, oszlop].BackColor = Color.Black;
            }
        }

        private void Kattintas(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int oszlop = b.Location.X / 100;
            Szinvaltas(oszlop);
            Ellenorzes();
        }

        private void Ellenorzes()
        {
            bool megoldva = true;
            // minden piros (elso sor piros, masodik fekete)?
            for (int i=0; i<4; i++)
            {
                if (gombok[0,i].BackColor!=Color.Red || gombok[1,i].BackColor!=Color.Black)
                {
                    megoldva = false;
                }
            }
            // ha megoldva, ujrakeveres
            if (megoldva)
            {
                MessageBox.Show("Sikerült mindent pirosra állítani!", "Megoldva!");
                Keveres();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // eventhandler objektum
            EventHandler eh = new EventHandler(Kattintas);
            // gombok letrehozasa
            for (int i=0; i<3; i++)
            {
                for (int j=0; j<4; j++)
                {
                    gombok[i, j] = new Button();
                    gombok[i, j].Size = new Size(100, 100);
                    gombok[i, j].Location = new Point(j * 100, i * 100);
                    if (i==0) { gombok[i, j].BackColor = Color.Red; }
                    else { gombok[i, j].BackColor = Color.Black; }
                    gombok[i, j].Click += eh;
                    this.Controls.Add(gombok[i, j]);
                }
            }
            // form beallitasa
            this.ClientSize = new Size(400, 300);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            // keveres
            Keveres();
        }
    }
}
