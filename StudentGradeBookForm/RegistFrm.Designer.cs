namespace StudentGradeBookForm
{
    partial class RegistFrm
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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPswrdCnfrm = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPswrdCnfrm = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpRgster = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpRgster.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(18, 31);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(58, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(18, 67);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblPswrdCnfrm
            // 
            this.lblPswrdCnfrm.AutoSize = true;
            this.lblPswrdCnfrm.Location = new System.Drawing.Point(18, 118);
            this.lblPswrdCnfrm.Name = "lblPswrdCnfrm";
            this.lblPswrdCnfrm.Size = new System.Drawing.Size(94, 13);
            this.lblPswrdCnfrm.TabIndex = 2;
            this.lblPswrdCnfrm.Text = "Confirm Password:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(146, 31);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(146, 64);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // txtPswrdCnfrm
            // 
            this.txtPswrdCnfrm.Location = new System.Drawing.Point(146, 111);
            this.txtPswrdCnfrm.Name = "txtPswrdCnfrm";
            this.txtPswrdCnfrm.Size = new System.Drawing.Size(100, 20);
            this.txtPswrdCnfrm.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(260, 31);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Location = new System.Drawing.Point(153, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "grpExit";
            // 
            // grpRgster
            // 
            this.grpRgster.Controls.Add(this.lblUser);
            this.grpRgster.Controls.Add(this.lblPassword);
            this.grpRgster.Controls.Add(this.btnSubmit);
            this.grpRgster.Controls.Add(this.lblPswrdCnfrm);
            this.grpRgster.Controls.Add(this.txtPswrdCnfrm);
            this.grpRgster.Controls.Add(this.txtUser);
            this.grpRgster.Controls.Add(this.txtPassword);
            this.grpRgster.Location = new System.Drawing.Point(106, 51);
            this.grpRgster.Name = "grpRgster";
            this.grpRgster.Size = new System.Drawing.Size(341, 153);
            this.grpRgster.TabIndex = 8;
            this.grpRgster.TabStop = false;
            this.grpRgster.Text = "Register New Account";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(67, 38);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // RegistFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.grpRgster);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistFrm";
            this.Text = "RegistFrm";
            this.groupBox1.ResumeLayout(false);
            this.grpRgster.ResumeLayout(false);
            this.grpRgster.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPswrdCnfrm;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPswrdCnfrm;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpRgster;
    }
}