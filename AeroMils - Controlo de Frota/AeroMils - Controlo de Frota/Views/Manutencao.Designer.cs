namespace AeroMils___Controlo_de_Frota.Views
{
    partial class Manutencao
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
            dataGridViewManutencao = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewManutencao).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewManutencao
            // 
            dataGridViewManutencao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewManutencao.Location = new Point(2, 2);
            dataGridViewManutencao.Name = "dataGridViewManutencao";
            dataGridViewManutencao.RowTemplate.Height = 25;
            dataGridViewManutencao.Size = new Size(695, 333);
            dataGridViewManutencao.TabIndex = 0;
            // 
            // Manutencao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(dataGridViewManutencao);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Manutencao";
            Text = "Manutencao";
            ((System.ComponentModel.ISupportInitialize)dataGridViewManutencao).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewManutencao;
    }
}