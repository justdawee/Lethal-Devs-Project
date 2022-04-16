namespace Lethal_Devs_Project
{
    partial class addUserForm
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
            this.bornDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBorndate = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPw = new System.Windows.Forms.Label();
            this.txtboxPw = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtboxPhone = new System.Windows.Forms.TextBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.checkboxAdminYes = new System.Windows.Forms.CheckBox();
            this.checkboxAdminNo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bornDatePicker
            // 
            this.bornDatePicker.Location = new System.Drawing.Point(130, 297);
            this.bornDatePicker.Name = "bornDatePicker";
            this.bornDatePicker.Size = new System.Drawing.Size(240, 20);
            this.bornDatePicker.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(131, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(239, 106);
            this.label11.TabIndex = 71;
            this.label11.Text = "Felhasználó hozzáadása";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lethal_Devs_Project.Properties.Resources.Untitled_11;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtboxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEmail.ForeColor = System.Drawing.Color.White;
            this.txtboxEmail.Location = new System.Drawing.Point(130, 334);
            this.txtboxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxEmail.MaxLength = 255;
            this.txtboxEmail.Multiline = true;
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(240, 32);
            this.txtboxEmail.TabIndex = 6;
            this.txtboxEmail.Text = "minta@gmail.com";
            this.txtboxEmail.Click += new System.EventHandler(this.txtboxEmail_Click);
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtboxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxAddress.ForeColor = System.Drawing.Color.White;
            this.txtboxAddress.Location = new System.Drawing.Point(130, 250);
            this.txtboxAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxAddress.MaxLength = 120;
            this.txtboxAddress.Multiline = true;
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(240, 32);
            this.txtboxAddress.TabIndex = 4;
            this.txtboxAddress.Text = "1234 Budapest, Minta utca 12.";
            this.txtboxAddress.Click += new System.EventHandler(this.txtboxAddress_Click);
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtboxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxUsername.ForeColor = System.Drawing.Color.White;
            this.txtboxUsername.Location = new System.Drawing.Point(130, 124);
            this.txtboxUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxUsername.MaxLength = 50;
            this.txtboxUsername.Multiline = true;
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(240, 32);
            this.txtboxUsername.TabIndex = 1;
            this.txtboxUsername.Text = "MintaJanos";
            this.txtboxUsername.Click += new System.EventHandler(this.txtboxUsername_Click);
            // 
            // txtboxName
            // 
            this.txtboxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtboxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxName.ForeColor = System.Drawing.Color.White;
            this.txtboxName.Location = new System.Drawing.Point(130, 208);
            this.txtboxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxName.MaxLength = 255;
            this.txtboxName.Multiline = true;
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(240, 32);
            this.txtboxName.TabIndex = 3;
            this.txtboxName.Text = "Minta János";
            this.txtboxName.Click += new System.EventHandler(this.txtboxName_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(5, 334);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(120, 32);
            this.lblEmail.TabIndex = 63;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBorndate
            // 
            this.lblBorndate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBorndate.ForeColor = System.Drawing.Color.White;
            this.lblBorndate.Location = new System.Drawing.Point(5, 292);
            this.lblBorndate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorndate.Name = "lblBorndate";
            this.lblBorndate.Size = new System.Drawing.Size(120, 32);
            this.lblBorndate.TabIndex = 58;
            this.lblBorndate.Text = "Szül. dátum:";
            this.lblBorndate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(5, 250);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(120, 32);
            this.lblAddress.TabIndex = 62;
            this.lblAddress.Text = "Cím:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(5, 208);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(120, 32);
            this.lblName.TabIndex = 61;
            this.lblName.Text = "Név:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(5, 129);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(120, 27);
            this.lblUsername.TabIndex = 59;
            this.lblUsername.Text = "Felhasználónév:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(13, 462);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 37);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Vissza";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(258, 462);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 37);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Hozzáadás";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPw
            // 
            this.lblPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPw.ForeColor = System.Drawing.Color.White;
            this.lblPw.Location = new System.Drawing.Point(9, 166);
            this.lblPw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPw.Name = "lblPw";
            this.lblPw.Size = new System.Drawing.Size(120, 32);
            this.lblPw.TabIndex = 59;
            this.lblPw.Text = "Jelszó:";
            this.lblPw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtboxPw
            // 
            this.txtboxPw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtboxPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPw.ForeColor = System.Drawing.Color.White;
            this.txtboxPw.Location = new System.Drawing.Point(130, 166);
            this.txtboxPw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxPw.MaxLength = 255;
            this.txtboxPw.Multiline = true;
            this.txtboxPw.Name = "txtboxPw";
            this.txtboxPw.PasswordChar = '*';
            this.txtboxPw.Size = new System.Drawing.Size(240, 32);
            this.txtboxPw.TabIndex = 2;
            this.txtboxPw.Text = "MintaJelszo";
            this.txtboxPw.Click += new System.EventHandler(this.txtboxPw_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(5, 376);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(120, 32);
            this.lblPhone.TabIndex = 63;
            this.lblPhone.Text = "Telefonszám:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtboxPhone
            // 
            this.txtboxPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtboxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPhone.ForeColor = System.Drawing.Color.White;
            this.txtboxPhone.Location = new System.Drawing.Point(130, 376);
            this.txtboxPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxPhone.MaxLength = 255;
            this.txtboxPhone.Multiline = true;
            this.txtboxPhone.Name = "txtboxPhone";
            this.txtboxPhone.Size = new System.Drawing.Size(240, 32);
            this.txtboxPhone.TabIndex = 6;
            this.txtboxPhone.Text = "06701234567";
            this.txtboxPhone.Click += new System.EventHandler(this.txtboxPhone_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Location = new System.Drawing.Point(5, 411);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(120, 32);
            this.lblAdmin.TabIndex = 63;
            this.lblAdmin.Text = "Admin?";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkboxAdminYes
            // 
            this.checkboxAdminYes.AutoSize = true;
            this.checkboxAdminYes.FlatAppearance.BorderSize = 0;
            this.checkboxAdminYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkboxAdminYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkboxAdminYes.ForeColor = System.Drawing.Color.White;
            this.checkboxAdminYes.Location = new System.Drawing.Point(130, 418);
            this.checkboxAdminYes.Name = "checkboxAdminYes";
            this.checkboxAdminYes.Size = new System.Drawing.Size(49, 20);
            this.checkboxAdminYes.TabIndex = 9;
            this.checkboxAdminYes.Text = "Igen";
            this.checkboxAdminYes.UseVisualStyleBackColor = true;
            this.checkboxAdminYes.CheckedChanged += new System.EventHandler(this.checkboxAdminYes_CheckedChanged);
            // 
            // checkboxAdminNo
            // 
            this.checkboxAdminNo.AutoSize = true;
            this.checkboxAdminNo.Checked = true;
            this.checkboxAdminNo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxAdminNo.FlatAppearance.BorderSize = 0;
            this.checkboxAdminNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkboxAdminNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkboxAdminNo.ForeColor = System.Drawing.Color.White;
            this.checkboxAdminNo.Location = new System.Drawing.Point(180, 418);
            this.checkboxAdminNo.Name = "checkboxAdminNo";
            this.checkboxAdminNo.Size = new System.Drawing.Size(52, 20);
            this.checkboxAdminNo.TabIndex = 8;
            this.checkboxAdminNo.Text = "Nem";
            this.checkboxAdminNo.UseVisualStyleBackColor = true;
            this.checkboxAdminNo.CheckedChanged += new System.EventHandler(this.checkboxAdminNo_CheckedChanged);
            // 
            // addUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(389, 513);
            this.ControlBox = false;
            this.Controls.Add(this.checkboxAdminNo);
            this.Controls.Add(this.checkboxAdminYes);
            this.Controls.Add(this.bornDatePicker);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtboxPhone);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.txtboxAddress);
            this.Controls.Add(this.txtboxPw);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblBorndate);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPw);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "addUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Felhasználó Hozzáadása";
            this.Load += new System.EventHandler(this.addUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker bornDatePicker;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.TextBox txtboxAddress;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBorndate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPw;
        private System.Windows.Forms.TextBox txtboxPw;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtboxPhone;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.CheckBox checkboxAdminYes;
        private System.Windows.Forms.CheckBox checkboxAdminNo;
    }
}