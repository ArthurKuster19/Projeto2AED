namespace system_airplane
{
    partial class ViewFlights
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.Fdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.DstCb = new System.Windows.Forms.ComboBox();
            this.SrcCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Fcode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Seatnum = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.delete_button_list_fly = new Guna.UI2.WinForms.Guna2Button();
            this.att_view_fly = new Guna.UI2.WinForms.Guna2Button();
            this.back_to_save_fly = new Guna.UI2.WinForms.Guna2Button();
            this.reset_inputs = new Guna.UI2.WinForms.Guna2Button();
            this.close_view_fly = new System.Windows.Forms.Button();
            this.FlightDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.FlightDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lista de voos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(277, 23);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(238, 39);
            this.title.TabIndex = 5;
            this.title.Text = "Airplane Voos";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fdate
            // 
            this.Fdate.Animated = true;
            this.Fdate.BackColor = System.Drawing.Color.Transparent;
            this.Fdate.Checked = true;
            this.Fdate.CheckedState.Parent = this.Fdate;
            this.Fdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Fdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Fdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Fdate.HoverState.Parent = this.Fdate;
            this.Fdate.IndicateFocus = true;
            this.Fdate.Location = new System.Drawing.Point(116, 320);
            this.Fdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Fdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Fdate.Name = "Fdate";
            this.Fdate.ShadowDecoration.Parent = this.Fdate;
            this.Fdate.Size = new System.Drawing.Size(248, 36);
            this.Fdate.TabIndex = 31;
            this.Fdate.Value = new System.DateTime(2021, 12, 5, 15, 32, 40, 669);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 28);
            this.label6.TabIndex = 30;
            this.label6.Text = "Data:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DstCb
            // 
            this.DstCb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DstCb.FormattingEnabled = true;
            this.DstCb.Items.AddRange(new object[] {
            "ES",
            "SP",
            "AP",
            "AM",
            "CE",
            "RJ",
            "TC",
            "PA",
            "PR"});
            this.DstCb.Location = new System.Drawing.Point(572, 325);
            this.DstCb.Name = "DstCb";
            this.DstCb.Size = new System.Drawing.Size(182, 27);
            this.DstCb.TabIndex = 29;
            // 
            // SrcCb
            // 
            this.SrcCb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrcCb.FormattingEnabled = true;
            this.SrcCb.Items.AddRange(new object[] {
            "ES",
            "SP",
            "AP",
            "AM",
            "CE",
            "RJ",
            "TC",
            "PA",
            "PR"});
            this.SrcCb.Location = new System.Drawing.Point(572, 219);
            this.SrcCb.Name = "SrcCb";
            this.SrcCb.Size = new System.Drawing.Size(182, 27);
            this.SrcCb.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(444, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "Destino";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(444, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 28);
            this.label4.TabIndex = 26;
            this.label4.Text = "Procurar";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fcode
            // 
            this.Fcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Fcode.DefaultText = "";
            this.Fcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Fcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Fcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Fcode.DisabledState.Parent = this.Fcode;
            this.Fcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Fcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Fcode.FocusedState.Parent = this.Fcode;
            this.Fcode.Font = new System.Drawing.Font("Arial", 12F);
            this.Fcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Fcode.HoverState.Parent = this.Fcode;
            this.Fcode.Location = new System.Drawing.Point(205, 213);
            this.Fcode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Fcode.MaxLength = 4;
            this.Fcode.Name = "Fcode";
            this.Fcode.PasswordChar = '\0';
            this.Fcode.PlaceholderText = "Digite o código";
            this.Fcode.SelectedText = "";
            this.Fcode.ShadowDecoration.Parent = this.Fcode;
            this.Fcode.Size = new System.Drawing.Size(159, 43);
            this.Fcode.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "Código do voo:\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Seatnum
            // 
            this.Seatnum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Seatnum.DefaultText = "";
            this.Seatnum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Seatnum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Seatnum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Seatnum.DisabledState.Parent = this.Seatnum;
            this.Seatnum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Seatnum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Seatnum.FocusedState.Parent = this.Seatnum;
            this.Seatnum.Font = new System.Drawing.Font("Arial", 12F);
            this.Seatnum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Seatnum.HoverState.Parent = this.Seatnum;
            this.Seatnum.Location = new System.Drawing.Point(264, 402);
            this.Seatnum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Seatnum.MaxLength = 4;
            this.Seatnum.Name = "Seatnum";
            this.Seatnum.PasswordChar = '\0';
            this.Seatnum.PlaceholderText = "quantidade de assentos";
            this.Seatnum.SelectedText = "";
            this.Seatnum.ShadowDecoration.Parent = this.Seatnum;
            this.Seatnum.Size = new System.Drawing.Size(189, 43);
            this.Seatnum.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 28);
            this.label3.TabIndex = 32;
            this.label3.Text = "Números de assentos:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // delete_button_list_fly
            // 
            this.delete_button_list_fly.CheckedState.Parent = this.delete_button_list_fly;
            this.delete_button_list_fly.CustomImages.Parent = this.delete_button_list_fly;
            this.delete_button_list_fly.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete_button_list_fly.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete_button_list_fly.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete_button_list_fly.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete_button_list_fly.DisabledState.Parent = this.delete_button_list_fly;
            this.delete_button_list_fly.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.delete_button_list_fly.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.delete_button_list_fly.ForeColor = System.Drawing.Color.White;
            this.delete_button_list_fly.HoverState.Parent = this.delete_button_list_fly;
            this.delete_button_list_fly.Location = new System.Drawing.Point(231, 483);
            this.delete_button_list_fly.Name = "delete_button_list_fly";
            this.delete_button_list_fly.ShadowDecoration.Parent = this.delete_button_list_fly;
            this.delete_button_list_fly.Size = new System.Drawing.Size(114, 45);
            this.delete_button_list_fly.TabIndex = 36;
            this.delete_button_list_fly.Text = "Apagar";
            this.delete_button_list_fly.Click += new System.EventHandler(this.delete_button_list_fly_Click);
            // 
            // att_view_fly
            // 
            this.att_view_fly.CheckedState.Parent = this.att_view_fly;
            this.att_view_fly.CustomImages.Parent = this.att_view_fly;
            this.att_view_fly.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.att_view_fly.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.att_view_fly.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.att_view_fly.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.att_view_fly.DisabledState.Parent = this.att_view_fly;
            this.att_view_fly.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.att_view_fly.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.att_view_fly.ForeColor = System.Drawing.Color.White;
            this.att_view_fly.HoverState.Parent = this.att_view_fly;
            this.att_view_fly.Location = new System.Drawing.Point(85, 483);
            this.att_view_fly.Name = "att_view_fly";
            this.att_view_fly.ShadowDecoration.Parent = this.att_view_fly;
            this.att_view_fly.Size = new System.Drawing.Size(114, 45);
            this.att_view_fly.TabIndex = 35;
            this.att_view_fly.Text = "Atualizar";
            this.att_view_fly.Click += new System.EventHandler(this.att_view_fly_Click);
            // 
            // back_to_save_fly
            // 
            this.back_to_save_fly.CheckedState.Parent = this.back_to_save_fly;
            this.back_to_save_fly.CustomImages.Parent = this.back_to_save_fly;
            this.back_to_save_fly.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.back_to_save_fly.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.back_to_save_fly.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.back_to_save_fly.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.back_to_save_fly.DisabledState.Parent = this.back_to_save_fly;
            this.back_to_save_fly.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.back_to_save_fly.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.back_to_save_fly.ForeColor = System.Drawing.Color.White;
            this.back_to_save_fly.HoverState.Parent = this.back_to_save_fly;
            this.back_to_save_fly.Location = new System.Drawing.Point(532, 483);
            this.back_to_save_fly.Name = "back_to_save_fly";
            this.back_to_save_fly.ShadowDecoration.Parent = this.back_to_save_fly;
            this.back_to_save_fly.Size = new System.Drawing.Size(114, 45);
            this.back_to_save_fly.TabIndex = 38;
            this.back_to_save_fly.Text = "Voltar";
            this.back_to_save_fly.Click += new System.EventHandler(this.back_to_save_fly_Click);
            // 
            // reset_inputs
            // 
            this.reset_inputs.CheckedState.Parent = this.reset_inputs;
            this.reset_inputs.CustomImages.Parent = this.reset_inputs;
            this.reset_inputs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reset_inputs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reset_inputs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reset_inputs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reset_inputs.DisabledState.Parent = this.reset_inputs;
            this.reset_inputs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.reset_inputs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reset_inputs.ForeColor = System.Drawing.Color.White;
            this.reset_inputs.HoverState.Parent = this.reset_inputs;
            this.reset_inputs.Location = new System.Drawing.Point(384, 483);
            this.reset_inputs.Name = "reset_inputs";
            this.reset_inputs.ShadowDecoration.Parent = this.reset_inputs;
            this.reset_inputs.Size = new System.Drawing.Size(114, 45);
            this.reset_inputs.TabIndex = 37;
            this.reset_inputs.Text = "Resetar";
            this.reset_inputs.Click += new System.EventHandler(this.reset_inputs_Click);
            // 
            // close_view_fly
            // 
            this.close_view_fly.BackColor = System.Drawing.Color.Red;
            this.close_view_fly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_view_fly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_view_fly.Location = new System.Drawing.Point(720, -1);
            this.close_view_fly.Name = "close_view_fly";
            this.close_view_fly.Size = new System.Drawing.Size(50, 23);
            this.close_view_fly.TabIndex = 39;
            this.close_view_fly.Text = "X";
            this.close_view_fly.UseVisualStyleBackColor = false;
            this.close_view_fly.Click += new System.EventHandler(this.close_view_fly_Click);
            // 
            // FlightDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.FlightDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.FlightDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FlightDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.FlightDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FlightDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.FlightDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FlightDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.FlightDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FlightDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.FlightDGV.EnableHeadersVisualStyles = false;
            this.FlightDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FlightDGV.Location = new System.Drawing.Point(22, 551);
            this.FlightDGV.Name = "FlightDGV";
            this.FlightDGV.RowHeadersVisible = false;
            this.FlightDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FlightDGV.Size = new System.Drawing.Size(720, 233);
            this.FlightDGV.TabIndex = 48;
            this.FlightDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.FlightDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.FlightDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.FlightDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.FlightDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.FlightDGV.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.FlightDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FlightDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.FlightDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.FlightDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.FlightDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.FlightDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.FlightDGV.ThemeStyle.ReadOnly = false;
            this.FlightDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.FlightDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.FlightDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FlightDGV.ThemeStyle.RowsStyle.Height = 22;
            this.FlightDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FlightDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FlightDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FlightDGV_CellContentClick);
            // 
            // ViewFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 796);
            this.Controls.Add(this.FlightDGV);
            this.Controls.Add(this.close_view_fly);
            this.Controls.Add(this.back_to_save_fly);
            this.Controls.Add(this.reset_inputs);
            this.Controls.Add(this.delete_button_list_fly);
            this.Controls.Add(this.att_view_fly);
            this.Controls.Add(this.Seatnum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Fdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DstCb);
            this.Controls.Add(this.SrcCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Fcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewFlights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewFlights";
            this.Load += new System.EventHandler(this.ViewFlights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FlightDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private Guna.UI2.WinForms.Guna2DateTimePicker Fdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox DstCb;
        private System.Windows.Forms.ComboBox SrcCb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox Fcode;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox Seatnum;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button delete_button_list_fly;
        private Guna.UI2.WinForms.Guna2Button att_view_fly;
        private Guna.UI2.WinForms.Guna2Button back_to_save_fly;
        private Guna.UI2.WinForms.Guna2Button reset_inputs;
        private System.Windows.Forms.Button close_view_fly;
        private Guna.UI2.WinForms.Guna2DataGridView FlightDGV;
    }
}