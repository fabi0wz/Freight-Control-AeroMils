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
            MercadoriaDetails_panel = new Panel();
            escolha_aviao_label = new Label();
            Mercadoria_Peso_textBox = new TextBox();
            Mercadoria_Peso_label = new Label();
            Mercadoria_DeOnde_label = new Label();
            Mercadoria_Quando_label = new Label();
            Mercadoria_ParaOnde_label = new Label();
            Mercadoria_DeOnde_textBox = new TextBox();
            Mercadoria_ParaOnde_textBox = new TextBox();
            Mercadoria_Quando_dateTimePicker = new DateTimePicker();
            ParticularDetails_panel = new Panel();
            Particular_DeOnde_label = new Label();
            Particular_Quando_label = new Label();
            Particular_ParaOnde_label = new Label();
            Particular_DeOnde_textBox = new TextBox();
            Particular_ParaOnde_textBox = new TextBox();
            Particular_De_dateTimePicker = new DateTimePicker();
            ComercialDetails_panel = new Panel();
            Comercial_SoIda_panel = new Panel();
            Comercial_Ate_SoIda_label = new Label();
            Comercial_De_SoIda_label = new Label();
            Comercial_Deonde_SoIda_label = new Label();
            Comercial_Ate_SoIda_dateTimePicker = new DateTimePicker();
            Comercial_De_SoIda_dateTimePicker = new DateTimePicker();
            Comercial_Deonde_SoIda_textBox = new TextBox();
            IdaVolta_panel = new Panel();
            Comercial_Ate_IdaVolta_label = new Label();
            Comercial_De_IdaVolta_label = new Label();
            Comercial_ParaOnde_IdaVolta_label = new Label();
            Comercial_Ate_IdaVolta_dateTimePicker = new DateTimePicker();
            Comercial_DeOnde_IdaVolta_label = new Label();
            Comercial_De_IdaVolta_dateTimePicker = new DateTimePicker();
            Comercial_ParaOnde_IdaVolta_textBox = new TextBox();
            Comercial_DeOnde_IdaVolta_textBox = new TextBox();
            Comercial_IdaVolta_button = new Button();
            Comercial_SoIda_button = new Button();
            Reservar_button = new Button();
            VooMercadoria_button = new Button();
            Avionetas_button = new Button();
            Valor_label = new Label();
            VooParticular_button = new Button();
            VooComercial_button = new Button();
            avioesDisponiveisComboBox = new ComboBox();
            VoosPanel.SuspendLayout();
            MercadoriaDetails_panel.SuspendLayout();
            ParticularDetails_panel.SuspendLayout();
            ComercialDetails_panel.SuspendLayout();
            Comercial_SoIda_panel.SuspendLayout();
            IdaVolta_panel.SuspendLayout();
            SuspendLayout();
            // 
            // VoosPanel
            // 
            VoosPanel.Controls.Add(MercadoriaDetails_panel);
            VoosPanel.Controls.Add(ParticularDetails_panel);
            VoosPanel.Controls.Add(ComercialDetails_panel);
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
            // MercadoriaDetails_panel
            // 
            MercadoriaDetails_panel.Controls.Add(avioesDisponiveisComboBox);
            MercadoriaDetails_panel.Controls.Add(escolha_aviao_label);
            MercadoriaDetails_panel.Controls.Add(Mercadoria_Peso_textBox);
            MercadoriaDetails_panel.Controls.Add(Mercadoria_Peso_label);
            MercadoriaDetails_panel.Controls.Add(Mercadoria_DeOnde_label);
            MercadoriaDetails_panel.Controls.Add(Mercadoria_Quando_label);
            MercadoriaDetails_panel.Controls.Add(Mercadoria_ParaOnde_label);
            MercadoriaDetails_panel.Controls.Add(Mercadoria_DeOnde_textBox);
            MercadoriaDetails_panel.Controls.Add(Mercadoria_ParaOnde_textBox);
            MercadoriaDetails_panel.Controls.Add(Mercadoria_Quando_dateTimePicker);
            MercadoriaDetails_panel.Location = new Point(3, 77);
            MercadoriaDetails_panel.Name = "MercadoriaDetails_panel";
            MercadoriaDetails_panel.Size = new Size(700, 194);
            MercadoriaDetails_panel.TabIndex = 22;
            // 
            // escolha_aviao_label
            // 
            escolha_aviao_label.AutoSize = true;
            escolha_aviao_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            escolha_aviao_label.Location = new Point(378, 16);
            escolha_aviao_label.Name = "escolha_aviao_label";
            escolha_aviao_label.Size = new Size(143, 21);
            escolha_aviao_label.TabIndex = 24;
            escolha_aviao_label.Text = "Avioes Disponiveis:";
            // 
            // Mercadoria_Peso_textBox
            // 
            Mercadoria_Peso_textBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Mercadoria_Peso_textBox.Location = new Point(568, 120);
            Mercadoria_Peso_textBox.Name = "Mercadoria_Peso_textBox";
            Mercadoria_Peso_textBox.Size = new Size(103, 23);
            Mercadoria_Peso_textBox.TabIndex = 22;
            // 
            // Mercadoria_Peso_label
            // 
            Mercadoria_Peso_label.AutoSize = true;
            Mercadoria_Peso_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Mercadoria_Peso_label.Location = new Point(568, 98);
            Mercadoria_Peso_label.Name = "Mercadoria_Peso_label";
            Mercadoria_Peso_label.Size = new Size(46, 17);
            Mercadoria_Peso_label.TabIndex = 21;
            Mercadoria_Peso_label.Text = "Peso ?";
            // 
            // Mercadoria_DeOnde_label
            // 
            Mercadoria_DeOnde_label.AutoSize = true;
            Mercadoria_DeOnde_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Mercadoria_DeOnde_label.Location = new Point(21, 90);
            Mercadoria_DeOnde_label.Name = "Mercadoria_DeOnde_label";
            Mercadoria_DeOnde_label.Size = new Size(79, 21);
            Mercadoria_DeOnde_label.TabIndex = 20;
            Mercadoria_DeOnde_label.Text = "De onde ?";
            // 
            // Mercadoria_Quando_label
            // 
            Mercadoria_Quando_label.AutoSize = true;
            Mercadoria_Quando_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Mercadoria_Quando_label.Location = new Point(455, 98);
            Mercadoria_Quando_label.Name = "Mercadoria_Quando_label";
            Mercadoria_Quando_label.Size = new Size(65, 17);
            Mercadoria_Quando_label.TabIndex = 18;
            Mercadoria_Quando_label.Text = "Quando ?";
            // 
            // Mercadoria_ParaOnde_label
            // 
            Mercadoria_ParaOnde_label.AutoSize = true;
            Mercadoria_ParaOnde_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Mercadoria_ParaOnde_label.Location = new Point(258, 90);
            Mercadoria_ParaOnde_label.Name = "Mercadoria_ParaOnde_label";
            Mercadoria_ParaOnde_label.Size = new Size(90, 21);
            Mercadoria_ParaOnde_label.TabIndex = 17;
            Mercadoria_ParaOnde_label.Text = "Para onde ?";
            // 
            // Mercadoria_DeOnde_textBox
            // 
            Mercadoria_DeOnde_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Mercadoria_DeOnde_textBox.Location = new Point(21, 114);
            Mercadoria_DeOnde_textBox.Name = "Mercadoria_DeOnde_textBox";
            Mercadoria_DeOnde_textBox.Size = new Size(170, 29);
            Mercadoria_DeOnde_textBox.TabIndex = 2;
            // 
            // Mercadoria_ParaOnde_textBox
            // 
            Mercadoria_ParaOnde_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Mercadoria_ParaOnde_textBox.Location = new Point(258, 114);
            Mercadoria_ParaOnde_textBox.Name = "Mercadoria_ParaOnde_textBox";
            Mercadoria_ParaOnde_textBox.Size = new Size(170, 29);
            Mercadoria_ParaOnde_textBox.TabIndex = 4;
            // 
            // Mercadoria_Quando_dateTimePicker
            // 
            Mercadoria_Quando_dateTimePicker.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Mercadoria_Quando_dateTimePicker.Format = DateTimePickerFormat.Short;
            Mercadoria_Quando_dateTimePicker.Location = new Point(455, 118);
            Mercadoria_Quando_dateTimePicker.MaxDate = new DateTime(2023, 12, 31, 0, 0, 0, 0);
            Mercadoria_Quando_dateTimePicker.MinDate = new DateTime(2023, 8, 23, 14, 9, 15, 786);
            Mercadoria_Quando_dateTimePicker.Name = "Mercadoria_Quando_dateTimePicker";
            Mercadoria_Quando_dateTimePicker.Size = new Size(103, 25);
            Mercadoria_Quando_dateTimePicker.TabIndex = 13;
            Mercadoria_Quando_dateTimePicker.Value = new DateTime(2023, 8, 23, 14, 9, 15, 786);
            // 
            // ParticularDetails_panel
            // 
            ParticularDetails_panel.Controls.Add(Particular_DeOnde_label);
            ParticularDetails_panel.Controls.Add(Particular_Quando_label);
            ParticularDetails_panel.Controls.Add(Particular_ParaOnde_label);
            ParticularDetails_panel.Controls.Add(Particular_DeOnde_textBox);
            ParticularDetails_panel.Controls.Add(Particular_ParaOnde_textBox);
            ParticularDetails_panel.Controls.Add(Particular_De_dateTimePicker);
            ParticularDetails_panel.Location = new Point(3, 77);
            ParticularDetails_panel.Name = "ParticularDetails_panel";
            ParticularDetails_panel.Size = new Size(700, 194);
            ParticularDetails_panel.TabIndex = 21;
            // 
            // Particular_DeOnde_label
            // 
            Particular_DeOnde_label.AutoSize = true;
            Particular_DeOnde_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Particular_DeOnde_label.Location = new Point(21, 90);
            Particular_DeOnde_label.Name = "Particular_DeOnde_label";
            Particular_DeOnde_label.Size = new Size(79, 21);
            Particular_DeOnde_label.TabIndex = 20;
            Particular_DeOnde_label.Text = "De onde ?";
            // 
            // Particular_Quando_label
            // 
            Particular_Quando_label.AutoSize = true;
            Particular_Quando_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Particular_Quando_label.Location = new Point(492, 98);
            Particular_Quando_label.Name = "Particular_Quando_label";
            Particular_Quando_label.Size = new Size(65, 17);
            Particular_Quando_label.TabIndex = 18;
            Particular_Quando_label.Text = "Quando ?";
            // 
            // Particular_ParaOnde_label
            // 
            Particular_ParaOnde_label.AutoSize = true;
            Particular_ParaOnde_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Particular_ParaOnde_label.Location = new Point(258, 90);
            Particular_ParaOnde_label.Name = "Particular_ParaOnde_label";
            Particular_ParaOnde_label.Size = new Size(90, 21);
            Particular_ParaOnde_label.TabIndex = 17;
            Particular_ParaOnde_label.Text = "Para onde ?";
            // 
            // Particular_DeOnde_textBox
            // 
            Particular_DeOnde_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Particular_DeOnde_textBox.Location = new Point(21, 114);
            Particular_DeOnde_textBox.Name = "Particular_DeOnde_textBox";
            Particular_DeOnde_textBox.Size = new Size(170, 29);
            Particular_DeOnde_textBox.TabIndex = 2;
            // 
            // Particular_ParaOnde_textBox
            // 
            Particular_ParaOnde_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Particular_ParaOnde_textBox.Location = new Point(258, 114);
            Particular_ParaOnde_textBox.Name = "Particular_ParaOnde_textBox";
            Particular_ParaOnde_textBox.Size = new Size(170, 29);
            Particular_ParaOnde_textBox.TabIndex = 4;
            // 
            // Particular_De_dateTimePicker
            // 
            Particular_De_dateTimePicker.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Particular_De_dateTimePicker.Format = DateTimePickerFormat.Short;
            Particular_De_dateTimePicker.Location = new Point(492, 118);
            Particular_De_dateTimePicker.MaxDate = new DateTime(2023, 12, 31, 0, 0, 0, 0);
            Particular_De_dateTimePicker.MinDate = new DateTime(2023, 8, 23, 14, 9, 15, 786);
            Particular_De_dateTimePicker.Name = "Particular_De_dateTimePicker";
            Particular_De_dateTimePicker.Size = new Size(103, 25);
            Particular_De_dateTimePicker.TabIndex = 13;
            Particular_De_dateTimePicker.Value = new DateTime(2023, 8, 23, 14, 9, 15, 786);
            // 
            // ComercialDetails_panel
            // 
            ComercialDetails_panel.Controls.Add(Comercial_SoIda_panel);
            ComercialDetails_panel.Controls.Add(IdaVolta_panel);
            ComercialDetails_panel.Controls.Add(Comercial_IdaVolta_button);
            ComercialDetails_panel.Controls.Add(Comercial_SoIda_button);
            ComercialDetails_panel.Location = new Point(3, 77);
            ComercialDetails_panel.Name = "ComercialDetails_panel";
            ComercialDetails_panel.Size = new Size(700, 194);
            ComercialDetails_panel.TabIndex = 2;
            // 
            // Comercial_SoIda_panel
            // 
            Comercial_SoIda_panel.Controls.Add(Comercial_Ate_SoIda_label);
            Comercial_SoIda_panel.Controls.Add(Comercial_De_SoIda_label);
            Comercial_SoIda_panel.Controls.Add(Comercial_Deonde_SoIda_label);
            Comercial_SoIda_panel.Controls.Add(Comercial_Ate_SoIda_dateTimePicker);
            Comercial_SoIda_panel.Controls.Add(Comercial_De_SoIda_dateTimePicker);
            Comercial_SoIda_panel.Controls.Add(Comercial_Deonde_SoIda_textBox);
            Comercial_SoIda_panel.Location = new Point(3, 93);
            Comercial_SoIda_panel.Name = "Comercial_SoIda_panel";
            Comercial_SoIda_panel.Size = new Size(700, 101);
            Comercial_SoIda_panel.TabIndex = 20;
            // 
            // Comercial_Ate_SoIda_label
            // 
            Comercial_Ate_SoIda_label.AutoSize = true;
            Comercial_Ate_SoIda_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Comercial_Ate_SoIda_label.Location = new Point(568, 27);
            Comercial_Ate_SoIda_label.Name = "Comercial_Ate_SoIda_label";
            Comercial_Ate_SoIda_label.Size = new Size(37, 17);
            Comercial_Ate_SoIda_label.TabIndex = 19;
            Comercial_Ate_SoIda_label.Text = "Até ?";
            // 
            // Comercial_De_SoIda_label
            // 
            Comercial_De_SoIda_label.AutoSize = true;
            Comercial_De_SoIda_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Comercial_De_SoIda_label.Location = new Point(445, 27);
            Comercial_De_SoIda_label.Name = "Comercial_De_SoIda_label";
            Comercial_De_SoIda_label.Size = new Size(34, 17);
            Comercial_De_SoIda_label.TabIndex = 18;
            Comercial_De_SoIda_label.Text = "De ?";
            // 
            // Comercial_Deonde_SoIda_label
            // 
            Comercial_Deonde_SoIda_label.AutoSize = true;
            Comercial_Deonde_SoIda_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Comercial_Deonde_SoIda_label.Location = new Point(258, 19);
            Comercial_Deonde_SoIda_label.Name = "Comercial_Deonde_SoIda_label";
            Comercial_Deonde_SoIda_label.Size = new Size(79, 21);
            Comercial_Deonde_SoIda_label.TabIndex = 17;
            Comercial_Deonde_SoIda_label.Text = "De onde ?";
            // 
            // Comercial_Ate_SoIda_dateTimePicker
            // 
            Comercial_Ate_SoIda_dateTimePicker.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Comercial_Ate_SoIda_dateTimePicker.Format = DateTimePickerFormat.Short;
            Comercial_Ate_SoIda_dateTimePicker.Location = new Point(568, 47);
            Comercial_Ate_SoIda_dateTimePicker.MinDate = new DateTime(2023, 8, 23, 14, 9, 15, 786);
            Comercial_Ate_SoIda_dateTimePicker.Name = "Comercial_Ate_SoIda_dateTimePicker";
            Comercial_Ate_SoIda_dateTimePicker.Size = new Size(103, 25);
            Comercial_Ate_SoIda_dateTimePicker.TabIndex = 15;
            Comercial_Ate_SoIda_dateTimePicker.Value = new DateTime(2023, 8, 23, 14, 9, 15, 786);
            // 
            // Comercial_De_SoIda_dateTimePicker
            // 
            Comercial_De_SoIda_dateTimePicker.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Comercial_De_SoIda_dateTimePicker.Format = DateTimePickerFormat.Short;
            Comercial_De_SoIda_dateTimePicker.Location = new Point(445, 47);
            Comercial_De_SoIda_dateTimePicker.MaxDate = new DateTime(2023, 12, 31, 0, 0, 0, 0);
            Comercial_De_SoIda_dateTimePicker.MinDate = new DateTime(2023, 8, 23, 14, 9, 15, 786);
            Comercial_De_SoIda_dateTimePicker.Name = "Comercial_De_SoIda_dateTimePicker";
            Comercial_De_SoIda_dateTimePicker.Size = new Size(103, 25);
            Comercial_De_SoIda_dateTimePicker.TabIndex = 13;
            Comercial_De_SoIda_dateTimePicker.Value = new DateTime(2023, 8, 23, 14, 9, 15, 786);
            // 
            // Comercial_Deonde_SoIda_textBox
            // 
            Comercial_Deonde_SoIda_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Comercial_Deonde_SoIda_textBox.Location = new Point(258, 43);
            Comercial_Deonde_SoIda_textBox.Name = "Comercial_Deonde_SoIda_textBox";
            Comercial_Deonde_SoIda_textBox.Size = new Size(170, 29);
            Comercial_Deonde_SoIda_textBox.TabIndex = 4;
            // 
            // IdaVolta_panel
            // 
            IdaVolta_panel.Controls.Add(Comercial_Ate_IdaVolta_label);
            IdaVolta_panel.Controls.Add(Comercial_De_IdaVolta_label);
            IdaVolta_panel.Controls.Add(Comercial_ParaOnde_IdaVolta_label);
            IdaVolta_panel.Controls.Add(Comercial_Ate_IdaVolta_dateTimePicker);
            IdaVolta_panel.Controls.Add(Comercial_DeOnde_IdaVolta_label);
            IdaVolta_panel.Controls.Add(Comercial_De_IdaVolta_dateTimePicker);
            IdaVolta_panel.Controls.Add(Comercial_ParaOnde_IdaVolta_textBox);
            IdaVolta_panel.Controls.Add(Comercial_DeOnde_IdaVolta_textBox);
            IdaVolta_panel.Location = new Point(3, 93);
            IdaVolta_panel.Name = "IdaVolta_panel";
            IdaVolta_panel.Size = new Size(700, 101);
            IdaVolta_panel.TabIndex = 1;
            // 
            // Comercial_Ate_IdaVolta_label
            // 
            Comercial_Ate_IdaVolta_label.AutoSize = true;
            Comercial_Ate_IdaVolta_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Comercial_Ate_IdaVolta_label.Location = new Point(568, 27);
            Comercial_Ate_IdaVolta_label.Name = "Comercial_Ate_IdaVolta_label";
            Comercial_Ate_IdaVolta_label.Size = new Size(37, 17);
            Comercial_Ate_IdaVolta_label.TabIndex = 19;
            Comercial_Ate_IdaVolta_label.Text = "Até ?";
            // 
            // Comercial_De_IdaVolta_label
            // 
            Comercial_De_IdaVolta_label.AutoSize = true;
            Comercial_De_IdaVolta_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Comercial_De_IdaVolta_label.Location = new Point(445, 27);
            Comercial_De_IdaVolta_label.Name = "Comercial_De_IdaVolta_label";
            Comercial_De_IdaVolta_label.Size = new Size(34, 17);
            Comercial_De_IdaVolta_label.TabIndex = 18;
            Comercial_De_IdaVolta_label.Text = "De ?";
            // 
            // Comercial_ParaOnde_IdaVolta_label
            // 
            Comercial_ParaOnde_IdaVolta_label.AutoSize = true;
            Comercial_ParaOnde_IdaVolta_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Comercial_ParaOnde_IdaVolta_label.Location = new Point(258, 19);
            Comercial_ParaOnde_IdaVolta_label.Name = "Comercial_ParaOnde_IdaVolta_label";
            Comercial_ParaOnde_IdaVolta_label.Size = new Size(79, 21);
            Comercial_ParaOnde_IdaVolta_label.TabIndex = 17;
            Comercial_ParaOnde_IdaVolta_label.Text = "De onde ?";
            // 
            // Comercial_Ate_IdaVolta_dateTimePicker
            // 
            Comercial_Ate_IdaVolta_dateTimePicker.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Comercial_Ate_IdaVolta_dateTimePicker.Format = DateTimePickerFormat.Short;
            Comercial_Ate_IdaVolta_dateTimePicker.Location = new Point(568, 47);
            Comercial_Ate_IdaVolta_dateTimePicker.MinDate = new DateTime(2023, 8, 23, 14, 9, 15, 786);
            Comercial_Ate_IdaVolta_dateTimePicker.Name = "Comercial_Ate_IdaVolta_dateTimePicker";
            Comercial_Ate_IdaVolta_dateTimePicker.Size = new Size(103, 25);
            Comercial_Ate_IdaVolta_dateTimePicker.TabIndex = 15;
            Comercial_Ate_IdaVolta_dateTimePicker.Value = new DateTime(2023, 8, 23, 14, 9, 15, 786);
            // 
            // Comercial_DeOnde_IdaVolta_label
            // 
            Comercial_DeOnde_IdaVolta_label.AutoSize = true;
            Comercial_DeOnde_IdaVolta_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Comercial_DeOnde_IdaVolta_label.Location = new Point(21, 19);
            Comercial_DeOnde_IdaVolta_label.Name = "Comercial_DeOnde_IdaVolta_label";
            Comercial_DeOnde_IdaVolta_label.Size = new Size(79, 21);
            Comercial_DeOnde_IdaVolta_label.TabIndex = 14;
            Comercial_DeOnde_IdaVolta_label.Text = "De onde ?";
            // 
            // Comercial_De_IdaVolta_dateTimePicker
            // 
            Comercial_De_IdaVolta_dateTimePicker.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Comercial_De_IdaVolta_dateTimePicker.Format = DateTimePickerFormat.Short;
            Comercial_De_IdaVolta_dateTimePicker.Location = new Point(445, 47);
            Comercial_De_IdaVolta_dateTimePicker.MaxDate = new DateTime(2023, 12, 31, 0, 0, 0, 0);
            Comercial_De_IdaVolta_dateTimePicker.MinDate = new DateTime(2023, 8, 23, 14, 9, 15, 786);
            Comercial_De_IdaVolta_dateTimePicker.Name = "Comercial_De_IdaVolta_dateTimePicker";
            Comercial_De_IdaVolta_dateTimePicker.Size = new Size(103, 25);
            Comercial_De_IdaVolta_dateTimePicker.TabIndex = 13;
            Comercial_De_IdaVolta_dateTimePicker.Value = new DateTime(2023, 8, 23, 14, 9, 15, 786);
            // 
            // Comercial_ParaOnde_IdaVolta_textBox
            // 
            Comercial_ParaOnde_IdaVolta_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Comercial_ParaOnde_IdaVolta_textBox.Location = new Point(258, 43);
            Comercial_ParaOnde_IdaVolta_textBox.Name = "Comercial_ParaOnde_IdaVolta_textBox";
            Comercial_ParaOnde_IdaVolta_textBox.Size = new Size(170, 29);
            Comercial_ParaOnde_IdaVolta_textBox.TabIndex = 4;
            // 
            // Comercial_DeOnde_IdaVolta_textBox
            // 
            Comercial_DeOnde_IdaVolta_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Comercial_DeOnde_IdaVolta_textBox.Location = new Point(21, 43);
            Comercial_DeOnde_IdaVolta_textBox.Name = "Comercial_DeOnde_IdaVolta_textBox";
            Comercial_DeOnde_IdaVolta_textBox.Size = new Size(170, 29);
            Comercial_DeOnde_IdaVolta_textBox.TabIndex = 2;
            // 
            // Comercial_IdaVolta_button
            // 
            Comercial_IdaVolta_button.BackColor = Color.FromArgb(255, 98, 45);
            Comercial_IdaVolta_button.FlatAppearance.BorderSize = 0;
            Comercial_IdaVolta_button.FlatStyle = FlatStyle.Flat;
            Comercial_IdaVolta_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Comercial_IdaVolta_button.ForeColor = Color.White;
            Comercial_IdaVolta_button.ImageAlign = ContentAlignment.MiddleLeft;
            Comercial_IdaVolta_button.Location = new Point(24, 39);
            Comercial_IdaVolta_button.Margin = new Padding(3, 2, 3, 2);
            Comercial_IdaVolta_button.Name = "Comercial_IdaVolta_button";
            Comercial_IdaVolta_button.Size = new Size(106, 29);
            Comercial_IdaVolta_button.TabIndex = 9;
            Comercial_IdaVolta_button.Text = "Ida e volta";
            Comercial_IdaVolta_button.TextImageRelation = TextImageRelation.ImageBeforeText;
            Comercial_IdaVolta_button.UseVisualStyleBackColor = false;
            Comercial_IdaVolta_button.Click += Comercial_IdaVolta_button_Click;
            // 
            // Comercial_SoIda_button
            // 
            Comercial_SoIda_button.BackColor = Color.FromArgb(54, 53, 67);
            Comercial_SoIda_button.FlatAppearance.BorderSize = 0;
            Comercial_SoIda_button.FlatStyle = FlatStyle.Flat;
            Comercial_SoIda_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Comercial_SoIda_button.ForeColor = Color.White;
            Comercial_SoIda_button.ImageAlign = ContentAlignment.MiddleLeft;
            Comercial_SoIda_button.Location = new Point(136, 39);
            Comercial_SoIda_button.Margin = new Padding(3, 2, 3, 2);
            Comercial_SoIda_button.Name = "Comercial_SoIda_button";
            Comercial_SoIda_button.Size = new Size(106, 29);
            Comercial_SoIda_button.TabIndex = 10;
            Comercial_SoIda_button.Text = "Só ida";
            Comercial_SoIda_button.TextImageRelation = TextImageRelation.ImageBeforeText;
            Comercial_SoIda_button.UseVisualStyleBackColor = false;
            Comercial_SoIda_button.Click += Comercial_SoIda_button_Click;
            // 
            // Reservar_button
            // 
            Reservar_button.BackColor = Color.FromArgb(54, 53, 67);
            Reservar_button.FlatAppearance.BorderSize = 0;
            Reservar_button.FlatStyle = FlatStyle.Flat;
            Reservar_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Reservar_button.ForeColor = Color.White;
            Reservar_button.ImageAlign = ContentAlignment.MiddleLeft;
            Reservar_button.Location = new Point(568, 276);
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
            VooMercadoria_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            VooMercadoria_button.Click += VooMercadoria_Click;
            // 
            // Avionetas_button
            // 
            Avionetas_button.BackColor = Color.FromArgb(54, 53, 67);
            Avionetas_button.FlatAppearance.BorderSize = 0;
            Avionetas_button.FlatStyle = FlatStyle.Flat;
            Avionetas_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Avionetas_button.ForeColor = Color.White;
            Avionetas_button.ImageAlign = ContentAlignment.MiddleLeft;
            Avionetas_button.Location = new Point(530, 12);
            Avionetas_button.Margin = new Padding(3, 2, 3, 2);
            Avionetas_button.Name = "Avionetas_button";
            Avionetas_button.Size = new Size(144, 44);
            Avionetas_button.TabIndex = 7;
            Avionetas_button.Text = "Avionetas";
            Avionetas_button.TextImageRelation = TextImageRelation.ImageBeforeText;
            Avionetas_button.UseVisualStyleBackColor = false;
            Avionetas_button.Click += Avionetas_Click;
            // 
            // Valor_label
            // 
            Valor_label.AutoSize = true;
            Valor_label.Location = new Point(513, 296);
            Valor_label.Name = "Valor_label";
            Valor_label.Size = new Size(38, 15);
            Valor_label.TabIndex = 5;
            Valor_label.Text = "label1";
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
            VooParticular_button.Click += VooParticular_Click;
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
            VooComercial_button.Click += VooComercial_Click;
            // 
            // avioesDisponiveisComboBox
            // 
            avioesDisponiveisComboBox.FormattingEnabled = true;
            avioesDisponiveisComboBox.Location = new Point(378, 45);
            avioesDisponiveisComboBox.Name = "avioesDisponiveisComboBox";
            avioesDisponiveisComboBox.Size = new Size(230, 23);
            avioesDisponiveisComboBox.TabIndex = 25;
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
            MercadoriaDetails_panel.ResumeLayout(false);
            MercadoriaDetails_panel.PerformLayout();
            ParticularDetails_panel.ResumeLayout(false);
            ParticularDetails_panel.PerformLayout();
            ComercialDetails_panel.ResumeLayout(false);
            Comercial_SoIda_panel.ResumeLayout(false);
            Comercial_SoIda_panel.PerformLayout();
            IdaVolta_panel.ResumeLayout(false);
            IdaVolta_panel.PerformLayout();
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
        private Panel ParticularDetails_panel;
        private Label Particular_Ate_label;
        private Label Particular_Quando_label;
        private Label Particular_ParaOnde_label;
        private DateTimePicker Particular_Ate_dateTimePicker;
        private DateTimePicker Particular_De_dateTimePicker;
        private TextBox Particular_ParaOnde_textBox;
        private TextBox Particular_DeOnde_textBox;
        private Panel ComercialDetails_panel;
        private Panel Comercial_SoIda_panel;
        private Label Comercial_Ate_SoIda_label;
        private Label Comercial_De_SoIda_label;
        private Label Comercial_Deonde_SoIda_label;
        private DateTimePicker Comercial_Ate_SoIda_dateTimePicker;
        private DateTimePicker Comercial_De_SoIda_dateTimePicker;
        private TextBox Comercial_Deonde_SoIda_textBox;
        private Panel IdaVolta_panel;
        private Label Comercial_Ate_IdaVolta_label;
        private Label Comercial_De_IdaVolta_label;
        private Label Comercial_ParaOnde_IdaVolta_label;
        private DateTimePicker Comercial_Ate_IdaVolta_dateTimePicker;
        private Label Comercial_DeOnde_IdaVolta_label;
        private DateTimePicker Comercial_De_IdaVolta_dateTimePicker;
        private TextBox Comercial_ParaOnde_IdaVolta_textBox;
        private TextBox Comercial_DeOnde_IdaVolta_textBox;
        private Button Comercial_IdaVolta_button;
        private Button Comercial_SoIda_button;
        private Label Particular_DeOnde_label;
        private Panel MercadoriaDetails_panel;
        private TextBox Mercadoria_Peso_textBox;
        private Label Mercadoria_Peso_label;
        private Label Mercadoria_DeOnde_label;
        private Label Mercadoria_Quando_label;
        private Label Mercadoria_ParaOnde_label;
        private TextBox Mercadoria_DeOnde_textBox;
        private TextBox Mercadoria_ParaOnde_textBox;
        private DateTimePicker Mercadoria_Quando_dateTimePicker;
        private Label escolha_aviao_label;
        private ComboBox avioesDisponiveisComboBox;
    }
}