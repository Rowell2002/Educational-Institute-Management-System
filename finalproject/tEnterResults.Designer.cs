namespace finalproject
{
    partial class tEnterResults
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_resultid = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Marks = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.txt_grade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_marks = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_cls = new System.Windows.Forms.ComboBox();
            this.cmb_exam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.txt_resultid);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmb_cls);
            this.panel1.Controls.Add(this.cmb_exam);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_sid);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 628);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_resultid
            // 
            this.txt_resultid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_resultid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resultid.Location = new System.Drawing.Point(260, 148);
            this.txt_resultid.Multiline = true;
            this.txt_resultid.Name = "txt_resultid";
            this.txt_resultid.Size = new System.Drawing.Size(252, 43);
            this.txt_resultid.TabIndex = 109;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(310, 543);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(164, 54);
            this.btn_save.TabIndex = 108;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(648, 543);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(164, 54);
            this.btn_cancel.TabIndex = 107;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.Marks);
            this.panel2.Controls.Add(this.btn_calculate);
            this.panel2.Controls.Add(this.txt_grade);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_marks);
            this.panel2.Location = new System.Drawing.Point(260, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 166);
            this.panel2.TabIndex = 106;
            // 
            // Marks
            // 
            this.Marks.AutoSize = true;
            this.Marks.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marks.Location = new System.Drawing.Point(34, 19);
            this.Marks.Name = "Marks";
            this.Marks.Size = new System.Drawing.Size(67, 24);
            this.Marks.TabIndex = 105;
            this.Marks.Text = "Marks";
            // 
            // btn_calculate
            // 
            this.btn_calculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btn_calculate.FlatAppearance.BorderSize = 0;
            this.btn_calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculate.ForeColor = System.Drawing.Color.White;
            this.btn_calculate.Location = new System.Drawing.Point(239, 107);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(152, 46);
            this.btn_calculate.TabIndex = 36;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = false;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // txt_grade
            // 
            this.txt_grade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grade.Location = new System.Drawing.Point(365, 46);
            this.txt_grade.Multiline = true;
            this.txt_grade.Name = "txt_grade";
            this.txt_grade.Size = new System.Drawing.Size(242, 43);
            this.txt_grade.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(361, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 103;
            this.label5.Text = "Grade";
            // 
            // txt_marks
            // 
            this.txt_marks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_marks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_marks.Location = new System.Drawing.Point(21, 46);
            this.txt_marks.Multiline = true;
            this.txt_marks.Name = "txt_marks";
            this.txt_marks.Size = new System.Drawing.Size(242, 43);
            this.txt_marks.TabIndex = 104;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(621, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 24);
            this.label7.TabIndex = 105;
            this.label7.Text = "Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(268, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 102;
            this.label4.Text = "Result ID";
            // 
            // cmb_cls
            // 
            this.cmb_cls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_cls.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cls.FormattingEnabled = true;
            this.cmb_cls.Items.AddRange(new object[] {
            "Grade 12",
            "Grade 13"});
            this.cmb_cls.Location = new System.Drawing.Point(614, 267);
            this.cmb_cls.Name = "cmb_cls";
            this.cmb_cls.Size = new System.Drawing.Size(253, 40);
            this.cmb_cls.TabIndex = 101;
            // 
            // cmb_exam
            // 
            this.cmb_exam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_exam.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_exam.FormattingEnabled = true;
            this.cmb_exam.Items.AddRange(new object[] {
            "Physics 1st Term Test",
            "Physics 2nd Term Test",
            "Physics 3rd Term Test",
            "Chemistry 1st Term Test",
            "Chemistry 2nd Term Test",
            "Chemistry 3rd Term Test",
            "Combined Maths 1st Term Test",
            "Combined Maths 2nd Term Test",
            "Combined Maths 3rd Term Test"});
            this.cmb_exam.Location = new System.Drawing.Point(260, 267);
            this.cmb_exam.Name = "cmb_exam";
            this.cmb_exam.Size = new System.Drawing.Size(297, 40);
            this.cmb_exam.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(253, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(632, 63);
            this.label1.TabIndex = 79;
            this.label1.Text = "Upload Exam Results";
            // 
            // txt_sid
            // 
            this.txt_sid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sid.Location = new System.Drawing.Point(614, 148);
            this.txt_sid.Multiline = true;
            this.txt_sid.Name = "txt_sid";
            this.txt_sid.Size = new System.Drawing.Size(252, 43);
            this.txt_sid.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(621, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 86;
            this.label3.Text = "Student ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(268, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 24);
            this.label6.TabIndex = 82;
            this.label6.Text = "Exam Name";
            // 
            // tEnterResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 628);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "tEnterResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tEnterResults";
            this.Load += new System.EventHandler(this.tEnterResults_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_grade;
        private System.Windows.Forms.ComboBox cmb_exam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_cls;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_marks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_resultid;
        private System.Windows.Forms.Label Marks;
    }
}