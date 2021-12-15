namespace system_airplane
{
    partial class ViewPassenger
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.PpassTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PnameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cpf_view = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PaddTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.close_view_passanger = new System.Windows.Forms.Button();
            this.GendCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.natCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.back_viewpassenger = new Guna.UI2.WinForms.Guna2Button();
            this.reset_button_view = new Guna.UI2.WinForms.Guna2Button();
            this.delete_button_login = new Guna.UI2.WinForms.Guna2Button();
            this.update_passenger_view = new Guna.UI2.WinForms.Guna2Button();
            this.passangerDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.nmr_client_view = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.passangerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 43);
            this.label1.TabIndex = 8;
            this.label1.Text = "Visualizar passageiros";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(232, 30);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(238, 39);
            this.title.TabIndex = 7;
            this.title.Text = "Airplane Voos";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PpassTb
            // 
            this.PpassTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PpassTb.DefaultText = "";
            this.PpassTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PpassTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PpassTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PpassTb.DisabledState.Parent = this.PpassTb;
            this.PpassTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PpassTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PpassTb.FocusedState.Parent = this.PpassTb;
            this.PpassTb.Font = new System.Drawing.Font("Arial", 12F);
            this.PpassTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PpassTb.HoverState.Parent = this.PpassTb;
            this.PpassTb.Location = new System.Drawing.Point(321, 367);
            this.PpassTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PpassTb.MaxLength = 20;
            this.PpassTb.Name = "PpassTb";
            this.PpassTb.PasswordChar = '\0';
            this.PpassTb.PlaceholderText = "Digite o nmr pass.";
            this.PpassTb.SelectedText = "";
            this.PpassTb.ShadowDecoration.Parent = this.PpassTb;
            this.PpassTb.Size = new System.Drawing.Size(159, 43);
            this.PpassTb.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 28);
            this.label4.TabIndex = 30;
            this.label4.Text = "Número do passaporte:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnameTb
            // 
            this.PnameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PnameTb.DefaultText = "";
            this.PnameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PnameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PnameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PnameTb.DisabledState.Parent = this.PnameTb;
            this.PnameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PnameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PnameTb.FocusedState.Parent = this.PnameTb;
            this.PnameTb.Font = new System.Drawing.Font("Arial", 12F);
            this.PnameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PnameTb.HoverState.Parent = this.PnameTb;
            this.PnameTb.Location = new System.Drawing.Point(321, 288);
            this.PnameTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnameTb.MaxLength = 30;
            this.PnameTb.Name = "PnameTb";
            this.PnameTb.PasswordChar = '\0';
            this.PnameTb.PlaceholderText = "Digite o nome";
            this.PnameTb.SelectedText = "";
            this.PnameTb.ShadowDecoration.Parent = this.PnameTb;
            this.PnameTb.Size = new System.Drawing.Size(159, 43);
            this.PnameTb.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 28);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nome do cliente:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpf_view
            // 
            this.cpf_view.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cpf_view.DefaultText = "";
            this.cpf_view.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cpf_view.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cpf_view.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cpf_view.DisabledState.Parent = this.cpf_view;
            this.cpf_view.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cpf_view.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cpf_view.FocusedState.Parent = this.cpf_view;
            this.cpf_view.Font = new System.Drawing.Font("Arial", 12F);
            this.cpf_view.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cpf_view.HoverState.Parent = this.cpf_view;
            this.cpf_view.Location = new System.Drawing.Point(319, 206);
            this.cpf_view.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cpf_view.MaxLength = 11;
            this.cpf_view.Name = "cpf_view";
            this.cpf_view.PasswordChar = '\0';
            this.cpf_view.PlaceholderText = "Digite o CPF";
            this.cpf_view.SelectedText = "";
            this.cpf_view.ShadowDecoration.Parent = this.cpf_view;
            this.cpf_view.Size = new System.Drawing.Size(159, 43);
            this.cpf_view.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 28);
            this.label2.TabIndex = 26;
            this.label2.Text = "Cliente CPF:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PaddTb
            // 
            this.PaddTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PaddTb.DefaultText = "";
            this.PaddTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PaddTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PaddTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PaddTb.DisabledState.Parent = this.PaddTb;
            this.PaddTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PaddTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PaddTb.FocusedState.Parent = this.PaddTb;
            this.PaddTb.Font = new System.Drawing.Font("Arial", 12F);
            this.PaddTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PaddTb.HoverState.Parent = this.PaddTb;
            this.PaddTb.Location = new System.Drawing.Point(319, 448);
            this.PaddTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PaddTb.MaxLength = 15;
            this.PaddTb.Name = "PaddTb";
            this.PaddTb.PasswordChar = '\0';
            this.PaddTb.PlaceholderText = "Digite o end. pass.";
            this.PaddTb.SelectedText = "";
            this.PaddTb.ShadowDecoration.Parent = this.PaddTb;
            this.PaddTb.Size = new System.Drawing.Size(159, 43);
            this.PaddTb.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 28);
            this.label5.TabIndex = 32;
            this.label5.Text = "Endereço do passaporte:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // close_view_passanger
            // 
            this.close_view_passanger.BackColor = System.Drawing.Color.Red;
            this.close_view_passanger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_view_passanger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_view_passanger.Location = new System.Drawing.Point(693, -1);
            this.close_view_passanger.Name = "close_view_passanger";
            this.close_view_passanger.Size = new System.Drawing.Size(50, 23);
            this.close_view_passanger.TabIndex = 38;
            this.close_view_passanger.Text = "X";
            this.close_view_passanger.UseVisualStyleBackColor = false;
            this.close_view_passanger.Click += new System.EventHandler(this.close_view_passanger_Click);
            // 
            // GendCb
            // 
            this.GendCb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GendCb.FormattingEnabled = true;
            this.GendCb.Items.AddRange(new object[] {
            "",
            "Masculino",
            "Feminino"});
            this.GendCb.Location = new System.Drawing.Point(477, 633);
            this.GendCb.Name = "GendCb";
            this.GendCb.Size = new System.Drawing.Size(182, 27);
            this.GendCb.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(415, 637);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 21);
            this.label7.TabIndex = 41;
            this.label7.Text = "Sexo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // natCb
            // 
            this.natCb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.natCb.FormattingEnabled = true;
            this.natCb.Items.AddRange(new object[] {
            "",
            "Brasileiro",
            "Árabe"});
            this.natCb.Location = new System.Drawing.Point(204, 631);
            this.natCb.Name = "natCb";
            this.natCb.Size = new System.Drawing.Size(182, 27);
            this.natCb.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 631);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 21);
            this.label6.TabIndex = 39;
            this.label6.Text = "Nacionalidade";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // back_viewpassenger
            // 
            this.back_viewpassenger.CheckedState.Parent = this.back_viewpassenger;
            this.back_viewpassenger.CustomImages.Parent = this.back_viewpassenger;
            this.back_viewpassenger.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.back_viewpassenger.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.back_viewpassenger.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.back_viewpassenger.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.back_viewpassenger.DisabledState.Parent = this.back_viewpassenger;
            this.back_viewpassenger.FillColor = System.Drawing.Color.Purple;
            this.back_viewpassenger.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.back_viewpassenger.ForeColor = System.Drawing.Color.White;
            this.back_viewpassenger.HoverState.Parent = this.back_viewpassenger;
            this.back_viewpassenger.Location = new System.Drawing.Point(522, 703);
            this.back_viewpassenger.Name = "back_viewpassenger";
            this.back_viewpassenger.ShadowDecoration.Parent = this.back_viewpassenger;
            this.back_viewpassenger.Size = new System.Drawing.Size(114, 45);
            this.back_viewpassenger.TabIndex = 46;
            this.back_viewpassenger.Text = "Voltar";
            this.back_viewpassenger.Click += new System.EventHandler(this.back_viewpassenger_Click);
            // 
            // reset_button_view
            // 
            this.reset_button_view.CheckedState.Parent = this.reset_button_view;
            this.reset_button_view.CustomImages.Parent = this.reset_button_view;
            this.reset_button_view.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reset_button_view.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reset_button_view.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reset_button_view.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reset_button_view.DisabledState.Parent = this.reset_button_view;
            this.reset_button_view.FillColor = System.Drawing.Color.Teal;
            this.reset_button_view.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reset_button_view.ForeColor = System.Drawing.Color.White;
            this.reset_button_view.HoverState.Parent = this.reset_button_view;
            this.reset_button_view.Location = new System.Drawing.Point(376, 703);
            this.reset_button_view.Name = "reset_button_view";
            this.reset_button_view.ShadowDecoration.Parent = this.reset_button_view;
            this.reset_button_view.Size = new System.Drawing.Size(114, 45);
            this.reset_button_view.TabIndex = 45;
            this.reset_button_view.Text = "Resetar";
            this.reset_button_view.Click += new System.EventHandler(this.reset_button_view_Click);
            // 
            // delete_button_login
            // 
            this.delete_button_login.CheckedState.Parent = this.delete_button_login;
            this.delete_button_login.CustomImages.Parent = this.delete_button_login;
            this.delete_button_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete_button_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete_button_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete_button_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete_button_login.DisabledState.Parent = this.delete_button_login;
            this.delete_button_login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete_button_login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.delete_button_login.ForeColor = System.Drawing.Color.White;
            this.delete_button_login.HoverState.Parent = this.delete_button_login;
            this.delete_button_login.Location = new System.Drawing.Point(223, 703);
            this.delete_button_login.Name = "delete_button_login";
            this.delete_button_login.ShadowDecoration.Parent = this.delete_button_login;
            this.delete_button_login.Size = new System.Drawing.Size(114, 45);
            this.delete_button_login.TabIndex = 44;
            this.delete_button_login.Text = "Apagar";
            this.delete_button_login.Click += new System.EventHandler(this.delete_button_login_Click);
            // 
            // update_passenger_view
            // 
            this.update_passenger_view.CheckedState.Parent = this.update_passenger_view;
            this.update_passenger_view.CustomImages.Parent = this.update_passenger_view;
            this.update_passenger_view.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.update_passenger_view.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.update_passenger_view.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.update_passenger_view.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.update_passenger_view.DisabledState.Parent = this.update_passenger_view;
            this.update_passenger_view.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.update_passenger_view.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.update_passenger_view.ForeColor = System.Drawing.Color.White;
            this.update_passenger_view.HoverState.Parent = this.update_passenger_view;
            this.update_passenger_view.Location = new System.Drawing.Point(77, 703);
            this.update_passenger_view.Name = "update_passenger_view";
            this.update_passenger_view.ShadowDecoration.Parent = this.update_passenger_view;
            this.update_passenger_view.Size = new System.Drawing.Size(114, 45);
            this.update_passenger_view.TabIndex = 43;
            this.update_passenger_view.Text = "Atualizar";
            this.update_passenger_view.Click += new System.EventHandler(this.update_passenger_view_Click);
            // 
            // passangerDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.passangerDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.passangerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.passangerDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.passangerDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passangerDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.passangerDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.passangerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.passangerDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.passangerDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.passangerDGV.EnableHeadersVisualStyles = false;
            this.passangerDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.passangerDGV.Location = new System.Drawing.Point(13, 781);
            this.passangerDGV.Name = "passangerDGV";
            this.passangerDGV.RowHeadersVisible = false;
            this.passangerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.passangerDGV.Size = new System.Drawing.Size(720, 233);
            this.passangerDGV.TabIndex = 47;
            this.passangerDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.passangerDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.passangerDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.passangerDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.passangerDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.passangerDGV.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.passangerDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.passangerDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.passangerDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.passangerDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passangerDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.passangerDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.passangerDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.passangerDGV.ThemeStyle.ReadOnly = false;
            this.passangerDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.passangerDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.passangerDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passangerDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.passangerDGV.ThemeStyle.RowsStyle.Height = 22;
            this.passangerDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.passangerDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.passangerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.passangerDGV_CellContentClick);
            // 
            // nmr_client_view
            // 
            this.nmr_client_view.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmr_client_view.DefaultText = "";
            this.nmr_client_view.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nmr_client_view.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nmr_client_view.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nmr_client_view.DisabledState.Parent = this.nmr_client_view;
            this.nmr_client_view.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nmr_client_view.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nmr_client_view.FocusedState.Parent = this.nmr_client_view;
            this.nmr_client_view.Font = new System.Drawing.Font("Arial", 12F);
            this.nmr_client_view.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nmr_client_view.HoverState.Parent = this.nmr_client_view;
            this.nmr_client_view.Location = new System.Drawing.Point(319, 531);
            this.nmr_client_view.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmr_client_view.MaxLength = 11;
            this.nmr_client_view.Name = "nmr_client_view";
            this.nmr_client_view.PasswordChar = '\0';
            this.nmr_client_view.PlaceholderText = "Digite o número";
            this.nmr_client_view.SelectedText = "";
            this.nmr_client_view.ShadowDecoration.Parent = this.nmr_client_view;
            this.nmr_client_view.Size = new System.Drawing.Size(159, 43);
            this.nmr_client_view.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 535);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 28);
            this.label8.TabIndex = 48;
            this.label8.Text = "Número de celular:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(743, 1036);
            this.Controls.Add(this.nmr_client_view);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.passangerDGV);
            this.Controls.Add(this.back_viewpassenger);
            this.Controls.Add(this.reset_button_view);
            this.Controls.Add(this.delete_button_login);
            this.Controls.Add(this.update_passenger_view);
            this.Controls.Add(this.GendCb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.natCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.close_view_passanger);
            this.Controls.Add(this.PaddTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PpassTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PnameTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cpf_view);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPassenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPassenger";
            this.Load += new System.EventHandler(this.ViewPassenger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passangerDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private Guna.UI2.WinForms.Guna2TextBox PpassTb;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox PnameTb;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox cpf_view;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox PaddTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button close_view_passanger;
        private System.Windows.Forms.ComboBox GendCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox natCb;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button back_viewpassenger;
        private Guna.UI2.WinForms.Guna2Button reset_button_view;
        private Guna.UI2.WinForms.Guna2Button delete_button_login;
        private Guna.UI2.WinForms.Guna2Button update_passenger_view;
        private Guna.UI2.WinForms.Guna2DataGridView passangerDGV;
        private Guna.UI2.WinForms.Guna2TextBox nmr_client_view;
        private System.Windows.Forms.Label label8;
    }
}