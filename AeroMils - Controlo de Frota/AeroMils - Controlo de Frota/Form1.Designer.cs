namespace AeroMils___Controlo_de_Frota
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel_sidebar = new Panel();
            button_sobre = new Button();
            button_alertas = new Button();
            button_manutencao = new Button();
            button_reservas = new Button();
            button_avioes = new Button();
            button_dashboard = new Button();
            panel_icone = new Panel();
            panel_main = new Panel();
            panel_sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panel_sidebar
            // 
            panel_sidebar.BackColor = Color.FromArgb(54, 53, 67);
            panel_sidebar.Controls.Add(button_sobre);
            panel_sidebar.Controls.Add(button_alertas);
            panel_sidebar.Controls.Add(button_manutencao);
            panel_sidebar.Controls.Add(button_reservas);
            panel_sidebar.Controls.Add(button_avioes);
            panel_sidebar.Controls.Add(button_dashboard);
            panel_sidebar.Controls.Add(panel_icone);
            panel_sidebar.Dock = DockStyle.Left;
            panel_sidebar.Location = new Point(0, 0);
            panel_sidebar.Name = "panel_sidebar";
            panel_sidebar.Size = new Size(186, 577);
            panel_sidebar.TabIndex = 0;
            // 
            // button_sobre
            // 
            button_sobre.Dock = DockStyle.Bottom;
            button_sobre.FlatAppearance.BorderSize = 0;
            button_sobre.FlatStyle = FlatStyle.Flat;
            button_sobre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_sobre.ForeColor = Color.White;
            button_sobre.Location = new Point(0, 522);
            button_sobre.Name = "button_sobre";
            button_sobre.Size = new Size(186, 55);
            button_sobre.TabIndex = 1;
            button_sobre.Text = "Sobre";
            button_sobre.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_sobre.UseVisualStyleBackColor = true;
            button_sobre.Click += button_sobre_Click;
            // 
            // button_alertas
            // 
            button_alertas.Dock = DockStyle.Top;
            button_alertas.FlatAppearance.BorderSize = 0;
            button_alertas.FlatStyle = FlatStyle.Flat;
            button_alertas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_alertas.ForeColor = Color.White;
            button_alertas.Location = new Point(0, 383);
            button_alertas.Name = "button_alertas";
            button_alertas.Size = new Size(186, 55);
            button_alertas.TabIndex = 1;
            button_alertas.Text = "Alertas";
            button_alertas.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_alertas.UseVisualStyleBackColor = true;
            button_alertas.Click += button_alertas_Click;
            // 
            // button_manutencao
            // 
            button_manutencao.Dock = DockStyle.Top;
            button_manutencao.FlatAppearance.BorderSize = 0;
            button_manutencao.FlatStyle = FlatStyle.Flat;
            button_manutencao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_manutencao.ForeColor = Color.White;
            button_manutencao.Location = new Point(0, 328);
            button_manutencao.Name = "button_manutencao";
            button_manutencao.Size = new Size(186, 55);
            button_manutencao.TabIndex = 1;
            button_manutencao.Text = "Manutenção";
            button_manutencao.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_manutencao.UseVisualStyleBackColor = true;
            button_manutencao.Click += button_manutencao_Click;
            // 
            // button_reservas
            // 
            button_reservas.Dock = DockStyle.Top;
            button_reservas.FlatAppearance.BorderSize = 0;
            button_reservas.FlatStyle = FlatStyle.Flat;
            button_reservas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_reservas.ForeColor = Color.White;
            button_reservas.Location = new Point(0, 273);
            button_reservas.Name = "button_reservas";
            button_reservas.Size = new Size(186, 55);
            button_reservas.TabIndex = 1;
            button_reservas.Text = "Reservas";
            button_reservas.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_reservas.UseVisualStyleBackColor = true;
            button_reservas.Click += button_reservas_Click;
            // 
            // button_avioes
            // 
            button_avioes.Dock = DockStyle.Top;
            button_avioes.FlatAppearance.BorderSize = 0;
            button_avioes.FlatStyle = FlatStyle.Flat;
            button_avioes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_avioes.ForeColor = Color.White;
            button_avioes.Location = new Point(0, 218);
            button_avioes.Name = "button_avioes";
            button_avioes.Size = new Size(186, 55);
            button_avioes.TabIndex = 1;
            button_avioes.Text = "Aviões";
            button_avioes.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_avioes.UseVisualStyleBackColor = true;
            button_avioes.Click += button_avioes_Click;
            // 
            // button_dashboard
            // 
            button_dashboard.Dock = DockStyle.Top;
            button_dashboard.FlatAppearance.BorderSize = 0;
            button_dashboard.FlatStyle = FlatStyle.Flat;
            button_dashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_dashboard.ForeColor = Color.White;
            button_dashboard.Location = new Point(0, 163);
            button_dashboard.Name = "button_dashboard";
            button_dashboard.Size = new Size(186, 55);
            button_dashboard.TabIndex = 1;
            button_dashboard.Text = "Dashboard";
            button_dashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_dashboard.UseVisualStyleBackColor = true;
            button_dashboard.Click += button_dashboard_Click;
            // 
            // panel_icone
            // 
            panel_icone.BackgroundImage = (Image)resources.GetObject("panel_icone.BackgroundImage");
            panel_icone.Dock = DockStyle.Top;
            panel_icone.Location = new Point(0, 0);
            panel_icone.Name = "panel_icone";
            panel_icone.Size = new Size(186, 163);
            panel_icone.TabIndex = 0;
            // 
            // panel_main
            // 
            panel_main.Dock = DockStyle.Fill;
            panel_main.Location = new Point(186, 0);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(765, 577);
            panel_main.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 577);
            Controls.Add(panel_main);
            Controls.Add(panel_sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel_sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_sidebar;
        private Button button_dashboard;
        private Panel panel_icone;
        private Button button_alertas;
        private Button button_manutencao;
        private Button button_reservas;
        private Button button_avioes;
        private Button button_sobre;
        private Panel panel_main;
    }
}