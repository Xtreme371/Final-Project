namespace Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.gpbLogin = new System.Windows.Forms.GroupBox();
            this.btnsign = new System.Windows.Forms.Button();
            this.lblnewapplicant = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblsignIn = new System.Windows.Forms.Label();
            this.gpbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbLogin
            // 
            this.gpbLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpbLogin.Controls.Add(this.btnsign);
            this.gpbLogin.Controls.Add(this.lblnewapplicant);
            this.gpbLogin.Controls.Add(this.txtpass);
            this.gpbLogin.Controls.Add(this.txtuser);
            this.gpbLogin.Controls.Add(this.lblpass);
            this.gpbLogin.Controls.Add(this.lbluser);
            this.gpbLogin.Controls.Add(this.btnSignUp);
            this.gpbLogin.Controls.Add(this.label1);
            this.gpbLogin.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpbLogin.Location = new System.Drawing.Point(3, 41);
            this.gpbLogin.Name = "gpbLogin";
            this.gpbLogin.Size = new System.Drawing.Size(347, 514);
            this.gpbLogin.TabIndex = 1;
            this.gpbLogin.TabStop = false;
            this.gpbLogin.Text = "SignIn";
            // 
            // btnsign
            // 
            this.btnsign.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsign.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsign.Location = new System.Drawing.Point(156, 451);
            this.btnsign.Name = "btnsign";
            this.btnsign.Size = new System.Drawing.Size(146, 35);
            this.btnsign.TabIndex = 11;
            this.btnsign.Text = "SignUp";
            this.btnsign.UseVisualStyleBackColor = true;
            this.btnsign.Click += new System.EventHandler(this.btnsign_Click);
            // 
            // lblnewapplicant
            // 
            this.lblnewapplicant.AutoSize = true;
            this.lblnewapplicant.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewapplicant.Location = new System.Drawing.Point(163, 418);
            this.lblnewapplicant.Name = "lblnewapplicant";
            this.lblnewapplicant.Size = new System.Drawing.Size(139, 18);
            this.lblnewapplicant.TabIndex = 5;
            this.lblnewapplicant.Text = "New Applicant?";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(20, 188);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(226, 20);
            this.txtpass.TabIndex = 10;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(20, 102);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(226, 20);
            this.txtuser.TabIndex = 9;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblpass.Location = new System.Drawing.Point(17, 154);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(87, 18);
            this.lblpass.TabIndex = 7;
            this.lblpass.Text = "Password";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbluser.Location = new System.Drawing.Point(17, 64);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(94, 18);
            this.lbluser.TabIndex = 6;
            this.lbluser.Text = "UserName";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSignUp.Location = new System.Drawing.Point(20, 253);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(188, 35);
            this.btnSignUp.TabIndex = 2;
            this.btnSignUp.Text = "LogIn";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 14);
            this.label1.TabIndex = 0;
            // 
            // lblsignIn
            // 
            this.lblsignIn.AutoSize = true;
            this.lblsignIn.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsignIn.Location = new System.Drawing.Point(26, 4);
            this.lblsignIn.Name = "lblsignIn";
            this.lblsignIn.Size = new System.Drawing.Size(138, 34);
            this.lblsignIn.TabIndex = 4;
            this.lblsignIn.Text = "SIGN IN";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 548);
            this.Controls.Add(this.lblsignIn);
            this.Controls.Add(this.gpbLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.gpbLogin.ResumeLayout(false);
            this.gpbLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbLogin;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnewapplicant;
        private System.Windows.Forms.Label lblsignIn;
        private System.Windows.Forms.Button btnsign;
    }
}