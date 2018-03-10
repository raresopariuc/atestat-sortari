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
    public partial class algoritm_naiva : Form
    {
        public algoritm_naiva()
        {
            InitializeComponent();
            this.TopMost = true;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(label1.Text);
        }
    }
}
