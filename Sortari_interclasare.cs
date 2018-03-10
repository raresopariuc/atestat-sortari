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
    public partial class Sortari_interclasare : UserControl
    {

        private double[] v = new double[100];
        private int k;

        public Sortari_interclasare(double[] v, int k)
        {
            InitializeComponent();
            richTextBox1.Text = "";
            vector_interclasare_label1.Left = (this.ClientSize.Width - vector_interclasare_label1.Width) / 2;

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

        private void inter(int i, int m, int j)
        {
            int x = i, k = 0, y = m + 1;
            double[] z = new double[100];
            while (x <= m && y <= j)
                if (v[x] < v[y]) z[++k] = v[x++];
                else z[++k] = v[y++];
            while (x <= m) z[++k] = v[x++];
            while (y <= j) z[++k] = v[y++];
            int p = i;
            for (k = 1; k <= j - i + 1; k++)
                v[p++] = z[k];

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

        private void sort(int i, int j)
        {
            if (i < j)
            {
                int m = (i + j) / 2;
                sort(i, m);
                sort(m + 1, j);
                inter(i, m, j);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sort(1, k);

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
            var Algoritm = new algoritm_interclasare();
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
