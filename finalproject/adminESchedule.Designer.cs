namespace finalproject
{
    partial class adminESchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminESchedule));
            this.emp_pnl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_addEmpSchedule = new System.Windows.Forms.Button();
            this.btn_updateEmpSchedule = new System.Windows.Forms.Button();
            this.emp_pnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // emp_pnl
            // 
            this.emp_pnl.Controls.Add(this.panel2);
            this.emp_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emp_pnl.Location = new System.Drawing.Point(0, 0);
            this.emp_pnl.Name = "emp_pnl";
            this.emp_pnl.Size = new System.Drawing.Size(1093, 622);
            this.emp_pnl.TabIndex = 0;
            this.emp_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btn_addEmpSchedule);
            this.panel2.Controls.Add(this.btn_updateEmpSchedule);
            this.panel2.Location = new System.Drawing.Point(320, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 448);
            this.panel2.TabIndex = 19;
            // 
            // btn_addEmpSchedule
            // 
            this.btn_addEmpSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btn_addEmpSchedule.FlatAppearance.BorderSize = 0;
            this.btn_addEmpSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addEmpSchedule.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addEmpSchedule.ForeColor = System.Drawing.Color.White;
            this.btn_addEmpSchedule.Location = new System.Drawing.Point(80, 82);
            this.btn_addEmpSchedule.Name = "btn_addEmpSchedule";
            this.btn_addEmpSchedule.Size = new System.Drawing.Size(304, 110);
            this.btn_addEmpSchedule.TabIndex = 0;
            this.btn_addEmpSchedule.Text = "Add Employee Schedule";
            this.btn_addEmpSchedule.UseVisualStyleBackColor = false;
            this.btn_addEmpSchedule.Click += new System.EventHandler(this.btn_addEmpSchedule_Click_1);
            // 
            // btn_updateEmpSchedule
            // 
            this.btn_updateEmpSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btn_updateEmpSchedule.FlatAppearance.BorderSize = 0;
            this.btn_updateEmpSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateEmpSchedule.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateEmpSchedule.ForeColor = System.Drawing.Color.White;
            this.btn_updateEmpSchedule.Location = new System.Drawing.Point(80, 258);
            this.btn_updateEmpSchedule.Name = "btn_updateEmpSchedule";
            this.btn_updateEmpSchedule.Size = new System.Drawing.Size(304, 110);
            this.btn_updateEmpSchedule.TabIndex = 2;
            this.btn_updateEmpSchedule.Text = "Update Employee Schedule";
            this.btn_updateEmpSchedule.UseVisualStyleBackColor = false;
            this.btn_updateEmpSchedule.Click += new System.EventHandler(this.btn_updateEmpSchedule_Click_1);
            // 
            // adminESchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1093, 622);
            this.Controls.Add(this.emp_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "adminESchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminESchedule";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.adminESchedule_Load);
            this.emp_pnl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel emp_pnl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_addEmpSchedule;
        private System.Windows.Forms.Button btn_updateEmpSchedule;
    }
}