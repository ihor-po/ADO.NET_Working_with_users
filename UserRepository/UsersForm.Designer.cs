namespace UserRepository
{
    partial class UsersForm
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
            this.dView = new System.Windows.Forms.DataGridView();
            this.bCreateUser = new System.Windows.Forms.Button();
            this.bDeleteUser = new System.Windows.Forms.Button();
            this.bShowAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dView)).BeginInit();
            this.SuspendLayout();
            // 
            // dView
            // 
            this.dView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dView.Location = new System.Drawing.Point(0, 0);
            this.dView.Name = "dView";
            this.dView.ReadOnly = true;
            this.dView.Size = new System.Drawing.Size(669, 404);
            this.dView.TabIndex = 0;
            // 
            // bCreateUser
            // 
            this.bCreateUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.bCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCreateUser.Location = new System.Drawing.Point(0, 404);
            this.bCreateUser.Name = "bCreateUser";
            this.bCreateUser.Size = new System.Drawing.Size(188, 62);
            this.bCreateUser.TabIndex = 1;
            this.bCreateUser.Text = "Создать пользователя";
            this.bCreateUser.UseVisualStyleBackColor = true;
            this.bCreateUser.Click += new System.EventHandler(this.bCreateUser_Click);
            // 
            // bDeleteUser
            // 
            this.bDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDeleteUser.Location = new System.Drawing.Point(237, 404);
            this.bDeleteUser.Name = "bDeleteUser";
            this.bDeleteUser.Size = new System.Drawing.Size(188, 62);
            this.bDeleteUser.TabIndex = 2;
            this.bDeleteUser.Text = "Удалить пользователя";
            this.bDeleteUser.UseVisualStyleBackColor = true;
            this.bDeleteUser.Click += new System.EventHandler(this.bDeleteUser_Click);
            // 
            // bShowAdmin
            // 
            this.bShowAdmin.Dock = System.Windows.Forms.DockStyle.Right;
            this.bShowAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bShowAdmin.Location = new System.Drawing.Point(481, 404);
            this.bShowAdmin.Name = "bShowAdmin";
            this.bShowAdmin.Size = new System.Drawing.Size(188, 62);
            this.bShowAdmin.TabIndex = 3;
            this.bShowAdmin.Text = "Показать администраторов";
            this.bShowAdmin.UseVisualStyleBackColor = true;
            this.bShowAdmin.Click += new System.EventHandler(this.button3_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 466);
            this.Controls.Add(this.bShowAdmin);
            this.Controls.Add(this.bDeleteUser);
            this.Controls.Add(this.bCreateUser);
            this.Controls.Add(this.dView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователи";
            ((System.ComponentModel.ISupportInitialize)(this.dView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dView;
        private System.Windows.Forms.Button bCreateUser;
        private System.Windows.Forms.Button bDeleteUser;
        private System.Windows.Forms.Button bShowAdmin;
    }
}

