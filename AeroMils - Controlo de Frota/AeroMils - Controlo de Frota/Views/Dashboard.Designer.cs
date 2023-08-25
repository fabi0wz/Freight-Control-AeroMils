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
            label1.Location = new Point(34, 203);
            label1.Name = "label1";
            label1.Size = new Size(278, 45);
            label1.TabIndex = 0;
            label1.Text = "Fretes a Terminar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(34, 397);
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
            dataGridViewAvioesemViagem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAvioesemViagem.Location = new Point(45, 57);
            dataGridViewAvioesemViagem.Name = "dataGridViewAvioesemViagem";
            dataGridViewAvioesemViagem.RowTemplate.Height = 25;
            dataGridViewAvioesemViagem.Size = new Size(857, 143);
            dataGridViewAvioesemViagem.TabIndex = 3;
            // 
            // dataGridViewFretesaTerminar
            // 
            dataGridViewFretesaTerminar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFretesaTerminar.Location = new Point(45, 251);
            dataGridViewFretesaTerminar.Name = "dataGridViewFretesaTerminar";
            dataGridViewFretesaTerminar.RowTemplate.Height = 25;
            dataGridViewFretesaTerminar.Size = new Size(857, 143);
            dataGridViewFretesaTerminar.TabIndex = 4;
            // 
            // dataGridViewManutencoesemBreve
            // 
            dataGridViewManutencoesemBreve.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewManutencoesemBreve.Location = new Point(45, 455);
            dataGridViewManutencoesemBreve.Name = "dataGridViewManutencoesemBreve";
            dataGridViewManutencoesemBreve.RowTemplate.Height = 25;
            dataGridViewManutencoesemBreve.Size = new Size(857, 143);
            dataGridViewManutencoesemBreve.TabIndex = 5;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 730);
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