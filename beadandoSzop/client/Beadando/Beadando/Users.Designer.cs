namespace Beadando
{
    partial class Users
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
            dataGridView1 = new DataGridView();
            groupBoxUsers = new GroupBox();
            txtAdmin = new TextBox();
            txtName = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Username = new Label();
            labelId = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxUsers.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(760, 546);
            dataGridView1.TabIndex = 0;
            // 
            // groupBoxUsers
            // 
            groupBoxUsers.Controls.Add(txtAdmin);
            groupBoxUsers.Controls.Add(txtName);
            groupBoxUsers.Controls.Add(txtPassword);
            groupBoxUsers.Controls.Add(txtUsername);
            groupBoxUsers.Controls.Add(label4);
            groupBoxUsers.Controls.Add(label3);
            groupBoxUsers.Controls.Add(label2);
            groupBoxUsers.Controls.Add(Username);
            groupBoxUsers.Controls.Add(labelId);
            groupBoxUsers.Location = new Point(786, 12);
            groupBoxUsers.Name = "groupBoxUsers";
            groupBoxUsers.Size = new Size(298, 209);
            groupBoxUsers.TabIndex = 1;
            groupBoxUsers.TabStop = false;
            groupBoxUsers.Text = "Manage Users";
            // 
            // txtAdmin
            // 
            txtAdmin.Location = new Point(97, 148);
            txtAdmin.Name = "txtAdmin";
            txtAdmin.Size = new Size(155, 23);
            txtAdmin.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(97, 118);
            txtName.Name = "txtName";
            txtName.Size = new Size(155, 23);
            txtName.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(97, 87);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(155, 23);
            txtPassword.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(97, 56);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(155, 23);
            txtUsername.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 151);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 4;
            label4.Text = "IsAdmin?:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 121);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 3;
            label3.Text = "Name:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 90);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(28, 59);
            Username.Name = "Username";
            Username.Size = new Size(63, 15);
            Username.TabIndex = 1;
            Username.Text = "Username:";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(28, 33);
            labelId.Name = "labelId";
            labelId.Size = new Size(20, 15);
            labelId.TabIndex = 0;
            labelId.Text = "Id:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(883, 254);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(155, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(883, 298);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(155, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(883, 340);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(155, 23);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 547);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(groupBoxUsers);
            Controls.Add(dataGridView1);
            Name = "Users";
            Text = "Users";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxUsers.ResumeLayout(false);
            groupBoxUsers.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBoxUsers;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label Username;
        private Label labelId;
        private TextBox txtAdmin;
        private TextBox txtName;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
    }
}