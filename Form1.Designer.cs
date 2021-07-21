
namespace App
{
    partial class Form_principal
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
            this.panel_button = new System.Windows.Forms.Panel();
            this.btn_analytics = new FontAwesome.Sharp.IconButton();
            this.btn_laptops = new FontAwesome.Sharp.IconButton();
            this.btn_editUser = new FontAwesome.Sharp.IconButton();
            this.btn_search = new FontAwesome.Sharp.IconButton();
            this.panel_log = new System.Windows.Forms.Panel();
            this.btn_Picture = new System.Windows.Forms.PictureBox();
            this.panel_name = new System.Windows.Forms.Panel();
            this.lbl_actual = new System.Windows.Forms.Label();
            this.icon_IconoActual = new FontAwesome.Sharp.IconPictureBox();
            this.panel_container = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel_button.SuspendLayout();
            this.panel_log.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Picture)).BeginInit();
            this.panel_name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_IconoActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_button
            // 
            this.panel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel_button.Controls.Add(this.iconPictureBox1);
            this.panel_button.Controls.Add(this.btn_analytics);
            this.panel_button.Controls.Add(this.btn_laptops);
            this.panel_button.Controls.Add(this.btn_editUser);
            this.panel_button.Controls.Add(this.btn_search);
            this.panel_button.Controls.Add(this.panel_log);
            this.panel_button.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_button.Location = new System.Drawing.Point(0, 0);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(189, 525);
            this.panel_button.TabIndex = 0;
            // 
            // btn_analytics
            // 
            this.btn_analytics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_analytics.FlatAppearance.BorderSize = 0;
            this.btn_analytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_analytics.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btn_analytics.ForeColor = System.Drawing.Color.White;
            this.btn_analytics.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btn_analytics.IconColor = System.Drawing.Color.White;
            this.btn_analytics.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_analytics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_analytics.Location = new System.Drawing.Point(0, 338);
            this.btn_analytics.Name = "btn_analytics";
            this.btn_analytics.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btn_analytics.Size = new System.Drawing.Size(189, 60);
            this.btn_analytics.TabIndex = 15;
            this.btn_analytics.Text = "Analytics";
            this.btn_analytics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_analytics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_analytics.UseVisualStyleBackColor = true;
            this.btn_analytics.Click += new System.EventHandler(this.btn_analytics_Click_1);
            // 
            // btn_laptops
            // 
            this.btn_laptops.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_laptops.FlatAppearance.BorderSize = 0;
            this.btn_laptops.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_laptops.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btn_laptops.ForeColor = System.Drawing.Color.White;
            this.btn_laptops.IconChar = FontAwesome.Sharp.IconChar.Laptop;
            this.btn_laptops.IconColor = System.Drawing.Color.White;
            this.btn_laptops.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_laptops.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_laptops.Location = new System.Drawing.Point(0, 277);
            this.btn_laptops.Name = "btn_laptops";
            this.btn_laptops.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btn_laptops.Size = new System.Drawing.Size(189, 61);
            this.btn_laptops.TabIndex = 14;
            this.btn_laptops.Text = "Computer";
            this.btn_laptops.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_laptops.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_laptops.UseVisualStyleBackColor = true;
            this.btn_laptops.Click += new System.EventHandler(this.btn_laptops_Click);
            // 
            // btn_editUser
            // 
            this.btn_editUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_editUser.FlatAppearance.BorderSize = 0;
            this.btn_editUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editUser.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btn_editUser.ForeColor = System.Drawing.Color.White;
            this.btn_editUser.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btn_editUser.IconColor = System.Drawing.Color.White;
            this.btn_editUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_editUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editUser.Location = new System.Drawing.Point(0, 216);
            this.btn_editUser.Name = "btn_editUser";
            this.btn_editUser.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btn_editUser.Size = new System.Drawing.Size(189, 61);
            this.btn_editUser.TabIndex = 13;
            this.btn_editUser.Text = "Users";
            this.btn_editUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editUser.UseVisualStyleBackColor = true;
            this.btn_editUser.Click += new System.EventHandler(this.btn_editUser_Click_1);
            // 
            // btn_search
            // 
            this.btn_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_search.IconColor = System.Drawing.Color.White;
            this.btn_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(0, 155);
            this.btn_search.Name = "btn_search";
            this.btn_search.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btn_search.Size = new System.Drawing.Size(189, 61);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // panel_log
            // 
            this.panel_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel_log.Controls.Add(this.btn_Picture);
            this.panel_log.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_log.Location = new System.Drawing.Point(0, 0);
            this.panel_log.Name = "panel_log";
            this.panel_log.Size = new System.Drawing.Size(189, 155);
            this.panel_log.TabIndex = 1;
            // 
            // btn_Picture
            // 
            this.btn_Picture.Location = new System.Drawing.Point(0, 0);
            this.btn_Picture.Name = "btn_Picture";
            this.btn_Picture.Size = new System.Drawing.Size(116, 95);
            this.btn_Picture.TabIndex = 0;
            this.btn_Picture.TabStop = false;
            this.btn_Picture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel_name
            // 
            this.panel_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel_name.Controls.Add(this.lbl_actual);
            this.panel_name.Controls.Add(this.icon_IconoActual);
            this.panel_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_name.Location = new System.Drawing.Point(189, 0);
            this.panel_name.Name = "panel_name";
            this.panel_name.Size = new System.Drawing.Size(854, 65);
            this.panel_name.TabIndex = 1;
            // 
            // lbl_actual
            // 
            this.lbl_actual.AutoSize = true;
            this.lbl_actual.BackColor = System.Drawing.Color.Transparent;
            this.lbl_actual.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lbl_actual.ForeColor = System.Drawing.Color.White;
            this.lbl_actual.Location = new System.Drawing.Point(51, 29);
            this.lbl_actual.Name = "lbl_actual";
            this.lbl_actual.Size = new System.Drawing.Size(50, 20);
            this.lbl_actual.TabIndex = 1;
            this.lbl_actual.Text = "Home";
            // 
            // icon_IconoActual
            // 
            this.icon_IconoActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.icon_IconoActual.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.icon_IconoActual.IconColor = System.Drawing.Color.White;
            this.icon_IconoActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon_IconoActual.IconSize = 35;
            this.icon_IconoActual.Location = new System.Drawing.Point(11, 17);
            this.icon_IconoActual.Name = "icon_IconoActual";
            this.icon_IconoActual.Size = new System.Drawing.Size(35, 36);
            this.icon_IconoActual.TabIndex = 0;
            this.icon_IconoActual.TabStop = false;
            // 
            // panel_container
            // 
            this.panel_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_container.BackColor = System.Drawing.Color.White;
            this.panel_container.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_container.Location = new System.Drawing.Point(189, 65);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(855, 460);
            this.panel_container.TabIndex = 2;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 41;
            this.iconPictureBox1.Location = new System.Drawing.Point(148, 481);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(41, 44);
            this.iconPictureBox1.TabIndex = 16;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1043, 525);
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.panel_name);
            this.Controls.Add(this.panel_button);
            this.MinimumSize = new System.Drawing.Size(990, 536);
            this.Name = "Form_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_button.ResumeLayout(false);
            this.panel_log.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Picture)).EndInit();
            this.panel_name.ResumeLayout(false);
            this.panel_name.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_IconoActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.Panel panel_log;
        private System.Windows.Forms.Panel panel_name;
        private System.Windows.Forms.Panel panel_container;
        private FontAwesome.Sharp.IconButton btn_search;
        private System.Windows.Forms.PictureBox btn_Picture;
        private FontAwesome.Sharp.IconPictureBox icon_IconoActual;
        private System.Windows.Forms.Label lbl_actual;
        private FontAwesome.Sharp.IconButton btn_editUser;
        private FontAwesome.Sharp.IconButton btn_analytics;
        private FontAwesome.Sharp.IconButton btn_laptops;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}

