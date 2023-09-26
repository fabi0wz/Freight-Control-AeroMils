namespace AeroMils___Controlo_de_Frota.Views
{
    partial class Dashboard
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridViewAvioesemViagem = new DataGridView();
            dataGridViewFretesaTerminar = new DataGridView();
            dataGridViewManutencoesemBreve = new DataGridView();
            panel1 = new Panel();
            Mais1dia_button = new Button();
            Menos1dia_Button = new Button();
            dataHoje_label = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAvioesemViagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFretesaTerminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewManutencoesemBreve).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 222);
            label1.Name = "label1";
            label1.Size = new Size(278, 45);
            label1.TabIndex = 0;
            label1.Text = "Fretes a Terminar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(34, 424);
            label2.Name = "label2";
            label2.Size = new Size(369, 45);
            label2.TabIndex = 1;
            label2.Text = "Manutenções em Breve";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(34, 9);
            label3.Name = "label3";
            label3.Size = new Size(296, 45);
            label3.TabIndex = 2;
            label3.Text = "Aviões em Viagem";
            // 
            // dataGridViewAvioesemViagem
            // 
            dataGridViewAvioesemViagem.AllowUserToAddRows = false;
            dataGridViewAvioesemViagem.AllowUserToDeleteRows = false;
            dataGridViewAvioesemViagem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAvioesemViagem.BackgroundColor = SystemColors.Control;
            dataGridViewAvioesemViagem.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewAvioesemViagem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAvioesemViagem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAvioesemViagem.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewAvioesemViagem.Location = new Point(34, 52);
            dataGridViewAvioesemViagem.Name = "dataGridViewAvioesemViagem";
            dataGridViewAvioesemViagem.RowHeadersVisible = false;
            dataGridViewAvioesemViagem.RowHeadersWidth = 51;
            dataGridViewAvioesemViagem.RowTemplate.Height = 25;
            dataGridViewAvioesemViagem.Size = new Size(1122, 175);
            dataGridViewAvioesemViagem.TabIndex = 3;
            // 
            // dataGridViewFretesaTerminar
            // 
            dataGridViewFretesaTerminar.AllowUserToAddRows = false;
            dataGridViewFretesaTerminar.AllowUserToDeleteRows = false;
            dataGridViewFretesaTerminar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewFretesaTerminar.BackgroundColor = SystemColors.Control;
            dataGridViewFretesaTerminar.BorderStyle = BorderStyle.None;
            dataGridViewFretesaTerminar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFretesaTerminar.Location = new Point(34, 266);
            dataGridViewFretesaTerminar.Name = "dataGridViewFretesaTerminar";
            dataGridViewFretesaTerminar.RowHeadersVisible = false;
            dataGridViewFretesaTerminar.RowHeadersWidth = 51;
            dataGridViewFretesaTerminar.RowTemplate.Height = 25;
            dataGridViewFretesaTerminar.Size = new Size(565, 162);
            dataGridViewFretesaTerminar.TabIndex = 4;
            // 
            // dataGridViewManutencoesemBreve
            // 
            dataGridViewManutencoesemBreve.AllowUserToAddRows = false;
            dataGridViewManutencoesemBreve.AllowUserToDeleteRows = false;
            dataGridViewManutencoesemBreve.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewManutencoesemBreve.BackgroundColor = SystemColors.Control;
            dataGridViewManutencoesemBreve.BorderStyle = BorderStyle.None;
            dataGridViewManutencoesemBreve.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewManutencoesemBreve.Location = new Point(34, 476);
            dataGridViewManutencoesemBreve.Name = "dataGridViewManutencoesemBreve";
            dataGridViewManutencoesemBreve.RowHeadersVisible = false;
            dataGridViewManutencoesemBreve.RowHeadersWidth = 51;
            dataGridViewManutencoesemBreve.RowTemplate.Height = 25;
            dataGridViewManutencoesemBreve.Size = new Size(565, 167);
            dataGridViewManutencoesemBreve.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(Mais1dia_button);
            panel1.Controls.Add(Menos1dia_Button);
            panel1.Controls.Add(dataHoje_label);
            panel1.Location = new Point(739, 222);
            panel1.Name = "panel1";
            panel1.Size = new Size(417, 421);
            panel1.TabIndex = 6;
            // 
            // Mais1dia_button
            // 
            Mais1dia_button.BackColor = Color.FromArgb(54, 53, 67);
            Mais1dia_button.FlatStyle = FlatStyle.Flat;
            Mais1dia_button.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Mais1dia_button.ForeColor = Color.White;
            Mais1dia_button.Location = new Point(299, 22);
            Mais1dia_button.Margin = new Padding(2, 3, 2, 3);
            Mais1dia_button.Name = "Mais1dia_button";
            Mais1dia_button.Size = new Size(67, 25);
            Mais1dia_button.TabIndex = 15;
            Mais1dia_button.Text = "+1 Dia";
            Mais1dia_button.UseVisualStyleBackColor = false;
            Mais1dia_button.Click += Mais1dia_button_Click;
            // 
            // Menos1dia_Button
            // 
            Menos1dia_Button.BackColor = Color.FromArgb(54, 53, 67);
            Menos1dia_Button.FlatStyle = FlatStyle.Flat;
            Menos1dia_Button.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Menos1dia_Button.ForeColor = Color.White;
            Menos1dia_Button.Location = new Point(51, 22);
            Menos1dia_Button.Margin = new Padding(2, 3, 2, 3);
            Menos1dia_Button.Name = "Menos1dia_Button";
            Menos1dia_Button.Size = new Size(67, 25);
            Menos1dia_Button.TabIndex = 14;
            Menos1dia_Button.Text = "-1 Dia";
            Menos1dia_Button.UseVisualStyleBackColor = false;
            Menos1dia_Button.Click += Menos1dia_Button_Click;
            // 
            // dataHoje_label
            // 
            dataHoje_label.AutoSize = true;
            dataHoje_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataHoje_label.Location = new Point(149, 20);
            dataHoje_label.Name = "dataHoje_label";
            dataHoje_label.Size = new Size(116, 25);
            dataHoje_label.TabIndex = 0;
            dataHoje_label.Text = "26/09/2023";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 663);
            Controls.Add(panel1);
            Controls.Add(dataGridViewManutencoesemBreve);
            Controls.Add(dataGridViewFretesaTerminar);
            Controls.Add(dataGridViewAvioesemViagem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Dashboard";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAvioesemViagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFretesaTerminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewManutencoesemBreve).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridViewAvioesemViagem;
        private DataGridView dataGridViewFretesaTerminar;
        private DataGridView dataGridViewManutencoesemBreve;
        private Panel panel1;
        private Label dataHoje_label;
        private Button Mais1dia_button;
        private Button Menos1dia_Button;
    }
}