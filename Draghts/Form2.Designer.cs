namespace Draghts
{
    partial class Form2
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
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbConfirmPW = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSignUpUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSignUpPW = new System.Windows.Forms.TextBox();
            this.lbWarning = new System.Windows.Forms.Label();
            this.lbWarning2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(89, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(92, 112);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(100, 20);
            this.tbUser.TabIndex = 1;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(251, 112);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(119, 20);
            this.tbPass.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(248, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Old English Text MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSignIn.Image = global::Draghts.Properties.Resources.Dark_Wood_Background_640x400;
            this.btnSignIn.Location = new System.Drawing.Point(92, 186);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(96, 32);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "Log In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSignUp.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Old English Text MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSignUp.Image = global::Draghts.Properties.Resources.Dark_Wood_Background_640x400;
            this.btnSignUp.Location = new System.Drawing.Point(471, 343);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(96, 32);
            this.btnSignUp.TabIndex = 5;
            this.btnSignUp.Text = "SignUp";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Old English Text MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(462, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm Password";
            // 
            // tbConfirmPW
            // 
            this.tbConfirmPW.Location = new System.Drawing.Point(466, 266);
            this.tbConfirmPW.Name = "tbConfirmPW";
            this.tbConfirmPW.Size = new System.Drawing.Size(101, 20);
            this.tbConfirmPW.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Old English Text MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(463, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Username";
            // 
            // tbSignUpUserName
            // 
            this.tbSignUpUserName.Location = new System.Drawing.Point(466, 133);
            this.tbSignUpUserName.Name = "tbSignUpUserName";
            this.tbSignUpUserName.Size = new System.Drawing.Size(95, 20);
            this.tbSignUpUserName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Old English Text MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(463, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbSignUpPW
            // 
            this.tbSignUpPW.Location = new System.Drawing.Point(466, 198);
            this.tbSignUpPW.Name = "tbSignUpPW";
            this.tbSignUpPW.Size = new System.Drawing.Size(101, 20);
            this.tbSignUpPW.TabIndex = 11;
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.BackColor = System.Drawing.Color.Transparent;
            this.lbWarning.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWarning.ForeColor = System.Drawing.Color.Red;
            this.lbWarning.Location = new System.Drawing.Point(414, 305);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(190, 18);
            this.lbWarning.TabIndex = 12;
            this.lbWarning.Text = "*your passwords do not match";
            this.lbWarning.Visible = false;
            // 
            // lbWarning2
            // 
            this.lbWarning2.AutoSize = true;
            this.lbWarning2.BackColor = System.Drawing.Color.Transparent;
            this.lbWarning2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWarning2.ForeColor = System.Drawing.Color.Red;
            this.lbWarning2.Location = new System.Drawing.Point(93, 151);
            this.lbWarning2.Name = "lbWarning2";
            this.lbWarning2.Size = new System.Drawing.Size(113, 18);
            this.lbWarning2.TabIndex = 13;
            this.lbWarning2.Text = "*wrong password";
            this.lbWarning2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Old English Text MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(461, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sign Up Here";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Draghts.Properties.Resources.Dark_Wood_Background_640x400;
            this.ClientSize = new System.Drawing.Size(631, 402);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbWarning2);
            this.Controls.Add(this.lbWarning);
            this.Controls.Add(this.tbSignUpPW);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSignUpUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbConfirmPW);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbConfirmPW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSignUpUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSignUpPW;
        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.Label lbWarning2;
        private System.Windows.Forms.Label label6;
    }
}