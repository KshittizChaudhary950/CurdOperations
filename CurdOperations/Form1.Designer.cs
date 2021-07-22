
namespace CurdOperations
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.SalarytextBox = new System.Windows.Forms.TextBox();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GendercomboBox = new System.Windows.Forms.ComboBox();
            this.PositioncomboBox = new System.Windows.Forms.ComboBox();
            this.AgenumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgenumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Position";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Salary";
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(89, 59);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(152, 20);
            this.IDtextBox.TabIndex = 0;
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(89, 87);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(152, 20);
            this.NametextBox.TabIndex = 1;
            // 
            // SalarytextBox
            // 
            this.SalarytextBox.Location = new System.Drawing.Point(89, 227);
            this.SalarytextBox.Name = "SalarytextBox";
            this.SalarytextBox.Size = new System.Drawing.Size(152, 20);
            this.SalarytextBox.TabIndex = 5;
            // 
            // InsertBtn
            // 
            this.InsertBtn.Location = new System.Drawing.Point(276, 67);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(75, 23);
            this.InsertBtn.TabIndex = 7;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(276, 110);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 8;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(276, 140);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(75, 23);
            this.Deletebtn.TabIndex = 9;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(276, 176);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(75, 23);
            this.viewBtn.TabIndex = 10;
            this.viewBtn.Text = "View";
            this.viewBtn.UseVisualStyleBackColor = true;
            // 
            // Resetbtn
            // 
            this.Resetbtn.Location = new System.Drawing.Point(276, 222);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(75, 23);
            this.Resetbtn.TabIndex = 11;
            this.Resetbtn.Text = "Reset";
            this.Resetbtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(529, 167);
            this.dataGridView1.TabIndex = 13;
            // 
            // GendercomboBox
            // 
            this.GendercomboBox.FormattingEnabled = true;
            this.GendercomboBox.Location = new System.Drawing.Point(89, 113);
            this.GendercomboBox.Name = "GendercomboBox";
            this.GendercomboBox.Size = new System.Drawing.Size(152, 21);
            this.GendercomboBox.TabIndex = 14;
            // 
            // PositioncomboBox
            // 
            this.PositioncomboBox.FormattingEnabled = true;
            this.PositioncomboBox.Location = new System.Drawing.Point(89, 183);
            this.PositioncomboBox.Name = "PositioncomboBox";
            this.PositioncomboBox.Size = new System.Drawing.Size(152, 21);
            this.PositioncomboBox.TabIndex = 15;
            // 
            // AgenumericUpDown
            // 
            this.AgenumericUpDown.Location = new System.Drawing.Point(90, 148);
            this.AgenumericUpDown.Name = "AgenumericUpDown";
            this.AgenumericUpDown.Size = new System.Drawing.Size(151, 20);
            this.AgenumericUpDown.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.AgenumericUpDown);
            this.Controls.Add(this.PositioncomboBox);
            this.Controls.Add(this.GendercomboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Resetbtn);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.SalarytextBox);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgenumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox SalarytextBox;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button Resetbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox GendercomboBox;
        private System.Windows.Forms.ComboBox PositioncomboBox;
        private System.Windows.Forms.NumericUpDown AgenumericUpDown;
    }
}

