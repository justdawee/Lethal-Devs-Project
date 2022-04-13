namespace Lethal_Devs_Project.MainFormTabs
{
    partial class SecondTab
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
            this.tabLabel = new System.Windows.Forms.Label();
            this.listVehicles = new System.Windows.Forms.ListBox();
            this.addVehBtn = new System.Windows.Forms.Button();
            this.editVehBtn = new System.Windows.Forms.Button();
            this.delVehBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tabLabel
            // 
            this.tabLabel.AutoSize = true;
            this.tabLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLabel.ForeColor = System.Drawing.Color.White;
            this.tabLabel.Location = new System.Drawing.Point(12, 9);
            this.tabLabel.Name = "tabLabel";
            this.tabLabel.Size = new System.Drawing.Size(155, 25);
            this.tabLabel.TabIndex = 1;
            this.tabLabel.Text = "Manage Vehicles";
            // 
            // listVehicles
            // 
            this.listVehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.listVehicles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listVehicles.Font = new System.Drawing.Font("Myriad Arabic", 12F);
            this.listVehicles.ForeColor = System.Drawing.Color.White;
            this.listVehicles.FormattingEnabled = true;
            this.listVehicles.ItemHeight = 22;
            this.listVehicles.Items.AddRange(new object[] {
            "No items in the database..."});
            this.listVehicles.Location = new System.Drawing.Point(201, 56);
            this.listVehicles.Name = "listVehicles";
            this.listVehicles.Size = new System.Drawing.Size(520, 396);
            this.listVehicles.TabIndex = 2;
            // 
            // addVehBtn
            // 
            this.addVehBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.addVehBtn.FlatAppearance.BorderSize = 0;
            this.addVehBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVehBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVehBtn.ForeColor = System.Drawing.Color.White;
            this.addVehBtn.Location = new System.Drawing.Point(12, 56);
            this.addVehBtn.Name = "addVehBtn";
            this.addVehBtn.Size = new System.Drawing.Size(155, 40);
            this.addVehBtn.TabIndex = 56;
            this.addVehBtn.Text = "Add Vehicle";
            this.addVehBtn.UseVisualStyleBackColor = false;
            // 
            // editVehBtn
            // 
            this.editVehBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.editVehBtn.FlatAppearance.BorderSize = 0;
            this.editVehBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editVehBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editVehBtn.ForeColor = System.Drawing.Color.White;
            this.editVehBtn.Location = new System.Drawing.Point(12, 102);
            this.editVehBtn.Name = "editVehBtn";
            this.editVehBtn.Size = new System.Drawing.Size(155, 40);
            this.editVehBtn.TabIndex = 56;
            this.editVehBtn.Text = "Edit Selected";
            this.editVehBtn.UseVisualStyleBackColor = false;
            // 
            // delVehBtn
            // 
            this.delVehBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.delVehBtn.FlatAppearance.BorderSize = 0;
            this.delVehBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delVehBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delVehBtn.ForeColor = System.Drawing.Color.White;
            this.delVehBtn.Location = new System.Drawing.Point(12, 148);
            this.delVehBtn.Name = "delVehBtn";
            this.delVehBtn.Size = new System.Drawing.Size(155, 40);
            this.delVehBtn.TabIndex = 56;
            this.delVehBtn.Text = "Delete Vehicle";
            this.delVehBtn.UseVisualStyleBackColor = false;
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
            this.refreshBtn.TabIndex = 56;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            // 
            // SecondTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.delVehBtn);
            this.Controls.Add(this.editVehBtn);
            this.Controls.Add(this.addVehBtn);
            this.Controls.Add(this.listVehicles);
            this.Controls.Add(this.tabLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SecondTab";
            this.Text = "SecondTab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tabLabel;
        private System.Windows.Forms.ListBox listVehicles;
        private System.Windows.Forms.Button addVehBtn;
        private System.Windows.Forms.Button editVehBtn;
        private System.Windows.Forms.Button delVehBtn;
        private System.Windows.Forms.Button refreshBtn;
    }
}