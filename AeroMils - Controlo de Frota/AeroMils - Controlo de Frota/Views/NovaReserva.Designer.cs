namespace AeroMils___Controlo_de_Frota.Views
{
    partial class NovaReserva
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
            VoosPanel = new Panel();
            valorFreteLabel = new Label();
            listaAvioesInput = new ComboBox();
            escolhaAviaoLabel = new Label();
            nomeClienteLabel = new Label();
            nomeClienteInput = new TextBox();
            endDateLabel = new Label();
            startDateLabel = new Label();
            paraOndeLabel = new Label();
            endDateInput = new DateTimePicker();
            deOndeLabel = new Label();
            startDateInput = new DateTimePicker();
            localDestinoInput = new TextBox();
            localPartidaInput = new TextBox();
            Reservar_button = new Button();
            VooMercadoria_button = new Button();
            Avionetas_button = new Button();
            Valor_label = new Label();
            VooParticular_button = new Button();
            VooComercial_button = new Button();
            VoosPanel.SuspendLayout();
            SuspendLayout();
            // 
            // VoosPanel
            // 
            VoosPanel.Controls.Add(valorFreteLabel);
            VoosPanel.Controls.Add(listaAvioesInput);
            VoosPanel.Controls.Add(escolhaAviaoLabel);
            VoosPanel.Controls.Add(nomeClienteLabel);
            VoosPanel.Controls.Add(nomeClienteInput);
            VoosPanel.Controls.Add(endDateLabel);
            VoosPanel.Controls.Add(startDateLabel);
            VoosPanel.Controls.Add(paraOndeLabel);
            VoosPanel.Controls.Add(endDateInput);
            VoosPanel.Controls.Add(deOndeLabel);
            VoosPanel.Controls.Add(startDateInput);
            VoosPanel.Controls.Add(localDestinoInput);
            VoosPanel.Controls.Add(localPartidaInput);
            VoosPanel.Controls.Add(Reservar_button);
            VoosPanel.Controls.Add(VooMercadoria_button);
            VoosPanel.Controls.Add(Avionetas_button);
            VoosPanel.Controls.Add(Valor_label);
            VoosPanel.Controls.Add(VooParticular_button);
            VoosPanel.Controls.Add(VooComercial_button);
            VoosPanel.Dock = DockStyle.Fill;
            VoosPanel.Location = new Point(0, 0);
            VoosPanel.Name = "VoosPanel";
            VoosPanel.Size = new Size(700, 338);
            VoosPanel.TabIndex = 0;
            // 
            // valorFreteLabel
            // 
            valorFreteLabel.AutoSize = true;
            valorFreteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            valorFreteLabel.Location = new Point(24, 291);
            valorFreteLabel.Name = "valorFreteLabel";
            valorFreteLabel.Size = new Size(118, 21);
            valorFreteLabel.TabIndex = 45;
            valorFreteLabel.Text = "Valor do frete:";
            // 
            // listaAvioesInput
            // 
            listaAvioesInput.FormattingEnabled = true;
            listaAvioesInput.Location = new Point(251, 135);
            listaAvioesInput.Margin = new Padding(2);
            listaAvioesInput.Name = "listaAvioesInput";
            listaAvioesInput.Size = new Size(339, 23);
            listaAvioesInput.TabIndex = 44;
            // 
            // escolhaAviaoLabel
            // 
            escolhaAviaoLabel.AutoSize = true;
            escolhaAviaoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            escolhaAviaoLabel.Location = new Point(251, 108);
            escolhaAviaoLabel.Name = "escolhaAviaoLabel";
            escolhaAviaoLabel.Size = new Size(49, 21);
            escolhaAviaoLabel.TabIndex = 43;
            escolhaAviaoLabel.Text = "Aviao";
            // 
            // nomeClienteLabel
            // 
            nomeClienteLabel.AutoSize = true;
            nomeClienteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nomeClienteLabel.Location = new Point(24, 108);
            nomeClienteLabel.Name = "nomeClienteLabel";
            nomeClienteLabel.Size = new Size(105, 21);
            nomeClienteLabel.TabIndex = 42;
            nomeClienteLabel.Text = "Nome Cliente";
            // 
            // nomeClienteInput
            // 
            nomeClienteInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nomeClienteInput.Location = new Point(24, 132);
            nomeClienteInput.Name = "nomeClienteInput";
            nomeClienteInput.Size = new Size(171, 29);
            nomeClienteInput.TabIndex = 41;
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            endDateLabel.Location = new Point(571, 175);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(37, 17);
            endDateLabel.TabIndex = 40;
            endDateLabel.Text = "Até ?";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            startDateLabel.Location = new Point(448, 175);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(34, 17);
            startDateLabel.TabIndex = 39;
            startDateLabel.Text = "De ?";
            // 
            // paraOndeLabel
            // 
            paraOndeLabel.AutoSize = true;
            paraOndeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            paraOndeLabel.Location = new Point(251, 167);
            paraOndeLabel.Name = "paraOndeLabel";
            paraOndeLabel.Size = new Size(90, 21);
            paraOndeLabel.TabIndex = 38;
            paraOndeLabel.Text = "Para onde ?";
            // 
            // endDateInput
            // 
            endDateInput.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            endDateInput.Format = DateTimePickerFormat.Short;
            endDateInput.Location = new Point(571, 195);
            endDateInput.MinDate = DateTime.Now.AddDays(1);
            endDateInput.Name = "endDateInput";
            endDateInput.Size = new Size(103, 25);
            endDateInput.TabIndex = 37;
            endDateInput.Value = DateTime.Now.AddDays(1);
            // 
            // deOndeLabel
            // 
            deOndeLabel.AutoSize = true;
            deOndeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deOndeLabel.Location = new Point(24, 167);
            deOndeLabel.Name = "deOndeLabel";
            deOndeLabel.Size = new Size(79, 21);
            deOndeLabel.TabIndex = 36;
            deOndeLabel.Text = "De onde ?";
            // 
            // startDateInput
            // 
            startDateInput.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            startDateInput.Format = DateTimePickerFormat.Short;
            startDateInput.Location = new Point(448, 195);
            startDateInput.MinDate = DateTime.Now;
            startDateInput.Name = "startDateInput";
            startDateInput.Size = new Size(103, 25);
            startDateInput.TabIndex = 35;
            startDateInput.Value = DateTime.Now;
            // 
            // localDestinoInput
            // 
            localDestinoInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            localDestinoInput.Location = new Point(251, 191);
            localDestinoInput.Name = "localDestinoInput";
            localDestinoInput.Size = new Size(171, 29);
            localDestinoInput.TabIndex = 34;
            // 
            // localPartidaInput
            // 
            localPartidaInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            localPartidaInput.Location = new Point(24, 191);
            localPartidaInput.Name = "localPartidaInput";
            localPartidaInput.Size = new Size(171, 29);
            localPartidaInput.TabIndex = 33;
            // 
            // Reservar_button
            // 
            Reservar_button.BackColor = Color.FromArgb(54, 53, 67);
            Reservar_button.FlatAppearance.BorderSize = 0;
            Reservar_button.FlatStyle = FlatStyle.Flat;
            Reservar_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Reservar_button.ForeColor = Color.White;
            Reservar_button.ImageAlign = ContentAlignment.MiddleLeft;
            Reservar_button.Location = new Point(555, 276);
            Reservar_button.Margin = new Padding(3, 2, 3, 2);
            Reservar_button.Name = "Reservar_button";
            Reservar_button.Size = new Size(120, 51);
            Reservar_button.TabIndex = 16;
            Reservar_button.Text = "Reservar";
            Reservar_button.TextImageRelation = TextImageRelation.ImageBeforeText;
            Reservar_button.UseVisualStyleBackColor = false;
            Reservar_button.Click += Reservar_button_Click;
            // 
            // VooMercadoria_button
            // 
            VooMercadoria_button.BackColor = Color.FromArgb(54, 53, 67);
            VooMercadoria_button.FlatAppearance.BorderSize = 0;
            VooMercadoria_button.FlatStyle = FlatStyle.Flat;
            VooMercadoria_button.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            VooMercadoria_button.ForeColor = Color.White;
            VooMercadoria_button.ImageAlign = ContentAlignment.MiddleLeft;
            VooMercadoria_button.Location = new Point(363, 12);
            VooMercadoria_button.Margin = new Padding(3, 2, 3, 2);
            VooMercadoria_button.Name = "VooMercadoria_button";
            VooMercadoria_button.Size = new Size(144, 44);
            VooMercadoria_button.TabIndex = 8;
            VooMercadoria_button.Text = "Voo Mercadoria";
            VooMercadoria_button.TextImageRelation = TextImageRelation.ImageBeforeText;
            VooMercadoria_button.UseVisualStyleBackColor = false;
            VooMercadoria_button.Click += VooMercadoria_button_Click;
            // 
            // Avionetas_button
            // 
            Avionetas_button.BackColor = Color.FromArgb(54, 53, 67);
            Avionetas_button.FlatAppearance.BorderSize = 0;
            Avionetas_button.FlatStyle = FlatStyle.Flat;
            Avionetas_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Avionetas_button.ForeColor = Color.White;
            Avionetas_button.ImageAlign = ContentAlignment.MiddleLeft;
            Avionetas_button.Location = new Point(531, 12);
            Avionetas_button.Margin = new Padding(3, 2, 3, 2);
            Avionetas_button.Name = "Avionetas_button";
            Avionetas_button.Size = new Size(144, 44);
            Avionetas_button.TabIndex = 7;
            Avionetas_button.Text = "Avionetas";
            Avionetas_button.TextImageRelation = TextImageRelation.ImageBeforeText;
            Avionetas_button.UseVisualStyleBackColor = false;
            Avionetas_button.Click += Avionetas_button_Click;
            // 
            // Valor_label
            // 
            Valor_label.AutoSize = true;
            Valor_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Valor_label.Location = new Point(146, 291);
            Valor_label.Name = "Valor_label";
            Valor_label.Size = new Size(19, 21);
            Valor_label.TabIndex = 5;
            Valor_label.Text = "0";
            // 
            // VooParticular_button
            // 
            VooParticular_button.BackColor = Color.FromArgb(54, 53, 67);
            VooParticular_button.FlatAppearance.BorderSize = 0;
            VooParticular_button.FlatStyle = FlatStyle.Flat;
            VooParticular_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            VooParticular_button.ForeColor = Color.White;
            VooParticular_button.ImageAlign = ContentAlignment.MiddleLeft;
            VooParticular_button.Location = new Point(195, 12);
            VooParticular_button.Margin = new Padding(3, 2, 3, 2);
            VooParticular_button.Name = "VooParticular_button";
            VooParticular_button.Size = new Size(144, 44);
            VooParticular_button.TabIndex = 6;
            VooParticular_button.Text = "Voo Particular";
            VooParticular_button.TextImageRelation = TextImageRelation.ImageBeforeText;
            VooParticular_button.UseVisualStyleBackColor = false;
            VooParticular_button.Click += VooParticular_button_Click;
            // 
            // VooComercial_button
            // 
            VooComercial_button.BackColor = Color.FromArgb(255, 98, 45);
            VooComercial_button.FlatAppearance.BorderSize = 0;
            VooComercial_button.FlatStyle = FlatStyle.Flat;
            VooComercial_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            VooComercial_button.ForeColor = Color.White;
            VooComercial_button.ImageAlign = ContentAlignment.MiddleLeft;
            VooComercial_button.Location = new Point(24, 12);
            VooComercial_button.Margin = new Padding(3, 2, 3, 2);
            VooComercial_button.Name = "VooComercial_button";
            VooComercial_button.Size = new Size(144, 44);
            VooComercial_button.TabIndex = 5;
            VooComercial_button.Text = "Voo Comercial";
            VooComercial_button.TextImageRelation = TextImageRelation.ImageBeforeText;
            VooComercial_button.UseVisualStyleBackColor = false;
            VooComercial_button.Click += VooComercial_button_Click;
            // 
            // NovaReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(VoosPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "NovaReserva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NovaReserva";
            VoosPanel.ResumeLayout(false);
            VoosPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel VoosPanel;
        private Button VooComercial_button;
        private Button VooParticular_button;
        private Button VooMercadoria_button;
        private Button Avionetas_button;
        private Button Reservar_button;
        private Label Valor_label;
        private Label Particular_Ate_label;
        private DateTimePicker Particular_Ate_dateTimePicker;
        private ComboBox listaAvioesInput;
        private Label escolhaAviaoLabel;
        private Label nomeClienteLabel;
        private TextBox nomeClienteInput;
        private Label endDateLabel;
        private Label startDateLabel;
        private Label paraOndeLabel;
        private DateTimePicker endDateInput;
        private Label deOndeLabel;
        private DateTimePicker startDateInput;
        private TextBox localDestinoInput;
        private TextBox localPartidaInput;
        private Label valorFreteLabel;
    }
}