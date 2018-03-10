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
    public partial class VectoriMain : UserControl
    {

        public string[] cuv;
        public static double[] v = new double[100];
        public static int k = 0;
        public static Label vector_label3 = new Label();

        public VectoriMain()
        {
            InitializeComponent();
        }

        public static void UpdateLabel()
        {
            vector_label3.Width = TextRenderer.MeasureText(vector_label3.Text, vector_label3.Font).Width;
            vector_label3.Height = TextRenderer.MeasureText(vector_label3.Text, vector_label3.Font).Height;
            vector_label3.Left = (vector_label3.Parent.Size.Width - vector_label3.Width) / 2;
        }

        private void VectoriMain_Load(object sender, EventArgs e)
        {
            vector_label3.Font = new Font("Segoe UI Light", 16);
            vector_label3.AutoSize = false;
            vector_label3.Top = 155;
            vector_label3.Show();
            vector_label3.BringToFront();
            vector_label3.Visible = true;
            vector_label3.ForeColor = SystemColors.Window;
            vector_label3.Anchor = AnchorStyles.None;
            this.Controls.Add(vector_label3);

            vector_label1.Left = (this.ClientSize.Width - vector_label1.Width) / 2;
            textBox1.Left = (this.ClientSize.Width - textBox1.Width - vector_send.Width) / 2;
            vector_send.Left = (this.ClientSize.Width - vector_send.Width + textBox1.Width) / 2;
        }

        private void vector_send_Click(object sender, EventArgs e)
        {
            k = 0;
            vector_label3.Text = "";
            textBox1.Text = textBox1.Text.Trim();
            double verif_numar;
            cuv = textBox1.Text.Split();
            if (textBox1.Text == "") { vector_label3.Text = "Introduceți elemente în câmpul de mai sus!"; UpdateLabel(); }
            else
            {
                foreach (string x in cuv)
                {
                    if (double.TryParse(x, out verif_numar))
                    {
                        v[++k] = Convert.ToDouble(x);
                        vector_label3.Text += x + "  ";
                    }
                    else
                    {
                        k = 0;
                        vector_label3.Text = "Introduceți doar numere!";
                        break;
                    }
                }
                UpdateLabel();
            }
        }

        private void sortare_simpla_Click(object sender, EventArgs e)
        {
            if (k == 0) { vector_label3.Text = "Nu există elemente în vector!"; UpdateLabel(); }
            else
            {
                var Sortari_simpla = new Sortari_simpla(v, k);
                Form1.panel_main.Controls.Add(Sortari_simpla);
                Sortari_simpla.Show();
                Sortari_simpla.BringToFront();
            }
        }

        private void bubble_sort_Click(object sender, EventArgs e)
        {
            if (k == 0) { vector_label3.Text = "Nu există elemente în vector!"; UpdateLabel(); }
            else
            {
                var Sortari_bubble = new Sortari_bubble(v, k);

                Form1.panel_main.Controls.Add(Sortari_bubble);

                Sortari_bubble.Show();
                Sortari_bubble.BringToFront();
            }
        }

        private void sortare_selectie_Click(object sender, EventArgs e)
        {
            if (k == 0) { vector_label3.Text = "Nu există elemente în vector!"; UpdateLabel(); }
            else
            {
                var Sortari_selectie = new Sortari_selectie(v, k);
                Form1.panel_main.Controls.Add(Sortari_selectie);
                Sortari_selectie.Show();
                Sortari_selectie.BringToFront();
            }
        }

        private void sortare_insertie_Click(object sender, EventArgs e)
        {
            if (k == 0) { vector_label3.Text = "Nu există elemente în vector!"; UpdateLabel(); }
            else
            {
                var Sortari_insertie = new Sortari_insertie(v, k);
                Form1.panel_main.Controls.Add(Sortari_insertie);
                Sortari_insertie.Show();
                Sortari_insertie.BringToFront();
            }
        }

        private void sortare_interclasare_Click(object sender, EventArgs e)
        {
            if (k == 0) { vector_label3.Text = "Nu există elemente în vector!"; UpdateLabel(); }
            else
            {
                var Sortari_interclasare = new Sortari_interclasare(v, k);
                Form1.panel_main.Controls.Add(Sortari_interclasare);
                Sortari_interclasare.Show();
                Sortari_interclasare.BringToFront();
            }
        }

        private void quick_sort_Click(object sender, EventArgs e)
        {
            if (k == 0) { vector_label3.Text = "Nu există elemente în vector!"; UpdateLabel(); }
            else
            {
                var Sortari_quicksort = new Sortari_quicksort(v, k);
                Form1.panel_main.Controls.Add(Sortari_quicksort);
                Sortari_quicksort.Show();
                Sortari_quicksort.BringToFront();
            }
        }

        private void functia_sort_Click(object sender, EventArgs e)
        {
            if (k == 0) { vector_label3.Text = "Nu există elemente în vector!"; UpdateLabel(); }
            else
            {
                var Functia_sort = new Sortari_functia_sort(v, k);
                Form1.panel_main.Controls.Add(Functia_sort);
                Functia_sort.Show();
                Functia_sort.BringToFront();
            }
        }

        private void buton_inapoi_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            buton_inapoi.Hide();
        }

        private void comparatie_label_Click(object sender, EventArgs e)
        {
            panel1.Show();
            buton_inapoi.Show();
            panel1.BringToFront();
        }
    }
}
