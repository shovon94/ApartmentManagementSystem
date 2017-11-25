namespace ApartmentRentManagement
{
    partial class apartmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(apartmentForm));
            this.labelflatName = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelRent = new System.Windows.Forms.Label();
            this.textBoxFlatName = new System.Windows.Forms.TextBox();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.textBoxRent = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelflatName
            // 
            this.labelflatName.AutoSize = true;
            this.labelflatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelflatName.Location = new System.Drawing.Point(56, 62);
            this.labelflatName.Name = "labelflatName";
            this.labelflatName.Size = new System.Drawing.Size(86, 20);
            this.labelflatName.TabIndex = 0;
            this.labelflatName.Text = "Flat Name";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelInfo.Location = new System.Drawing.Point(56, 117);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(36, 20);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "Info";
            // 
            // labelRent
            // 
            this.labelRent.AutoSize = true;
            this.labelRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelRent.Location = new System.Drawing.Point(56, 226);
            this.labelRent.Name = "labelRent";
            this.labelRent.Size = new System.Drawing.Size(44, 20);
            this.labelRent.TabIndex = 2;
            this.labelRent.Text = "Rent";
            // 
            // textBoxFlatName
            // 
            this.textBoxFlatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFlatName.Location = new System.Drawing.Point(179, 62);
            this.textBoxFlatName.Name = "textBoxFlatName";
            this.textBoxFlatName.Size = new System.Drawing.Size(280, 27);
            this.textBoxFlatName.TabIndex = 3;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBoxInfo.Location = new System.Drawing.Point(179, 112);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(280, 87);
            this.textBoxInfo.TabIndex = 4;
            // 
            // textBoxRent
            // 
            this.textBoxRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBoxRent.Location = new System.Drawing.Point(179, 226);
            this.textBoxRent.Name = "textBoxRent";
            this.textBoxRent.Size = new System.Drawing.Size(280, 27);
            this.textBoxRent.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(193, 314);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 35);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(344, 314);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(115, 35);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // apartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(491, 365);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBoxRent);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.textBoxFlatName);
            this.Controls.Add(this.labelRent);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelflatName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "apartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apartment";
            this.Load += new System.EventHandler(this.apartmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelflatName;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelRent;
        private System.Windows.Forms.TextBox textBoxFlatName;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.TextBox textBoxRent;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
    }
}