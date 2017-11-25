namespace ApartmentRentManagement
{
    partial class flatUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flatUpdate));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBoxRent = new System.Windows.Forms.TextBox();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.labelRent = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelflatName = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnUpdate.Location = new System.Drawing.Point(332, 315);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 35);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnCancel.Location = new System.Drawing.Point(48, 315);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 35);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBoxRent
            // 
            this.textBoxRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBoxRent.Location = new System.Drawing.Point(167, 234);
            this.textBoxRent.Name = "textBoxRent";
            this.textBoxRent.Size = new System.Drawing.Size(280, 27);
            this.textBoxRent.TabIndex = 14;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBoxInfo.Location = new System.Drawing.Point(167, 101);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(280, 87);
            this.textBoxInfo.TabIndex = 13;
            // 
            // labelRent
            // 
            this.labelRent.AutoSize = true;
            this.labelRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelRent.Location = new System.Drawing.Point(44, 234);
            this.labelRent.Name = "labelRent";
            this.labelRent.Size = new System.Drawing.Size(44, 20);
            this.labelRent.TabIndex = 11;
            this.labelRent.Text = "Rent";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelInfo.Location = new System.Drawing.Point(44, 106);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(36, 20);
            this.labelInfo.TabIndex = 10;
            this.labelInfo.Text = "Info";
            // 
            // labelflatName
            // 
            this.labelflatName.AutoSize = true;
            this.labelflatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelflatName.Location = new System.Drawing.Point(44, 51);
            this.labelflatName.Name = "labelflatName";
            this.labelflatName.Size = new System.Drawing.Size(86, 20);
            this.labelflatName.TabIndex = 9;
            this.labelflatName.Text = "Flat Name";
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnRemove.Location = new System.Drawing.Point(188, 315);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(115, 35);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(167, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 24);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // flatUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(470, 373);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBoxRent);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.labelRent);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelflatName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "flatUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update/Remove";
            this.Load += new System.EventHandler(this.flatUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBoxRent;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Label labelRent;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelflatName;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}