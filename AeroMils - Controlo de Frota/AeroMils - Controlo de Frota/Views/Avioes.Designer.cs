﻿namespace AeroMils___Controlo_de_Frota.Views
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
            dataGridViewAvioes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAvioes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAvioes
            // 
            dataGridViewAvioes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAvioes.Location = new Point(85, 53);
            dataGridViewAvioes.Name = "dataGridViewAvioes";
            dataGridViewAvioes.RowTemplate.Height = 25;
            dataGridViewAvioes.Size = new Size(240, 150);
            dataGridViewAvioes.TabIndex = 0;
            // 
            // Avioes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(dataGridViewAvioes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Avioes";
            Text = "Avioes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAvioes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewAvioes;
    }
}