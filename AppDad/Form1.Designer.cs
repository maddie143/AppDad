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
            this.statisticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masiniToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.soferiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabelDataSet = new AppDad.tabelDataSet();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new AppDad.tabelDataSetTableAdapters.CarsTableAdapter();
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentTableAdapter = new AppDad.tabelDataSetTableAdapters.DocumentTableAdapter();
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driversTableAdapter = new AppDad.tabelDataSetTableAdapters.DriversTableAdapter();
            this.monthsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthsTableAdapter = new AppDad.tabelDataSetTableAdapters.MonthsTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthsBindingSource)).BeginInit();
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
            this.soferiToolStripMenuItem,
            this.statisticaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
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
            this.stergereFisaToolStripMenuItem.Click += new System.EventHandler(this.stergereFisaToolStripMenuItem_Click);
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
            this.adaugareMasinaToolStripMenuItem.Click += new System.EventHandler(this.adaugareMasinaToolStripMenuItem_Click);
            // 
            // stergereMasinaToolStripMenuItem
            // 
            this.stergereMasinaToolStripMenuItem.Name = "stergereMasinaToolStripMenuItem";
            this.stergereMasinaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.stergereMasinaToolStripMenuItem.Text = "Stergere masina";
            this.stergereMasinaToolStripMenuItem.Click += new System.EventHandler(this.stergereMasinaToolStripMenuItem_Click);
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
            this.stergereSoferiToolStripMenuItem.Click += new System.EventHandler(this.stergereSoferiToolStripMenuItem_Click);
            // 
            // statisticaToolStripMenuItem
            // 
            this.statisticaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fiseToolStripMenuItem,
            this.masiniToolStripMenuItem1,
            this.soferiToolStripMenuItem1});
            this.statisticaToolStripMenuItem.Name = "statisticaToolStripMenuItem";
            this.statisticaToolStripMenuItem.Size = new System.Drawing.Size(74, 22);
            this.statisticaToolStripMenuItem.Text = "Statistica";
            // 
            // fiseToolStripMenuItem
            // 
            this.fiseToolStripMenuItem.Name = "fiseToolStripMenuItem";
            this.fiseToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.fiseToolStripMenuItem.Text = "Fise";
            this.fiseToolStripMenuItem.Click += new System.EventHandler(this.fiseToolStripMenuItem_Click);
            // 
            // masiniToolStripMenuItem1
            // 
            this.masiniToolStripMenuItem1.Name = "masiniToolStripMenuItem1";
            this.masiniToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.masiniToolStripMenuItem1.Text = "Masini";
            this.masiniToolStripMenuItem1.Click += new System.EventHandler(this.masiniToolStripMenuItem1_Click);
            // 
            // soferiToolStripMenuItem1
            // 
            this.soferiToolStripMenuItem1.Name = "soferiToolStripMenuItem1";
            this.soferiToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.soferiToolStripMenuItem1.Text = "Soferi";
            this.soferiToolStripMenuItem1.Click += new System.EventHandler(this.soferiToolStripMenuItem1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(12, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "Schimba parola";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(320, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(320, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(317, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "Autentificare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Parola:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "User:";
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
            // monthsBindingSource
            // 
            this.monthsBindingSource.DataMember = "Months";
            this.monthsBindingSource.DataSource = this.tabelDataSet;
            // 
            // monthsTableAdapter
            // 
            this.monthsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 393);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthsBindingSource)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem statisticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masiniToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem soferiToolStripMenuItem1;
        private tabelDataSet tabelDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private tabelDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private System.Windows.Forms.BindingSource documentBindingSource;
        private tabelDataSetTableAdapters.DocumentTableAdapter documentTableAdapter;
        private System.Windows.Forms.BindingSource driversBindingSource;
        private tabelDataSetTableAdapters.DriversTableAdapter driversTableAdapter;
        private System.Windows.Forms.BindingSource monthsBindingSource;
        private tabelDataSetTableAdapters.MonthsTableAdapter monthsTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

