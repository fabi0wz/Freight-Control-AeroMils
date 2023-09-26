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
            inserirAutonomiaInput = new TextBox();
            inserirAnoInput = new TextBox();
            inserirQuantidadeInput = new TextBox();
            inserirSpecial2Input = new TextBox();
            submitButton = new Button();
            inserirSpecial1Input = new TextBox();
            inserirCapacidadeInput = new TextBox();
            SuspendLayout();
            // 
            // inserirTipoInput
            // 
            inserirTipoInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirTipoInput.FormattingEnabled = true;
            inserirTipoInput.Items.AddRange(new object[] { "Aeronave Comercial", "Aeronave de Mercadorias", "Aeronave Particular", "Avioneta" });
            inserirTipoInput.Location = new Point(44, 68);
            inserirTipoInput.Name = "inserirTipoInput";
            inserirTipoInput.Size = new Size(224, 29);
            inserirTipoInput.TabIndex = 2;
            inserirTipoInput.SelectedIndexChanged += inserirTipoInput_SelectedIndexChanged;
            // 
            // inserirModeloLabel
            // 
            inserirModeloLabel.AutoSize = true;
            inserirModeloLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirModeloLabel.Location = new Point(44, 202);
            inserirModeloLabel.Name = "inserirModeloLabel";
            inserirModeloLabel.Size = new Size(66, 21);
            inserirModeloLabel.TabIndex = 4;
            inserirModeloLabel.Text = "Modelo:";
            // 
            // inserirMarcaLabel
            // 
            inserirMarcaLabel.AutoSize = true;
            inserirMarcaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirMarcaLabel.Location = new Point(44, 131);
            inserirMarcaLabel.Name = "inserirMarcaLabel";
            inserirMarcaLabel.Size = new Size(56, 21);
            inserirMarcaLabel.TabIndex = 5;
            inserirMarcaLabel.Text = "Marca:";
            // 
            // inserirCapacidadeLabel
            // 
            inserirCapacidadeLabel.AutoSize = true;
            inserirCapacidadeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirCapacidadeLabel.Location = new Point(435, 131);
            inserirCapacidadeLabel.Name = "inserirCapacidadeLabel";
            inserirCapacidadeLabel.Size = new Size(199, 21);
            inserirCapacidadeLabel.TabIndex = 6;
            inserirCapacidadeLabel.Text = "Capacidade de Passageiros:";
            // 
            // inserirAutonomiaLabel
            // 
            inserirAutonomiaLabel.AutoSize = true;
            inserirAutonomiaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirAutonomiaLabel.Location = new Point(44, 267);
            inserirAutonomiaLabel.Name = "inserirAutonomiaLabel";
            inserirAutonomiaLabel.Size = new Size(90, 21);
            inserirAutonomiaLabel.TabIndex = 7;
            inserirAutonomiaLabel.Text = "Autonomia:";
            // 
            // inserirManutencaoLabel
            // 
            inserirManutencaoLabel.AutoSize = true;
            inserirManutencaoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirManutencaoLabel.Location = new Point(435, 267);
            inserirManutencaoLabel.Name = "inserirManutencaoLabel";
            inserirManutencaoLabel.Size = new Size(206, 21);
            inserirManutencaoLabel.TabIndex = 8;
            inserirManutencaoLabel.Text = "Data da Ultima Manutenção:";
            // 
            // inserirTipoLabel
            // 
            inserirTipoLabel.AutoSize = true;
            inserirTipoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirTipoLabel.Location = new Point(44, 44);
            inserirTipoLabel.Name = "inserirTipoLabel";
            inserirTipoLabel.Size = new Size(107, 21);
            inserirTipoLabel.TabIndex = 9;
            inserirTipoLabel.Text = "Tipo de Avião:";
            // 
            // inserirAnoLabel
            // 
            inserirAnoLabel.AutoSize = true;
            inserirAnoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirAnoLabel.Location = new Point(234, 202);
            inserirAnoLabel.Name = "inserirAnoLabel";
            inserirAnoLabel.Size = new Size(116, 21);
            inserirAnoLabel.TabIndex = 10;
            inserirAnoLabel.Text = "Ano de Fabrico:";
            // 
            // inserirQuantidadeLabel
            // 
            inserirQuantidadeLabel.AutoSize = true;
            inserirQuantidadeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirQuantidadeLabel.Location = new Point(234, 267);
            inserirQuantidadeLabel.Name = "inserirQuantidadeLabel";
            inserirQuantidadeLabel.Size = new Size(177, 21);
            inserirQuantidadeLabel.TabIndex = 11;
            inserirQuantidadeLabel.Text = "Quantidade de motores:";
            // 
            // inserirSpecial1Label
            // 
            inserirSpecial1Label.AutoSize = true;
            inserirSpecial1Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirSpecial1Label.Location = new Point(435, 202);
            inserirSpecial1Label.Name = "inserirSpecial1Label";
            inserirSpecial1Label.Size = new Size(180, 21);
            inserirSpecial1Label.TabIndex = 12;
            inserirSpecial1Label.Text = "Numero de Voos Diarios";
            // 
            // inserirSpecial2Label
            // 
            inserirSpecial2Label.AutoSize = true;
            inserirSpecial2Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirSpecial2Label.Location = new Point(234, 131);
            inserirSpecial2Label.Name = "inserirSpecial2Label";
            inserirSpecial2Label.Size = new Size(134, 21);
            inserirSpecial2Label.TabIndex = 13;
            inserirSpecial2Label.Text = "Companhia Aerea";
            // 
            // inserirManutencaoInput
            // 
            inserirManutencaoInput.Location = new Point(435, 295);
            inserirManutencaoInput.Name = "inserirManutencaoInput";
            inserirManutencaoInput.Size = new Size(200, 23);
            inserirManutencaoInput.TabIndex = 14;
            // 
            // inserirModeloInput
            // 
            inserirModeloInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirModeloInput.Location = new Point(44, 226);
            inserirModeloInput.Name = "inserirModeloInput";
            inserirModeloInput.Size = new Size(100, 29);
            inserirModeloInput.TabIndex = 15;
            // 
            // inserirMarcaInput
            // 
            inserirMarcaInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirMarcaInput.Location = new Point(44, 155);
            inserirMarcaInput.Name = "inserirMarcaInput";
            inserirMarcaInput.Size = new Size(100, 29);
            inserirMarcaInput.TabIndex = 16;
            // 
            // inserirAutonomiaInput
            // 
            inserirAutonomiaInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirAutonomiaInput.Location = new Point(44, 291);
            inserirAutonomiaInput.Name = "inserirAutonomiaInput";
            inserirAutonomiaInput.Size = new Size(100, 29);
            inserirAutonomiaInput.TabIndex = 18;
            // 
            // inserirAnoInput
            // 
            inserirAnoInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirAnoInput.Location = new Point(234, 226);
            inserirAnoInput.Name = "inserirAnoInput";
            inserirAnoInput.Size = new Size(100, 29);
            inserirAnoInput.TabIndex = 19;
            // 
            // inserirQuantidadeInput
            // 
            inserirQuantidadeInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirQuantidadeInput.Location = new Point(234, 291);
            inserirQuantidadeInput.Name = "inserirQuantidadeInput";
            inserirQuantidadeInput.Size = new Size(100, 29);
            inserirQuantidadeInput.TabIndex = 20;
            // 
            // inserirSpecial2Input
            // 
            inserirSpecial2Input.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirSpecial2Input.Location = new Point(234, 155);
            inserirSpecial2Input.Name = "inserirSpecial2Input";
            inserirSpecial2Input.Size = new Size(100, 29);
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
            submitButton.Location = new Point(435, 46);
            submitButton.Margin = new Padding(3, 2, 3, 2);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(199, 51);
            submitButton.TabIndex = 24;
            submitButton.Text = "Confirmar";
            submitButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // inserirSpecial1Input
            // 
            inserirSpecial1Input.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirSpecial1Input.Location = new Point(435, 226);
            inserirSpecial1Input.Name = "inserirSpecial1Input";
            inserirSpecial1Input.Size = new Size(100, 29);
            inserirSpecial1Input.TabIndex = 21;
            // 
            // inserirCapacidadeInput
            // 
            inserirCapacidadeInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirCapacidadeInput.Location = new Point(435, 155);
            inserirCapacidadeInput.Name = "inserirCapacidadeInput";
            inserirCapacidadeInput.Size = new Size(100, 29);
            inserirCapacidadeInput.TabIndex = 17;
            // 
            // InserirAviao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
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
            StartPosition = FormStartPosition.CenterScreen;
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
        private TextBox inserirAutonomiaInput;
        private TextBox inserirAnoInput;
        private TextBox inserirQuantidadeInput;
        private TextBox inserirSpecial2Input;
        private Button submitButton;
        private TextBox inserirSpecial1Input;
        private TextBox inserirCapacidadeInput;
    }
}