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
            inserirTipoInput = new ComboBox();
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
            SuspendLayout();
            // 
            // inserirTipoInput
            // 
            inserirTipoInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirTipoInput.FormattingEnabled = true;
            inserirTipoInput.Items.AddRange(new object[] { "Aeronave Comercial", "Aeronave de Mercadorias", "Aeronave Particular", "Avioneta" });
            inserirTipoInput.Location = new Point(12, 90);
            inserirTipoInput.Margin = new Padding(3, 4, 3, 4);
            inserirTipoInput.Name = "inserirTipoInput";
            inserirTipoInput.Size = new Size(256, 36);
            inserirTipoInput.TabIndex = 2;
            inserirTipoInput.SelectedIndexChanged += inserirTipoInput_SelectedIndexChanged;
            // 
            // inserirModeloLabel
            // 
            inserirModeloLabel.AutoSize = true;
            inserirModeloLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirModeloLabel.Location = new Point(12, 285);
            inserirModeloLabel.Name = "inserirModeloLabel";
            inserirModeloLabel.Size = new Size(85, 28);
            inserirModeloLabel.TabIndex = 4;
            inserirModeloLabel.Text = "Modelo:";
            // 
            // inserirMarcaLabel
            // 
            inserirMarcaLabel.AutoSize = true;
            inserirMarcaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirMarcaLabel.Location = new Point(12, 191);
            inserirMarcaLabel.Name = "inserirMarcaLabel";
            inserirMarcaLabel.Size = new Size(70, 28);
            inserirMarcaLabel.TabIndex = 5;
            inserirMarcaLabel.Text = "Marca:";
            // 
            // inserirCapacidadeLabel
            // 
            inserirCapacidadeLabel.AutoSize = true;
            inserirCapacidadeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirCapacidadeLabel.Location = new Point(369, 191);
            inserirCapacidadeLabel.Name = "inserirCapacidadeLabel";
            inserirCapacidadeLabel.Size = new Size(250, 28);
            inserirCapacidadeLabel.TabIndex = 6;
            inserirCapacidadeLabel.Text = "Capacidade de Passageiros:";
            // 
            // inserirAutonomiaLabel
            // 
            inserirAutonomiaLabel.AutoSize = true;
            inserirAutonomiaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirAutonomiaLabel.Location = new Point(12, 372);
            inserirAutonomiaLabel.Name = "inserirAutonomiaLabel";
            inserirAutonomiaLabel.Size = new Size(114, 28);
            inserirAutonomiaLabel.TabIndex = 7;
            inserirAutonomiaLabel.Text = "Autonomia:";
            // 
            // inserirManutencaoLabel
            // 
            inserirManutencaoLabel.AutoSize = true;
            inserirManutencaoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirManutencaoLabel.Location = new Point(369, 372);
            inserirManutencaoLabel.Name = "inserirManutencaoLabel";
            inserirManutencaoLabel.Size = new Size(261, 28);
            inserirManutencaoLabel.TabIndex = 8;
            inserirManutencaoLabel.Text = "Data da Ultima Manutenção:";
            // 
            // inserirTipoLabel
            // 
            inserirTipoLabel.AutoSize = true;
            inserirTipoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirTipoLabel.Location = new Point(12, 58);
            inserirTipoLabel.Name = "inserirTipoLabel";
            inserirTipoLabel.Size = new Size(137, 28);
            inserirTipoLabel.TabIndex = 9;
            inserirTipoLabel.Text = "Tipo de Avião:";
            // 
            // inserirAnoLabel
            // 
            inserirAnoLabel.AutoSize = true;
            inserirAnoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirAnoLabel.Location = new Point(178, 285);
            inserirAnoLabel.Name = "inserirAnoLabel";
            inserirAnoLabel.Size = new Size(148, 28);
            inserirAnoLabel.TabIndex = 10;
            inserirAnoLabel.Text = "Ano de Fabrico:";
            // 
            // inserirQuantidadeLabel
            // 
            inserirQuantidadeLabel.AutoSize = true;
            inserirQuantidadeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirQuantidadeLabel.Location = new Point(178, 372);
            inserirQuantidadeLabel.Name = "inserirQuantidadeLabel";
            inserirQuantidadeLabel.Size = new Size(90, 28);
            inserirQuantidadeLabel.TabIndex = 11;
            inserirQuantidadeLabel.Text = "Motores:";
            // 
            // inserirSpecial1Label
            // 
            inserirSpecial1Label.AutoSize = true;
            inserirSpecial1Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirSpecial1Label.Location = new Point(369, 285);
            inserirSpecial1Label.Name = "inserirSpecial1Label";
            inserirSpecial1Label.Size = new Size(225, 28);
            inserirSpecial1Label.TabIndex = 12;
            inserirSpecial1Label.Text = "Numero de Voos Diarios";
            // 
            // inserirSpecial2Label
            // 
            inserirSpecial2Label.AutoSize = true;
            inserirSpecial2Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirSpecial2Label.Location = new Point(178, 191);
            inserirSpecial2Label.Name = "inserirSpecial2Label";
            inserirSpecial2Label.Size = new Size(167, 28);
            inserirSpecial2Label.TabIndex = 13;
            inserirSpecial2Label.Text = "Companhia Aerea";
            // 
            // inserirManutencaoInput
            // 
            inserirManutencaoInput.Location = new Point(369, 409);
            inserirManutencaoInput.Margin = new Padding(3, 4, 3, 4);
            inserirManutencaoInput.Name = "inserirManutencaoInput";
            inserirManutencaoInput.Size = new Size(228, 27);
            inserirManutencaoInput.TabIndex = 14;
            // 
            // inserirModeloInput
            // 
            inserirModeloInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirModeloInput.Location = new Point(12, 317);
            inserirModeloInput.Margin = new Padding(3, 4, 3, 4);
            inserirModeloInput.Name = "inserirModeloInput";
            inserirModeloInput.Size = new Size(114, 34);
            inserirModeloInput.TabIndex = 15;
            // 
            // inserirMarcaInput
            // 
            inserirMarcaInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirMarcaInput.Location = new Point(12, 223);
            inserirMarcaInput.Margin = new Padding(3, 4, 3, 4);
            inserirMarcaInput.Name = "inserirMarcaInput";
            inserirMarcaInput.Size = new Size(114, 34);
            inserirMarcaInput.TabIndex = 16;
            // 
            // inserirCapacidadeInput
            // 
            inserirCapacidadeInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirCapacidadeInput.Location = new Point(369, 223);
            inserirCapacidadeInput.Margin = new Padding(3, 4, 3, 4);
            inserirCapacidadeInput.Name = "inserirCapacidadeInput";
            inserirCapacidadeInput.Size = new Size(114, 34);
            inserirCapacidadeInput.TabIndex = 17;
            // 
            // inserirAutonomiaInput
            // 
            inserirAutonomiaInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirAutonomiaInput.Location = new Point(12, 404);
            inserirAutonomiaInput.Margin = new Padding(3, 4, 3, 4);
            inserirAutonomiaInput.Name = "inserirAutonomiaInput";
            inserirAutonomiaInput.Size = new Size(114, 34);
            inserirAutonomiaInput.TabIndex = 18;
            // 
            // inserirAnoInput
            // 
            inserirAnoInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirAnoInput.Location = new Point(178, 317);
            inserirAnoInput.Margin = new Padding(3, 4, 3, 4);
            inserirAnoInput.Name = "inserirAnoInput";
            inserirAnoInput.Size = new Size(114, 34);
            inserirAnoInput.TabIndex = 19;
            // 
            // inserirQuantidadeInput
            // 
            inserirQuantidadeInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirQuantidadeInput.Location = new Point(178, 404);
            inserirQuantidadeInput.Margin = new Padding(3, 4, 3, 4);
            inserirQuantidadeInput.Name = "inserirQuantidadeInput";
            inserirQuantidadeInput.Size = new Size(114, 34);
            inserirQuantidadeInput.TabIndex = 20;
            // 
            // inserirSpecial1Input
            // 
            inserirSpecial1Input.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirSpecial1Input.Location = new Point(369, 317);
            inserirSpecial1Input.Margin = new Padding(3, 4, 3, 4);
            inserirSpecial1Input.Name = "inserirSpecial1Input";
            inserirSpecial1Input.Size = new Size(114, 34);
            inserirSpecial1Input.TabIndex = 21;
            // 
            // inserirSpecial2Input
            // 
            inserirSpecial2Input.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirSpecial2Input.Location = new Point(178, 223);
            inserirSpecial2Input.Margin = new Padding(3, 4, 3, 4);
            inserirSpecial2Input.Name = "inserirSpecial2Input";
            inserirSpecial2Input.Size = new Size(114, 34);
            inserirSpecial2Input.TabIndex = 22;
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.FromArgb(54, 53, 67);
            submitButton.FlatAppearance.BorderSize = 0;
            submitButton.FlatStyle = FlatStyle.Flat;
            submitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            submitButton.ForeColor = Color.White;
            submitButton.ImageAlign = ContentAlignment.MiddleLeft;
            submitButton.Location = new Point(642, 283);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(137, 68);
            submitButton.TabIndex = 24;
            submitButton.Text = "Confirmar";
            submitButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // InserirAviao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
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
            Name = "InserirAviao";
            Text = "InserirAviao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox inserirTipoInput;
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
    }
}