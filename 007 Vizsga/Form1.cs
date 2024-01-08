using System;
using System.IO;
using System.Windows.Forms;

namespace _007_Vizsga
{
    public partial class Form1 : Form
    {
        private const string FILENEV = "zeneszamok.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            if (File.Exists(FILENEV))
            {
                StreamReader sr = File.OpenText(FILENEV);
                string eloado;
                while ((eloado = sr.ReadLine()) != null) {
                    string cim = sr.ReadLine();
                    int perc = Convert.ToInt32(sr.ReadLine());
                    int masodperc = Convert.ToInt32(sr.ReadLine());
                    Zeneszam z = new Zeneszam(eloado, cim, perc, masodperc);
                    listBox1.Items.Add(z);
                }
                sr.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = File.CreateText(FILENEV);
            for (int i=0; i<listBox1.Items.Count; i++)
            {
                Zeneszam z = (Zeneszam)listBox1.Items[i];
                sw.WriteLine(z.GetEloado());
                sw.WriteLine(z.GetCim());                
                sw.WriteLine(z.GetPerc());
                sw.WriteLine(z.GetMasodperc());
            }
            sw.Close();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Zeneszam z = new Zeneszam(textBox1.Text, textBox2.Text, 
                                      Convert.ToInt32(textBox3.Text), 
                                      Convert.ToInt32(textBox4.Text));
            listBox1.Items.Add(z);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
