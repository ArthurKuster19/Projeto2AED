namespace system_airplane
{
    partial class Tickets
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
            this.close_tickets = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.Tid = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FCode = new System.Windows.Forms.ComboBox();
            this.PidCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PPassTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PAgeTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PNatTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PAmtTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.reset_button_view = new Guna.UI2.WinForms.Guna2Button();
            this.delete_button_login = new Guna.UI2.WinForms.Guna2Button();
            this.update_passenger_view = new Guna.UI2.WinForms.Guna2Button();
            this.passangerDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.passangerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // close_tickets
            // 
            this.close_tickets.BackColor = System.Drawing.Color.Red;
            this.close_tickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_tickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_tickets.Location = new System.Drawing.Point(784, -2);
            this.close_tickets.Name = "close_tickets";
            this.close_tickets.Size = new System.Drawing.Size(50, 23);
            this.close_tickets.TabIndex = 42;
            this.close_tickets.Text = "X";
            this.close_tickets.UseVisualStyleBackColor = false;
            this.close_tickets.Click += new System.EventHandler(this.close_tickets_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 43);
            this.label1.TabIndex = 41;
            this.label1.Text = "Reserva de bilhetes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(307, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(238, 39);
            this.title.TabIndex = 40;
            this.title.Text = "Airplane Voos";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tid
            // 
            this.Tid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tid.DefaultText = "";
            this.Tid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Tid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Tid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Tid.DisabledState.Parent = this.Tid;
            this.Tid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Tid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Tid.FocusedState.Parent = this.Tid;
            this.Tid.Font = new System.Drawing.Font("Arial", 12F);
            this.Tid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Tid.HoverState.Parent = this.Tid;
            this.Tid.Location = new System.Drawing.Point(202, 153);
            this.Tid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tid.MaxLength = 4;
            this.Tid.Name = "Tid";
            this.Tid.PasswordChar = '\0';
            this.Tid.PlaceholderText = "Digite o id";
            this.Tid.SelectedText = "";
            this.Tid.ShadowDecoration.Parent = this.Tid;
            this.Tid.Size = new System.Drawing.Size(159, 43);
            this.Tid.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 28);
            this.label2.TabIndex = 43;
            this.label2.Text = "Ticket id:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(416, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 28);
            this.label3.TabIndex = 45;
            this.label3.Text = "Código do voo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FCode
            // 
            this.FCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FCode.FormattingEnabled = true;
            this.FCode.Location = new System.Drawing.Point(602, 161);
            this.FCode.Name = "FCode";
            this.FCode.Size = new System.Drawing.Size(182, 27);
            this.FCode.TabIndex = 46;
            // 
            // PidCb
            // 
            this.PidCb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PidCb.FormattingEnabled = true;
            this.PidCb.Location = new System.Drawing.Point(251, 233);
            this.PidCb.Name = "PidCb";
            this.PidCb.Size = new System.Drawing.Size(182, 27);
            this.PidCb.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 28);
            this.label4.TabIndex = 47;
            this.label4.Text = "Passageiro id:  ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PNameTb
            // 
            this.PNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PNameTb.DefaultText = "";
            this.PNameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PNameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PNameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PNameTb.DisabledState.Parent = this.PNameTb;
            this.PNameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PNameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PNameTb.FocusedState.Parent = this.PNameTb;
            this.PNameTb.Font = new System.Drawing.Font("Arial", 12F);
            this.PNameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PNameTb.HoverState.Parent = this.PNameTb;
            this.PNameTb.Location = new System.Drawing.Point(603, 225);
            this.PNameTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PNameTb.MaxLength = 4;
            this.PNameTb.Name = "PNameTb";
            this.PNameTb.PasswordChar = '\0';
            this.PNameTb.PlaceholderText = "Digite o nome";
            this.PNameTb.SelectedText = "";
            this.PNameTb.ShadowDecoration.Parent = this.PNameTb;
            this.PNameTb.Size = new System.Drawing.Size(159, 43);
            this.PNameTb.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(464, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 28);
            this.label5.TabIndex = 49;
            this.label5.Text = "Nome:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PPassTb
            // 
            this.PPassTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PPassTb.DefaultText = "";
            this.PPassTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PPassTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PPassTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PPassTb.DisabledState.Parent = this.PPassTb;
            this.PPassTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PPassTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PPassTb.FocusedState.Parent = this.PPassTb;
            this.PPassTb.Font = new System.Drawing.Font("Arial", 12F);
            this.PPassTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PPassTb.HoverState.Parent = this.PPassTb;
            this.PPassTb.Location = new System.Drawing.Point(202, 312);
            this.PPassTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PPassTb.MaxLength = 4;
            this.PPassTb.Name = "PPassTb";
            this.PPassTb.PasswordChar = '\0';
            this.PPassTb.PlaceholderText = "Digite o passaporte";
            this.PPassTb.SelectedText = "";
            this.PPassTb.ShadowDecoration.Parent = this.PPassTb;
            this.PPassTb.Size = new System.Drawing.Size(159, 43);
            this.PPassTb.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 28);
            this.label6.TabIndex = 51;
            this.label6.Text = "Passaporte:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(416, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 28);
            this.label7.TabIndex = 53;
            this.label7.Text = "Nacionalidade:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PAgeTb
            // 
            this.PAgeTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PAgeTb.DefaultText = "";
            this.PAgeTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PAgeTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PAgeTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PAgeTb.DisabledState.Parent = this.PAgeTb;
            this.PAgeTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PAgeTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PAgeTb.FocusedState.Parent = this.PAgeTb;
            this.PAgeTb.Font = new System.Drawing.Font("Arial", 12F);
            this.PAgeTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PAgeTb.HoverState.Parent = this.PAgeTb;
            this.PAgeTb.Location = new System.Drawing.Point(202, 387);
            this.PAgeTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PAgeTb.MaxLength = 4;
            this.PAgeTb.Name = "PAgeTb";
            this.PAgeTb.PasswordChar = '\0';
            this.PAgeTb.PlaceholderText = "Digite o nome";
            this.PAgeTb.SelectedText = "";
            this.PAgeTb.ShadowDecoration.Parent = this.PAgeTb;
            this.PAgeTb.Size = new System.Drawing.Size(159, 43);
            this.PAgeTb.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 28);
            this.label8.TabIndex = 55;
            this.label8.Text = "Idade:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PNatTb
            // 
            this.PNatTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PNatTb.DefaultText = "";
            this.PNatTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PNatTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PNatTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PNatTb.DisabledState.Parent = this.PNatTb;
            this.PNatTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PNatTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PNatTb.FocusedState.Parent = this.PNatTb;
            this.PNatTb.Font = new System.Drawing.Font("Arial", 12F);
            this.PNatTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PNatTb.HoverState.Parent = this.PNatTb;
            this.PNatTb.Location = new System.Drawing.Point(604, 312);
            this.PNatTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PNatTb.MaxLength = 4;
            this.PNatTb.Name = "PNatTb";
            this.PNatTb.PasswordChar = '\0';
            this.PNatTb.PlaceholderText = "Digite a naciona...";
            this.PNatTb.SelectedText = "";
            this.PNatTb.ShadowDecoration.Parent = this.PNatTb;
            this.PNatTb.Size = new System.Drawing.Size(159, 43);
            this.PNatTb.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(416, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 28);
            this.label9.TabIndex = 57;
            this.label9.Text = "Quantidade:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PAmtTb
            // 
            this.PAmtTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PAmtTb.DefaultText = "";
            this.PAmtTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PAmtTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PAmtTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PAmtTb.DisabledState.Parent = this.PAmtTb;
            this.PAmtTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PAmtTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PAmtTb.FocusedState.Parent = this.PAmtTb;
            this.PAmtTb.Font = new System.Drawing.Font("Arial", 12F);
            this.PAmtTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PAmtTb.HoverState.Parent = this.PAmtTb;
            this.PAmtTb.Location = new System.Drawing.Point(602, 397);
            this.PAmtTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PAmtTb.MaxLength = 4;
            this.PAmtTb.Name = "PAmtTb";
            this.PAmtTb.PasswordChar = '\0';
            this.PAmtTb.PlaceholderText = "Digite a quantidade";
            this.PAmtTb.SelectedText = "";
            this.PAmtTb.ShadowDecoration.Parent = this.PAmtTb;
            this.PAmtTb.Size = new System.Drawing.Size(159, 43);
            this.PAmtTb.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(345, 444);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 35);
            this.label10.TabIndex = 59;
            this.label10.Text = "Reservas";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.reset_button_view.Location = new System.Drawing.Point(495, 497);
            this.reset_button_view.Name = "reset_button_view";
            this.reset_button_view.ShadowDecoration.Parent = this.reset_button_view;
            this.reset_button_view.Size = new System.Drawing.Size(114, 45);
            this.reset_button_view.TabIndex = 63;
            this.reset_button_view.Text = "Resetar";
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
            this.delete_button_login.Location = new System.Drawing.Point(342, 497);
            this.delete_button_login.Name = "delete_button_login";
            this.delete_button_login.ShadowDecoration.Parent = this.delete_button_login;
            this.delete_button_login.Size = new System.Drawing.Size(114, 45);
            this.delete_button_login.TabIndex = 62;
            this.delete_button_login.Text = "Apagar";
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
            this.update_passenger_view.Location = new System.Drawing.Point(196, 497);
            this.update_passenger_view.Name = "update_passenger_view";
            this.update_passenger_view.ShadowDecoration.Parent = this.update_passenger_view;
            this.update_passenger_view.Size = new System.Drawing.Size(114, 45);
            this.update_passenger_view.TabIndex = 61;
            this.update_passenger_view.Text = "Reserva";
            // 
            // passangerDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.passangerDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.passangerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.passangerDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.passangerDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passangerDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.passangerDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.passangerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.passangerDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.passangerDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.passangerDGV.EnableHeadersVisualStyles = false;
            this.passangerDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.passangerDGV.Location = new System.Drawing.Point(21, 559);
            this.passangerDGV.Name = "passangerDGV";
            this.passangerDGV.RowHeadersVisible = false;
            this.passangerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.passangerDGV.Size = new System.Drawing.Size(799, 242);
            this.passangerDGV.TabIndex = 64;
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
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(832, 813);
            this.Controls.Add(this.passangerDGV);
            this.Controls.Add(this.reset_button_view);
            this.Controls.Add(this.delete_button_login);
            this.Controls.Add(this.update_passenger_view);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PAmtTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PAgeTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PNatTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PPassTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PNameTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PidCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.close_tickets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Tickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passangerDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close_tickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private Guna.UI2.WinForms.Guna2TextBox Tid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FCode;
        private System.Windows.Forms.ComboBox PidCb;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox PNameTb;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox PPassTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox PAgeTb;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox PNatTb;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox PAmtTb;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button reset_button_view;
        private Guna.UI2.WinForms.Guna2Button delete_button_login;
        private Guna.UI2.WinForms.Guna2Button update_passenger_view;
        private Guna.UI2.WinForms.Guna2DataGridView passangerDGV;
    }
}