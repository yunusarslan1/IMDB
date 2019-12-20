namespace CınemaSıte.UI
{
    partial class AdminCategoryPage
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnGetByDate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.mskdStartDate = new System.Windows.Forms.MaskedTextBox();
            this.mskdEndDate = new System.Windows.Forms.MaskedTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFindCategory = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdateDesciption = new System.Windows.Forms.TextBox();
            this.txtUpdateID = new System.Windows.Forms.TextBox();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnGetByDate);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.mskdStartDate);
            this.groupBox7.Controls.Add(this.mskdEndDate);
            this.groupBox7.Location = new System.Drawing.Point(705, 110);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(231, 84);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Get Category By Date";
            // 
            // btnGetByDate
            // 
            this.btnGetByDate.Location = new System.Drawing.Point(145, 46);
            this.btnGetByDate.Name = "btnGetByDate";
            this.btnGetByDate.Size = new System.Drawing.Size(75, 23);
            this.btnGetByDate.TabIndex = 2;
            this.btnGetByDate.Text = "Get";
            this.btnGetByDate.UseVisualStyleBackColor = true;
            this.btnGetByDate.Click += new System.EventHandler(this.btnGetByDate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Please type into dates";
            // 
            // mskdStartDate
            // 
            this.mskdStartDate.Location = new System.Drawing.Point(9, 48);
            this.mskdStartDate.Mask = "00/00/0000";
            this.mskdStartDate.Name = "mskdStartDate";
            this.mskdStartDate.Size = new System.Drawing.Size(62, 20);
            this.mskdStartDate.TabIndex = 0;
            this.mskdStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // mskdEndDate
            // 
            this.mskdEndDate.Location = new System.Drawing.Point(77, 48);
            this.mskdEndDate.Mask = "00/00/0000";
            this.mskdEndDate.Name = "mskdEndDate";
            this.mskdEndDate.Size = new System.Drawing.Size(62, 20);
            this.mskdEndDate.TabIndex = 0;
            this.mskdEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnGetAll);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(705, 15);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(231, 91);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Get All Category";
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(56, 56);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(99, 27);
            this.btnGetAll.TabIndex = 1;
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 49);
            this.label6.TabIndex = 0;
            this.label6.Text = "Please Cllick The Button For Access All Category";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnFind);
            this.groupBox5.Controls.Add(this.txtFindCategory);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(499, 110);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 84);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Find A Category";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(108, 48);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFindCategory
            // 
            this.txtFindCategory.Location = new System.Drawing.Point(64, 22);
            this.txtFindCategory.Name = "txtFindCategory";
            this.txtFindCategory.Size = new System.Drawing.Size(119, 20);
            this.txtFindCategory.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Name:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtDelete);
            this.groupBox4.Location = new System.Drawing.Point(499, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 91);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete Category";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(108, 38);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID:";
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(44, 40);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(58, 20);
            this.txtDelete.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(924, 237);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of Categories";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(902, 211);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.txtUpdateDesciption);
            this.groupBox3.Controls.Add(this.txtUpdateID);
            this.groupBox3.Controls.Add(this.txtUpdateName);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(264, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 179);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Category";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(128, 129);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdateDesciption
            // 
            this.txtUpdateDesciption.Location = new System.Drawing.Point(103, 103);
            this.txtUpdateDesciption.Name = "txtUpdateDesciption";
            this.txtUpdateDesciption.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateDesciption.TabIndex = 1;
            // 
            // txtUpdateID
            // 
            this.txtUpdateID.Location = new System.Drawing.Point(103, 40);
            this.txtUpdateID.Name = "txtUpdateID";
            this.txtUpdateID.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateID.TabIndex = 1;
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(103, 71);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtAddDescription);
            this.groupBox1.Controls.Add(this.txtAddName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 180);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Category";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(130, 115);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(105, 89);
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(100, 20);
            this.txtAddDescription.TabIndex = 1;
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(105, 57);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(100, 20);
            this.txtAddName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // AdminCategoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminCategoryPage";
            this.Text = "AdminCategoryPage";
            this.Load += new System.EventHandler(this.AdminCategoryPage_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnGetByDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mskdStartDate;
        private System.Windows.Forms.MaskedTextBox mskdEndDate;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFindCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdateDesciption;
        private System.Windows.Forms.TextBox txtUpdateID;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}