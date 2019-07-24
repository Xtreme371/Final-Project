namespace Project
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.gpbregister = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblregister = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblsurname = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.gpbregister.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbregister
            // 
            this.gpbregister.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpbregister.Controls.Add(this.btnlogin);
            this.gpbregister.Controls.Add(this.txtpass);
            this.gpbregister.Controls.Add(this.txtuser);
            this.gpbregister.Controls.Add(this.txtsurname);
            this.gpbregister.Controls.Add(this.lblpass);
            this.gpbregister.Controls.Add(this.lbluser);
            this.gpbregister.Controls.Add(this.lblsurname);
            this.gpbregister.Controls.Add(this.lblname);
            this.gpbregister.Controls.Add(this.btnSignUp);
            this.gpbregister.Controls.Add(this.txtname);
            this.gpbregister.Controls.Add(this.label1);
            this.gpbregister.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbregister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpbregister.Location = new System.Drawing.Point(12, 55);
            this.gpbregister.Name = "gpbregister";
            this.gpbregister.Size = new System.Drawing.Size(347, 495);
            this.gpbregister.TabIndex = 0;
            this.gpbregister.TabStop = false;
            this.gpbregister.Text = "SignUp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 14);
            this.label1.TabIndex = 0;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(41, 69);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(226, 20);
            this.txtname.TabIndex = 1;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSignUp.Location = new System.Drawing.Point(79, 319);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(188, 35);
            this.btnSignUp.TabIndex = 2;
            this.btnSignUp.Text = "SignUp";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblregister
            // 
            this.lblregister.AutoSize = true;
            this.lblregister.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregister.Location = new System.Drawing.Point(106, 9);
            this.lblregister.Name = "lblregister";
            this.lblregister.Size = new System.Drawing.Size(178, 34);
            this.lblregister.TabIndex = 3;
            this.lblregister.Text = "REGISTER";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblname.Location = new System.Drawing.Point(38, 30);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(56, 18);
            this.lblname.TabIndex = 4;
            this.lblname.Text = "Name";
            // 
            // lblsurname
            // 
            this.lblsurname.AutoSize = true;
            this.lblsurname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsurname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblsurname.Location = new System.Drawing.Point(38, 92);
            this.lblsurname.Name = "lblsurname";
            this.lblsurname.Size = new System.Drawing.Size(83, 18);
            this.lblsurname.TabIndex = 5;
            this.lblsurname.Text = "Surname";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbluser.Location = new System.Drawing.Point(38, 158);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(94, 18);
            this.lbluser.TabIndex = 6;
            this.lbluser.Text = "UserName";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblpass.Location = new System.Drawing.Point(43, 232);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(87, 18);
            this.lblpass.TabIndex = 7;
            this.lblpass.Text = "Password";
            // 
            // txtsurname
            // 
            this.txtsurname.Location = new System.Drawing.Point(41, 125);
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(226, 20);
            this.txtsurname.TabIndex = 8;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(41, 192);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(226, 20);
            this.txtuser.TabIndex = 9;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(41, 267);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(226, 20);
            this.txtpass.TabIndex = 10;
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlogin.Location = new System.Drawing.Point(6, 443);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(134, 34);
            this.btnlogin.TabIndex = 11;
            this.btnlogin.Text = "BackToLogin";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 544);
            this.Controls.Add(this.lblregister);
            this.Controls.Add(this.gpbregister);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.gpbregister.ResumeLayout(false);
            this.gpbregister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbregister;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtsurname;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblsurname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblregister;
    }
}