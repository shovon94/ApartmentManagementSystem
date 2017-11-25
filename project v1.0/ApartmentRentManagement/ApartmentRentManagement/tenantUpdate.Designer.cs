namespace ApartmentRentManagement
{
    partial class tenantUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tenantUpdate));
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhoneNo = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateOfRent = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioBtnFemale = new System.Windows.Forms.RadioButton();
            this.radioBtnMale = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNIDImage = new System.Windows.Forms.Button();
            this.pictureBoxNID = new System.Windows.Forms.PictureBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.pictureBoxTenant = new System.Windows.Forms.PictureBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.textBoxOccupation = new System.Windows.Forms.TextBox();
            this.textBoxMotherName = new System.Windows.Forms.TextBox();
            this.textBoxFatherName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelOccupation = new System.Windows.Forms.Label();
            this.labelFatherName = new System.Windows.Forms.Label();
            this.labelMotherName = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboBoxTenantName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTenant)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBoxEmail.Location = new System.Drawing.Point(210, 390);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(239, 27);
            this.textBoxEmail.TabIndex = 56;
            // 
            // textBoxPhoneNo
            // 
            this.textBoxPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBoxPhoneNo.Location = new System.Drawing.Point(210, 344);
            this.textBoxPhoneNo.Name = "textBoxPhoneNo";
            this.textBoxPhoneNo.Size = new System.Drawing.Size(239, 27);
            this.textBoxPhoneNo.TabIndex = 55;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelEmail.Location = new System.Drawing.Point(51, 395);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(57, 20);
            this.labelEmail.TabIndex = 54;
            this.labelEmail.Text = "E-mail";
            // 
            // labelPhoneNo
            // 
            this.labelPhoneNo.AutoSize = true;
            this.labelPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelPhoneNo.Location = new System.Drawing.Point(51, 351);
            this.labelPhoneNo.Name = "labelPhoneNo";
            this.labelPhoneNo.Size = new System.Drawing.Size(86, 20);
            this.labelPhoneNo.TabIndex = 53;
            this.labelPhoneNo.Text = "Phone No.";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnRemove.Location = new System.Drawing.Point(613, 600);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(135, 37);
            this.btnRemove.TabIndex = 52;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnCancel.Location = new System.Drawing.Point(445, 600);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 37);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dateOfRent
            // 
            this.dateOfRent.Location = new System.Drawing.Point(666, 498);
            this.dateOfRent.Name = "dateOfRent";
            this.dateOfRent.Size = new System.Drawing.Size(238, 22);
            this.dateOfRent.TabIndex = 50;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioBtnFemale);
            this.panel1.Controls.Add(this.radioBtnMale);
            this.panel1.Location = new System.Drawing.Point(206, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 50);
            this.panel1.TabIndex = 49;
            // 
            // radioBtnFemale
            // 
            this.radioBtnFemale.AutoSize = true;
            this.radioBtnFemale.Location = new System.Drawing.Point(149, 12);
            this.radioBtnFemale.Name = "radioBtnFemale";
            this.radioBtnFemale.Size = new System.Drawing.Size(75, 21);
            this.radioBtnFemale.TabIndex = 22;
            this.radioBtnFemale.TabStop = true;
            this.radioBtnFemale.Text = "Female";
            this.radioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // radioBtnMale
            // 
            this.radioBtnMale.AutoSize = true;
            this.radioBtnMale.Location = new System.Drawing.Point(29, 12);
            this.radioBtnMale.Name = "radioBtnMale";
            this.radioBtnMale.Size = new System.Drawing.Size(59, 21);
            this.radioBtnMale.TabIndex = 21;
            this.radioBtnMale.TabStop = true;
            this.radioBtnMale.Text = "Male";
            this.radioBtnMale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.Location = new System.Drawing.Point(507, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Date of Renting";
            // 
            // btnNIDImage
            // 
            this.btnNIDImage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnNIDImage.Location = new System.Drawing.Point(565, 418);
            this.btnNIDImage.Name = "btnNIDImage";
            this.btnNIDImage.Size = new System.Drawing.Size(75, 30);
            this.btnNIDImage.TabIndex = 47;
            this.btnNIDImage.Text = "Browse";
            this.btnNIDImage.UseVisualStyleBackColor = false;
            this.btnNIDImage.Click += new System.EventHandler(this.btnNIDImage_Click);
            // 
            // pictureBoxNID
            // 
            this.pictureBoxNID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxNID.Location = new System.Drawing.Point(565, 249);
            this.pictureBoxNID.Name = "pictureBoxNID";
            this.pictureBoxNID.Size = new System.Drawing.Size(339, 158);
            this.pictureBoxNID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNID.TabIndex = 46;
            this.pictureBoxNID.TabStop = false;
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBrowseImage.Location = new System.Drawing.Point(565, 186);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(75, 30);
            this.btnBrowseImage.TabIndex = 45;
            this.btnBrowseImage.Text = "Browse";
            this.btnBrowseImage.UseVisualStyleBackColor = false;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // pictureBoxTenant
            // 
            this.pictureBoxTenant.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxTenant.Location = new System.Drawing.Point(565, 36);
            this.pictureBoxTenant.Name = "pictureBoxTenant";
            this.pictureBoxTenant.Size = new System.Drawing.Size(230, 137);
            this.pictureBoxTenant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTenant.TabIndex = 44;
            this.pictureBoxTenant.TabStop = false;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBoxAddress.Location = new System.Drawing.Point(210, 441);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(239, 118);
            this.textBoxAddress.TabIndex = 43;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBoxCountry.Location = new System.Drawing.Point(210, 298);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(239, 27);
            this.textBoxCountry.TabIndex = 42;
            // 
            // textBoxOccupation
            // 
            this.textBoxOccupation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBoxOccupation.Location = new System.Drawing.Point(210, 249);
            this.textBoxOccupation.Name = "textBoxOccupation";
            this.textBoxOccupation.Size = new System.Drawing.Size(239, 27);
            this.textBoxOccupation.TabIndex = 41;
            // 
            // textBoxMotherName
            // 
            this.textBoxMotherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBoxMotherName.Location = new System.Drawing.Point(210, 194);
            this.textBoxMotherName.Name = "textBoxMotherName";
            this.textBoxMotherName.Size = new System.Drawing.Size(239, 27);
            this.textBoxMotherName.TabIndex = 40;
            // 
            // textBoxFatherName
            // 
            this.textBoxFatherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBoxFatherName.Location = new System.Drawing.Point(210, 137);
            this.textBoxFatherName.Name = "textBoxFatherName";
            this.textBoxFatherName.Size = new System.Drawing.Size(239, 27);
            this.textBoxFatherName.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(50, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Permanent Address";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelCountry.Location = new System.Drawing.Point(50, 305);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(67, 20);
            this.labelCountry.TabIndex = 36;
            this.labelCountry.Text = "Country";
            // 
            // labelOccupation
            // 
            this.labelOccupation.AutoSize = true;
            this.labelOccupation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelOccupation.Location = new System.Drawing.Point(51, 256);
            this.labelOccupation.Name = "labelOccupation";
            this.labelOccupation.Size = new System.Drawing.Size(94, 20);
            this.labelOccupation.TabIndex = 35;
            this.labelOccupation.Text = "Occupation";
            // 
            // labelFatherName
            // 
            this.labelFatherName.AutoSize = true;
            this.labelFatherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelFatherName.Location = new System.Drawing.Point(51, 137);
            this.labelFatherName.Name = "labelFatherName";
            this.labelFatherName.Size = new System.Drawing.Size(119, 20);
            this.labelFatherName.TabIndex = 34;
            this.labelFatherName.Text = "Father\'s Name";
            // 
            // labelMotherName
            // 
            this.labelMotherName.AutoSize = true;
            this.labelMotherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelMotherName.Location = new System.Drawing.Point(51, 199);
            this.labelMotherName.Name = "labelMotherName";
            this.labelMotherName.Size = new System.Drawing.Size(123, 20);
            this.labelMotherName.TabIndex = 33;
            this.labelMotherName.Text = "Mother\'s Name";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelGender.Location = new System.Drawing.Point(51, 91);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(64, 20);
            this.labelGender.TabIndex = 32;
            this.labelGender.Text = "Gender";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelName.Location = new System.Drawing.Point(51, 43);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 20);
            this.labelName.TabIndex = 31;
            this.labelName.Text = "Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnUpdate.Location = new System.Drawing.Point(781, 600);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 37);
            this.btnUpdate.TabIndex = 57;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comboBoxTenantName
            // 
            this.comboBoxTenantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.comboBoxTenantName.FormattingEnabled = true;
            this.comboBoxTenantName.Location = new System.Drawing.Point(206, 36);
            this.comboBoxTenantName.Name = "comboBoxTenantName";
            this.comboBoxTenantName.Size = new System.Drawing.Size(243, 28);
            this.comboBoxTenantName.TabIndex = 58;
            this.comboBoxTenantName.SelectedIndexChanged += new System.EventHandler(this.comboBoxTenantName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(671, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 87;
            this.label2.Text = "NID Scan Copy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(671, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 88;
            this.label4.Text = "Image";
            // 
            // tenantUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(955, 672);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTenantName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhoneNo);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhoneNo);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dateOfRent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNIDImage);
            this.Controls.Add(this.pictureBoxNID);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.pictureBoxTenant);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.textBoxOccupation);
            this.Controls.Add(this.textBoxMotherName);
            this.Controls.Add(this.textBoxFatherName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelOccupation);
            this.Controls.Add(this.labelFatherName);
            this.Controls.Add(this.labelMotherName);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tenantUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update/Remove";
            this.Load += new System.EventHandler(this.tenantUpdate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTenant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhoneNo;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhoneNo;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dateOfRent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioBtnFemale;
        private System.Windows.Forms.RadioButton radioBtnMale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNIDImage;
        private System.Windows.Forms.PictureBox pictureBoxNID;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.PictureBox pictureBoxTenant;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.TextBox textBoxOccupation;
        private System.Windows.Forms.TextBox textBoxMotherName;
        private System.Windows.Forms.TextBox textBoxFatherName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelOccupation;
        private System.Windows.Forms.Label labelFatherName;
        private System.Windows.Forms.Label labelMotherName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboBoxTenantName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}