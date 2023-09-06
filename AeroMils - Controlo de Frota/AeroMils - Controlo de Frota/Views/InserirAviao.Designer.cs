namespace AeroMils___Controlo_de_Frota.Views
{
    partial class InserirAviao
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
            components = new System.ComponentModel.Container();
            inserirTipoInput = new ComboBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            inserirModeloLabel = new Label();
            inserirMarcaLabel = new Label();
            inserirCapacidadeLabel = new Label();
            inserirAutonomiaLabel = new Label();
            inserirManutencaoLabel = new Label();
            inserirTipoLabel = new Label();
            inserirAnoLabel = new Label();
            inserirQuantidadeLabel = new Label();
            inserirSpecial1Label = new Label();
            inserirSpecial2Label = new Label();
            inserirManutencaoInput = new DateTimePicker();
            inserirModeloInput = new TextBox();
            inserirMarcaInput = new TextBox();
            inserirCapacidadeInput = new TextBox();
            inserirAutonomiaInput = new TextBox();
            inserirAnoInput = new TextBox();
            inserirQuantidadeInput = new TextBox();
            inserirSpecial1Input = new TextBox();
            inserirSpecial2Input = new TextBox();
            submitButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // inserirTipoInput
            // 
            inserirTipoInput.FormattingEnabled = true;
            inserirTipoInput.Items.AddRange(new object[] { "Aeronave Comercial", "Aeronave de Mercadorias", "Aeronave Particular", "Avioneta" });
            inserirTipoInput.Location = new Point(42, 346);
            inserirTipoInput.Name = "inserirTipoInput";
            inserirTipoInput.Size = new Size(121, 23);
            inserirTipoInput.TabIndex = 2;
            inserirTipoInput.SelectedIndexChanged += inserirTipoInput_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // inserirModeloLabel
            // 
            inserirModeloLabel.AutoSize = true;
            inserirModeloLabel.Location = new Point(42, 48);
            inserirModeloLabel.Name = "inserirModeloLabel";
            inserirModeloLabel.Size = new Size(48, 15);
            inserirModeloLabel.TabIndex = 4;
            inserirModeloLabel.Text = "Modelo";
            // 
            // inserirMarcaLabel
            // 
            inserirMarcaLabel.AutoSize = true;
            inserirMarcaLabel.Location = new Point(42, 107);
            inserirMarcaLabel.Name = "inserirMarcaLabel";
            inserirMarcaLabel.Size = new Size(40, 15);
            inserirMarcaLabel.TabIndex = 5;
            inserirMarcaLabel.Text = "Marca";
            // 
            // inserirCapacidadeLabel
            // 
            inserirCapacidadeLabel.AutoSize = true;
            inserirCapacidadeLabel.Location = new Point(42, 163);
            inserirCapacidadeLabel.Name = "inserirCapacidadeLabel";
            inserirCapacidadeLabel.Size = new Size(149, 15);
            inserirCapacidadeLabel.TabIndex = 6;
            inserirCapacidadeLabel.Text = "Capacidade de Passageiros";
            // 
            // inserirAutonomiaLabel
            // 
            inserirAutonomiaLabel.AutoSize = true;
            inserirAutonomiaLabel.Location = new Point(42, 216);
            inserirAutonomiaLabel.Name = "inserirAutonomiaLabel";
            inserirAutonomiaLabel.Size = new Size(67, 15);
            inserirAutonomiaLabel.TabIndex = 7;
            inserirAutonomiaLabel.Text = "Autonomia";
            // 
            // inserirManutencaoLabel
            // 
            inserirManutencaoLabel.AutoSize = true;
            inserirManutencaoLabel.Location = new Point(42, 270);
            inserirManutencaoLabel.Name = "inserirManutencaoLabel";
            inserirManutencaoLabel.Size = new Size(155, 15);
            inserirManutencaoLabel.TabIndex = 8;
            inserirManutencaoLabel.Text = "Data da Ultima Manutenção";
            // 
            // inserirTipoLabel
            // 
            inserirTipoLabel.AutoSize = true;
            inserirTipoLabel.Location = new Point(42, 328);
            inserirTipoLabel.Name = "inserirTipoLabel";
            inserirTipoLabel.Size = new Size(79, 15);
            inserirTipoLabel.TabIndex = 9;
            inserirTipoLabel.Text = "Tipo de Avião";
            // 
            // inserirAnoLabel
            // 
            inserirAnoLabel.AutoSize = true;
            inserirAnoLabel.Location = new Point(42, 397);
            inserirAnoLabel.Name = "inserirAnoLabel";
            inserirAnoLabel.Size = new Size(87, 15);
            inserirAnoLabel.TabIndex = 10;
            inserirAnoLabel.Text = "Ano de Fabrico";
            // 
            // inserirQuantidadeLabel
            // 
            inserirQuantidadeLabel.AutoSize = true;
            inserirQuantidadeLabel.Location = new Point(42, 451);
            inserirQuantidadeLabel.Name = "inserirQuantidadeLabel";
            inserirQuantidadeLabel.Size = new Size(132, 15);
            inserirQuantidadeLabel.TabIndex = 11;
            inserirQuantidadeLabel.Text = "Quantidade de Motores";
            // 
            // inserirSpecial1Label
            // 
            inserirSpecial1Label.AutoSize = true;
            inserirSpecial1Label.Location = new Point(648, 152);
            inserirSpecial1Label.Name = "inserirSpecial1Label";
            inserirSpecial1Label.Size = new Size(134, 15);
            inserirSpecial1Label.TabIndex = 12;
            inserirSpecial1Label.Text = "Numero de Voos Diarios";
            // 
            // inserirSpecial2Label
            // 
            inserirSpecial2Label.AutoSize = true;
            inserirSpecial2Label.Location = new Point(648, 216);
            inserirSpecial2Label.Name = "inserirSpecial2Label";
            inserirSpecial2Label.Size = new Size(102, 15);
            inserirSpecial2Label.TabIndex = 13;
            inserirSpecial2Label.Text = "Companhia Aerea";
            // 
            // inserirManutencaoInput
            // 
            inserirManutencaoInput.Location = new Point(42, 290);
            inserirManutencaoInput.Name = "inserirManutencaoInput";
            inserirManutencaoInput.Size = new Size(200, 23);
            inserirManutencaoInput.TabIndex = 14;
            // 
            // inserirModeloInput
            // 
            inserirModeloInput.Location = new Point(42, 66);
            inserirModeloInput.Name = "inserirModeloInput";
            inserirModeloInput.Size = new Size(100, 23);
            inserirModeloInput.TabIndex = 15;
            // 
            // inserirMarcaInput
            // 
            inserirMarcaInput.Location = new Point(42, 125);
            inserirMarcaInput.Name = "inserirMarcaInput";
            inserirMarcaInput.Size = new Size(100, 23);
            inserirMarcaInput.TabIndex = 16;
            // 
            // inserirCapacidadeInput
            // 
            inserirCapacidadeInput.Location = new Point(42, 181);
            inserirCapacidadeInput.Name = "inserirCapacidadeInput";
            inserirCapacidadeInput.Size = new Size(100, 23);
            inserirCapacidadeInput.TabIndex = 17;
            // 
            // inserirAutonomiaInput
            // 
            inserirAutonomiaInput.Location = new Point(42, 234);
            inserirAutonomiaInput.Name = "inserirAutonomiaInput";
            inserirAutonomiaInput.Size = new Size(100, 23);
            inserirAutonomiaInput.TabIndex = 18;
            // 
            // inserirAnoInput
            // 
            inserirAnoInput.Location = new Point(42, 415);
            inserirAnoInput.Name = "inserirAnoInput";
            inserirAnoInput.Size = new Size(100, 23);
            inserirAnoInput.TabIndex = 19;
            // 
            // inserirQuantidadeInput
            // 
            inserirQuantidadeInput.Location = new Point(42, 482);
            inserirQuantidadeInput.Name = "inserirQuantidadeInput";
            inserirQuantidadeInput.Size = new Size(100, 23);
            inserirQuantidadeInput.TabIndex = 20;
            // 
            // inserirSpecial1Input
            // 
            inserirSpecial1Input.Location = new Point(650, 170);
            inserirSpecial1Input.Name = "inserirSpecial1Input";
            inserirSpecial1Input.Size = new Size(100, 23);
            inserirSpecial1Input.TabIndex = 21;
            // 
            // inserirSpecial2Input
            // 
            inserirSpecial2Input.Location = new Point(650, 234);
            inserirSpecial2Input.Name = "inserirSpecial2Input";
            inserirSpecial2Input.Size = new Size(100, 23);
            inserirSpecial2Input.TabIndex = 22;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(675, 482);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 23;
            submitButton.Text = "Confirmar";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // InserirAviao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 590);
            Controls.Add(submitButton);
            Controls.Add(inserirSpecial2Input);
            Controls.Add(inserirSpecial1Input);
            Controls.Add(inserirQuantidadeInput);
            Controls.Add(inserirAnoInput);
            Controls.Add(inserirAutonomiaInput);
            Controls.Add(inserirCapacidadeInput);
            Controls.Add(inserirMarcaInput);
            Controls.Add(inserirModeloInput);
            Controls.Add(inserirManutencaoInput);
            Controls.Add(inserirSpecial2Label);
            Controls.Add(inserirSpecial1Label);
            Controls.Add(inserirQuantidadeLabel);
            Controls.Add(inserirAnoLabel);
            Controls.Add(inserirTipoLabel);
            Controls.Add(inserirManutencaoLabel);
            Controls.Add(inserirAutonomiaLabel);
            Controls.Add(inserirCapacidadeLabel);
            Controls.Add(inserirMarcaLabel);
            Controls.Add(inserirModeloLabel);
            Controls.Add(inserirTipoInput);
            Margin = new Padding(3, 2, 3, 2);
            Name = "InserirAviao";
            Text = "InserirAviao";
            Load += InserirAviao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox inserirTipoInput;
        private ContextMenuStrip contextMenuStrip1;
        private Label inserirModeloLabel;
        private Label inserirMarcaLabel;
        private Label inserirCapacidadeLabel;
        private Label inserirAutonomiaLabel;
        private Label inserirManutencaoLabel;
        private Label inserirTipoLabel;
        private Label inserirAnoLabel;
        private Label inserirQuantidadeLabel;
        private Label inserirSpecial1Label;
        private Label inserirSpecial2Label;
        private DateTimePicker inserirManutencaoInput;
        private TextBox inserirModeloInput;
        private TextBox inserirMarcaInput;
        private TextBox inserirCapacidadeInput;
        private TextBox inserirAutonomiaInput;
        private TextBox inserirAnoInput;
        private TextBox inserirQuantidadeInput;
        private TextBox inserirSpecial1Input;
        private TextBox inserirSpecial2Input;
        private Button submitButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}