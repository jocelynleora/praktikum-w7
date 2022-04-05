namespace praktikum_w7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_input = new System.Windows.Forms.Label();
            this.lbl_hurufAwal = new System.Windows.Forms.Label();
            this.lbl_hurufAkhir = new System.Windows.Forms.Label();
            this.lblHasil = new System.Windows.Forms.Label();
            this.lbl_output = new System.Windows.Forms.Label();
            this.tbox_input = new System.Windows.Forms.TextBox();
            this.tbox_hurufAwal = new System.Windows.Forms.TextBox();
            this.tbox_hurufAkhir = new System.Windows.Forms.TextBox();
            this.btn_konversi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.Location = new System.Drawing.Point(69, 56);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(107, 15);
            this.lbl_input.TabIndex = 0;
            this.lbl_input.Text = "Masukkan Kalimat:";
            // 
            // lbl_hurufAwal
            // 
            this.lbl_hurufAwal.AutoSize = true;
            this.lbl_hurufAwal.Location = new System.Drawing.Point(69, 99);
            this.lbl_hurufAwal.Name = "lbl_hurufAwal";
            this.lbl_hurufAwal.Size = new System.Drawing.Size(98, 15);
            this.lbl_hurufAwal.TabIndex = 1;
            this.lbl_hurufAwal.Text = "Masukkan Huruf:";
            // 
            // lbl_hurufAkhir
            // 
            this.lbl_hurufAkhir.AutoSize = true;
            this.lbl_hurufAkhir.Location = new System.Drawing.Point(274, 99);
            this.lbl_hurufAkhir.Name = "lbl_hurufAkhir";
            this.lbl_hurufAkhir.Size = new System.Drawing.Size(50, 15);
            this.lbl_hurufAkhir.TabIndex = 2;
            this.lbl_hurufAkhir.Text = "Menjadi";
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Location = new System.Drawing.Point(69, 191);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(36, 15);
            this.lblHasil.TabIndex = 3;
            this.lblHasil.Text = "Hasil:";
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Location = new System.Drawing.Point(175, 191);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(39, 15);
            this.lbl_output.TabIndex = 4;
            this.lbl_output.Text = "HASIL";
            // 
            // tbox_input
            // 
            this.tbox_input.Location = new System.Drawing.Point(182, 53);
            this.tbox_input.Name = "tbox_input";
            this.tbox_input.Size = new System.Drawing.Size(217, 23);
            this.tbox_input.TabIndex = 5;
            // 
            // tbox_hurufAwal
            // 
            this.tbox_hurufAwal.Location = new System.Drawing.Point(182, 96);
            this.tbox_hurufAwal.Name = "tbox_hurufAwal";
            this.tbox_hurufAwal.Size = new System.Drawing.Size(69, 23);
            this.tbox_hurufAwal.TabIndex = 6;
            // 
            // tbox_hurufAkhir
            // 
            this.tbox_hurufAkhir.Location = new System.Drawing.Point(330, 96);
            this.tbox_hurufAkhir.Name = "tbox_hurufAkhir";
            this.tbox_hurufAkhir.Size = new System.Drawing.Size(69, 23);
            this.tbox_hurufAkhir.TabIndex = 7;
            // 
            // btn_konversi
            // 
            this.btn_konversi.Location = new System.Drawing.Point(182, 147);
            this.btn_konversi.Name = "btn_konversi";
            this.btn_konversi.Size = new System.Drawing.Size(217, 23);
            this.btn_konversi.TabIndex = 8;
            this.btn_konversi.Text = "Konversi";
            this.btn_konversi.UseVisualStyleBackColor = true;
            this.btn_konversi.Click += new System.EventHandler(this.btn_konversi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_konversi);
            this.Controls.Add(this.tbox_hurufAkhir);
            this.Controls.Add(this.tbox_hurufAwal);
            this.Controls.Add(this.tbox_input);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.lbl_hurufAkhir);
            this.Controls.Add(this.lbl_hurufAwal);
            this.Controls.Add(this.lbl_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_input;
        private Label lbl_hurufAwal;
        private Label lbl_hurufAkhir;
        private Label lblHasil;
        private Label lbl_output;
        private TextBox tbox_input;
        private TextBox tbox_hurufAwal;
        private TextBox tbox_hurufAkhir;
        private Button btn_konversi;
    }
}