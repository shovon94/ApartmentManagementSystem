namespace ApartmentRentManagement
{
    partial class BillingRecord
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingRecord));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.recordIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flatnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalBillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentManagementDataSet1 = new ApartmentRentManagement.apartmentManagementDataSet1();
            this.recordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentManagementDataSet = new ApartmentRentManagement.apartmentManagementDataSet();
            this.btnCancel = new System.Windows.Forms.Button();
            this.recordTableAdapter = new ApartmentRentManagement.apartmentManagementDataSetTableAdapters.recordTableAdapter();
            this.recordTableAdapter1 = new ApartmentRentManagement.apartmentManagementDataSet1TableAdapters.recordTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordIdDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.flatnameDataGridViewTextBoxColumn,
            this.tenantNameDataGridViewTextBoxColumn,
            this.totalBillDataGridViewTextBoxColumn,
            this.remark});
            this.dataGridView1.DataSource = this.recordBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1057, 406);
            this.dataGridView1.TabIndex = 0;
            // 
            // recordIdDataGridViewTextBoxColumn
            // 
            this.recordIdDataGridViewTextBoxColumn.DataPropertyName = "recordId";
            this.recordIdDataGridViewTextBoxColumn.HeaderText = "Record Id";
            this.recordIdDataGridViewTextBoxColumn.Name = "recordIdDataGridViewTextBoxColumn";
            this.recordIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Month";
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            this.monthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flatnameDataGridViewTextBoxColumn
            // 
            this.flatnameDataGridViewTextBoxColumn.DataPropertyName = "flatname";
            this.flatnameDataGridViewTextBoxColumn.HeaderText = "Flat Name";
            this.flatnameDataGridViewTextBoxColumn.Name = "flatnameDataGridViewTextBoxColumn";
            this.flatnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenantNameDataGridViewTextBoxColumn
            // 
            this.tenantNameDataGridViewTextBoxColumn.DataPropertyName = "tenantName";
            this.tenantNameDataGridViewTextBoxColumn.HeaderText = "Tenant Name";
            this.tenantNameDataGridViewTextBoxColumn.Name = "tenantNameDataGridViewTextBoxColumn";
            this.tenantNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalBillDataGridViewTextBoxColumn
            // 
            this.totalBillDataGridViewTextBoxColumn.DataPropertyName = "totalBill";
            this.totalBillDataGridViewTextBoxColumn.HeaderText = "Total Bill";
            this.totalBillDataGridViewTextBoxColumn.Name = "totalBillDataGridViewTextBoxColumn";
            this.totalBillDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remark
            // 
            this.remark.DataPropertyName = "remark";
            this.remark.HeaderText = "Remarks";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            // 
            // recordBindingSource1
            // 
            this.recordBindingSource1.DataMember = "record";
            this.recordBindingSource1.DataSource = this.apartmentManagementDataSet1;
            // 
            // apartmentManagementDataSet1
            // 
            this.apartmentManagementDataSet1.DataSetName = "apartmentManagementDataSet1";
            this.apartmentManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recordBindingSource
            // 
            this.recordBindingSource.DataMember = "record";
            this.recordBindingSource.DataSource = this.apartmentManagementDataSet;
            // 
            // apartmentManagementDataSet
            // 
            this.apartmentManagementDataSet.DataSetName = "apartmentManagementDataSet";
            this.apartmentManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnCancel.Location = new System.Drawing.Point(902, 521);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 46);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // recordTableAdapter
            // 
            this.recordTableAdapter.ClearBeforeFill = true;
            // 
            // recordTableAdapter1
            // 
            this.recordTableAdapter1.ClearBeforeFill = true;
            // 
            // BillingRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1070, 579);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BillingRecord";
            this.Text = "Billing Record";
            this.Load += new System.EventHandler(this.BillingRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentManagementDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancel;
        private apartmentManagementDataSet apartmentManagementDataSet;
        private System.Windows.Forms.BindingSource recordBindingSource;
        private apartmentManagementDataSetTableAdapters.recordTableAdapter recordTableAdapter;
        private apartmentManagementDataSet1 apartmentManagementDataSet1;
        private System.Windows.Forms.BindingSource recordBindingSource1;
        private apartmentManagementDataSet1TableAdapters.recordTableAdapter recordTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flatnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBillDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
    }
}