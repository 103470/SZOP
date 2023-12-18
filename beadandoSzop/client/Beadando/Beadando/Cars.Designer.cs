namespace Beadando
{
    partial class Cars
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
            groupBoxCars = new GroupBox();
            txtAr = new TextBox();
            txtUzemanyag = new TextBox();
            txtKivitel = new TextBox();
            txtEvjarat = new TextBox();
            txtTipus = new TextBox();
            txtMarka = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            labelId = new Label();
            BtnSave = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxCars.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(670, 555);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBoxCars
            // 
            groupBoxCars.Controls.Add(txtAr);
            groupBoxCars.Controls.Add(txtUzemanyag);
            groupBoxCars.Controls.Add(txtKivitel);
            groupBoxCars.Controls.Add(txtEvjarat);
            groupBoxCars.Controls.Add(txtTipus);
            groupBoxCars.Controls.Add(txtMarka);
            groupBoxCars.Controls.Add(label7);
            groupBoxCars.Controls.Add(label6);
            groupBoxCars.Controls.Add(label5);
            groupBoxCars.Controls.Add(label4);
            groupBoxCars.Controls.Add(label3);
            groupBoxCars.Controls.Add(label2);
            groupBoxCars.Controls.Add(label1);
            groupBoxCars.Controls.Add(labelId);
            groupBoxCars.Location = new Point(735, 39);
            groupBoxCars.Name = "groupBoxCars";
            groupBoxCars.Size = new Size(306, 220);
            groupBoxCars.TabIndex = 1;
            groupBoxCars.TabStop = false;
            groupBoxCars.Text = "Manage Cars";
            // 
            // txtAr
            // 
            txtAr.Location = new Point(76, 189);
            txtAr.Name = "txtAr";
            txtAr.Size = new Size(198, 23);
            txtAr.TabIndex = 13;
            // 
            // txtUzemanyag
            // 
            txtUzemanyag.Location = new Point(102, 161);
            txtUzemanyag.Name = "txtUzemanyag";
            txtUzemanyag.Size = new Size(198, 23);
            txtUzemanyag.TabIndex = 12;
            // 
            // txtKivitel
            // 
            txtKivitel.Location = new Point(76, 135);
            txtKivitel.Name = "txtKivitel";
            txtKivitel.Size = new Size(198, 23);
            txtKivitel.TabIndex = 11;
            // 
            // txtEvjarat
            // 
            txtEvjarat.Location = new Point(76, 110);
            txtEvjarat.Name = "txtEvjarat";
            txtEvjarat.Size = new Size(198, 23);
            txtEvjarat.TabIndex = 10;
            // 
            // txtTipus
            // 
            txtTipus.Location = new Point(76, 83);
            txtTipus.Name = "txtTipus";
            txtTipus.Size = new Size(198, 23);
            txtTipus.TabIndex = 9;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(76, 56);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(198, 23);
            txtMarka.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 192);
            label7.Name = "label7";
            label7.Size = new Size(22, 15);
            label7.TabIndex = 7;
            label7.Text = "Ár:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 164);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 6;
            label6.Text = "Üzemanyag:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 138);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 5;
            label5.Text = "Kivitel:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 113);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 4;
            label4.Text = "Évjárat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 113);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 86);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "Típus:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 59);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Márka:";
            label1.Click += label1_Click;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(27, 34);
            labelId.Name = "labelId";
            labelId.Size = new Size(20, 15);
            labelId.TabIndex = 0;
            labelId.Text = "Id:";
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(811, 302);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(198, 23);
            BtnSave.TabIndex = 2;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(811, 344);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(198, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(811, 387);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(198, 23);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Cars
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 555);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(BtnSave);
            Controls.Add(groupBoxCars);
            Controls.Add(dataGridView1);
            Name = "Cars";
            Text = "Cars";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxCars.ResumeLayout(false);
            groupBoxCars.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBoxCars;
        private Label label1;
        private Label labelId;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtAr;
        private TextBox txtUzemanyag;
        private TextBox txtKivitel;
        private TextBox txtEvjarat;
        private TextBox txtTipus;
        private TextBox txtMarka;
        private Label label7;
        private Label label6;
        private Button BtnSave;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridViewTextBoxColumn cId;
        private DataGridViewTextBoxColumn cMarka;
        private DataGridViewTextBoxColumn cTipus;
        private DataGridViewTextBoxColumn cEvjarat;
        private DataGridViewTextBoxColumn cKivitel;
        private DataGridViewTextBoxColumn cUzemanyag;
        private DataGridViewTextBoxColumn cAr;
    }
}