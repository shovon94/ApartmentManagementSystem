namespace ApartmentRentManagement
{
    partial class chargesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chargesForm));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBoxUtility = new System.Windows.Forms.TextBox();
            this.labelUtility = new System.Windows.Forms.Label();
            this.labelGasBill = new System.Windows.Forms.Label();
            this.labelWaterBill = new System.Windows.Forms.Label();
            this.textBoxGasBill = new System.Windows.Forms.TextBox();
            this.textBoxWaterBill = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdate.Location = new System.Drawing.Point(367, 269);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 44);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCancel.Location = new System.Drawing.Point(205, 269);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 44);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBoxUtility
            // 
            this.textBoxUtility.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBoxUtility.Location = new System.Drawing.Point(205, 179);
            this.textBoxUtility.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUtility.Name = "textBoxUtility";
            this.textBoxUtility.Size = new System.Drawing.Size(280, 27);
            this.textBoxUtility.TabIndex = 23;
            // 
            // labelUtility
            // 
            this.labelUtility.AutoSize = true;
            this.labelUtility.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelUtility.Location = new System.Drawing.Point(62, 188);
            this.labelUtility.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUtility.Name = "labelUtility";
            this.labelUtility.Size = new System.Drawing.Size(80, 20);
            this.labelUtility.TabIndex = 21;
            this.labelUtility.Text = "Utility Bill";
            // 
            // labelGasBill
            // 
            this.labelGasBill.AutoSize = true;
            this.labelGasBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelGasBill.Location = new System.Drawing.Point(62, 125);
            this.labelGasBill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGasBill.Name = "labelGasBill";
            this.labelGasBill.Size = new System.Drawing.Size(69, 20);
            this.labelGasBill.TabIndex = 20;
            this.labelGasBill.Text = "Gas Bill";
            // 
            // labelWaterBill
            // 
            this.labelWaterBill.AutoSize = true;
            this.labelWaterBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWaterBill.Location = new System.Drawing.Point(62, 64);
            this.labelWaterBill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWaterBill.Name = "labelWaterBill";
            this.labelWaterBill.Size = new System.Drawing.Size(83, 20);
            this.labelWaterBill.TabIndex = 19;
            this.labelWaterBill.Text = "Water Bill";
            // 
            // textBoxGasBill
            // 
            this.textBoxGasBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBoxGasBill.Location = new System.Drawing.Point(205, 121);
            this.textBoxGasBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxGasBill.Name = "textBoxGasBill";
            this.textBoxGasBill.Size = new System.Drawing.Size(280, 27);
            this.textBoxGasBill.TabIndex = 27;
            // 
            // textBoxWaterBill
            // 
            this.textBoxWaterBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBoxWaterBill.Location = new System.Drawing.Point(205, 55);
            this.textBoxWaterBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxWaterBill.Name = "textBoxWaterBill";
            this.textBoxWaterBill.Size = new System.Drawing.Size(280, 27);
            this.textBoxWaterBill.TabIndex = 28;
            // 
            // chargesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(501, 329);
            this.Controls.Add(this.textBoxWaterBill);
            this.Controls.Add(this.textBoxGasBill);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBoxUtility);
            this.Controls.Add(this.labelUtility);
            this.Controls.Add(this.labelGasBill);
            this.Controls.Add(this.labelWaterBill);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "chargesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Charges";
            this.Load += new System.EventHandler(this.chargesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBoxUtility;
        private System.Windows.Forms.Label labelUtility;
        private System.Windows.Forms.Label labelGasBill;
        private System.Windows.Forms.Label labelWaterBill;
        private System.Windows.Forms.TextBox textBoxGasBill;
        private System.Windows.Forms.TextBox textBoxWaterBill;
    }
}