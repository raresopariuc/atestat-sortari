using System;
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
    public partial class Sortari_quicksort : UserControl
    {

        private double[] v = new double[100];
        private int k;

        public Sortari_quicksort(double[] v, int k)
        {
            InitializeComponent();
            richTextBox1.Text = "";
            vector_quicksort_label1.Left = (this.ClientSize.Width - vector_quicksort_label1.Width) / 2;

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

        private int pivot(int i, int j)
        {
            int p, q;
            double x;
            p = i; q = j;
            x = v[i];
            while (p < q)
            {
                while (p < q && x <= v[q]) q--;
                v[p] = v[q];

                while (p < q && x >= v[p]) p++;
                v[q] = v[p];

            }
            v[p] = x;

            if (checkBox1.Checked == true)
            {
                afis();
                Application.DoEvents();
                if (radioButton1.Checked == true)
                    System.Threading.Thread.Sleep(200);
                else
                    System.Threading.Thread.Sleep(900);
            }

            return p;
        }

        private void quick(int i, int j)
        {
            int m;
            if(i<= j)
            {
                m = pivot(i, j);
                quick(i, m - 1);
                quick(m + 1, j);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            quick(1, k);

            if (checkBox1.Checked == false)
            {
                richTextBox1.Text = "";
                for (int i = 1; i <= k; i++)
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

        private void algoritm_interclasare_Click(object sender, EventArgs e)
        {
            var Algoritm = new algoritm_quicksort();
            Algoritm.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
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
