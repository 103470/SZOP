namespace Beadando
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
            txtUsername = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            btnLogin = new Button();
            btnLogout = new Button();
            menuStrip1 = new MenuStrip();
            MenuItemUsers = new ToolStripMenuItem();
            MenuItemCars = new ToolStripMenuItem();
            groupBoxLogin = new GroupBox();
            menuStrip1.SuspendLayout();
            groupBoxLogin.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(85, 29);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(150, 23);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 32);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(85, 61);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 23);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 64);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(80, 112);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(150, 299);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(150, 23);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuItemUsers, MenuItemCars });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(454, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // MenuItemUsers
            // 
            MenuItemUsers.Name = "MenuItemUsers";
            MenuItemUsers.Size = new Size(47, 20);
            MenuItemUsers.Text = "Users";
            // 
            // MenuItemCars
            // 
            MenuItemCars.Name = "MenuItemCars";
            MenuItemCars.Size = new Size(42, 20);
            MenuItemCars.Text = "Cars";
            // 
            // groupBoxLogin
            // 
            groupBoxLogin.Controls.Add(label1);
            groupBoxLogin.Controls.Add(txtUsername);
            groupBoxLogin.Controls.Add(btnLogin);
            groupBoxLogin.Controls.Add(label2);
            groupBoxLogin.Controls.Add(txtPassword);
            groupBoxLogin.Location = new Point(70, 66);
            groupBoxLogin.Name = "groupBoxLogin";
            groupBoxLogin.Size = new Size(313, 182);
            groupBoxLogin.TabIndex = 7;
            groupBoxLogin.TabStop = false;
            groupBoxLogin.Text = "Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 334);
            Controls.Add(groupBoxLogin);
            Controls.Add(btnLogout);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBoxLogin.ResumeLayout(false);
            groupBoxLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private Label label1;
        private TextBox txtPassword;
        private Label label2;
        private Button btnLogin;
        private Button btnLogout;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuItemUsers;
        private ToolStripMenuItem MenuItemCars;
        private GroupBox groupBoxLogin;
    }
}
