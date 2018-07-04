namespace UserRepository
{
    partial class UsersFields
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chb_isAdmin = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bCreate_Edit = new System.Windows.Forms.Button();
            this.mtb_phone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(117, 34);
            this.tb_login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(234, 26);
            this.tb_login.TabIndex = 1;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(117, 83);
            this.tb_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(234, 26);
            this.tb_password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(117, 134);
            this.tb_address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(234, 26);
            this.tb_address.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Телефон";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 8;
            // 
            // chb_isAdmin
            // 
            this.chb_isAdmin.AutoSize = true;
            this.chb_isAdmin.Location = new System.Drawing.Point(117, 232);
            this.chb_isAdmin.Name = "chb_isAdmin";
            this.chb_isAdmin.Size = new System.Drawing.Size(150, 24);
            this.chb_isAdmin.TabIndex = 12;
            this.chb_isAdmin.Text = "Администратор";
            this.chb_isAdmin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Отменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bCreate_Edit
            // 
            this.bCreate_Edit.Location = new System.Drawing.Point(117, 274);
            this.bCreate_Edit.Name = "bCreate_Edit";
            this.bCreate_Edit.Size = new System.Drawing.Size(106, 34);
            this.bCreate_Edit.TabIndex = 14;
            this.bCreate_Edit.Text = "Создать";
            this.bCreate_Edit.UseVisualStyleBackColor = true;
            this.bCreate_Edit.Click += new System.EventHandler(this.button2_Click);
            // 
            // mtb_phone
            // 
            this.mtb_phone.Location = new System.Drawing.Point(117, 184);
            this.mtb_phone.Mask = "38(000)000-00-00";
            this.mtb_phone.Name = "mtb_phone";
            this.mtb_phone.Size = new System.Drawing.Size(234, 26);
            this.mtb_phone.TabIndex = 15;
            // 
            // UsersFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 320);
            this.Controls.Add(this.mtb_phone);
            this.Controls.Add(this.bCreate_Edit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chb_isAdmin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UsersFields";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersFields";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chb_isAdmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bCreate_Edit;
        private System.Windows.Forms.MaskedTextBox mtb_phone;
    }
}