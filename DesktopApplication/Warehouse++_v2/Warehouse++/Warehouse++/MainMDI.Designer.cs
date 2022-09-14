namespace Warehouse__
{
    partial class MainMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMDI));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.homepahemenustrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewWarehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.homepahemenustrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // homepahemenustrip
            // 
            this.homepahemenustrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.homepahemenustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.settingsToolStripMenuItem});
            this.homepahemenustrip.Location = new System.Drawing.Point(0, 0);
            this.homepahemenustrip.Name = "homepahemenustrip";
            this.homepahemenustrip.Size = new System.Drawing.Size(632, 24);
            this.homepahemenustrip.TabIndex = 13;
            this.homepahemenustrip.Text = "menuStrip1";
            this.homepahemenustrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.productToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.warehouseToolStripMenuItem,
            this.userToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.testToolStripMenuItem,
            this.qrToolStripMenuItem,
            this.printToolStripMenuItem});
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageTransparentColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 20);
            this.toolStripMenuItem1.Text = "Menu";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.productListToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.addProductToolStripMenuItem.Text = "Add Product";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click_1);
            // 
            // productListToolStripMenuItem
            // 
            this.productListToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.productListToolStripMenuItem.Name = "productListToolStripMenuItem";
            this.productListToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.productListToolStripMenuItem.Text = "Product List";
            this.productListToolStripMenuItem.Click += new System.EventHandler(this.productListToolStripMenuItem_Click_1);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOrdersToolStripMenuItem,
            this.orderListToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // addOrdersToolStripMenuItem
            // 
            this.addOrdersToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addOrdersToolStripMenuItem.Name = "addOrdersToolStripMenuItem";
            this.addOrdersToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.addOrdersToolStripMenuItem.Text = "Add Orders";
            this.addOrdersToolStripMenuItem.Click += new System.EventHandler(this.addOrdersToolStripMenuItem_Click);
            // 
            // orderListToolStripMenuItem
            // 
            this.orderListToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.orderListToolStripMenuItem.Name = "orderListToolStripMenuItem";
            this.orderListToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.orderListToolStripMenuItem.Text = "Order List";
            this.orderListToolStripMenuItem.Click += new System.EventHandler(this.orderListToolStripMenuItem_Click_1);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.customerListToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click_1);
            // 
            // customerListToolStripMenuItem
            // 
            this.customerListToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.customerListToolStripMenuItem.Name = "customerListToolStripMenuItem";
            this.customerListToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.customerListToolStripMenuItem.Text = "Customer List";
            this.customerListToolStripMenuItem.Click += new System.EventHandler(this.customerListToolStripMenuItem_Click);
            // 
            // warehouseToolStripMenuItem
            // 
            this.warehouseToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.warehouseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewWarehouseToolStripMenuItem,
            this.addStockToolStripMenuItem,
            this.addLocationToolStripMenuItem});
            this.warehouseToolStripMenuItem.Name = "warehouseToolStripMenuItem";
            this.warehouseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.warehouseToolStripMenuItem.Text = "Warehouse";
            // 
            // viewWarehouseToolStripMenuItem
            // 
            this.viewWarehouseToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.viewWarehouseToolStripMenuItem.Name = "viewWarehouseToolStripMenuItem";
            this.viewWarehouseToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.viewWarehouseToolStripMenuItem.Text = "View Warehouse";
            this.viewWarehouseToolStripMenuItem.Click += new System.EventHandler(this.viewWarehouseToolStripMenuItem_Click_1);
            // 
            // addStockToolStripMenuItem
            // 
            this.addStockToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addStockToolStripMenuItem.Name = "addStockToolStripMenuItem";
            this.addStockToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.addStockToolStripMenuItem.Text = "Add Stock";
            this.addStockToolStripMenuItem.Click += new System.EventHandler(this.addStockToolStripMenuItem_Click);
            // 
            // addLocationToolStripMenuItem
            // 
            this.addLocationToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addLocationToolStripMenuItem.Name = "addLocationToolStripMenuItem";
            this.addLocationToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.addLocationToolStripMenuItem.Text = "Add Location";
            this.addLocationToolStripMenuItem.Click += new System.EventHandler(this.addLocationToolStripMenuItem_Click_1);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.userListToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.userToolStripMenuItem.Text = "User";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click_1);
            // 
            // userListToolStripMenuItem
            // 
            this.userListToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.userListToolStripMenuItem.Name = "userListToolStripMenuItem";
            this.userListToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.userListToolStripMenuItem.Text = "User List";
            this.userListToolStripMenuItem.Click += new System.EventHandler(this.userListToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.testToolStripMenuItem.Text = "test";
            this.testToolStripMenuItem.Visible = false;
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // qrToolStripMenuItem
            // 
            this.qrToolStripMenuItem.Name = "qrToolStripMenuItem";
            this.qrToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.qrToolStripMenuItem.Text = "qr";
            this.qrToolStripMenuItem.Visible = false;
            this.qrToolStripMenuItem.Click += new System.EventHandler(this.qrToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "print";
            this.printToolStripMenuItem.Visible = false;
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // MainMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.homepahemenustrip);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.homepahemenustrip;
            this.Name = "MainMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WAREHOUSE++";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMDI_FormClosed);
            this.Load += new System.EventHandler(this.MainMDI_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.homepahemenustrip.ResumeLayout(false);
            this.homepahemenustrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip homepahemenustrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewWarehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    }
}



