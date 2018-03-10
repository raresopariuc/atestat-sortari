using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Biblioteci
{
    public partial class Form1 : Form
    {

        public static Panel panel_main;
        
        public Form1()
        {
            InitializeComponent();
            panel_main = new Panel();
            Controls.Add(panel_main);
            panel_main.BringToFront();
            panel_main.Location = new Point(0, 24);
            panel_main.Name = "panel_main";
            panel_main.Anchor = AnchorStyles.None;
            panel_main.Size = new Size(1215, 599);
            //panel_main.Dock = DockStyle.Fill;
            panel_main.TabIndex = 6;

            panel_main.AutoScroll = true;

            var VectoriMain = new VectoriMain();
            panel_main.Controls.Add(VectoriMain);
            VectoriMain.Width = panel_main.Width;
            VectoriMain.Height = panel_main.Height;

        }
        private void deschidereFișierToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Deschide fișier";
            dialog.Filter = "TXT files|*.txt";
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                string nume_fisier = dialog.FileName, linie = File.ReadLines(nume_fisier).First().Trim();
                string[] cuv = linie.Split();
                double verif_numar;
                if (linie == "") { VectoriMain.vector_label3.Text = "Introduceți elemente în fișier!"; VectoriMain.UpdateLabel(); }
                else
                {
                    VectoriMain.vector_label3.Text = "";
                    VectoriMain.k = 0;
                    foreach (string x in cuv)
                    {
                        if (double.TryParse(x, out verif_numar))
                        {
                            VectoriMain.v[++VectoriMain.k] = Convert.ToDouble(x);
                            VectoriMain.vector_label3.Text += Convert.ToString(x) + "  ";
                        }
                        else
                        {
                            VectoriMain.k = 0;
                            VectoriMain.vector_label3.Text = "";
                            VectoriMain.vector_label3.Text = "Introduceți doar numere!";
                            VectoriMain.UpdateLabel();
                            break;
                        }
                        VectoriMain.UpdateLabel();
                    }
                }
            }
        }

        private void ieșireToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sunteți sigur că doriți să închideți?", "Ieșire", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
                
            }
        }

        private void despreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var Despre = new Despre();
            Despre.Show();
        }

        private void sortareSimplănaivăToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var Algoritm = new algoritm_naiva();
            Algoritm.Show();
        }

        private void bubbleSortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var Algoritm = new algoritm_bubble();
            Algoritm.Show();
        }

        private void sortarePrinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Algoritm = new algoritm_selectie();
            Algoritm.Show();
        }

        private void sortarePrinInserțieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var Algoritm = new algoritm_insertie();
            Algoritm.Show();
        }

        private void sortarePrinInterclasareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var Algoritm = new algoritm_interclasare();
            Algoritm.Show();
        }

        private void quickSortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var Algoritm = new algoritm_quicksort();
            Algoritm.Show();
        }

        
    }
}
