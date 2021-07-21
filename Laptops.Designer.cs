
namespace App
{
    partial class Form_Laptops
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
            this.DGV_ASIGNADAS = new System.Windows.Forms.DataGridView();
            this.btn_laptopsasignadas = new System.Windows.Forms.Button();
            this.btn_laptopDisponible = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_nuevaLaptop = new System.Windows.Forms.Button();
            this.btn_modificarlaptop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ASIGNADAS)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_ASIGNADAS
            // 
            this.DGV_ASIGNADAS.AllowUserToAddRows = false;
            this.DGV_ASIGNADAS.AllowUserToDeleteRows = false;
            this.DGV_ASIGNADAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_ASIGNADAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ASIGNADAS.Location = new System.Drawing.Point(12, 70);
            this.DGV_ASIGNADAS.Name = "DGV_ASIGNADAS";
            this.DGV_ASIGNADAS.ReadOnly = true;
            this.DGV_ASIGNADAS.RowTemplate.Height = 25;
            this.DGV_ASIGNADAS.Size = new System.Drawing.Size(963, 348);
            this.DGV_ASIGNADAS.TabIndex = 0;
            // 
            // btn_laptopsasignadas
            // 
            this.btn_laptopsasignadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_laptopsasignadas.Location = new System.Drawing.Point(25, 455);
            this.btn_laptopsasignadas.Name = "btn_laptopsasignadas";
            this.btn_laptopsasignadas.Size = new System.Drawing.Size(121, 41);
            this.btn_laptopsasignadas.TabIndex = 1;
            this.btn_laptopsasignadas.Text = "Assigned Computer";
            this.btn_laptopsasignadas.UseVisualStyleBackColor = true;
            // 
            // btn_laptopDisponible
            // 
            this.btn_laptopDisponible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_laptopDisponible.Location = new System.Drawing.Point(151, 455);
            this.btn_laptopDisponible.Name = "btn_laptopDisponible";
            this.btn_laptopDisponible.Size = new System.Drawing.Size(121, 41);
            this.btn_laptopDisponible.TabIndex = 2;
            this.btn_laptopDisponible.Text = "Available Computer";
            this.btn_laptopDisponible.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(277, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Non-functional Computer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_nuevaLaptop
            // 
            this.btn_nuevaLaptop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nuevaLaptop.Location = new System.Drawing.Point(708, 455);
            this.btn_nuevaLaptop.Name = "btn_nuevaLaptop";
            this.btn_nuevaLaptop.Size = new System.Drawing.Size(121, 41);
            this.btn_nuevaLaptop.TabIndex = 4;
            this.btn_nuevaLaptop.Text = "New Computer";
            this.btn_nuevaLaptop.UseVisualStyleBackColor = true;
            this.btn_nuevaLaptop.Click += new System.EventHandler(this.btn_nuevaLaptop_Click);
            // 
            // btn_modificarlaptop
            // 
            this.btn_modificarlaptop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_modificarlaptop.Location = new System.Drawing.Point(834, 455);
            this.btn_modificarlaptop.Name = "btn_modificarlaptop";
            this.btn_modificarlaptop.Size = new System.Drawing.Size(121, 41);
            this.btn_modificarlaptop.TabIndex = 5;
            this.btn_modificarlaptop.Text = "Edit";
            this.btn_modificarlaptop.UseVisualStyleBackColor = true;
            this.btn_modificarlaptop.Click += new System.EventHandler(this.btn_modificarlaptop_Click);
            // 
            // Form_Laptops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 530);
            this.ControlBox = false;
            this.Controls.Add(this.btn_modificarlaptop);
            this.Controls.Add(this.btn_nuevaLaptop);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_laptopDisponible);
            this.Controls.Add(this.btn_laptopsasignadas);
            this.Controls.Add(this.DGV_ASIGNADAS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Laptops";
            this.Text = "Laptops";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ASIGNADAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_ASIGNADAS;
        private System.Windows.Forms.Button btn_laptopsasignadas;
        private System.Windows.Forms.Button btn_laptopDisponible;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_nuevaLaptop;
        private System.Windows.Forms.Button btn_modificarlaptop;
    }
}