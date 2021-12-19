namespace system_airplane
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.title = new System.Windows.Forms.Label();
            this.show_flys = new Guna.UI2.WinForms.Guna2Button();
            this.show_passenger = new Guna.UI2.WinForms.Guna2Button();
            this.show_tickets = new Guna.UI2.WinForms.Guna2Button();
            this.show_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.close_home = new System.Windows.Forms.Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Controls.Add(this.close_home);
            this.guna2Panel1.Controls.Add(this.title);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(800, 72);
            this.guna2Panel1.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Cascadia Code", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(251, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(293, 46);
            this.title.TabIndex = 62;
            this.title.Text = "Airplane Voos";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // show_flys
            // 
            this.show_flys.BorderRadius = 20;
            this.show_flys.CheckedState.Parent = this.show_flys;
            this.show_flys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_flys.CustomImages.Parent = this.show_flys;
            this.show_flys.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.show_flys.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.show_flys.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.show_flys.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.show_flys.DisabledState.Parent = this.show_flys;
            this.show_flys.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.show_flys.ForeColor = System.Drawing.Color.White;
            this.show_flys.HoverState.Parent = this.show_flys;
            this.show_flys.Location = new System.Drawing.Point(17, 365);
            this.show_flys.Name = "show_flys";
            this.show_flys.ShadowDecoration.Parent = this.show_flys;
            this.show_flys.Size = new System.Drawing.Size(147, 44);
            this.show_flys.TabIndex = 64;
            this.show_flys.Text = "Voos";
            this.show_flys.Click += new System.EventHandler(this.show_flys_Click);
            // 
            // show_passenger
            // 
            this.show_passenger.BorderRadius = 20;
            this.show_passenger.CheckedState.Parent = this.show_passenger;
            this.show_passenger.CustomImages.Parent = this.show_passenger;
            this.show_passenger.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.show_passenger.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.show_passenger.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.show_passenger.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.show_passenger.DisabledState.Parent = this.show_passenger;
            this.show_passenger.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.show_passenger.ForeColor = System.Drawing.Color.White;
            this.show_passenger.HoverState.Parent = this.show_passenger;
            this.show_passenger.Location = new System.Drawing.Point(211, 365);
            this.show_passenger.Name = "show_passenger";
            this.show_passenger.ShadowDecoration.Parent = this.show_passenger;
            this.show_passenger.Size = new System.Drawing.Size(147, 44);
            this.show_passenger.TabIndex = 65;
            this.show_passenger.Text = "Passageiros";
            this.show_passenger.Click += new System.EventHandler(this.show_passenger_Click);
            // 
            // show_tickets
            // 
            this.show_tickets.BorderRadius = 20;
            this.show_tickets.CheckedState.Parent = this.show_tickets;
            this.show_tickets.CustomImages.Parent = this.show_tickets;
            this.show_tickets.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.show_tickets.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.show_tickets.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.show_tickets.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.show_tickets.DisabledState.Parent = this.show_tickets;
            this.show_tickets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.show_tickets.ForeColor = System.Drawing.Color.White;
            this.show_tickets.HoverState.Parent = this.show_tickets;
            this.show_tickets.Location = new System.Drawing.Point(406, 365);
            this.show_tickets.Name = "show_tickets";
            this.show_tickets.ShadowDecoration.Parent = this.show_tickets;
            this.show_tickets.Size = new System.Drawing.Size(147, 44);
            this.show_tickets.TabIndex = 66;
            this.show_tickets.Text = "Reservas";
            this.show_tickets.Click += new System.EventHandler(this.show_tickets_Click);
            // 
            // show_cancel
            // 
            this.show_cancel.BorderRadius = 20;
            this.show_cancel.CheckedState.Parent = this.show_cancel;
            this.show_cancel.CustomImages.Parent = this.show_cancel;
            this.show_cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.show_cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.show_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.show_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.show_cancel.DisabledState.Parent = this.show_cancel;
            this.show_cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.show_cancel.ForeColor = System.Drawing.Color.White;
            this.show_cancel.HoverState.Parent = this.show_cancel;
            this.show_cancel.Location = new System.Drawing.Point(609, 365);
            this.show_cancel.Name = "show_cancel";
            this.show_cancel.ShadowDecoration.Parent = this.show_cancel;
            this.show_cancel.Size = new System.Drawing.Size(147, 44);
            this.show_cancel.TabIndex = 67;
            this.show_cancel.Text = "Cancelamentos";
            this.show_cancel.Click += new System.EventHandler(this.show_cancel_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(211, 96);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(371, 243);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 68;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // close_home
            // 
            this.close_home.BackColor = System.Drawing.Color.Red;
            this.close_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_home.Location = new System.Drawing.Point(750, 0);
            this.close_home.Name = "close_home";
            this.close_home.Size = new System.Drawing.Size(50, 23);
            this.close_home.TabIndex = 69;
            this.close_home.Text = "X";
            this.close_home.UseVisualStyleBackColor = false;
            this.close_home.Click += new System.EventHandler(this.close_home_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.show_cancel);
            this.Controls.Add(this.show_tickets);
            this.Controls.Add(this.show_passenger);
            this.Controls.Add(this.show_flys);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label title;
        private Guna.UI2.WinForms.Guna2Button show_flys;
        private Guna.UI2.WinForms.Guna2Button show_passenger;
        private Guna.UI2.WinForms.Guna2Button show_tickets;
        private Guna.UI2.WinForms.Guna2Button show_cancel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Button close_home;
    }
}