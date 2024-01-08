using System;
using System.Drawing;
using System.Windows.Forms;

namespace _006_Vizsga
{
    public partial class Form1 : Form
    {
        private Button[] gombok = new Button[5];
        private Random rnd = new Random();
        private int tet = 1, pontszam = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                gombok[i] = new Button();
                gombok[i].Text = (i + 1).ToString();
                gombok[i].Size = new Size(80, 40);
                gombok[i].Font = new Font("Arial", 14);
                gombok[i].Click += new EventHandler(Kattintas);
                this.Controls.Add(gombok[i]);
            }
            this.ClientSize = new Size(80 * 5 + 10, 500);
            Ujrainditas();
        }

        private void Ujrainditas()
        {
            for (int i = 0; i < 5; i++)
            {
                gombok[i].Location = new Point(i * 80 + 5, 40);
                gombok[i].BackColor = Color.Orange;
            }
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
        }

        private void Kattintas(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                Button btn = (Button)sender;
                btn.BackColor = Color.Red;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                timer1.Enabled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                tet = Convert.ToInt32(rb.Text);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = rnd.Next(5);
            gombok[i].Location = new Point(gombok[i].Location.X, gombok[i].Location.Y + 10);
            if (gombok[i].Location.Y + gombok[i].Size.Height >= this.ClientSize.Height)
            {
                timer1.Enabled = false;
                if (gombok[i].BackColor == Color.Red)
                {
                    pontszam += 10 * tet;
                }
                else
                {
                    pontszam -= tet;
                }
                label2.Text = "Pontszám: " + pontszam;
                if (i + 1 == 1 || i + 1 == 2 || i + 1 == 4)
                {
                    MessageBox.Show((i + 1) + "-es sorszámú gomb nyert!", "Vége", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (i + 1 == 3)
                {
                    MessageBox.Show((i + 1) + "-as sorszámú gomb nyert!", "Vége", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show((i + 1) + "-ös sorszámú gomb nyert!", "Vége", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Ujrainditas();
            }
        }
    }
}
