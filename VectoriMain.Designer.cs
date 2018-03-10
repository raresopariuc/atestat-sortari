namespace Biblioteci
{
    partial class VectoriMain
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.vector_label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.vector_send = new System.Windows.Forms.Button();
            this.sortare_simpla = new System.Windows.Forms.Button();
            this.bubble_sort = new System.Windows.Forms.Button();
            this.sortare_selectie = new System.Windows.Forms.Button();
            this.sortare_insertie = new System.Windows.Forms.Button();
            this.sortare_interclasare = new System.Windows.Forms.Button();
            this.quick_sort = new System.Windows.Forms.Button();
            this.functia_sort = new System.Windows.Forms.Button();
            this.comparatie_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buton_inapoi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vector_label1
            // 
            this.vector_label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vector_label1.AutoSize = true;
            this.vector_label1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vector_label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.vector_label1.Location = new System.Drawing.Point(327, 63);
            this.vector_label1.Name = "vector_label1";
            this.vector_label1.Size = new System.Drawing.Size(554, 30);
            this.vector_label1.TabIndex = 0;
            this.vector_label1.Text = "Introduceți elementele vectorului, separate prin câte un spațiu";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(373, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(416, 33);
            this.textBox1.TabIndex = 1;
            // 
            // vector_send
            // 
            this.vector_send.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vector_send.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.vector_send.FlatAppearance.BorderSize = 0;
            this.vector_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vector_send.Font = new System.Drawing.Font("Myriad Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.vector_send.Location = new System.Drawing.Point(789, 109);
            this.vector_send.Name = "vector_send";
            this.vector_send.Size = new System.Drawing.Size(34, 31);
            this.vector_send.TabIndex = 2;
            this.vector_send.Text = ">";
            this.vector_send.UseVisualStyleBackColor = false;
            this.vector_send.Click += new System.EventHandler(this.vector_send_Click);
            // 
            // sortare_simpla
            // 
            this.sortare_simpla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sortare_simpla.AutoSize = true;
            this.sortare_simpla.BackColor = System.Drawing.Color.Maroon;
            this.sortare_simpla.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.sortare_simpla.FlatAppearance.BorderSize = 0;
            this.sortare_simpla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortare_simpla.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortare_simpla.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sortare_simpla.Location = new System.Drawing.Point(426, 214);
            this.sortare_simpla.Name = "sortare_simpla";
            this.sortare_simpla.Size = new System.Drawing.Size(363, 36);
            this.sortare_simpla.TabIndex = 3;
            this.sortare_simpla.Text = "Sortare simplă (naivă)";
            this.sortare_simpla.UseVisualStyleBackColor = false;
            this.sortare_simpla.Click += new System.EventHandler(this.sortare_simpla_Click);
            // 
            // bubble_sort
            // 
            this.bubble_sort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bubble_sort.BackColor = System.Drawing.Color.Maroon;
            this.bubble_sort.FlatAppearance.BorderSize = 0;
            this.bubble_sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bubble_sort.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bubble_sort.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bubble_sort.Location = new System.Drawing.Point(426, 256);
            this.bubble_sort.Name = "bubble_sort";
            this.bubble_sort.Size = new System.Drawing.Size(363, 36);
            this.bubble_sort.TabIndex = 4;
            this.bubble_sort.Text = "Bubble Sort";
            this.bubble_sort.UseVisualStyleBackColor = false;
            this.bubble_sort.Click += new System.EventHandler(this.bubble_sort_Click);
            // 
            // sortare_selectie
            // 
            this.sortare_selectie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sortare_selectie.BackColor = System.Drawing.Color.Maroon;
            this.sortare_selectie.FlatAppearance.BorderSize = 0;
            this.sortare_selectie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortare_selectie.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortare_selectie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sortare_selectie.Location = new System.Drawing.Point(426, 298);
            this.sortare_selectie.Name = "sortare_selectie";
            this.sortare_selectie.Size = new System.Drawing.Size(363, 36);
            this.sortare_selectie.TabIndex = 5;
            this.sortare_selectie.Text = "Sortare prin selecție";
            this.sortare_selectie.UseVisualStyleBackColor = false;
            this.sortare_selectie.Click += new System.EventHandler(this.sortare_selectie_Click);
            // 
            // sortare_insertie
            // 
            this.sortare_insertie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sortare_insertie.BackColor = System.Drawing.Color.Maroon;
            this.sortare_insertie.FlatAppearance.BorderSize = 0;
            this.sortare_insertie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortare_insertie.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortare_insertie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sortare_insertie.Location = new System.Drawing.Point(426, 340);
            this.sortare_insertie.Name = "sortare_insertie";
            this.sortare_insertie.Size = new System.Drawing.Size(363, 36);
            this.sortare_insertie.TabIndex = 7;
            this.sortare_insertie.Text = "Sortare prin inserție";
            this.sortare_insertie.UseVisualStyleBackColor = false;
            this.sortare_insertie.Click += new System.EventHandler(this.sortare_insertie_Click);
            // 
            // sortare_interclasare
            // 
            this.sortare_interclasare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sortare_interclasare.BackColor = System.Drawing.Color.Maroon;
            this.sortare_interclasare.FlatAppearance.BorderSize = 0;
            this.sortare_interclasare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortare_interclasare.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortare_interclasare.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sortare_interclasare.Location = new System.Drawing.Point(426, 382);
            this.sortare_interclasare.Name = "sortare_interclasare";
            this.sortare_interclasare.Size = new System.Drawing.Size(363, 36);
            this.sortare_interclasare.TabIndex = 8;
            this.sortare_interclasare.Text = "Sortare prin interclasare";
            this.sortare_interclasare.UseVisualStyleBackColor = false;
            this.sortare_interclasare.Click += new System.EventHandler(this.sortare_interclasare_Click);
            // 
            // quick_sort
            // 
            this.quick_sort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quick_sort.BackColor = System.Drawing.Color.Maroon;
            this.quick_sort.FlatAppearance.BorderSize = 0;
            this.quick_sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quick_sort.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quick_sort.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.quick_sort.Location = new System.Drawing.Point(426, 424);
            this.quick_sort.Name = "quick_sort";
            this.quick_sort.Size = new System.Drawing.Size(363, 35);
            this.quick_sort.TabIndex = 9;
            this.quick_sort.Text = "Quick Sort";
            this.quick_sort.UseVisualStyleBackColor = false;
            this.quick_sort.Click += new System.EventHandler(this.quick_sort_Click);
            // 
            // functia_sort
            // 
            this.functia_sort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.functia_sort.BackColor = System.Drawing.Color.Maroon;
            this.functia_sort.FlatAppearance.BorderSize = 0;
            this.functia_sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.functia_sort.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functia_sort.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.functia_sort.Location = new System.Drawing.Point(426, 465);
            this.functia_sort.Name = "functia_sort";
            this.functia_sort.Size = new System.Drawing.Size(363, 35);
            this.functia_sort.TabIndex = 10;
            this.functia_sort.Text = "Funcția sort";
            this.functia_sort.UseVisualStyleBackColor = false;
            this.functia_sort.Click += new System.EventHandler(this.functia_sort_Click);
            // 
            // comparatie_label
            // 
            this.comparatie_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comparatie_label.AutoSize = true;
            this.comparatie_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comparatie_label.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comparatie_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.comparatie_label.Location = new System.Drawing.Point(494, 514);
            this.comparatie_label.Name = "comparatie_label";
            this.comparatie_label.Size = new System.Drawing.Size(228, 21);
            this.comparatie_label.TabIndex = 11;
            this.comparatie_label.Text = "Comparație între vitezele sortărilor";
            this.comparatie_label.Click += new System.EventHandler(this.comparatie_label_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buton_inapoi);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 599);
            this.panel1.TabIndex = 12;
            this.panel1.Visible = false;
            // 
            // buton_inapoi
            // 
            this.buton_inapoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buton_inapoi.AutoSize = true;
            this.buton_inapoi.BackColor = System.Drawing.Color.Firebrick;
            this.buton_inapoi.FlatAppearance.BorderSize = 0;
            this.buton_inapoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buton_inapoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_inapoi.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton_inapoi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buton_inapoi.Location = new System.Drawing.Point(1, 1);
            this.buton_inapoi.Name = "buton_inapoi";
            this.buton_inapoi.Size = new System.Drawing.Size(122, 46);
            this.buton_inapoi.TabIndex = 6;
            this.buton_inapoi.Text = "< înapoi";
            this.buton_inapoi.UseVisualStyleBackColor = false;
            this.buton_inapoi.Visible = false;
            this.buton_inapoi.Click += new System.EventHandler(this.buton_inapoi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biblioteci.Properties.Resources.viteze_sortari1;
            this.pictureBox1.Location = new System.Drawing.Point(119, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(989, 499);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // VectoriMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.Controls.Add(this.comparatie_label);
            this.Controls.Add(this.functia_sort);
            this.Controls.Add(this.quick_sort);
            this.Controls.Add(this.sortare_interclasare);
            this.Controls.Add(this.sortare_insertie);
            this.Controls.Add(this.sortare_selectie);
            this.Controls.Add(this.bubble_sort);
            this.Controls.Add(this.sortare_simpla);
            this.Controls.Add(this.vector_send);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.vector_label1);
            this.Controls.Add(this.panel1);
            this.Name = "VectoriMain";
            this.Size = new System.Drawing.Size(1215, 599);
            this.Load += new System.EventHandler(this.VectoriMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vector_label1;
        private System.Windows.Forms.Button vector_send;
        private System.Windows.Forms.Button sortare_simpla;
        private System.Windows.Forms.Button bubble_sort;
        private System.Windows.Forms.Button sortare_selectie;
        private System.Windows.Forms.Button sortare_insertie;
        private System.Windows.Forms.Button sortare_interclasare;
        private System.Windows.Forms.Button quick_sort;
        private System.Windows.Forms.Button functia_sort;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label comparatie_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buton_inapoi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
