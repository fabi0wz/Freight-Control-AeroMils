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
            ((System.ComponentModel.ISupportInitialize)dataGridViewAvioesemViagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFretesaTerminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewManutencoesemBreve).BeginInit();
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
            dataGridViewFretesaTerminar.Size = new Size(1122, 162);
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
            dataGridViewManutencoesemBreve.Size = new Size(1122, 167);
            dataGridViewManutencoesemBreve.TabIndex = 5;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 730);
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
    }
}