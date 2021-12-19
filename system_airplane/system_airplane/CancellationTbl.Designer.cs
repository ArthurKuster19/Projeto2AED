namespace system_airplane
{
    partial class CancellationTbl
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
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TidCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CanId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.close_cancel_tickets = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CancelDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cancel_ticket = new Guna.UI2.WinForms.Guna2Button();
            this.Resete_ticket = new Guna.UI2.WinForms.Guna2Button();
            this.FcodeTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.CancDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.home_button = new Guna.UI2.WinForms.Guna2Button();
            this.back_ticket = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.CancelDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(200, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(383, 35);
            this.label10.TabIndex = 80;
            this.label10.Text = "Lista de cancelamentos:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 28);
            this.label4.TabIndex = 68;
            this.label4.Text = "Voo id:  ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TidCb
            // 
            this.TidCb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TidCb.FormattingEnabled = true;
            this.TidCb.Location = new System.Drawing.Point(601, 160);
            this.TidCb.Name = "TidCb";
            this.TidCb.Size = new System.Drawing.Size(182, 27);
            this.TidCb.TabIndex = 67;
            this.TidCb.SelectionChangeCommitted += new System.EventHandler(this.TidCb_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(439, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 28);
            this.label3.TabIndex = 66;
            this.label3.Text = "Ticket id:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CanId
            // 
            this.CanId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CanId.DefaultText = "";
            this.CanId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CanId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CanId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CanId.DisabledState.Parent = this.CanId;
            this.CanId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CanId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CanId.FocusedState.Parent = this.CanId;
            this.CanId.Font = new System.Drawing.Font("Arial", 12F);
            this.CanId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CanId.HoverState.Parent = this.CanId;
            this.CanId.Location = new System.Drawing.Point(236, 160);
            this.CanId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CanId.MaxLength = 4;
            this.CanId.Name = "CanId";
            this.CanId.PasswordChar = '\0';
            this.CanId.PlaceholderText = "Digite o id";
            this.CanId.SelectedText = "";
            this.CanId.ShadowDecoration.Parent = this.CanId;
            this.CanId.Size = new System.Drawing.Size(159, 43);
            this.CanId.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 64;
            this.label2.Text = "Cancelamento id:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // close_cancel_tickets
            // 
            this.close_cancel_tickets.BackColor = System.Drawing.Color.Red;
            this.close_cancel_tickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_cancel_tickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_cancel_tickets.Location = new System.Drawing.Point(783, 0);
            this.close_cancel_tickets.Name = "close_cancel_tickets";
            this.close_cancel_tickets.Size = new System.Drawing.Size(50, 23);
            this.close_cancel_tickets.TabIndex = 63;
            this.close_cancel_tickets.Text = "X";
            this.close_cancel_tickets.UseVisualStyleBackColor = false;
            this.close_cancel_tickets.Click += new System.EventHandler(this.close_cancel_tickets_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 43);
            this.label1.TabIndex = 62;
            this.label1.Text = "Cancelamento de reserva";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(306, 11);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(238, 39);
            this.title.TabIndex = 61;
            this.title.Text = "Airplane Voos";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 28);
            this.label5.TabIndex = 82;
            this.label5.Text = "Data:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CancelDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CancelDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CancelDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CancelDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.CancelDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CancelDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CancelDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CancelDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CancelDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CancelDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.CancelDGV.EnableHeadersVisualStyles = false;
            this.CancelDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CancelDGV.Location = new System.Drawing.Point(12, 408);
            this.CancelDGV.Name = "CancelDGV";
            this.CancelDGV.RowHeadersVisible = false;
            this.CancelDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CancelDGV.Size = new System.Drawing.Size(799, 242);
            this.CancelDGV.TabIndex = 84;
            this.CancelDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CancelDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CancelDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CancelDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CancelDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CancelDGV.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.CancelDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CancelDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CancelDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CancelDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CancelDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.CancelDGV.ThemeStyle.ReadOnly = false;
            this.CancelDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CancelDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CancelDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CancelDGV.ThemeStyle.RowsStyle.Height = 22;
            this.CancelDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CancelDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cancel_ticket
            // 
            this.cancel_ticket.CheckedState.Parent = this.cancel_ticket;
            this.cancel_ticket.CustomImages.Parent = this.cancel_ticket;
            this.cancel_ticket.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancel_ticket.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancel_ticket.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancel_ticket.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancel_ticket.DisabledState.Parent = this.cancel_ticket;
            this.cancel_ticket.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cancel_ticket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancel_ticket.ForeColor = System.Drawing.Color.White;
            this.cancel_ticket.HoverState.Parent = this.cancel_ticket;
            this.cancel_ticket.Location = new System.Drawing.Point(60, 357);
            this.cancel_ticket.Name = "cancel_ticket";
            this.cancel_ticket.ShadowDecoration.Parent = this.cancel_ticket;
            this.cancel_ticket.Size = new System.Drawing.Size(114, 45);
            this.cancel_ticket.TabIndex = 85;
            this.cancel_ticket.Text = "Cancelar";
            this.cancel_ticket.Click += new System.EventHandler(this.cancel_ticket_Click);
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
            this.Resete_ticket.Location = new System.Drawing.Point(256, 357);
            this.Resete_ticket.Name = "Resete_ticket";
            this.Resete_ticket.ShadowDecoration.Parent = this.Resete_ticket;
            this.Resete_ticket.Size = new System.Drawing.Size(114, 45);
            this.Resete_ticket.TabIndex = 86;
            this.Resete_ticket.Text = "Limpar";
            this.Resete_ticket.Click += new System.EventHandler(this.Resete_ticket_Click);
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
            this.FcodeTb.Enabled = false;
            this.FcodeTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FcodeTb.FocusedState.Parent = this.FcodeTb;
            this.FcodeTb.Font = new System.Drawing.Font("Arial", 12F);
            this.FcodeTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FcodeTb.HoverState.Parent = this.FcodeTb;
            this.FcodeTb.Location = new System.Drawing.Point(236, 236);
            this.FcodeTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FcodeTb.MaxLength = 4;
            this.FcodeTb.Name = "FcodeTb";
            this.FcodeTb.PasswordChar = '\0';
            this.FcodeTb.PlaceholderText = "";
            this.FcodeTb.SelectedText = "";
            this.FcodeTb.ShadowDecoration.Parent = this.FcodeTb;
            this.FcodeTb.Size = new System.Drawing.Size(159, 43);
            this.FcodeTb.TabIndex = 88;
            this.FcodeTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CancDate
            // 
            this.CancDate.Animated = true;
            this.CancDate.BackColor = System.Drawing.Color.Transparent;
            this.CancDate.Checked = true;
            this.CancDate.CheckedState.Parent = this.CancDate;
            this.CancDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CancDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CancDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.CancDate.HoverState.Parent = this.CancDate;
            this.CancDate.IndicateFocus = true;
            this.CancDate.Location = new System.Drawing.Point(535, 236);
            this.CancDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.CancDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.CancDate.Name = "CancDate";
            this.CancDate.ShadowDecoration.Parent = this.CancDate;
            this.CancDate.Size = new System.Drawing.Size(248, 36);
            this.CancDate.TabIndex = 89;
            this.CancDate.Value = new System.DateTime(2021, 12, 5, 15, 32, 40, 669);
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
            this.home_button.Location = new System.Drawing.Point(660, 357);
            this.home_button.Name = "home_button";
            this.home_button.ShadowDecoration.Parent = this.home_button;
            this.home_button.Size = new System.Drawing.Size(114, 45);
            this.home_button.TabIndex = 90;
            this.home_button.Text = "Home";
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // back_ticket
            // 
            this.back_ticket.CheckedState.Parent = this.back_ticket;
            this.back_ticket.CustomImages.Parent = this.back_ticket;
            this.back_ticket.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.back_ticket.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.back_ticket.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.back_ticket.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.back_ticket.DisabledState.Parent = this.back_ticket;
            this.back_ticket.FillColor = System.Drawing.Color.Green;
            this.back_ticket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.back_ticket.ForeColor = System.Drawing.Color.White;
            this.back_ticket.HoverState.Parent = this.back_ticket;
            this.back_ticket.Location = new System.Drawing.Point(467, 357);
            this.back_ticket.Name = "back_ticket";
            this.back_ticket.ShadowDecoration.Parent = this.back_ticket;
            this.back_ticket.Size = new System.Drawing.Size(114, 45);
            this.back_ticket.TabIndex = 87;
            this.back_ticket.Text = "Voltar";
            // 
            // CancellationTbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(832, 662);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.CancDate);
            this.Controls.Add(this.FcodeTb);
            this.Controls.Add(this.back_ticket);
            this.Controls.Add(this.Resete_ticket);
            this.Controls.Add(this.cancel_ticket);
            this.Controls.Add(this.CancelDGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TidCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CanId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.close_cancel_tickets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CancellationTbl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancellationTbl";
            this.Load += new System.EventHandler(this.CancellationTbl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CancelDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TidCb;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox CanId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button close_cancel_tickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView CancelDGV;
        private Guna.UI2.WinForms.Guna2Button cancel_ticket;
        private Guna.UI2.WinForms.Guna2Button Resete_ticket;
        private Guna.UI2.WinForms.Guna2TextBox FcodeTb;
        private Guna.UI2.WinForms.Guna2DateTimePicker CancDate;
        private Guna.UI2.WinForms.Guna2Button home_button;
        private Guna.UI2.WinForms.Guna2Button back_ticket;
    }
}