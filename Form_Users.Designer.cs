
namespace App
{
    partial class Form_Users
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_searchUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_deleteUser = new System.Windows.Forms.Button();
            this.btn_editUser = new System.Windows.Forms.Button();
            this.btn_newUser = new System.Windows.Forms.Button();
            this.btn_showUserAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(93, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(950, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_searchUser
            // 
            this.btn_searchUser.Location = new System.Drawing.Point(511, 48);
            this.btn_searchUser.Name = "btn_searchUser";
            this.btn_searchUser.Size = new System.Drawing.Size(86, 34);
            this.btn_searchUser.TabIndex = 1;
            this.btn_searchUser.Text = "Search User";
            this.btn_searchUser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 23);
            this.textBox1.TabIndex = 3;
            // 
            // btn_deleteUser
            // 
            this.btn_deleteUser.Location = new System.Drawing.Point(963, 508);
            this.btn_deleteUser.Name = "btn_deleteUser";
            this.btn_deleteUser.Size = new System.Drawing.Size(80, 33);
            this.btn_deleteUser.TabIndex = 4;
            this.btn_deleteUser.Text = "Delete User";
            this.btn_deleteUser.UseVisualStyleBackColor = true;
            // 
            // btn_editUser
            // 
            this.btn_editUser.Location = new System.Drawing.Point(877, 508);
            this.btn_editUser.Name = "btn_editUser";
            this.btn_editUser.Size = new System.Drawing.Size(80, 33);
            this.btn_editUser.TabIndex = 5;
            this.btn_editUser.Text = "Edit User";
            this.btn_editUser.UseVisualStyleBackColor = true;
            // 
            // btn_newUser
            // 
            this.btn_newUser.Location = new System.Drawing.Point(791, 508);
            this.btn_newUser.Name = "btn_newUser";
            this.btn_newUser.Size = new System.Drawing.Size(80, 33);
            this.btn_newUser.TabIndex = 6;
            this.btn_newUser.Text = "New User";
            this.btn_newUser.UseVisualStyleBackColor = true;
            // 
            // btn_showUserAll
            // 
            this.btn_showUserAll.Location = new System.Drawing.Point(93, 508);
            this.btn_showUserAll.Name = "btn_showUserAll";
            this.btn_showUserAll.Size = new System.Drawing.Size(112, 33);
            this.btn_showUserAll.TabIndex = 7;
            this.btn_showUserAll.Text = "Show All User";
            this.btn_showUserAll.UseVisualStyleBackColor = true;
            // 
            // Form_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 573);
            this.Controls.Add(this.btn_showUserAll);
            this.Controls.Add(this.btn_newUser);
            this.Controls.Add(this.btn_editUser);
            this.Controls.Add(this.btn_deleteUser);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_searchUser);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Users";
            this.Text = "Form_Users";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_searchUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_deleteUser;
        private System.Windows.Forms.Button btn_editUser;
        private System.Windows.Forms.Button btn_newUser;
        private System.Windows.Forms.Button btn_showUserAll;
    }
}