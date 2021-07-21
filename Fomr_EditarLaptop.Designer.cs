
namespace App
{
    partial class Fomr_EditarLaptop
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.GB_editLaptop = new System.Windows.Forms.GroupBox();
            this.btn_listo = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_editpc_idaum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.GB_editLaptop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(14, 145);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(153, 42);
            this.btn_cancelar.TabIndex = 0;
            this.btn_cancelar.Text = "CANCEL";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // GB_editLaptop
            // 
            this.GB_editLaptop.Controls.Add(this.btn_listo);
            this.GB_editLaptop.Controls.Add(this.textBox4);
            this.GB_editLaptop.Controls.Add(this.textBox3);
            this.GB_editLaptop.Controls.Add(this.textBox2);
            this.GB_editLaptop.Controls.Add(this.txt_editpc_idaum);
            this.GB_editLaptop.Controls.Add(this.label3);
            this.GB_editLaptop.Controls.Add(this.label2);
            this.GB_editLaptop.Controls.Add(this.label1);
            this.GB_editLaptop.Controls.Add(this.label_ID);
            this.GB_editLaptop.Controls.Add(this.btn_cancelar);
            this.GB_editLaptop.Location = new System.Drawing.Point(12, 10);
            this.GB_editLaptop.Name = "GB_editLaptop";
            this.GB_editLaptop.Size = new System.Drawing.Size(354, 192);
            this.GB_editLaptop.TabIndex = 2;
            this.GB_editLaptop.TabStop = false;
            this.GB_editLaptop.Text = "Edit";
            // 
            // btn_listo
            // 
            this.btn_listo.Location = new System.Drawing.Point(189, 145);
            this.btn_listo.Name = "btn_listo";
            this.btn_listo.Size = new System.Drawing.Size(153, 42);
            this.btn_listo.TabIndex = 9;
            this.btn_listo.Text = "DONE";
            this.btn_listo.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(123, 53);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(207, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(123, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(207, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 20);
            this.textBox2.TabIndex = 6;
            // 
            // txt_editpc_idaum
            // 
            this.txt_editpc_idaum.Location = new System.Drawing.Point(123, 28);
            this.txt_editpc_idaum.Name = "txt_editpc_idaum";
            this.txt_editpc_idaum.Size = new System.Drawing.Size(207, 20);
            this.txt_editpc_idaum.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "SERIAL NUMBER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "MODEL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "BRAND";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(15, 30);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(45, 13);
            this.label_ID.TabIndex = 1;
            this.label_ID.Text = "ID UAM";
            // 
            // Fomr_EditarLaptop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(378, 212);
            this.Controls.Add(this.GB_editLaptop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fomr_EditarLaptop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fomr_EditarLaptop";
            this.GB_editLaptop.ResumeLayout(false);
            this.GB_editLaptop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox GB_editLaptop;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_listo;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt_editpc_idaum;
        private System.Windows.Forms.Label label3;
    }
}