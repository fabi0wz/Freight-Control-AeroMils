namespace AeroMils___Controlo_de_Frota.Views
{
    partial class Avioes
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
            sQLiteDBContextBindingSource = new BindingSource(components);
            dataGridViewAvioes = new DataGridView();
            changeStatus = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)sQLiteDBContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAvioes).BeginInit();
            SuspendLayout();
            // 
            // sQLiteDBContextBindingSource
            // 
            sQLiteDBContextBindingSource.DataSource = typeof(Data.DbContext.SQLiteDBContext);
            // 
            // dataGridViewAvioes
            // 
            dataGridViewAvioes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAvioes.Columns.AddRange(new DataGridViewColumn[] { changeStatus });
            dataGridViewAvioes.Location = new Point(12, 12);
            dataGridViewAvioes.Name = "dataGridViewAvioes";
            dataGridViewAvioes.RowTemplate.Height = 25;
            dataGridViewAvioes.Size = new Size(1000, 500);
            dataGridViewAvioes.TabIndex = 0;
            // 
            // changeStatus
            // 
            changeStatus.HeaderText = "Mudar Estado";
            changeStatus.Name = "changeStatus";
            // 
            // Avioes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 515);
            Controls.Add(dataGridViewAvioes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Avioes";
            Text = "Avioes";
            ((System.ComponentModel.ISupportInitialize)sQLiteDBContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAvioes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource sQLiteDBContextBindingSource;
        private FlowLayoutPanel airplaneSlideMenuFlowLayoutPanel;
        private DataGridView dataGridViewAvioes;
        private DataGridViewButtonColumn changeStatus;
    }
}