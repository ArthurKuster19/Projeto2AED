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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.PNatTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PAmtTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Resete_ticket = new Guna.UI2.WinForms.Guna2Button();
            this.save_ticket = new Guna.UI2.WinForms.Guna2Button();
            this.TicketDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.home_button = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.TicketDGV)).BeginInit();
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
            this.Tid.Location = new System.Drawing.Point(251, 158);
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
            this.PidCb.SelectionChangeCommitted += new System.EventHandler(this.PidCb_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 28);
            this.label4.TabIndex = 47;
            this.label4.Text = "Passageiro CPF:  ";
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
            this.PNameTb.Enabled = false;
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
            this.label5.Location = new System.Drawing.Point(473, 230);
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
            this.PPassTb.Enabled = false;
            this.PPassTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PPassTb.FocusedState.Parent = this.PPassTb;
            this.PPassTb.Font = new System.Drawing.Font("Arial", 12F);
            this.PPassTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PPassTb.HoverState.Parent = this.PPassTb;
            this.PPassTb.Location = new System.Drawing.Point(250, 317);
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
            // PNatTb
            // 
            this.PNatTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PNatTb.DefaultText = "";
            this.PNatTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PNatTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PNatTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PNatTb.DisabledState.Parent = this.PNatTb;
            this.PNatTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PNatTb.Enabled = false;
            this.PNatTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PNatTb.FocusedState.Parent = this.PNatTb;
            this.PNatTb.Font = new System.Drawing.Font("Arial", 12F);
            this.PNatTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PNatTb.HoverState.Parent = this.PNatTb;
            this.PNatTb.Location = new System.Drawing.Point(605, 312);
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
            this.label9.Location = new System.Drawing.Point(65, 402);
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
            this.PAmtTb.Location = new System.Drawing.Point(251, 397);
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
            // Resete_ticket
            // 
            this.Resete_ticket.CheckedState.Parent = this.Resete_ticket;
            this.Resete_ticket.CustomImages.Parent = this.Resete_ticket;
            this.Resete_ticket.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Resete_ticket.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Resete_ticket.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Resete_ticket.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Resete_ticket.DisabledState.Parent = this.Resete_ticket;
            this.Resete_ticket.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Resete_ticket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Resete_ticket.ForeColor = System.Drawing.Color.White;
            this.Resete_ticket.HoverState.Parent = this.Resete_ticket;
            this.Resete_ticket.Location = new System.Drawing.Point(351, 498);
            this.Resete_ticket.Name = "Resete_ticket";
            this.Resete_ticket.ShadowDecoration.Parent = this.Resete_ticket;
            this.Resete_ticket.Size = new System.Drawing.Size(114, 45);
            this.Resete_ticket.TabIndex = 62;
            this.Resete_ticket.Text = "Resetar";
            this.Resete_ticket.Click += new System.EventHandler(this.Resete_ticket_Click);
            // 
            // save_ticket
            // 
            this.save_ticket.CheckedState.Parent = this.save_ticket;
            this.save_ticket.CustomImages.Parent = this.save_ticket;
            this.save_ticket.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.save_ticket.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.save_ticket.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.save_ticket.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.save_ticket.DisabledState.Parent = this.save_ticket;
            this.save_ticket.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.save_ticket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.save_ticket.ForeColor = System.Drawing.Color.White;
            this.save_ticket.HoverState.Parent = this.save_ticket;
            this.save_ticket.Location = new System.Drawing.Point(126, 498);
            this.save_ticket.Name = "save_ticket";
            this.save_ticket.ShadowDecoration.Parent = this.save_ticket;
            this.save_ticket.Size = new System.Drawing.Size(114, 45);
            this.save_ticket.TabIndex = 61;
            this.save_ticket.Text = "Reserva";
            this.save_ticket.Click += new System.EventHandler(this.save_ticket_Click);
            // 
            // TicketDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.TicketDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TicketDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TicketDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TicketDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TicketDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TicketDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TicketDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TicketDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TicketDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.TicketDGV.EnableHeadersVisualStyles = false;
            this.TicketDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TicketDGV.Location = new System.Drawing.Point(21, 559);
            this.TicketDGV.Name = "TicketDGV";
            this.TicketDGV.RowHeadersVisible = false;
            this.TicketDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TicketDGV.Size = new System.Drawing.Size(799, 242);
            this.TicketDGV.TabIndex = 64;
            this.TicketDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TicketDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TicketDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TicketDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TicketDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TicketDGV.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.TicketDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TicketDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TicketDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TicketDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TicketDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TicketDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.TicketDGV.ThemeStyle.ReadOnly = false;
            this.TicketDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TicketDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TicketDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TicketDGV.ThemeStyle.RowsStyle.Height = 22;
            this.TicketDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TicketDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.home_button.Location = new System.Drawing.Point(580, 498);
            this.home_button.Name = "home_button";
            this.home_button.ShadowDecoration.Parent = this.home_button;
            this.home_button.Size = new System.Drawing.Size(114, 45);
            this.home_button.TabIndex = 91;
            this.home_button.Text = "Home";
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(832, 813);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.TicketDGV);
            this.Controls.Add(this.Resete_ticket);
            this.Controls.Add(this.save_ticket);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PAmtTb);
            this.Controls.Add(this.label9);
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
            ((System.ComponentModel.ISupportInitialize)(this.TicketDGV)).EndInit();
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
        private Guna.UI2.WinForms.Guna2TextBox PNatTb;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox PAmtTb;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button Resete_ticket;
        private Guna.UI2.WinForms.Guna2Button save_ticket;
        private Guna.UI2.WinForms.Guna2DataGridView TicketDGV;
        private Guna.UI2.WinForms.Guna2Button home_button;
    }
}