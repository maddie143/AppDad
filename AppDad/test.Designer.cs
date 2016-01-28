namespace AppDad
{
    partial class test
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabelDataSet = new AppDad.tabelDataSet();
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentTableAdapter = new AppDad.tabelDataSetTableAdapters.DocumentTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmstartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursstartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDBLUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthnrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.documentnoDataGridViewTextBoxColumn,
            this.carnumberDataGridViewTextBoxColumn,
            this.driverNameDataGridViewTextBoxColumn,
            this.fuelDataGridViewTextBoxColumn,
            this.kmstartDataGridViewTextBoxColumn,
            this.kmendDataGridViewTextBoxColumn,
            this.hoursstartDataGridViewTextBoxColumn,
            this.hoursendDataGridViewTextBoxColumn,
            this.consumptionDataGridViewTextBoxColumn,
            this.aDBLUDataGridViewTextBoxColumn,
            this.routeDataGridViewTextBoxColumn,
            this.monthnrDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.documentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(631, 202);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabelDataSet
            // 
            this.tabelDataSet.DataSetName = "tabelDataSet";
            this.tabelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentBindingSource
            // 
            this.documentBindingSource.DataMember = "Document";
            this.documentBindingSource.DataSource = this.tabelDataSet;
            // 
            // documentTableAdapter
            // 
            this.documentTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // documentnoDataGridViewTextBoxColumn
            // 
            this.documentnoDataGridViewTextBoxColumn.DataPropertyName = "Document_no";
            this.documentnoDataGridViewTextBoxColumn.HeaderText = "Document_no";
            this.documentnoDataGridViewTextBoxColumn.Name = "documentnoDataGridViewTextBoxColumn";
            // 
            // carnumberDataGridViewTextBoxColumn
            // 
            this.carnumberDataGridViewTextBoxColumn.DataPropertyName = "Car_number";
            this.carnumberDataGridViewTextBoxColumn.HeaderText = "Car_number";
            this.carnumberDataGridViewTextBoxColumn.Name = "carnumberDataGridViewTextBoxColumn";
            // 
            // driverNameDataGridViewTextBoxColumn
            // 
            this.driverNameDataGridViewTextBoxColumn.DataPropertyName = "Driver_Name";
            this.driverNameDataGridViewTextBoxColumn.HeaderText = "Driver_Name";
            this.driverNameDataGridViewTextBoxColumn.Name = "driverNameDataGridViewTextBoxColumn";
            // 
            // fuelDataGridViewTextBoxColumn
            // 
            this.fuelDataGridViewTextBoxColumn.DataPropertyName = "Fuel";
            this.fuelDataGridViewTextBoxColumn.HeaderText = "Fuel";
            this.fuelDataGridViewTextBoxColumn.Name = "fuelDataGridViewTextBoxColumn";
            // 
            // kmstartDataGridViewTextBoxColumn
            // 
            this.kmstartDataGridViewTextBoxColumn.DataPropertyName = "Km_start";
            this.kmstartDataGridViewTextBoxColumn.HeaderText = "Km_start";
            this.kmstartDataGridViewTextBoxColumn.Name = "kmstartDataGridViewTextBoxColumn";
            // 
            // kmendDataGridViewTextBoxColumn
            // 
            this.kmendDataGridViewTextBoxColumn.DataPropertyName = "Km_end";
            this.kmendDataGridViewTextBoxColumn.HeaderText = "Km_end";
            this.kmendDataGridViewTextBoxColumn.Name = "kmendDataGridViewTextBoxColumn";
            // 
            // hoursstartDataGridViewTextBoxColumn
            // 
            this.hoursstartDataGridViewTextBoxColumn.DataPropertyName = "Hours_start";
            this.hoursstartDataGridViewTextBoxColumn.HeaderText = "Hours_start";
            this.hoursstartDataGridViewTextBoxColumn.Name = "hoursstartDataGridViewTextBoxColumn";
            // 
            // hoursendDataGridViewTextBoxColumn
            // 
            this.hoursendDataGridViewTextBoxColumn.DataPropertyName = "Hours_end";
            this.hoursendDataGridViewTextBoxColumn.HeaderText = "Hours_end";
            this.hoursendDataGridViewTextBoxColumn.Name = "hoursendDataGridViewTextBoxColumn";
            // 
            // consumptionDataGridViewTextBoxColumn
            // 
            this.consumptionDataGridViewTextBoxColumn.DataPropertyName = "Consumption";
            this.consumptionDataGridViewTextBoxColumn.HeaderText = "Consumption";
            this.consumptionDataGridViewTextBoxColumn.Name = "consumptionDataGridViewTextBoxColumn";
            // 
            // aDBLUDataGridViewTextBoxColumn
            // 
            this.aDBLUDataGridViewTextBoxColumn.DataPropertyName = "ADBLU";
            this.aDBLUDataGridViewTextBoxColumn.HeaderText = "ADBLU";
            this.aDBLUDataGridViewTextBoxColumn.Name = "aDBLUDataGridViewTextBoxColumn";
            // 
            // routeDataGridViewTextBoxColumn
            // 
            this.routeDataGridViewTextBoxColumn.DataPropertyName = "Route";
            this.routeDataGridViewTextBoxColumn.HeaderText = "Route";
            this.routeDataGridViewTextBoxColumn.Name = "routeDataGridViewTextBoxColumn";
            // 
            // monthnrDataGridViewTextBoxColumn
            // 
            this.monthnrDataGridViewTextBoxColumn.DataPropertyName = "Month_nr";
            this.monthnrDataGridViewTextBoxColumn.HeaderText = "Month_nr";
            this.monthnrDataGridViewTextBoxColumn.Name = "monthnrDataGridViewTextBoxColumn";
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 280);
            this.Controls.Add(this.dataGridView1);
            this.Name = "test";
            this.Text = "test";
            this.Load += new System.EventHandler(this.test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private tabelDataSet tabelDataSet;
        private System.Windows.Forms.BindingSource documentBindingSource;
        private tabelDataSetTableAdapters.DocumentTableAdapter documentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmstartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursstartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDBLUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthnrDataGridViewTextBoxColumn;
    }
}