namespace DoAnCKWin.User_ConTrol
{
    partial class UC_SanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_PhuTung = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Xemay = new Guna.UI2.WinForms.Guna2Button();
            this.panel_Xemay = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btn_PhuTung);
            this.guna2Panel1.Controls.Add(this.btn_Xemay);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(874, 52);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btn_PhuTung
            // 
            this.btn_PhuTung.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_PhuTung.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.btn_PhuTung.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_PhuTung.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_PhuTung.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_PhuTung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_PhuTung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_PhuTung.FillColor = System.Drawing.Color.White;
            this.btn_PhuTung.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PhuTung.ForeColor = System.Drawing.Color.Black;
            this.btn_PhuTung.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.btn_PhuTung.Location = new System.Drawing.Point(183, 4);
            this.btn_PhuTung.Name = "btn_PhuTung";
            this.btn_PhuTung.Size = new System.Drawing.Size(180, 45);
            this.btn_PhuTung.TabIndex = 1;
            this.btn_PhuTung.Text = "Phụ tùng";
            this.btn_PhuTung.Click += new System.EventHandler(this.btn_PhuTung_Click);
            // 
            // btn_Xemay
            // 
            this.btn_Xemay.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Xemay.Checked = true;
            this.btn_Xemay.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.btn_Xemay.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_Xemay.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_Xemay.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_Xemay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xemay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xemay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Xemay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Xemay.FillColor = System.Drawing.Color.White;
            this.btn_Xemay.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_Xemay.ForeColor = System.Drawing.Color.Black;
            this.btn_Xemay.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.btn_Xemay.Location = new System.Drawing.Point(3, 4);
            this.btn_Xemay.Name = "btn_Xemay";
            this.btn_Xemay.Size = new System.Drawing.Size(180, 45);
            this.btn_Xemay.TabIndex = 0;
            this.btn_Xemay.Text = "Xe máy";
            this.btn_Xemay.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel_Xemay
            // 
            this.panel_Xemay.BorderColor = System.Drawing.Color.Silver;
            this.panel_Xemay.BorderThickness = 2;
            this.panel_Xemay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Xemay.Location = new System.Drawing.Point(0, 52);
            this.panel_Xemay.Name = "panel_Xemay";
            this.panel_Xemay.Size = new System.Drawing.Size(874, 533);
            this.panel_Xemay.TabIndex = 1;
            // 
            // UC_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Xemay);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UC_SanPham";
            this.Size = new System.Drawing.Size(874, 585);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panel_Xemay;
        private Guna.UI2.WinForms.Guna2Button btn_Xemay;
        private Guna.UI2.WinForms.Guna2Button btn_PhuTung;
    }
}
