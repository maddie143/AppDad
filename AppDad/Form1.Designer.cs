namespace AppDad
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adaugareFisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareFisaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereFisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareMasinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereMasinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soferiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareSoferiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereSoferiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelDataSet = new AppDad.tabelDataSet();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new AppDad.tabelDataSetTableAdapters.CarsTableAdapter();
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentTableAdapter = new AppDad.tabelDataSetTableAdapters.DocumentTableAdapter();
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driversTableAdapter = new AppDad.tabelDataSetTableAdapters.DriversTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 4);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(16, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareFisaToolStripMenuItem,
            this.masiniToolStripMenuItem,
            this.soferiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adaugareFisaToolStripMenuItem
            // 
            this.adaugareFisaToolStripMenuItem.AutoSize = false;
            this.adaugareFisaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareFisaToolStripMenuItem1,
            this.stergereFisaToolStripMenuItem});
            this.adaugareFisaToolStripMenuItem.Name = "adaugareFisaToolStripMenuItem";
            this.adaugareFisaToolStripMenuItem.Size = new System.Drawing.Size(70, 22);
            this.adaugareFisaToolStripMenuItem.Text = "Fisa";
            this.adaugareFisaToolStripMenuItem.Click += new System.EventHandler(this.adaugareFisaToolStripMenuItem_Click);
            // 
            // adaugareFisaToolStripMenuItem1
            // 
            this.adaugareFisaToolStripMenuItem1.Name = "adaugareFisaToolStripMenuItem1";
            this.adaugareFisaToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.adaugareFisaToolStripMenuItem1.Text = "Adaugare fisa";
            this.adaugareFisaToolStripMenuItem1.Click += new System.EventHandler(this.adaugareFisaToolStripMenuItem1_Click);
            // 
            // stergereFisaToolStripMenuItem
            // 
            this.stergereFisaToolStripMenuItem.Name = "stergereFisaToolStripMenuItem";
            this.stergereFisaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.stergereFisaToolStripMenuItem.Text = "Stergere fisa";
            // 
            // masiniToolStripMenuItem
            // 
            this.masiniToolStripMenuItem.AutoSize = false;
            this.masiniToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.masiniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareMasinaToolStripMenuItem,
            this.stergereMasinaToolStripMenuItem});
            this.masiniToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masiniToolStripMenuItem.Name = "masiniToolStripMenuItem";
            this.masiniToolStripMenuItem.Size = new System.Drawing.Size(70, 22);
            this.masiniToolStripMenuItem.Text = "Masini";
            // 
            // adaugareMasinaToolStripMenuItem
            // 
            this.adaugareMasinaToolStripMenuItem.Name = "adaugareMasinaToolStripMenuItem";
            this.adaugareMasinaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.adaugareMasinaToolStripMenuItem.Text = "Adaugare masina";
            // 
            // stergereMasinaToolStripMenuItem
            // 
            this.stergereMasinaToolStripMenuItem.Name = "stergereMasinaToolStripMenuItem";
            this.stergereMasinaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.stergereMasinaToolStripMenuItem.Text = "Stergere masina";
            // 
            // soferiToolStripMenuItem
            // 
            this.soferiToolStripMenuItem.AutoSize = false;
            this.soferiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareSoferiToolStripMenuItem,
            this.stergereSoferiToolStripMenuItem});
            this.soferiToolStripMenuItem.Name = "soferiToolStripMenuItem";
            this.soferiToolStripMenuItem.Size = new System.Drawing.Size(70, 22);
            this.soferiToolStripMenuItem.Text = "Soferi";
            // 
            // adaugareSoferiToolStripMenuItem
            // 
            this.adaugareSoferiToolStripMenuItem.Name = "adaugareSoferiToolStripMenuItem";
            this.adaugareSoferiToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.adaugareSoferiToolStripMenuItem.Text = "Adaugare soferi";
            this.adaugareSoferiToolStripMenuItem.Click += new System.EventHandler(this.adaugareSoferiToolStripMenuItem_Click);
            // 
            // stergereSoferiToolStripMenuItem
            // 
            this.stergereSoferiToolStripMenuItem.Name = "stergereSoferiToolStripMenuItem";
            this.stergereSoferiToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.stergereSoferiToolStripMenuItem.Text = "Stergere soferi";
            // 
            // tabelDataSet
            // 
            this.tabelDataSet.DataSetName = "tabelDataSet";
            this.tabelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.tabelDataSet;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
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
            // driversBindingSource
            // 
            this.driversBindingSource.DataMember = "Drivers";
            this.driversBindingSource.DataSource = this.tabelDataSet;
            // 
            // driversTableAdapter
            // 
            this.driversTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 393);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugareFisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masiniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soferiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareFisaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stergereFisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareMasinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereMasinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareSoferiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereSoferiToolStripMenuItem;
        private tabelDataSet tabelDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private tabelDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private System.Windows.Forms.BindingSource documentBindingSource;
        private tabelDataSetTableAdapters.DocumentTableAdapter documentTableAdapter;
        private System.Windows.Forms.BindingSource driversBindingSource;
        private tabelDataSetTableAdapters.DriversTableAdapter driversTableAdapter;
    }
}

