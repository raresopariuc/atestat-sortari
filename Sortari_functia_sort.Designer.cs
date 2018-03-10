namespace Biblioteci
{
    partial class Sortari_functia_sort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sortari_functia_sort));
            this.buton_inapoi = new System.Windows.Forms.Button();
            this.vector_functia_label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buton_inapoi
            // 
            this.buton_inapoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buton_inapoi.AutoSize = true;
            this.buton_inapoi.BackColor = System.Drawing.Color.Firebrick;
            this.buton_inapoi.FlatAppearance.BorderSize = 0;
            this.buton_inapoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buton_inapoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_inapoi.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton_inapoi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buton_inapoi.Location = new System.Drawing.Point(0, 0);
            this.buton_inapoi.Name = "buton_inapoi";
            this.buton_inapoi.Size = new System.Drawing.Size(122, 46);
            this.buton_inapoi.TabIndex = 7;
            this.buton_inapoi.Text = "< înapoi";
            this.buton_inapoi.UseVisualStyleBackColor = false;
            this.buton_inapoi.Click += new System.EventHandler(this.buton_inapoi_Click);
            // 
            // vector_functia_label1
            // 
            this.vector_functia_label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vector_functia_label1.AutoSize = true;
            this.vector_functia_label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vector_functia_label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.vector_functia_label1.Location = new System.Drawing.Point(546, 45);
            this.vector_functia_label1.Name = "vector_functia_label1";
            this.vector_functia_label1.Size = new System.Drawing.Size(127, 30);
            this.vector_functia_label1.TabIndex = 8;
            this.vector_functia_label1.Text = "Funcția sort";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox1.BackColor = System.Drawing.Color.Firebrick;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox1.Location = new System.Drawing.Point(0, 525);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1215, 31);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "aici apare vectorul initial, apoi cel sortat(rich)";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(552, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "Sortează";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(36, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1142, 397);
            this.label1.TabIndex = 15;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Sortari_functia_sort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.vector_functia_label1);
            this.Controls.Add(this.buton_inapoi);
            this.Name = "Sortari_functia_sort";
            this.Size = new System.Drawing.Size(1215, 599);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buton_inapoi;
        private System.Windows.Forms.Label vector_functia_label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}
