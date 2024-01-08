using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002_Vizsga
{
    public partial class Form1 : Form
    {

        int szamlalo = 1;
        Button[] gombok = new Button[25];
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Keveres()
        {
            for (int i = 0; i < 25; i++)
            {
                gombok[i].BackColor = Color.White;
                int j = rnd.Next(i, 25);
                string tmp = gombok[i].Text;
                gombok[i].Text = gombok[j].Text;
                gombok[j].Text = tmp;
            }
            szamlalo = 1;
            label1.Text = "Hol van a(z) " + szamlalo + " ?";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int k = 1;
            for (int i = 0; i < 25; i++)
            {
                gombok[i] = new Button();
                gombok[i].Size = new Size(60, 60);
                gombok[i].Location = new Point(i % 5 * 60, i / 5 * 60 + 45);
                gombok[i].Text = k.ToString();
                k++;
                gombok[i].Font = new Font("Arial", 20);
                gombok[i].Parent = this;
                gombok[i].Click += new EventHandler(Kattintas);
            }            
            this.ClientSize = new Size(5 * 60, 5 * 60 + 45);
            Keveres();
        }

        private void Kattintas(Object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (Convert.ToInt32(b.Text) == szamlalo)
            {
                b.BackColor = Color.Green;
                szamlalo++;
                if (szamlalo > 25)
                {
                    label1.Text = "Hurrá, sikerült kirakni!";
                    if (MessageBox.Show("Akarsz még egyet játszani?", "Játék vége!", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Keveres();
                    } else
                    {
                        this.Close();
                    }
                }
                else
                {
                    label1.Text = "Hol van a(z) " + szamlalo + " ?";
                }
            }
            else
            {
                b.BackColor = Color.Red;
                if (Convert.ToInt32(b.Text) < szamlalo)
                {
                    szamlalo = Convert.ToInt32(b.Text);
                    label1.Text = "Hol van a(z) " + szamlalo + " ?";
                    foreach (Button btn in gombok)
                    {
                        if (btn.BackColor == Color.Green && Convert.ToInt32(btn.Text) > szamlalo)
                        {
                            btn.BackColor = Color.Red;
                        }
                    }
                }
            }
        }
    }
}
