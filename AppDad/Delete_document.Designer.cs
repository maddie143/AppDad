namespace AppDad
{
    partial class Delete_document
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabelDataSet = new AppDad.tabelDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(310, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Stergere";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabelDataSet
            // 
            this.tabelDataSet.DataSetName = "tabelDataSet";
            this.tabelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(804, 300);
            this.dataGridView1.TabIndex = 2;
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
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentnoDataGridViewTextBoxColumn
            // 
            this.documentnoDataGridViewTextBoxColumn.DataPropertyName = "Document_no";
            this.documentnoDataGridViewTextBoxColumn.HeaderText = "Document_no";
            this.documentnoDataGridViewTextBoxColumn.Name = "documentnoDataGridViewTextBoxColumn";
            this.documentnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carnumberDataGridViewTextBoxColumn
            // 
            this.carnumberDataGridViewTextBoxColumn.DataPropertyName = "Car_number";
            this.carnumberDataGridViewTextBoxColumn.HeaderText = "Car_number";
            this.carnumberDataGridViewTextBoxColumn.Name = "carnumberDataGridViewTextBoxColumn";
            this.carnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // driverNameDataGridViewTextBoxColumn
            // 
            this.driverNameDataGridViewTextBoxColumn.DataPropertyName = "Driver_Name";
            this.driverNameDataGridViewTextBoxColumn.HeaderText = "Driver_Name";
            this.driverNameDataGridViewTextBoxColumn.Name = "driverNameDataGridViewTextBoxColumn";
            this.driverNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fuelDataGridViewTextBoxColumn
            // 
            this.fuelDataGridViewTextBoxColumn.DataPropertyName = "Fuel";
            this.fuelDataGridViewTextBoxColumn.HeaderText = "Fuel";
            this.fuelDataGridViewTextBoxColumn.Name = "fuelDataGridViewTextBoxColumn";
            this.fuelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kmstartDataGridViewTextBoxColumn
            // 
            this.kmstartDataGridViewTextBoxColumn.DataPropertyName = "Km_start";
            this.kmstartDataGridViewTextBoxColumn.HeaderText = "Km_start";
            this.kmstartDataGridViewTextBoxColumn.Name = "kmstartDataGridViewTextBoxColumn";
            this.kmstartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kmendDataGridViewTextBoxColumn
            // 
            this.kmendDataGridViewTextBoxColumn.DataPropertyName = "Km_end";
            this.kmendDataGridViewTextBoxColumn.HeaderText = "Km_end";
            this.kmendDataGridViewTextBoxColumn.Name = "kmendDataGridViewTextBoxColumn";
            this.kmendDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoursstartDataGridViewTextBoxColumn
            // 
            this.hoursstartDataGridViewTextBoxColumn.DataPropertyName = "Hours_start";
            this.hoursstartDataGridViewTextBoxColumn.HeaderText = "Hours_start";
            this.hoursstartDataGridViewTextBoxColumn.Name = "hoursstartDataGridViewTextBoxColumn";
            this.hoursstartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoursendDataGridViewTextBoxColumn
            // 
            this.hoursendDataGridViewTextBoxColumn.DataPropertyName = "Hours_end";
            this.hoursendDataGridViewTextBoxColumn.HeaderText = "Hours_end";
            this.hoursendDataGridViewTextBoxColumn.Name = "hoursendDataGridViewTextBoxColumn";
            this.hoursendDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consumptionDataGridViewTextBoxColumn
            // 
            this.consumptionDataGridViewTextBoxColumn.DataPropertyName = "Consumption";
            this.consumptionDataGridViewTextBoxColumn.HeaderText = "Consumption";
            this.consumptionDataGridViewTextBoxColumn.Name = "consumptionDataGridViewTextBoxColumn";
            this.consumptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDBLUDataGridViewTextBoxColumn
            // 
            this.aDBLUDataGridViewTextBoxColumn.DataPropertyName = "ADBLU";
            this.aDBLUDataGridViewTextBoxColumn.HeaderText = "ADBLU";
            this.aDBLUDataGridViewTextBoxColumn.Name = "aDBLUDataGridViewTextBoxColumn";
            this.aDBLUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // routeDataGridViewTextBoxColumn
            // 
            this.routeDataGridViewTextBoxColumn.DataPropertyName = "Route";
            this.routeDataGridViewTextBoxColumn.HeaderText = "Route";
            this.routeDataGridViewTextBoxColumn.Name = "routeDataGridViewTextBoxColumn";
            this.routeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monthnrDataGridViewTextBoxColumn
            // 
            this.monthnrDataGridViewTextBoxColumn.DataPropertyName = "Month_nr";
            this.monthnrDataGridViewTextBoxColumn.HeaderText = "Month_nr";
            this.monthnrDataGridViewTextBoxColumn.Name = "monthnrDataGridViewTextBoxColumn";
            this.monthnrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(278, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nu exista inregistrari";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Visible = false;
            // 
            // Delete_document
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Delete_document";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delete_document";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Delete_document_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private tabelDataSet tabelDataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Label label1;
    }
}