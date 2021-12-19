namespace system_airplane
{
    partial class FlightTbl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightTbl));
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FcodeTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.SeatNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Fsrc = new System.Windows.Forms.ComboBox();
            this.FDest = new System.Windows.Forms.ComboBox();
            this.close_Flight_tbl = new System.Windows.Forms.Button();
            this.reset_button_new_fly = new Guna.UI2.WinForms.Guna2Button();
            this.save_fly = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.FDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.View_fly = new Guna.UI2.WinForms.Guna2Button();
            this.home_button = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(270, 19);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(238, 39);
            this.title.TabIndex = 3;
            this.title.Text = "Airplane Voos";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "Salvas novos vôos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Código do voo:\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Números de assentos:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FcodeTb
            // 
            this.FcodeTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FcodeTb.DefaultText = "";
            this.FcodeTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FcodeTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FcodeTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FcodeTb.DisabledState.Parent = this.FcodeTb;
            this.FcodeTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FcodeTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FcodeTb.FocusedState.Parent = this.FcodeTb;
            this.FcodeTb.Font = new System.Drawing.Font("Arial", 12F);
            this.FcodeTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FcodeTb.HoverState.Parent = this.FcodeTb;
            this.FcodeTb.Location = new System.Drawing.Point(250, 197);
            this.FcodeTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FcodeTb.MaxLength = 4;
            this.FcodeTb.Name = "FcodeTb";
            this.FcodeTb.PasswordChar = '\0';
            this.FcodeTb.PlaceholderText = "Digite o código";
            this.FcodeTb.SelectedText = "";
            this.FcodeTb.ShadowDecoration.Parent = this.FcodeTb;
            this.FcodeTb.Size = new System.Drawing.Size(159, 43);
            this.FcodeTb.TabIndex = 11;
            // 
            // SeatNum
            // 
            this.SeatNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SeatNum.DefaultText = "";
            this.SeatNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SeatNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SeatNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SeatNum.DisabledState.Parent = this.SeatNum;
            this.SeatNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SeatNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SeatNum.FocusedState.Parent = this.SeatNum;
            this.SeatNum.Font = new System.Drawing.Font("Arial", 12F);
            this.SeatNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SeatNum.HoverState.Parent = this.SeatNum;
            this.SeatNum.Location = new System.Drawing.Point(254, 293);
            this.SeatNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SeatNum.MaxLength = 4;
            this.SeatNum.Name = "SeatNum";
            this.SeatNum.PasswordChar = '\0';
            this.SeatNum.PlaceholderText = "quantidade de assentos";
            this.SeatNum.SelectedText = "";
            this.SeatNum.ShadowDecoration.Parent = this.SeatNum;
            this.SeatNum.Size = new System.Drawing.Size(189, 43);
            this.SeatNum.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 490);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(446, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "Partida";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(446, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "Destino";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fsrc
            // 
            this.Fsrc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fsrc.FormattingEnabled = true;
            this.Fsrc.Items.AddRange(new object[] {
            "ES",
            "SP",
            "AP",
            "AM",
            "CE",
            "RJ",
            "TC",
            "PA",
            "PR"});
            this.Fsrc.Location = new System.Drawing.Point(574, 197);
            this.Fsrc.Name = "Fsrc";
            this.Fsrc.Size = new System.Drawing.Size(182, 27);
            this.Fsrc.TabIndex = 17;
            // 
            // FDest
            // 
            this.FDest.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FDest.FormattingEnabled = true;
            this.FDest.Items.AddRange(new object[] {
            "ES",
            "SP",
            "AP",
            "AM",
            "CE",
            "RJ",
            "TC",
            "PA",
            "PR"});
            this.FDest.Location = new System.Drawing.Point(574, 303);
            this.FDest.Name = "FDest";
            this.FDest.Size = new System.Drawing.Size(182, 27);
            this.FDest.TabIndex = 18;
            // 
            // close_Flight_tbl
            // 
            this.close_Flight_tbl.BackColor = System.Drawing.Color.Red;
            this.close_Flight_tbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_Flight_tbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_Flight_tbl.Location = new System.Drawing.Point(718, 0);
            this.close_Flight_tbl.Name = "close_Flight_tbl";
            this.close_Flight_tbl.Size = new System.Drawing.Size(50, 23);
            this.close_Flight_tbl.TabIndex = 19;
            this.close_Flight_tbl.Text = "X";
            this.close_Flight_tbl.UseVisualStyleBackColor = false;
            this.close_Flight_tbl.Click += new System.EventHandler(this.close_Flight_tbl_Click);
            // 
            // reset_button_new_fly
            // 
            this.reset_button_new_fly.CheckedState.Parent = this.reset_button_new_fly;
            this.reset_button_new_fly.CustomImages.Parent = this.reset_button_new_fly;
            this.reset_button_new_fly.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reset_button_new_fly.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reset_button_new_fly.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reset_button_new_fly.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reset_button_new_fly.DisabledState.Parent = this.reset_button_new_fly;
            this.reset_button_new_fly.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.reset_button_new_fly.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reset_button_new_fly.ForeColor = System.Drawing.Color.White;
            this.reset_button_new_fly.HoverState.Parent = this.reset_button_new_fly;
            this.reset_button_new_fly.Location = new System.Drawing.Point(497, 609);
            this.reset_button_new_fly.Name = "reset_button_new_fly";
            this.reset_button_new_fly.ShadowDecoration.Parent = this.reset_button_new_fly;
            this.reset_button_new_fly.Size = new System.Drawing.Size(114, 45);
            this.reset_button_new_fly.TabIndex = 21;
            this.reset_button_new_fly.Text = "Resetar";
            this.reset_button_new_fly.Click += new System.EventHandler(this.reset_button_new_fly_Click);
            // 
            // save_fly
            // 
            this.save_fly.CheckedState.Parent = this.save_fly;
            this.save_fly.CustomImages.Parent = this.save_fly;
            this.save_fly.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.save_fly.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.save_fly.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.save_fly.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.save_fly.DisabledState.Parent = this.save_fly;
            this.save_fly.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.save_fly.ForeColor = System.Drawing.Color.White;
            this.save_fly.HoverState.Parent = this.save_fly;
            this.save_fly.Location = new System.Drawing.Point(497, 535);
            this.save_fly.Name = "save_fly";
            this.save_fly.ShadowDecoration.Parent = this.save_fly;
            this.save_fly.Size = new System.Drawing.Size(114, 45);
            this.save_fly.TabIndex = 20;
            this.save_fly.Text = "Salvar";
            this.save_fly.Click += new System.EventHandler(this.save_fly_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 28);
            this.label6.TabIndex = 22;
            this.label6.Text = "Escolha uma data:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FDate
            // 
            this.FDate.Animated = true;
            this.FDate.BackColor = System.Drawing.Color.Transparent;
            this.FDate.Checked = true;
            this.FDate.CheckedState.Parent = this.FDate;
            this.FDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.FDate.HoverState.Parent = this.FDate;
            this.FDate.IndicateFocus = true;
            this.FDate.Location = new System.Drawing.Point(225, 398);
            this.FDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.FDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.FDate.Name = "FDate";
            this.FDate.ShadowDecoration.Parent = this.FDate;
            this.FDate.Size = new System.Drawing.Size(248, 36);
            this.FDate.TabIndex = 23;
            this.FDate.Value = new System.DateTime(2021, 12, 5, 15, 32, 40, 669);
            // 
            // View_fly
            // 
            this.View_fly.CheckedState.Parent = this.View_fly;
            this.View_fly.CustomImages.Parent = this.View_fly;
            this.View_fly.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.View_fly.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.View_fly.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.View_fly.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.View_fly.DisabledState.Parent = this.View_fly;
            this.View_fly.FillColor = System.Drawing.Color.Green;
            this.View_fly.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.View_fly.ForeColor = System.Drawing.Color.White;
            this.View_fly.HoverState.Parent = this.View_fly;
            this.View_fly.Location = new System.Drawing.Point(629, 609);
            this.View_fly.Name = "View_fly";
            this.View_fly.ShadowDecoration.Parent = this.View_fly;
            this.View_fly.Size = new System.Drawing.Size(114, 45);
            this.View_fly.TabIndex = 24;
            this.View_fly.Text = "Visualizar voos";
            this.View_fly.Click += new System.EventHandler(this.View_fly_Click);
            // 
            // home_button
            // 
            this.home_button.CheckedState.Parent = this.home_button;
            this.home_button.CustomImages.Parent = this.home_button;
            this.home_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.home_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.home_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.home_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.home_button.DisabledState.Parent = this.home_button;
            this.home_button.FillColor = System.Drawing.Color.Teal;
            this.home_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.home_button.ForeColor = System.Drawing.Color.White;
            this.home_button.HoverState.Parent = this.home_button;
            this.home_button.Location = new System.Drawing.Point(629, 535);
            this.home_button.Name = "home_button";
            this.home_button.ShadowDecoration.Parent = this.home_button;
            this.home_button.Size = new System.Drawing.Size(114, 45);
            this.home_button.TabIndex = 92;
            this.home_button.Text = "Home";
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // FlightTbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 666);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.View_fly);
            this.Controls.Add(this.FDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.reset_button_new_fly);
            this.Controls.Add(this.save_fly);
            this.Controls.Add(this.close_Flight_tbl);
            this.Controls.Add(this.FDest);
            this.Controls.Add(this.Fsrc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SeatNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FcodeTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlightTbl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlightTbl";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox FcodeTb;
        private Guna.UI2.WinForms.Guna2TextBox SeatNum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Fsrc;
        private System.Windows.Forms.ComboBox FDest;
        private System.Windows.Forms.Button close_Flight_tbl;
        private Guna.UI2.WinForms.Guna2Button reset_button_new_fly;
        private Guna.UI2.WinForms.Guna2Button save_fly;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker FDate;
        private Guna.UI2.WinForms.Guna2Button View_fly;
        private Guna.UI2.WinForms.Guna2Button home_button;
    }
}