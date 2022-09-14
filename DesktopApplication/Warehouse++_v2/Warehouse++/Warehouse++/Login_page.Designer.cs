namespace Warehouse__
{
    partial class Login_page
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
            this.Nikki_lbl = new System.Windows.Forms.Label();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.Username_txt = new System.Windows.Forms.TextBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.Login_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nikki_lbl
            // 
            this.Nikki_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Nikki_lbl.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nikki_lbl.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Nikki_lbl.Location = new System.Drawing.Point(491, 50);
            this.Nikki_lbl.Name = "Nikki_lbl";
            this.Nikki_lbl.Size = new System.Drawing.Size(382, 75);
            this.Nikki_lbl.TabIndex = 0;
            this.Nikki_lbl.Text = "Nikki Industries";
            this.Nikki_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Username_lbl
            // 
            this.Username_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Username_lbl.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_lbl.Location = new System.Drawing.Point(526, 265);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(129, 23);
            this.Username_lbl.TabIndex = 2;
            this.Username_lbl.Text = "Username";
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Password_lbl.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_lbl.Location = new System.Drawing.Point(526, 327);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(115, 29);
            this.Password_lbl.TabIndex = 3;
            this.Password_lbl.Text = "Password";
            // 
            // Username_txt
            // 
            this.Username_txt.AcceptsReturn = true;
            this.Username_txt.AcceptsTab = true;
            this.Username_txt.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_txt.Location = new System.Drawing.Point(673, 266);
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.Size = new System.Drawing.Size(158, 29);
            this.Username_txt.TabIndex = 4;
            this.Username_txt.TextChanged += new System.EventHandler(this.Username_txt_TextChanged);
            // 
            // Password_txt
            // 
            this.Password_txt.AcceptsReturn = true;
            this.Password_txt.AcceptsTab = true;
            this.Password_txt.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_txt.Location = new System.Drawing.Point(673, 328);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.PasswordChar = '*';
            this.Password_txt.Size = new System.Drawing.Size(158, 29);
            this.Password_txt.TabIndex = 5;
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Login_btn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Login_btn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Login_btn.Location = new System.Drawing.Point(560, 426);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(95, 36);
            this.Login_btn.TabIndex = 6;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(686, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Warehouse__.Properties.Resources.logo3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(488, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 75);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::Warehouse__.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.Username_txt);
            this.Controls.Add(this.Password_lbl);
            this.Controls.Add(this.Username_lbl);
            this.Controls.Add(this.Nikki_lbl);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Login_page";
            this.Text = "Login page";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Login_page_Load);
            this.Leave += new System.EventHandler(this.Login_page_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nikki_lbl;
        private System.Windows.Forms.Label Username_lbl;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.TextBox Username_txt;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

