namespace Lethal_Devs_Project
{
    partial class editVehForm
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
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textboxVin = new System.Windows.Forms.TextBox();
            this.textboxLicense = new System.Windows.Forms.TextBox();
            this.textboxMileage = new System.Windows.Forms.TextBox();
            this.textboxCcm = new System.Windows.Forms.TextBox();
            this.txtboxProdyear = new System.Windows.Forms.TextBox();
            this.txtboxType = new System.Windows.Forms.TextBox();
            this.lblVin = new System.Windows.Forms.Label();
            this.lblCcm = new System.Windows.Forms.Label();
            this.lblLicense = new System.Windows.Forms.Label();
            this.lblEngine = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblProdyear = new System.Windows.Forms.Label();
            this.lblMileage = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.comboColor = new System.Windows.Forms.ComboBox();
            this.comboFuel = new System.Windows.Forms.ComboBox();
            this.comboEngine = new System.Windows.Forms.ComboBox();
            this.comboOwner = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.hiddenId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.label11.Location = new System.Drawing.Point(131, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(239, 106);
            this.label11.TabIndex = 30;
            this.label11.Text = "Jármű szerkesztése";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lethal_Devs_Project.Properties.Resources.editcar;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // textboxVin
            // 
            this.textboxVin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textboxVin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxVin.ForeColor = System.Drawing.Color.White;
            this.textboxVin.Location = new System.Drawing.Point(130, 502);
            this.textboxVin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textboxVin.MaxLength = 17;
            this.textboxVin.Multiline = true;
            this.textboxVin.Name = "textboxVin";
            this.textboxVin.Size = new System.Drawing.Size(240, 32);
            this.textboxVin.TabIndex = 34;
            this.textboxVin.Click += new System.EventHandler(this.textboxVin_Click);
            // 
            // textboxLicense
            // 
            this.textboxLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textboxLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxLicense.ForeColor = System.Drawing.Color.White;
            this.textboxLicense.Location = new System.Drawing.Point(130, 460);
            this.textboxLicense.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textboxLicense.MaxLength = 6;
            this.textboxLicense.Multiline = true;
            this.textboxLicense.Name = "textboxLicense";
            this.textboxLicense.Size = new System.Drawing.Size(240, 32);
            this.textboxLicense.TabIndex = 33;
            this.textboxLicense.Click += new System.EventHandler(this.textboxLicense_Click);
            // 
            // textboxMileage
            // 
            this.textboxMileage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textboxMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxMileage.ForeColor = System.Drawing.Color.White;
            this.textboxMileage.Location = new System.Drawing.Point(130, 376);
            this.textboxMileage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textboxMileage.MaxLength = 6;
            this.textboxMileage.Multiline = true;
            this.textboxMileage.Name = "textboxMileage";
            this.textboxMileage.Size = new System.Drawing.Size(240, 32);
            this.textboxMileage.TabIndex = 31;
            this.textboxMileage.Click += new System.EventHandler(this.textboxMileage_Click);
            // 
            // textboxCcm
            // 
            this.textboxCcm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textboxCcm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxCcm.ForeColor = System.Drawing.Color.White;
            this.textboxCcm.Location = new System.Drawing.Point(130, 292);
            this.textboxCcm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textboxCcm.MaxLength = 6;
            this.textboxCcm.Multiline = true;
            this.textboxCcm.Name = "textboxCcm";
            this.textboxCcm.Size = new System.Drawing.Size(240, 32);
            this.textboxCcm.TabIndex = 27;
            this.textboxCcm.Click += new System.EventHandler(this.textboxCcm_Click);
            // 
            // txtboxProdyear
            // 
            this.txtboxProdyear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtboxProdyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxProdyear.ForeColor = System.Drawing.Color.White;
            this.txtboxProdyear.Location = new System.Drawing.Point(130, 208);
            this.txtboxProdyear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxProdyear.MaxLength = 4;
            this.txtboxProdyear.Multiline = true;
            this.txtboxProdyear.Name = "txtboxProdyear";
            this.txtboxProdyear.Size = new System.Drawing.Size(240, 32);
            this.txtboxProdyear.TabIndex = 25;
            this.txtboxProdyear.Click += new System.EventHandler(this.txtboxProdyear_Click);
            // 
            // txtboxType
            // 
            this.txtboxType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtboxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxType.ForeColor = System.Drawing.Color.White;
            this.txtboxType.Location = new System.Drawing.Point(130, 166);
            this.txtboxType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxType.MaxLength = 255;
            this.txtboxType.Multiline = true;
            this.txtboxType.Name = "txtboxType";
            this.txtboxType.Size = new System.Drawing.Size(240, 32);
            this.txtboxType.TabIndex = 22;
            this.txtboxType.Click += new System.EventHandler(this.txtboxType_Click);
            // 
            // lblVin
            // 
            this.lblVin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVin.ForeColor = System.Drawing.Color.White;
            this.lblVin.Location = new System.Drawing.Point(5, 502);
            this.lblVin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVin.Name = "lblVin";
            this.lblVin.Size = new System.Drawing.Size(120, 32);
            this.lblVin.TabIndex = 21;
            this.lblVin.Text = "Alvázszám:";
            this.lblVin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCcm
            // 
            this.lblCcm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCcm.ForeColor = System.Drawing.Color.White;
            this.lblCcm.Location = new System.Drawing.Point(5, 292);
            this.lblCcm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCcm.Name = "lblCcm";
            this.lblCcm.Size = new System.Drawing.Size(120, 32);
            this.lblCcm.TabIndex = 20;
            this.lblCcm.Text = "Köbcenti:";
            this.lblCcm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLicense
            // 
            this.lblLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLicense.ForeColor = System.Drawing.Color.White;
            this.lblLicense.Location = new System.Drawing.Point(5, 460);
            this.lblLicense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(120, 32);
            this.lblLicense.TabIndex = 19;
            this.lblLicense.Text = "Rendszám:";
            this.lblLicense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEngine
            // 
            this.lblEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEngine.ForeColor = System.Drawing.Color.White;
            this.lblEngine.Location = new System.Drawing.Point(5, 250);
            this.lblEngine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(120, 32);
            this.lblEngine.TabIndex = 14;
            this.lblEngine.Text = "Motor:";
            this.lblEngine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblColor
            // 
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblColor.ForeColor = System.Drawing.Color.White;
            this.lblColor.Location = new System.Drawing.Point(5, 418);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(120, 32);
            this.lblColor.TabIndex = 17;
            this.lblColor.Text = "Szín:";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProdyear
            // 
            this.lblProdyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProdyear.ForeColor = System.Drawing.Color.White;
            this.lblProdyear.Location = new System.Drawing.Point(5, 208);
            this.lblProdyear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProdyear.Name = "lblProdyear";
            this.lblProdyear.Size = new System.Drawing.Size(120, 32);
            this.lblProdyear.TabIndex = 16;
            this.lblProdyear.Text = "Évjárat:";
            this.lblProdyear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMileage
            // 
            this.lblMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMileage.ForeColor = System.Drawing.Color.White;
            this.lblMileage.Location = new System.Drawing.Point(5, 376);
            this.lblMileage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(120, 32);
            this.lblMileage.TabIndex = 15;
            this.lblMileage.Text = "KM futott:";
            this.lblMileage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(5, 166);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(120, 32);
            this.lblType.TabIndex = 23;
            this.lblType.Text = "Típus:";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFuel
            // 
            this.lblFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFuel.ForeColor = System.Drawing.Color.White;
            this.lblFuel.Location = new System.Drawing.Point(5, 334);
            this.lblFuel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(120, 32);
            this.lblFuel.TabIndex = 24;
            this.lblFuel.Text = "Üzemanyag:";
            this.lblFuel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOwner
            // 
            this.lblOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOwner.ForeColor = System.Drawing.Color.White;
            this.lblOwner.Location = new System.Drawing.Point(5, 123);
            this.lblOwner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(120, 32);
            this.lblOwner.TabIndex = 18;
            this.lblOwner.Text = "Tulajdonos:";
            this.lblOwner.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboColor
            // 
            this.comboColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.comboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboColor.ForeColor = System.Drawing.Color.White;
            this.comboColor.FormattingEnabled = true;
            this.comboColor.Location = new System.Drawing.Point(130, 418);
            this.comboColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboColor.MaximumSize = new System.Drawing.Size(240, 0);
            this.comboColor.MinimumSize = new System.Drawing.Size(240, 0);
            this.comboColor.Name = "comboColor";
            this.comboColor.Size = new System.Drawing.Size(240, 32);
            this.comboColor.TabIndex = 32;
            this.comboColor.Click += new System.EventHandler(this.comboColor_Click);
            // 
            // comboFuel
            // 
            this.comboFuel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.comboFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFuel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFuel.ForeColor = System.Drawing.Color.White;
            this.comboFuel.FormattingEnabled = true;
            this.comboFuel.Location = new System.Drawing.Point(130, 334);
            this.comboFuel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboFuel.MaximumSize = new System.Drawing.Size(240, 0);
            this.comboFuel.MinimumSize = new System.Drawing.Size(240, 0);
            this.comboFuel.Name = "comboFuel";
            this.comboFuel.Size = new System.Drawing.Size(240, 32);
            this.comboFuel.TabIndex = 29;
            this.comboFuel.Click += new System.EventHandler(this.comboFuel_Click);
            // 
            // comboEngine
            // 
            this.comboEngine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.comboEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEngine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEngine.ForeColor = System.Drawing.Color.White;
            this.comboEngine.FormattingEnabled = true;
            this.comboEngine.Location = new System.Drawing.Point(130, 250);
            this.comboEngine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboEngine.MaximumSize = new System.Drawing.Size(240, 0);
            this.comboEngine.MinimumSize = new System.Drawing.Size(240, 0);
            this.comboEngine.Name = "comboEngine";
            this.comboEngine.Size = new System.Drawing.Size(240, 32);
            this.comboEngine.TabIndex = 26;
            this.comboEngine.Click += new System.EventHandler(this.comboEngine_Click);
            // 
            // comboOwner
            // 
            this.comboOwner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.comboOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboOwner.ForeColor = System.Drawing.Color.White;
            this.comboOwner.FormattingEnabled = true;
            this.comboOwner.Items.AddRange(new object[] {
            "Minta István"});
            this.comboOwner.Location = new System.Drawing.Point(130, 123);
            this.comboOwner.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboOwner.MaximumSize = new System.Drawing.Size(240, 0);
            this.comboOwner.MinimumSize = new System.Drawing.Size(240, 0);
            this.comboOwner.Name = "comboOwner";
            this.comboOwner.Size = new System.Drawing.Size(240, 32);
            this.comboOwner.TabIndex = 13;
            this.comboOwner.Click += new System.EventHandler(this.comboOwner_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.btnBack.Location = new System.Drawing.Point(13, 543);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 37);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "Vissza";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.btnEdit.Location = new System.Drawing.Point(258, 543);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 37);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "Szerkesztés";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // hiddenId
            // 
            this.hiddenId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.hiddenId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.hiddenId.Location = new System.Drawing.Point(388, 0);
            this.hiddenId.Name = "hiddenId";
            this.hiddenId.Size = new System.Drawing.Size(44, 20);
            this.hiddenId.TabIndex = 999;
            this.hiddenId.Visible = false;
            // 
            // editVehForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(389, 593);
            this.ControlBox = false;
            this.Controls.Add(this.hiddenId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textboxVin);
            this.Controls.Add(this.textboxLicense);
            this.Controls.Add(this.textboxMileage);
            this.Controls.Add(this.textboxCcm);
            this.Controls.Add(this.txtboxProdyear);
            this.Controls.Add(this.txtboxType);
            this.Controls.Add(this.lblVin);
            this.Controls.Add(this.lblCcm);
            this.Controls.Add(this.lblLicense);
            this.Controls.Add(this.lblEngine);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblProdyear);
            this.Controls.Add(this.lblMileage);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblFuel);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.comboColor);
            this.Controls.Add(this.comboFuel);
            this.Controls.Add(this.comboEngine);
            this.Controls.Add(this.comboOwner);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEdit);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "editVehForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jármű szerkesztése";
            this.Load += new System.EventHandler(this.editVehForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textboxVin;
        private System.Windows.Forms.TextBox textboxLicense;
        private System.Windows.Forms.TextBox textboxMileage;
        private System.Windows.Forms.TextBox textboxCcm;
        private System.Windows.Forms.TextBox txtboxProdyear;
        private System.Windows.Forms.TextBox txtboxType;
        private System.Windows.Forms.Label lblVin;
        private System.Windows.Forms.Label lblCcm;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.Label lblEngine;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblProdyear;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.ComboBox comboColor;
        private System.Windows.Forms.ComboBox comboFuel;
        private System.Windows.Forms.ComboBox comboEngine;
        private System.Windows.Forms.ComboBox comboOwner;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox hiddenId;
    }
}