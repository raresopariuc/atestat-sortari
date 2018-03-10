﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteci
{
    public partial class Sortari_simpla : UserControl
    {

        private double[] v = new double[100];
        private int k;

        public Sortari_simpla(double[] v, int k)
        {
            InitializeComponent();

            richTextBox1.Text = "";
            vector_simpla_label1.Left = (this.ClientSize.Width - vector_simpla_label1.Width) / 2;

            for (int i = 1; i <= k; i++)
            {
                this.v[i] = v[i];
                
                richTextBox1.Text += v[i] + "  ";
            }
            this.k = k;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void afis()
        {
            richTextBox1.Text = "";
            for (int i = 1; i <= k; i++)
            {
                richTextBox1.Text += v[i] + "  ";
            }
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j;
            for (i = 1; i < k; ++i)
                for (j = i + 1; j <= k; ++j)
                    if (v[i] > v[j])
                    {
                        v[0] = v[i];
                        v[i] = v[j];
                        v[j] = v[0];

                        if (checkBox1.Checked == true)
                        {
                            afis();
                            Application.DoEvents();
                            if (radioButton1.Checked == true)
                                System.Threading.Thread.Sleep(200);
                            else
                                System.Threading.Thread.Sleep(900);
                        }
                    }

            if (checkBox1.Checked == false)
            {
                richTextBox1.Text = "";
                for (i = 1; i <= k; i++)
                {
                    richTextBox1.Text += v[i] + "  ";
                }
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        private void buton_inapoi_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form1.panel_main.Controls.Remove(this);
        }

        private void algoritm_simpla_Click(object sender, EventArgs e)
        {
            var Algoritm = new algoritm_naiva();
            Algoritm.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == false)
            {
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
            }
            else
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
            }
        }
    }
}
