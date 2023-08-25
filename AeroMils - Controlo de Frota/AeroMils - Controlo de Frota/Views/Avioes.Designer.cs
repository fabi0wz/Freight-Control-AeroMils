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
            dataGridViewAvioes = new DataGridView();
            sQLiteDBContextBindingSource = new BindingSource(components);
            dataGridViewAvioesButtons = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAvioes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sQLiteDBContextBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAvioes
            // 
            dataGridViewAvioes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAvioes.Columns.AddRange(new DataGridViewColumn[] { dataGridViewAvioesButtons });
            dataGridViewAvioes.Location = new Point(3, 2);
            dataGridViewAvioes.Name = "dataGridViewAvioes";
            dataGridViewAvioes.RowTemplate.Height = 25;
            dataGridViewAvioes.Size = new Size(1056, 508);
            dataGridViewAvioes.TabIndex = 0;
            // 
            // sQLiteDBContextBindingSource
            // 
            sQLiteDBContextBindingSource.DataSource = typeof(Data.DbContext.SQLiteDBContext);
            // 
            // dataGridViewAvioesButtons
            // 
            dataGridViewAvioesButtons.HeaderText = "Editar Estado";
            dataGridViewAvioesButtons.Name = "dataGridViewAvioesButtons";
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewAvioes).EndInit();
            ((System.ComponentModel.ISupportInitialize)sQLiteDBContextBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewAvioes;
        private BindingSource sQLiteDBContextBindingSource;
        private DataGridViewButtonColumn dataGridViewAvioesButtons;
    }
}