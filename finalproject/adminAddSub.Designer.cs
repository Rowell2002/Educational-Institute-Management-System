namespace finalproject
{
    partial class adminAddSub
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
            this.pnl_AddSub = new System.Windows.Forms.Panel();
            this.txt_grd = new System.Windows.Forms.TextBox();
            this.txt_subName = new System.Windows.Forms.TextBox();
            this.txt_subID = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_AddSub.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_AddSub
            // 
            this.pnl_AddSub.BackColor = System.Drawing.Color.LightGray;
            this.pnl_AddSub.Controls.Add(this.txt_grd);
            this.pnl_AddSub.Controls.Add(this.txt_subName);
            this.pnl_AddSub.Controls.Add(this.txt_subID);
            this.pnl_AddSub.Controls.Add(this.btn_cancel);
            this.pnl_AddSub.Controls.Add(this.btn_add);
            this.pnl_AddSub.Controls.Add(this.label5);
            this.pnl_AddSub.Controls.Add(this.label4);
            this.pnl_AddSub.Controls.Add(this.label2);
            this.pnl_AddSub.Controls.Add(this.label1);
            this.pnl_AddSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_AddSub.Location = new System.Drawing.Point(0, 0);
            this.pnl_AddSub.Name = "pnl_AddSub";
            this.pnl_AddSub.Size = new System.Drawing.Size(1093, 622);
            this.pnl_AddSub.TabIndex = 0;
            this.pnl_AddSub.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_grd
            // 
            this.txt_grd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_grd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grd.Location = new System.Drawing.Point(416, 431);
            this.txt_grd.Multiline = true;
            this.txt_grd.Name = "txt_grd";
            this.txt_grd.Size = new System.Drawing.Size(298, 43);
            this.txt_grd.TabIndex = 72;
            this.txt_grd.TextChanged += new System.EventHandler(this.txt_grd_TextChanged);
            // 
            // txt_subName
            // 
            this.txt_subName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_subName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subName.Location = new System.Drawing.Point(416, 303);
            this.txt_subName.Multiline = true;
            this.txt_subName.Name = "txt_subName";
            this.txt_subName.Size = new System.Drawing.Size(298, 43);
            this.txt_subName.TabIndex = 71;
            this.txt_subName.TextChanged += new System.EventHandler(this.txt_subName_TextChanged);
            // 
            // txt_subID
            // 
            this.txt_subID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_subID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subID.Location = new System.Drawing.Point(416, 175);
            this.txt_subID.Multiline = true;
            this.txt_subID.Name = "txt_subID";
            this.txt_subID.Size = new System.Drawing.Size(298, 43);
            this.txt_subID.TabIndex = 69;
            this.txt_subID.TextChanged += new System.EventHandler(this.txt_subID_TextChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(644, 519);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(164, 54);
            this.btn_cancel.TabIndex = 68;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(297, 519);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(164, 54);
            this.btn_add.TabIndex = 67;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(422, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 66;
            this.label5.Text = "Grade";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(422, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 24);
            this.label4.TabIndex = 65;
            this.label4.Text = "Subject Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(422, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 63;
            this.label2.Text = "Subject ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 44.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(358, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 70);
            this.label1.TabIndex = 62;
            this.label1.Text = "Add Subject";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // adminAddSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 622);
            this.Controls.Add(this.pnl_AddSub);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminAddSub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminAddSub";
            this.Load += new System.EventHandler(this.adminAddSub_Load);
            this.pnl_AddSub.ResumeLayout(false);
            this.pnl_AddSub.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_AddSub;
        private System.Windows.Forms.TextBox txt_grd;
        private System.Windows.Forms.TextBox txt_subName;
        private System.Windows.Forms.TextBox txt_subID;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}