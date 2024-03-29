﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _017_Vizsga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IdegenSzo sz = new IdegenSzo(textBox1.Text, textBox2.Text, comboBox1.Text);
            listBox1.Items.Add(sz);
            listBox1.SelectedItem = sz;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IdegenSzo sz = new IdegenSzo(textBox1.Text, textBox2.Text, comboBox1.Text);
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox1.Items.Add(sz);
            listBox1.SelectedItem = sz;            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                IdegenSzo sz = (IdegenSzo)listBox1.SelectedItem;
                textBox1.Text = sz.GetSzo();
                textBox2.Text = sz.GetJelentese();
                comboBox1.Text = sz.GetEredete();
                if (textBox1.Text.Trim().Length > 0 && textBox2.Text.Trim().Length > 0)
                {
                    button2.Enabled = true;
                }
                button3.Enabled = true;
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length > 0 && textBox2.Text.Trim().Length > 0)
            {
                button1.Enabled = true;
                if (listBox1.SelectedIndex >= 0)
                {
                    button2.Enabled = true;
                }
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }
    }
}
