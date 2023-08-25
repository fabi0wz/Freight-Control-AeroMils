namespace AeroMils___Controlo_de_Frota.Views
{
    partial class HistoricoReservas
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
            dataGridViewHistoricoReservas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistoricoReservas).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewHistoricoReservas
            // 
            dataGridViewHistoricoReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistoricoReservas.Location = new Point(12, 12);
            dataGridViewHistoricoReservas.Name = "dataGridViewHistoricoReservas";
            dataGridViewHistoricoReservas.RowTemplate.Height = 25;
            dataGridViewHistoricoReservas.Size = new Size(1027, 518);
            dataGridViewHistoricoReservas.TabIndex = 0;
            // 
            // HistoricoReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 575);
            Controls.Add(dataGridViewHistoricoReservas);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HistoricoReservas";
            Text = "HistoricoReservas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistoricoReservas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewHistoricoReservas;
    }
}