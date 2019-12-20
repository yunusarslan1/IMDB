namespace CınemaSıte.UI
{
    partial class AdminCınemaPage
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbAddAuthor = new System.Windows.Forms.ComboBox();
            this.cmbAddCategory = new System.Windows.Forms.ComboBox();
            this.btnAddPictureUrl = new System.Windows.Forms.Button();
            this.txtAddPictureUrl = new System.Windows.Forms.TextBox();
            this.txtAddTitle = new System.Windows.Forms.TextBox();
            this.txtAddContent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdAdd = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(830, 220);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of Cinema";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(807, 179);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cmbAddAuthor);
            this.groupBox1.Controls.Add(this.cmbAddCategory);
            this.groupBox1.Controls.Add(this.btnAddPictureUrl);
            this.groupBox1.Controls.Add(this.txtAddPictureUrl);
            this.groupBox1.Controls.Add(this.txtAddTitle);
            this.groupBox1.Controls.Add(this.txtAddContent);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 345);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Cinema";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(198, 311);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbAddAuthor
            // 
            this.cmbAddAuthor.FormattingEnabled = true;
            this.cmbAddAuthor.Location = new System.Drawing.Point(98, 275);
            this.cmbAddAuthor.Name = "cmbAddAuthor";
            this.cmbAddAuthor.Size = new System.Drawing.Size(175, 21);
            this.cmbAddAuthor.TabIndex = 3;
            // 
            // cmbAddCategory
            // 
            this.cmbAddCategory.FormattingEnabled = true;
            this.cmbAddCategory.Location = new System.Drawing.Point(98, 224);
            this.cmbAddCategory.Name = "cmbAddCategory";
            this.cmbAddCategory.Size = new System.Drawing.Size(175, 21);
            this.cmbAddCategory.TabIndex = 3;
            // 
            // btnAddPictureUrl
            // 
            this.btnAddPictureUrl.Location = new System.Drawing.Point(101, 146);
            this.btnAddPictureUrl.Name = "btnAddPictureUrl";
            this.btnAddPictureUrl.Size = new System.Drawing.Size(175, 23);
            this.btnAddPictureUrl.TabIndex = 2;
            this.btnAddPictureUrl.Text = "Choose A Picture";
            this.btnAddPictureUrl.UseVisualStyleBackColor = true;
            this.btnAddPictureUrl.Click += new System.EventHandler(this.btnAddPictureUrl_Click);
            // 
            // txtAddPictureUrl
            // 
            this.txtAddPictureUrl.Location = new System.Drawing.Point(101, 175);
            this.txtAddPictureUrl.Name = "txtAddPictureUrl";
            this.txtAddPictureUrl.Size = new System.Drawing.Size(175, 20);
            this.txtAddPictureUrl.TabIndex = 1;
            // 
            // txtAddTitle
            // 
            this.txtAddTitle.Location = new System.Drawing.Point(101, 19);
            this.txtAddTitle.Name = "txtAddTitle";
            this.txtAddTitle.Size = new System.Drawing.Size(175, 20);
            this.txtAddTitle.TabIndex = 1;
            // 
            // txtAddContent
            // 
            this.txtAddContent.Location = new System.Drawing.Point(101, 51);
            this.txtAddContent.Multiline = true;
            this.txtAddContent.Name = "txtAddContent";
            this.txtAddContent.Size = new System.Drawing.Size(175, 80);
            this.txtAddContent.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Picture:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Please Choose A Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Please Choose A Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Content:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // ofdAdd
            // 
            this.ofdAdd.FileName = "ofdAdd";
            // 
            // AdminCınemaPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 592);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminCınemaPage";
            this.Text = "AdminCınemaPage";
            this.Load += new System.EventHandler(this.AdminCınemaPage_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbAddAuthor;
        private System.Windows.Forms.ComboBox cmbAddCategory;
        private System.Windows.Forms.Button btnAddPictureUrl;
        private System.Windows.Forms.TextBox txtAddPictureUrl;
        private System.Windows.Forms.TextBox txtAddTitle;
        private System.Windows.Forms.TextBox txtAddContent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofdAdd;
    }
}