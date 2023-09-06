namespace AeroMils___Controlo_de_Frota.Views
{
    partial class HistoricoManutencoes
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
            dataGridViewHistoricoManutencoes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistoricoManutencoes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewHistoricoManutencoes
            // 
            dataGridViewHistoricoManutencoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistoricoManutencoes.Location = new Point(2, 2);
            dataGridViewHistoricoManutencoes.Name = "dataGridViewHistoricoManutencoes";
            dataGridViewHistoricoManutencoes.RowTemplate.Height = 25;
            dataGridViewHistoricoManutencoes.Size = new Size(897, 544);
            dataGridViewHistoricoManutencoes.TabIndex = 0;
            // 
            // HistoricoManutencoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 548);
            Controls.Add(dataGridViewHistoricoManutencoes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HistoricoManutencoes";
            Text = "HistoricoManutencoes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistoricoManutencoes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewHistoricoManutencoes;
    }
}