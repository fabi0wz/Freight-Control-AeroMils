namespace AeroMils___Controlo_de_Frota.Views
{
    partial class Reservas
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
            dataGridViewReservas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservas).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewReservas
            // 
            dataGridViewReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReservas.Location = new Point(1, 3);
            dataGridViewReservas.Name = "dataGridViewReservas";
            dataGridViewReservas.RowTemplate.Height = 25;
            dataGridViewReservas.Size = new Size(696, 332);
            dataGridViewReservas.TabIndex = 0;
            // 
            // Reservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(dataGridViewReservas);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Reservas";
            Text = "Reservas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewReservas;
    }
}