namespace Lethal_Devs_Project.MainFormTabs
{
    partial class ThirdTab
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
            this.refreshBtn = new System.Windows.Forms.Button();
            this.delUserBtn = new System.Windows.Forms.Button();
            this.editUserBtn = new System.Windows.Forms.Button();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.listUsers = new System.Windows.Forms.ListBox();
            this.tabLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.refreshBtn.FlatAppearance.BorderSize = 0;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.ForeColor = System.Drawing.Color.White;
            this.refreshBtn.Location = new System.Drawing.Point(12, 423);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(155, 40);
            this.refreshBtn.TabIndex = 59;
            this.refreshBtn.Text = "Frissítés";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // delUserBtn
            // 
            this.delUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.delUserBtn.FlatAppearance.BorderSize = 0;
            this.delUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delUserBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delUserBtn.ForeColor = System.Drawing.Color.White;
            this.delUserBtn.Location = new System.Drawing.Point(12, 148);
            this.delUserBtn.Name = "delUserBtn";
            this.delUserBtn.Size = new System.Drawing.Size(155, 40);
            this.delUserBtn.TabIndex = 60;
            this.delUserBtn.Text = "Felh. Törlése";
            this.delUserBtn.UseVisualStyleBackColor = false;
            this.delUserBtn.Click += new System.EventHandler(this.delUserBtn_Click);
            // 
            // editUserBtn
            // 
            this.editUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.editUserBtn.FlatAppearance.BorderSize = 0;
            this.editUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editUserBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUserBtn.ForeColor = System.Drawing.Color.White;
            this.editUserBtn.Location = new System.Drawing.Point(12, 102);
            this.editUserBtn.Name = "editUserBtn";
            this.editUserBtn.Size = new System.Drawing.Size(155, 40);
            this.editUserBtn.TabIndex = 61;
            this.editUserBtn.Text = "Szerkesztés";
            this.editUserBtn.UseVisualStyleBackColor = false;
            this.editUserBtn.Click += new System.EventHandler(this.editUserBtn_Click);
            // 
            // addUserBtn
            // 
            this.addUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.addUserBtn.FlatAppearance.BorderSize = 0;
            this.addUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserBtn.ForeColor = System.Drawing.Color.White;
            this.addUserBtn.Location = new System.Drawing.Point(12, 56);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(155, 40);
            this.addUserBtn.TabIndex = 62;
            this.addUserBtn.Text = "Felvétel";
            this.addUserBtn.UseVisualStyleBackColor = false;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // listUsers
            // 
            this.listUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.listUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listUsers.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listUsers.ForeColor = System.Drawing.Color.White;
            this.listUsers.FormattingEnabled = true;
            this.listUsers.ItemHeight = 15;
            this.listUsers.Items.AddRange(new object[] {
            "Az adatbázis üres..."});
            this.listUsers.Location = new System.Drawing.Point(201, 56);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(520, 390);
            this.listUsers.TabIndex = 58;
            // 
            // tabLabel
            // 
            this.tabLabel.AutoSize = true;
            this.tabLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLabel.ForeColor = System.Drawing.Color.White;
            this.tabLabel.Location = new System.Drawing.Point(12, 9);
            this.tabLabel.Name = "tabLabel";
            this.tabLabel.Size = new System.Drawing.Size(244, 25);
            this.tabLabel.TabIndex = 57;
            this.tabLabel.Text = "Felhasználók Menedzselése";
            // 
            // ThirdTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.delUserBtn);
            this.Controls.Add(this.editUserBtn);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.listUsers);
            this.Controls.Add(this.tabLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThirdTab";
            this.Text = "ThirdTab";
            this.Load += new System.EventHandler(this.ThirdTab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button delUserBtn;
        private System.Windows.Forms.Button editUserBtn;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.Label tabLabel;
    }
}