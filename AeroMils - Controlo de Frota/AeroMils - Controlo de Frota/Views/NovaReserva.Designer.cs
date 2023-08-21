namespace AeroMils___Controlo_de_Frota.Views
{
    partial class NovaReserva
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
            VoosPanel = new Panel();
            panel_vooComercial = new Panel();
            panel_vooParticular = new Panel();
            panel_vooMercadoria = new Panel();
            panel_avionetas = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Avionetas = new Button();
            VooMercadoria = new Button();
            VooParticular = new Button();
            VooComercial = new Button();
            VooDetails = new Panel();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            button3 = new Button();
            VoosPanel.SuspendLayout();
            panel_vooComercial.SuspendLayout();
            panel_vooParticular.SuspendLayout();
            panel_vooMercadoria.SuspendLayout();
            panel_avionetas.SuspendLayout();
            VooDetails.SuspendLayout();
            SuspendLayout();
            // 
            // VoosPanel
            // 
            VoosPanel.Controls.Add(panel_vooParticular);
            VoosPanel.Controls.Add(panel_vooMercadoria);
            VoosPanel.Controls.Add(panel_avionetas);
            VoosPanel.Controls.Add(Avionetas);
            VoosPanel.Controls.Add(VooMercadoria);
            VoosPanel.Controls.Add(VooParticular);
            VoosPanel.Controls.Add(VooComercial);
            VoosPanel.Dock = DockStyle.Top;
            VoosPanel.Location = new Point(0, 0);
            VoosPanel.Name = "VoosPanel";
            VoosPanel.Size = new Size(934, 110);
            VoosPanel.TabIndex = 0;
            // 
            // panel_vooComercial
            // 
            panel_vooComercial.Controls.Add(button3);
            panel_vooComercial.Controls.Add(label1);
            panel_vooComercial.Controls.Add(textBox3);
            panel_vooComercial.Controls.Add(textBox2);
            panel_vooComercial.Controls.Add(textBox1);
            panel_vooComercial.Controls.Add(button2);
            panel_vooComercial.Controls.Add(button1);
            panel_vooComercial.Dock = DockStyle.Fill;
            panel_vooComercial.Location = new Point(0, 0);
            panel_vooComercial.Name = "panel_vooComercial";
            panel_vooComercial.Size = new Size(934, 502);
            panel_vooComercial.TabIndex = 1;
            // 
            // panel_vooParticular
            // 
            panel_vooParticular.Controls.Add(label2);
            panel_vooParticular.Location = new Point(826, 71);
            panel_vooParticular.Name = "panel_vooParticular";
            panel_vooParticular.Size = new Size(934, 503);
            panel_vooParticular.TabIndex = 2;
            // 
            // panel_vooMercadoria
            // 
            panel_vooMercadoria.Controls.Add(label3);
            panel_vooMercadoria.Location = new Point(846, 34);
            panel_vooMercadoria.Name = "panel_vooMercadoria";
            panel_vooMercadoria.Size = new Size(934, 503);
            panel_vooMercadoria.TabIndex = 3;
            // 
            // panel_avionetas
            // 
            panel_avionetas.Controls.Add(label4);
            panel_avionetas.Location = new Point(879, 12);
            panel_avionetas.Name = "panel_avionetas";
            panel_avionetas.Size = new Size(934, 503);
            panel_avionetas.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(334, 201);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 0;
            label4.Text = "AVIONETAS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(334, 201);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 0;
            label3.Text = "MERCADORIA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(334, 201);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 0;
            label2.Text = "PARTICULAR";
            // 
            // Avionetas
            // 
            Avionetas.Location = new Point(689, 50);
            Avionetas.Name = "Avionetas";
            Avionetas.Size = new Size(75, 23);
            Avionetas.TabIndex = 3;
            Avionetas.Text = "Avionetas";
            Avionetas.UseVisualStyleBackColor = true;
            Avionetas.Click += Avionetas_Click;
            // 
            // VooMercadoria
            // 
            VooMercadoria.Location = new Point(478, 55);
            VooMercadoria.Name = "VooMercadoria";
            VooMercadoria.Size = new Size(127, 23);
            VooMercadoria.TabIndex = 2;
            VooMercadoria.Text = "Voo Mercadoria";
            VooMercadoria.UseVisualStyleBackColor = true;
            VooMercadoria.Click += VooMercadoria_Click;
            // 
            // VooParticular
            // 
            VooParticular.Location = new Point(268, 59);
            VooParticular.Name = "VooParticular";
            VooParticular.Size = new Size(122, 23);
            VooParticular.TabIndex = 1;
            VooParticular.Text = "Voo Particular";
            VooParticular.UseVisualStyleBackColor = true;
            VooParticular.Click += VooParticular_Click;
            // 
            // VooComercial
            // 
            VooComercial.Location = new Point(95, 52);
            VooComercial.Name = "VooComercial";
            VooComercial.Size = new Size(126, 23);
            VooComercial.TabIndex = 0;
            VooComercial.Text = "Voo Comercial";
            VooComercial.UseVisualStyleBackColor = true;
            VooComercial.Click += VooComercial_Click;
            // 
            // VooDetails
            // 
            VooDetails.Controls.Add(panel_vooComercial);
            VooDetails.Dock = DockStyle.Fill;
            VooDetails.Location = new Point(0, 110);
            VooDetails.Name = "VooDetails";
            VooDetails.Size = new Size(934, 502);
            VooDetails.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(95, 121);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(215, 121);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(70, 272);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(374, 272);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(745, 266);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(666, 436);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // button3
            // 
            button3.Location = new Point(806, 434);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // NovaReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 612);
            Controls.Add(VooDetails);
            Controls.Add(VoosPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "NovaReserva";
            Text = "NovaReserva";
            VoosPanel.ResumeLayout(false);
            panel_vooComercial.ResumeLayout(false);
            panel_vooComercial.PerformLayout();
            panel_vooParticular.ResumeLayout(false);
            panel_vooParticular.PerformLayout();
            panel_vooMercadoria.ResumeLayout(false);
            panel_vooMercadoria.PerformLayout();
            panel_avionetas.ResumeLayout(false);
            panel_avionetas.PerformLayout();
            VooDetails.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel VoosPanel;
        private Button Avionetas;
        private Button VooMercadoria;
        private Button VooParticular;
        private Button VooComercial;
        private Panel panel_vooComercial;
        private Panel panel_vooParticular;
        private Label label2;
        private Panel panel_vooMercadoria;
        private Label label3;
        private Panel panel_avionetas;
        private Label label4;
        private Panel VooDetails;
        private Button button3;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
    }
}