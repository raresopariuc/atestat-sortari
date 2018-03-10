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
    public partial class Sortari_functia_sort : UserControl
    {

        private double[] v = new double[100];
        private int k;

        public Sortari_functia_sort(double[] v, int k)
        {
            InitializeComponent();

            richTextBox1.Text = "";
            vector_functia_label1.Left = (this.ClientSize.Width - vector_functia_label1.Width) / 2;

            for (int i = 1; i <= k; i++)
            {
                this.v[i] = v[i];

                richTextBox1.Text += v[i] + "  ";
            }
            this.k = k;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }



        private void buton_inapoi_Click(object sender, EventArgs e)
        {
            Form1.panel_main.Controls.Remove(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Array.Sort(v, 1, k);
            richTextBox1.Text = "";
            for (int i = 1; i <= k; i++)
            {
                richTextBox1.Text += v[i] + "  ";
            }
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}
