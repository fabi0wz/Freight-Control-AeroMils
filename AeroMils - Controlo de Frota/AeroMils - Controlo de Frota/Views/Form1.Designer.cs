namespace AeroMils___Controlo_de_Frota.Views
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
            panel_sidebar = new Panel();
            button_sobre = new Button();
            button_alertas = new Button();
            button_manutencao = new Button();
            button_reservas = new Button();
            button_avioes = new Button();
            button_dashboard = new Button();
            panel_icone = new Panel();
            pictureBoxLogo = new PictureBox();
            panel_main = new Panel();
            button_HistoricoManutencao = new Button();
            button_NovaManutencao = new Button();
            button_HistoricoReserva = new Button();
            button_NovaReserva = new Button();
            button_InserirAviao = new Button();
            panel_sidebar.SuspendLayout();
            panel_icone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panel_sidebar
            // 
            panel_sidebar.BackColor = Color.FromArgb(54, 53, 67);
            panel_sidebar.Controls.Add(button_HistoricoManutencao);
            panel_sidebar.Controls.Add(button_sobre);
            panel_sidebar.Controls.Add(button_NovaManutencao);
            panel_sidebar.Controls.Add(button_alertas);
            panel_sidebar.Controls.Add(button_HistoricoReserva);
            panel_sidebar.Controls.Add(button_manutencao);
            panel_sidebar.Controls.Add(button_NovaReserva);
            panel_sidebar.Controls.Add(button_reservas);
            panel_sidebar.Controls.Add(button_InserirAviao);
            panel_sidebar.Controls.Add(button_avioes);
            panel_sidebar.Controls.Add(button_dashboard);
            panel_sidebar.Controls.Add(panel_icone);
            panel_sidebar.Dock = DockStyle.Left;
            panel_sidebar.Location = new Point(0, 0);
            panel_sidebar.Name = "panel_sidebar";
            panel_sidebar.Size = new Size(218, 868);
            panel_sidebar.TabIndex = 0;
            // 
            // button_sobre
            // 
            button_sobre.Dock = DockStyle.Bottom;
            button_sobre.FlatAppearance.BorderSize = 0;
            button_sobre.FlatStyle = FlatStyle.Flat;
            button_sobre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_sobre.ForeColor = Color.White;
            button_sobre.Image = Properties.Resources.Sobre;
            button_sobre.Location = new Point(0, 813);
            button_sobre.Name = "button_sobre";
            button_sobre.Size = new Size(218, 55);
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
            button_alertas.Image = Properties.Resources.Alertas;
            button_alertas.ImageAlign = ContentAlignment.MiddleLeft;
            button_alertas.Location = new Point(0, 475);
            button_alertas.Name = "button_alertas";
            button_alertas.Size = new Size(218, 55);
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
            button_manutencao.Image = Properties.Resources.Manutencao;
            button_manutencao.ImageAlign = ContentAlignment.MiddleLeft;
            button_manutencao.Location = new Point(0, 420);
            button_manutencao.Name = "button_manutencao";
            button_manutencao.Size = new Size(218, 55);
            button_manutencao.TabIndex = 1;
            button_manutencao.Text = "Manutenção   ❯";
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
            button_reservas.Image = Properties.Resources.Reservas;
            button_reservas.ImageAlign = ContentAlignment.MiddleLeft;
            button_reservas.Location = new Point(0, 365);
            button_reservas.Name = "button_reservas";
            button_reservas.Size = new Size(218, 55);
            button_reservas.TabIndex = 1;
            button_reservas.Text = "Reservas   ❯";
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
            button_avioes.Image = Properties.Resources.Avioes;
            button_avioes.ImageAlign = ContentAlignment.MiddleLeft;
            button_avioes.Location = new Point(0, 310);
            button_avioes.Name = "button_avioes";
            button_avioes.Size = new Size(218, 55);
            button_avioes.TabIndex = 1;
            button_avioes.Text = "Aviões   ❯";
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
            button_dashboard.Image = Properties.Resources.Dashboard;
            button_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            button_dashboard.Location = new Point(0, 255);
            button_dashboard.Name = "button_dashboard";
            button_dashboard.Size = new Size(218, 55);
            button_dashboard.TabIndex = 1;
            button_dashboard.Text = "Dashboard";
            button_dashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_dashboard.UseVisualStyleBackColor = false;
            button_dashboard.Click += button_dashboard_Click;
            // 
            // panel_icone
            // 
            panel_icone.Controls.Add(pictureBoxLogo);
            panel_icone.Dock = DockStyle.Top;
            panel_icone.Location = new Point(0, 0);
            panel_icone.Margin = new Padding(11, 7, 6, 13);
            panel_icone.Name = "panel_icone";
            panel_icone.Size = new Size(218, 255);
            panel_icone.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.amlogo;
            pictureBoxLogo.Location = new Point(23, 13);
            pictureBoxLogo.Margin = new Padding(3, 4, 3, 4);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(170, 208);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // panel_main
            // 
            panel_main.AllowDrop = true;
            panel_main.BorderStyle = BorderStyle.Fixed3D;
            panel_main.Dock = DockStyle.Fill;
            panel_main.ImeMode = ImeMode.Off;
            panel_main.Location = new Point(218, 0);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(1086, 868);
            panel_main.TabIndex = 1;
            // 
            // button_HistoricoManutencao
            // 
            button_HistoricoManutencao.Location = new Point(9, 744);
            button_HistoricoManutencao.Margin = new Padding(3, 4, 3, 4);
            button_HistoricoManutencao.Name = "button_HistoricoManutencao";
            button_HistoricoManutencao.Size = new Size(203, 31);
            button_HistoricoManutencao.TabIndex = 4;
            button_HistoricoManutencao.Text = "Historico de Manutenções";
            button_HistoricoManutencao.UseVisualStyleBackColor = true;
            button_HistoricoManutencao.Click += button_HistoricoManutencao_Click;
            // 
            // button_NovaManutencao
            // 
            button_NovaManutencao.Location = new Point(33, 708);
            button_NovaManutencao.Margin = new Padding(3, 4, 3, 4);
            button_NovaManutencao.Name = "button_NovaManutencao";
            button_NovaManutencao.Size = new Size(179, 31);
            button_NovaManutencao.TabIndex = 3;
            button_NovaManutencao.Text = "Nova Manutencao";
            button_NovaManutencao.UseVisualStyleBackColor = true;
            button_NovaManutencao.Click += button_NovaManutencao_Click;
            // 
            // button_HistoricoReserva
            // 
            button_HistoricoReserva.Location = new Point(53, 674);
            button_HistoricoReserva.Margin = new Padding(3, 4, 3, 4);
            button_HistoricoReserva.Name = "button_HistoricoReserva";
            button_HistoricoReserva.Size = new Size(159, 31);
            button_HistoricoReserva.TabIndex = 2;
            button_HistoricoReserva.Text = "Historico de Reservas";
            button_HistoricoReserva.UseVisualStyleBackColor = true;
            button_HistoricoReserva.Click += button_HistoricoReserva_Click;
            // 
            // button_NovaReserva
            // 
            button_NovaReserva.Location = new Point(87, 643);
            button_NovaReserva.Margin = new Padding(3, 4, 3, 4);
            button_NovaReserva.Name = "button_NovaReserva";
            button_NovaReserva.Size = new Size(125, 31);
            button_NovaReserva.TabIndex = 1;
            button_NovaReserva.Text = "Nova Reserva";
            button_NovaReserva.UseVisualStyleBackColor = true;
            button_NovaReserva.Click += button_NovaReserva_Click;
            // 
            // button_InserirAviao
            // 
            button_InserirAviao.Location = new Point(76, 604);
            button_InserirAviao.Margin = new Padding(3, 4, 3, 4);
            button_InserirAviao.Name = "button_InserirAviao";
            button_InserirAviao.Size = new Size(136, 31);
            button_InserirAviao.TabIndex = 0;
            button_InserirAviao.Text = "Inserir Avião";
            button_InserirAviao.UseVisualStyleBackColor = true;
            button_InserirAviao.Click += button_InserirAviao_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 868);
            Controls.Add(panel_main);
            Controls.Add(panel_sidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aeromils";
            panel_sidebar.ResumeLayout(false);
            panel_icone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
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
        private PictureBox pictureBoxLogo;
        private Button button_HistoricoManutencao;
        private Button button_NovaManutencao;
        private Button button_HistoricoReserva;
        private Button button_NovaReserva;
        private Button button_InserirAviao;
    }
}