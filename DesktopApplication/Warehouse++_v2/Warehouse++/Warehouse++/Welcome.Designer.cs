namespace Warehouse__
{
    partial class Welcome
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
            this.warehouse_lbl = new System.Windows.Forms.Label();
            this.warehousetimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // warehouse_lbl
            // 
            this.warehouse_lbl.BackColor = System.Drawing.Color.Transparent;
            this.warehouse_lbl.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouse_lbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.warehouse_lbl.Location = new System.Drawing.Point(104, 169);
            this.warehouse_lbl.Name = "warehouse_lbl";
            this.warehouse_lbl.Size = new System.Drawing.Size(522, 68);
            this.warehouse_lbl.TabIndex = 0;
            this.warehouse_lbl.Text = "WAREHOUSE++";
            this.warehouse_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // warehousetimer
            // 
            this.warehousetimer.Enabled = true;
            this.warehousetimer.Interval = 3000;
            this.warehousetimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::Warehouse__.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 432);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.warehouse_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label warehouse_lbl;
        private System.Windows.Forms.Timer warehousetimer;
        private System.Windows.Forms.Label label1;
    }
}