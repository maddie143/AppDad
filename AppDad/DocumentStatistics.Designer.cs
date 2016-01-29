namespace AppDad
{
    partial class DocumentStatistics
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabelDataSet = new AppDad.tabelDataSet();
            this.documentTableAdapter = new AppDad.tabelDataSetTableAdapters.DocumentTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(715, 222);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 50F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 42;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.FillWeight = 50F;
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn.Width = 55;
            // 
            // documentnoDataGridViewTextBoxColumn
            // 
            this.documentnoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.documentnoDataGridViewTextBoxColumn.DataPropertyName = "Document_no";
            this.documentnoDataGridViewTextBoxColumn.FillWeight = 50F;
            this.documentnoDataGridViewTextBoxColumn.HeaderText = "Document_no";
            this.documentnoDataGridViewTextBoxColumn.Name = "documentnoDataGridViewTextBoxColumn";
            this.documentnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentnoDataGridViewTextBoxColumn.Width = 99;
            // 
            // carnumberDataGridViewTextBoxColumn
            // 
            this.carnumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.carnumberDataGridViewTextBoxColumn.DataPropertyName = "Car_number";
            this.carnumberDataGridViewTextBoxColumn.HeaderText = "Car_number";
            this.carnumberDataGridViewTextBoxColumn.Name = "carnumberDataGridViewTextBoxColumn";
            this.carnumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.carnumberDataGridViewTextBoxColumn.Width = 89;
            // 
            // driverNameDataGridViewTextBoxColumn
            // 
            this.driverNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.driverNameDataGridViewTextBoxColumn.DataPropertyName = "Driver_Name";
            this.driverNameDataGridViewTextBoxColumn.HeaderText = "Driver_Name";
            this.driverNameDataGridViewTextBoxColumn.Name = "driverNameDataGridViewTextBoxColumn";
            this.driverNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.driverNameDataGridViewTextBoxColumn.Width = 94;
            // 
            // fuelDataGridViewTextBoxColumn
            // 
            this.fuelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fuelDataGridViewTextBoxColumn.DataPropertyName = "Fuel";
            this.fuelDataGridViewTextBoxColumn.HeaderText = "Fuel";
            this.fuelDataGridViewTextBoxColumn.Name = "fuelDataGridViewTextBoxColumn";
            this.fuelDataGridViewTextBoxColumn.ReadOnly = true;
            this.fuelDataGridViewTextBoxColumn.Width = 52;
            // 
            // kmstartDataGridViewTextBoxColumn
            // 
            this.kmstartDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.kmstartDataGridViewTextBoxColumn.DataPropertyName = "Km_start";
            this.kmstartDataGridViewTextBoxColumn.FillWeight = 200F;
            this.kmstartDataGridViewTextBoxColumn.HeaderText = "Km_start";
            this.kmstartDataGridViewTextBoxColumn.Name = "kmstartDataGridViewTextBoxColumn";
            this.kmstartDataGridViewTextBoxColumn.ReadOnly = true;
            this.kmstartDataGridViewTextBoxColumn.Width = 73;
            // 
            // kmendDataGridViewTextBoxColumn
            // 
            this.kmendDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.kmendDataGridViewTextBoxColumn.DataPropertyName = "Km_end";
            this.kmendDataGridViewTextBoxColumn.FillWeight = 200F;
            this.kmendDataGridViewTextBoxColumn.HeaderText = "Km_end";
            this.kmendDataGridViewTextBoxColumn.Name = "kmendDataGridViewTextBoxColumn";
            this.kmendDataGridViewTextBoxColumn.ReadOnly = true;
            this.kmendDataGridViewTextBoxColumn.Width = 71;
            // 
            // hoursstartDataGridViewTextBoxColumn
            // 
            this.hoursstartDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.hoursstartDataGridViewTextBoxColumn.DataPropertyName = "Hours_start";
            this.hoursstartDataGridViewTextBoxColumn.HeaderText = "Hours_start";
            this.hoursstartDataGridViewTextBoxColumn.Name = "hoursstartDataGridViewTextBoxColumn";
            this.hoursstartDataGridViewTextBoxColumn.ReadOnly = true;
            this.hoursstartDataGridViewTextBoxColumn.Width = 86;
            // 
            // hoursendDataGridViewTextBoxColumn
            // 
            this.hoursendDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.hoursendDataGridViewTextBoxColumn.DataPropertyName = "Hours_end";
            this.hoursendDataGridViewTextBoxColumn.FillWeight = 200F;
            this.hoursendDataGridViewTextBoxColumn.HeaderText = "Hours_end";
            this.hoursendDataGridViewTextBoxColumn.Name = "hoursendDataGridViewTextBoxColumn";
            this.hoursendDataGridViewTextBoxColumn.ReadOnly = true;
            this.hoursendDataGridViewTextBoxColumn.Width = 84;
            // 
            // consumptionDataGridViewTextBoxColumn
            // 
            this.consumptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.consumptionDataGridViewTextBoxColumn.DataPropertyName = "Consumption";
            this.consumptionDataGridViewTextBoxColumn.FillWeight = 50F;
            this.consumptionDataGridViewTextBoxColumn.HeaderText = "Consumption";
            this.consumptionDataGridViewTextBoxColumn.Name = "consumptionDataGridViewTextBoxColumn";
            this.consumptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.consumptionDataGridViewTextBoxColumn.Width = 93;
            // 
            // aDBLUDataGridViewTextBoxColumn
            // 
            this.aDBLUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.aDBLUDataGridViewTextBoxColumn.DataPropertyName = "ADBLU";
            this.aDBLUDataGridViewTextBoxColumn.FillWeight = 50F;
            this.aDBLUDataGridViewTextBoxColumn.HeaderText = "ADBLU";
            this.aDBLUDataGridViewTextBoxColumn.Name = "aDBLUDataGridViewTextBoxColumn";
            this.aDBLUDataGridViewTextBoxColumn.ReadOnly = true;
            this.aDBLUDataGridViewTextBoxColumn.Width = 68;
            // 
            // routeDataGridViewTextBoxColumn
            // 
            this.routeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.routeDataGridViewTextBoxColumn.DataPropertyName = "Route";
            this.routeDataGridViewTextBoxColumn.FillWeight = 400F;
            this.routeDataGridViewTextBoxColumn.HeaderText = "Route";
            this.routeDataGridViewTextBoxColumn.Name = "routeDataGridViewTextBoxColumn";
            this.routeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monthnrDataGridViewTextBoxColumn
            // 
            this.monthnrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.monthnrDataGridViewTextBoxColumn.DataPropertyName = "Month_nr";
            this.monthnrDataGridViewTextBoxColumn.FillWeight = 50F;
            this.monthnrDataGridViewTextBoxColumn.HeaderText = "Month_nr";
            this.monthnrDataGridViewTextBoxColumn.Name = "monthnrDataGridViewTextBoxColumn";
            this.monthnrDataGridViewTextBoxColumn.ReadOnly = true;
            this.monthnrDataGridViewTextBoxColumn.Width = 77;
            // 
            // documentBindingSource
            // 
            this.documentBindingSource.DataMember = "Document";
            this.documentBindingSource.DataSource = this.tabelDataSet;
            // 
            // tabelDataSet
            // 
            this.tabelDataSet.DataSetName = "tabelDataSet";
            this.tabelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentTableAdapter
            // 
            this.documentTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(145, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Statistici pe luni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(378, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Statistici pe masini";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DocumentStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 326);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DocumentStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DocumentStatistics";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DocumentStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private tabelDataSet tabelDataSet;
        private System.Windows.Forms.BindingSource documentBindingSource;
        private tabelDataSetTableAdapters.DocumentTableAdapter documentTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
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