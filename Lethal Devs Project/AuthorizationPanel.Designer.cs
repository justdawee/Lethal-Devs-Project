namespace Lethal_Devs_Project
{
    partial class AuthorizationPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.rememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.forgotBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LoginIcon = new System.Windows.Forms.PictureBox();
            this.showPwPic = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LoginIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPwPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(1, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrator Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rememberMeCheckBox
            // 
            this.rememberMeCheckBox.AutoSize = true;
            this.rememberMeCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.rememberMeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rememberMeCheckBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.rememberMeCheckBox.Location = new System.Drawing.Point(51, 404);
            this.rememberMeCheckBox.Name = "rememberMeCheckBox";
            this.rememberMeCheckBox.Size = new System.Drawing.Size(119, 21);
            this.rememberMeCheckBox.TabIndex = 1;
            this.rememberMeCheckBox.Text = "Remember me";
            this.rememberMeCheckBox.UseVisualStyleBackColor = false;
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameBox.Location = new System.Drawing.Point(50, 314);
            this.usernameBox.MaxLength = 32;
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(328, 27);
            this.usernameBox.TabIndex = 2;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(51, 439);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(328, 40);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(47, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(47, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordBox.Location = new System.Drawing.Point(50, 369);
            this.passwordBox.MaxLength = 32;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(328, 27);
            this.passwordBox.TabIndex = 2;
            // 
            // forgotBtn
            // 
            this.forgotBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.forgotBtn.FlatAppearance.BorderSize = 0;
            this.forgotBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgotBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.forgotBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.forgotBtn.Location = new System.Drawing.Point(248, 404);
            this.forgotBtn.Margin = new System.Windows.Forms.Padding(0);
            this.forgotBtn.Name = "forgotBtn";
            this.forgotBtn.Size = new System.Drawing.Size(130, 27);
            this.forgotBtn.TabIndex = 3;
            this.forgotBtn.Text = "Forgot password?";
            this.forgotBtn.UseVisualStyleBackColor = false;
            this.forgotBtn.Click += new System.EventHandler(this.forgotBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(406, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(31, 29);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(120, 515);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(192, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Made with ♥ by Dávid Lukács ® 2022";
            // 
            // LoginIcon
            // 
            this.LoginIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.LoginIcon.Image = global::Lethal_Devs_Project.Properties.Resources.icon;
            this.LoginIcon.Location = new System.Drawing.Point(141, 57);
            this.LoginIcon.Name = "LoginIcon";
            this.LoginIcon.Size = new System.Drawing.Size(150, 150);
            this.LoginIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginIcon.TabIndex = 4;
            this.LoginIcon.TabStop = false;
            // 
            // showPwPic
            // 
            this.showPwPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.showPwPic.Image = global::Lethal_Devs_Project.Properties.Resources.showpassword;
            this.showPwPic.Location = new System.Drawing.Point(386, 375);
            this.showPwPic.Name = "showPwPic";
            this.showPwPic.Size = new System.Drawing.Size(24, 15);
            this.showPwPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showPwPic.TabIndex = 6;
            this.showPwPic.TabStop = false;
            this.showPwPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showPwPic_MouseDown);
            this.showPwPic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.showPwPic_MouseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "DEBUG";
            // 
            // AuthorizationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(440, 530);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LoginIcon);
            this.Controls.Add(this.showPwPic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.forgotBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rememberMeCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthorizationPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Management System Administrator Unit";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AuthorizationPanel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AuthorizationPanel_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AuthorizationPanel_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.LoginIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPwPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox rememberMeCheckBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button forgotBtn;
        private System.Windows.Forms.PictureBox LoginIcon;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox showPwPic;
        private System.Windows.Forms.Label label5;
    }
}

