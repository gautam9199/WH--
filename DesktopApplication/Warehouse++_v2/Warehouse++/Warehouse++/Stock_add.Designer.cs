namespace Warehouse__
{
    partial class Stock_add
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
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseDataSet2 = new Warehouse__.warehouseDataSet2();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Warehouse__.DataSet1();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseDataSet1 = new Warehouse__.warehouseDataSet1();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proj_databaseDataSet = new Warehouse__.proj_databaseDataSet();
            this.productTableAdapter = new Warehouse__.proj_databaseDataSetTableAdapters.ProductTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.pbqr = new System.Windows.Forms.PictureBox();
            this.productTableAdapter1 = new Warehouse__.warehouseDataSet1TableAdapters.ProductTableAdapter();
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter2 = new Warehouse__.warehouseDataSet2TableAdapters.ProductTableAdapter();
            this.loginTableAdapter = new Warehouse__.warehouseDataSet2TableAdapters.LoginTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proj_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbqr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(222, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Product Id";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quantity";
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(545, 369);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(121, 39);
            this.Add.TabIndex = 19;
            this.Add.Text = "Generate";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(352, 207);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(251, 26);
            this.quantity.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(352, 137);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 26);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            this.loginBindingSource.DataSource = this.warehouseDataSet2;
            // 
            // warehouseDataSet2
            // 
            this.warehouseDataSet2.DataSetName = "warehouseDataSet2";
            this.warehouseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            this.productBindingSource1.DataSource = this.warehouseDataSet1;
            // 
            // warehouseDataSet1
            // 
            this.warehouseDataSet1.DataSetName = "warehouseDataSet1";
            this.warehouseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.proj_databaseDataSet;
            // 
            // proj_databaseDataSet
            // 
            this.proj_databaseDataSet.DataSetName = "proj_databaseDataSet";
            this.proj_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(693, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 39);
            this.button1.TabIndex = 20;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbqr
            // 
            this.pbqr.BackColor = System.Drawing.Color.Transparent;
            this.pbqr.Location = new System.Drawing.Point(775, 79);
            this.pbqr.Name = "pbqr";
            this.pbqr.Size = new System.Drawing.Size(221, 204);
            this.pbqr.TabIndex = 37;
            this.pbqr.TabStop = false;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // productBindingSource2
            // 
            this.productBindingSource2.DataMember = "Product";
            this.productBindingSource2.DataSource = this.warehouseDataSet2;
            // 
            // productTableAdapter2
            // 
            this.productTableAdapter2.ClearBeforeFill = true;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // Stock_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::Warehouse__.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.pbqr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "Stock_add";
            this.Text = "Stock_add";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Stock_add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proj_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbqr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.ComboBox comboBox1;
        private proj_databaseDataSet proj_databaseDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private proj_databaseDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbqr;
        private warehouseDataSet1 warehouseDataSet1;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private warehouseDataSet1TableAdapters.ProductTableAdapter productTableAdapter1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private warehouseDataSet2 warehouseDataSet2;
        private System.Windows.Forms.BindingSource productBindingSource2;
        private warehouseDataSet2TableAdapters.ProductTableAdapter productTableAdapter2;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private warehouseDataSet2TableAdapters.LoginTableAdapter loginTableAdapter;
    }
}