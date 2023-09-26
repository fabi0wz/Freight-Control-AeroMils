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
            components = new System.ComponentModel.Container();
            panel_sidebar = new Panel();
            ExportCSV_button = new Button();
            SobreContainer = new Panel();
            button_sobre = new Button();
            ManutencaoContainer = new Panel();
            button_HistoricoManutencao = new Button();
            button_manutencao = new Button();
            ReservasContainer = new Panel();
            button_HistoricoReserva = new Button();
            button_NovaReserva = new Button();
            button_reservas = new Button();
            AvioesContainer = new Panel();
            button_avioes = new Button();
            button_InserirAviao = new Button();
            DashboardContainer = new Panel();
            button_dashboard = new Button();
            panel_icone = new Panel();
            pictureBoxLogo = new PictureBox();
            panel_main = new Panel();
            AvioesTimer = new System.Windows.Forms.Timer(components);
            ReservasTimer = new System.Windows.Forms.Timer(components);
            ManutencaoTimer = new System.Windows.Forms.Timer(components);
            panel_sidebar.SuspendLayout();
            SobreContainer.SuspendLayout();
            ManutencaoContainer.SuspendLayout();
            ReservasContainer.SuspendLayout();
            AvioesContainer.SuspendLayout();
            DashboardContainer.SuspendLayout();
            panel_icone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panel_sidebar
            // 
            panel_sidebar.BackColor = Color.FromArgb(54, 53, 67);
            panel_sidebar.Controls.Add(ExportCSV_button);
            panel_sidebar.Controls.Add(SobreContainer);
            panel_sidebar.Controls.Add(ManutencaoContainer);
            panel_sidebar.Controls.Add(ReservasContainer);
            panel_sidebar.Controls.Add(AvioesContainer);
            panel_sidebar.Controls.Add(DashboardContainer);
            panel_sidebar.Controls.Add(panel_icone);
            panel_sidebar.Dock = DockStyle.Left;
            panel_sidebar.Location = new Point(0, 0);
            panel_sidebar.Margin = new Padding(3, 1, 3, 1);
            panel_sidebar.Name = "panel_sidebar";
            panel_sidebar.Size = new Size(239, 702);
            panel_sidebar.TabIndex = 0;
            // 
            // ExportCSV_button
            // 
            ExportCSV_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ExportCSV_button.Dock = DockStyle.Bottom;
            ExportCSV_button.FlatAppearance.BorderSize = 0;
            ExportCSV_button.FlatStyle = FlatStyle.Flat;
            ExportCSV_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ExportCSV_button.ForeColor = Color.White;
            ExportCSV_button.ImageAlign = ContentAlignment.MiddleLeft;
            ExportCSV_button.Location = new Point(0, 620);
            ExportCSV_button.Margin = new Padding(3, 1, 3, 1);
            ExportCSV_button.Name = "ExportCSV_button";
            ExportCSV_button.Size = new Size(239, 41);
            ExportCSV_button.TabIndex = 2;
            ExportCSV_button.Text = "Exportar dados para CSV";
            ExportCSV_button.TextImageRelation = TextImageRelation.ImageBeforeText;
            ExportCSV_button.UseVisualStyleBackColor = true;
            ExportCSV_button.Click += ExportCSV_button_Click;
            // 
            // SobreContainer
            // 
            SobreContainer.BackColor = Color.FromArgb(54, 53, 67);
            SobreContainer.Controls.Add(button_sobre);
            SobreContainer.Dock = DockStyle.Bottom;
            SobreContainer.Location = new Point(0, 661);
            SobreContainer.MaximumSize = new Size(277, 41);
            SobreContainer.MinimumSize = new Size(277, 41);
            SobreContainer.Name = "SobreContainer";
            SobreContainer.Size = new Size(277, 41);
            SobreContainer.TabIndex = 3;
            // 
            // button_sobre
            // 
            button_sobre.Dock = DockStyle.Bottom;
            button_sobre.FlatAppearance.BorderSize = 0;
            button_sobre.FlatStyle = FlatStyle.Flat;
            button_sobre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_sobre.ForeColor = Color.White;
            button_sobre.Image = Properties.Resources.Sobre;
            button_sobre.Location = new Point(0, 0);
            button_sobre.Margin = new Padding(3, 1, 3, 1);
            button_sobre.Name = "button_sobre";
            button_sobre.Size = new Size(277, 41);
            button_sobre.TabIndex = 1;
            button_sobre.Text = "NÃO CLICAR !!!";
            button_sobre.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_sobre.UseVisualStyleBackColor = true;
            button_sobre.Click += button_sobre_Click;
            // 
            // ManutencaoContainer
            // 
            ManutencaoContainer.BackColor = Color.FromArgb(54, 53, 67);
            ManutencaoContainer.Controls.Add(button_HistoricoManutencao);
            ManutencaoContainer.Controls.Add(button_manutencao);
            ManutencaoContainer.Dock = DockStyle.Top;
            ManutencaoContainer.Location = new Point(0, 314);
            ManutencaoContainer.MaximumSize = new Size(277, 82);
            ManutencaoContainer.MinimumSize = new Size(277, 41);
            ManutencaoContainer.Name = "ManutencaoContainer";
            ManutencaoContainer.Size = new Size(277, 41);
            ManutencaoContainer.TabIndex = 1;
            // 
            // button_HistoricoManutencao
            // 
            button_HistoricoManutencao.Dock = DockStyle.Top;
            button_HistoricoManutencao.FlatAppearance.BorderSize = 0;
            button_HistoricoManutencao.FlatStyle = FlatStyle.Flat;
            button_HistoricoManutencao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_HistoricoManutencao.ForeColor = Color.White;
            button_HistoricoManutencao.Image = Properties.Resources.Manutencao;
            button_HistoricoManutencao.ImageAlign = ContentAlignment.MiddleLeft;
            button_HistoricoManutencao.Location = new Point(0, 41);
            button_HistoricoManutencao.Margin = new Padding(3, 1, 3, 1);
            button_HistoricoManutencao.Name = "button_HistoricoManutencao";
            button_HistoricoManutencao.Size = new Size(277, 41);
            button_HistoricoManutencao.TabIndex = 3;
            button_HistoricoManutencao.Text = "Historico Manutenções";
            button_HistoricoManutencao.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_HistoricoManutencao.UseVisualStyleBackColor = true;
            button_HistoricoManutencao.Click += button_HistoricoManutencao_Click;
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
            button_manutencao.Location = new Point(0, 0);
            button_manutencao.Margin = new Padding(3, 1, 3, 1);
            button_manutencao.Name = "button_manutencao";
            button_manutencao.Size = new Size(277, 41);
            button_manutencao.TabIndex = 1;
            button_manutencao.Text = "Manutenção   ❯";
            button_manutencao.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_manutencao.UseVisualStyleBackColor = true;
            button_manutencao.Click += button_manutencao_Click;
            // 
            // ReservasContainer
            // 
            ReservasContainer.BackColor = Color.FromArgb(54, 53, 67);
            ReservasContainer.Controls.Add(button_HistoricoReserva);
            ReservasContainer.Controls.Add(button_NovaReserva);
            ReservasContainer.Controls.Add(button_reservas);
            ReservasContainer.Dock = DockStyle.Top;
            ReservasContainer.Location = new Point(0, 273);
            ReservasContainer.MaximumSize = new Size(277, 125);
            ReservasContainer.MinimumSize = new Size(277, 41);
            ReservasContainer.Name = "ReservasContainer";
            ReservasContainer.Size = new Size(277, 41);
            ReservasContainer.TabIndex = 1;
            // 
            // button_HistoricoReserva
            // 
            button_HistoricoReserva.Dock = DockStyle.Top;
            button_HistoricoReserva.FlatAppearance.BorderSize = 0;
            button_HistoricoReserva.FlatStyle = FlatStyle.Flat;
            button_HistoricoReserva.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_HistoricoReserva.ForeColor = Color.White;
            button_HistoricoReserva.Image = Properties.Resources.Reservas;
            button_HistoricoReserva.ImageAlign = ContentAlignment.MiddleLeft;
            button_HistoricoReserva.Location = new Point(0, 82);
            button_HistoricoReserva.Margin = new Padding(3, 1, 3, 1);
            button_HistoricoReserva.Name = "button_HistoricoReserva";
            button_HistoricoReserva.Size = new Size(277, 41);
            button_HistoricoReserva.TabIndex = 3;
            button_HistoricoReserva.Text = "Historico Reservas";
            button_HistoricoReserva.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_HistoricoReserva.UseVisualStyleBackColor = true;
            button_HistoricoReserva.Click += button_HistoricoReserva_Click;
            // 
            // button_NovaReserva
            // 
            button_NovaReserva.Dock = DockStyle.Top;
            button_NovaReserva.FlatAppearance.BorderSize = 0;
            button_NovaReserva.FlatStyle = FlatStyle.Flat;
            button_NovaReserva.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_NovaReserva.ForeColor = Color.White;
            button_NovaReserva.Image = Properties.Resources.Reservas;
            button_NovaReserva.ImageAlign = ContentAlignment.MiddleLeft;
            button_NovaReserva.Location = new Point(0, 41);
            button_NovaReserva.Margin = new Padding(3, 1, 3, 1);
            button_NovaReserva.Name = "button_NovaReserva";
            button_NovaReserva.Size = new Size(277, 41);
            button_NovaReserva.TabIndex = 2;
            button_NovaReserva.Text = "Nova Reserva";
            button_NovaReserva.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_NovaReserva.UseVisualStyleBackColor = true;
            button_NovaReserva.Click += button_NovaReserva_Click;
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
            button_reservas.Location = new Point(0, 0);
            button_reservas.Margin = new Padding(3, 1, 3, 1);
            button_reservas.Name = "button_reservas";
            button_reservas.Size = new Size(277, 41);
            button_reservas.TabIndex = 1;
            button_reservas.Text = "Reservas   ❯";
            button_reservas.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_reservas.UseVisualStyleBackColor = true;
            button_reservas.Click += button_reservas_Click;
            // 
            // AvioesContainer
            // 
            AvioesContainer.BackColor = Color.FromArgb(54, 53, 67);
            AvioesContainer.Controls.Add(button_avioes);
            AvioesContainer.Controls.Add(button_InserirAviao);
            AvioesContainer.Dock = DockStyle.Top;
            AvioesContainer.Location = new Point(0, 232);
            AvioesContainer.MaximumSize = new Size(277, 83);
            AvioesContainer.MinimumSize = new Size(277, 41);
            AvioesContainer.Name = "AvioesContainer";
            AvioesContainer.Size = new Size(277, 41);
            AvioesContainer.TabIndex = 0;
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
            button_avioes.Location = new Point(0, 0);
            button_avioes.Margin = new Padding(3, 1, 3, 1);
            button_avioes.Name = "button_avioes";
            button_avioes.Size = new Size(277, 41);
            button_avioes.TabIndex = 1;
            button_avioes.Text = "Aviões   ❯";
            button_avioes.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_avioes.UseVisualStyleBackColor = true;
            button_avioes.Click += button_avioes_Click;
            // 
            // button_InserirAviao
            // 
            button_InserirAviao.Dock = DockStyle.Bottom;
            button_InserirAviao.FlatAppearance.BorderSize = 0;
            button_InserirAviao.FlatStyle = FlatStyle.Flat;
            button_InserirAviao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_InserirAviao.ForeColor = Color.White;
            button_InserirAviao.Image = Properties.Resources.Avioes;
            button_InserirAviao.ImageAlign = ContentAlignment.MiddleLeft;
            button_InserirAviao.Location = new Point(0, 0);
            button_InserirAviao.Margin = new Padding(3, 1, 3, 1);
            button_InserirAviao.Name = "button_InserirAviao";
            button_InserirAviao.Size = new Size(277, 41);
            button_InserirAviao.TabIndex = 2;
            button_InserirAviao.Text = "Inserir Aviao";
            button_InserirAviao.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_InserirAviao.UseVisualStyleBackColor = true;
            button_InserirAviao.Click += button_InserirAviao_Click;
            // 
            // DashboardContainer
            // 
            DashboardContainer.BackColor = Color.FromArgb(54, 53, 67);
            DashboardContainer.Controls.Add(button_dashboard);
            DashboardContainer.Dock = DockStyle.Top;
            DashboardContainer.Location = new Point(0, 191);
            DashboardContainer.MaximumSize = new Size(277, 41);
            DashboardContainer.MinimumSize = new Size(277, 41);
            DashboardContainer.Name = "DashboardContainer";
            DashboardContainer.Size = new Size(277, 41);
            DashboardContainer.TabIndex = 2;
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
            button_dashboard.Location = new Point(0, 0);
            button_dashboard.Margin = new Padding(3, 1, 3, 1);
            button_dashboard.Name = "button_dashboard";
            button_dashboard.Size = new Size(277, 41);
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
            panel_icone.Margin = new Padding(10, 5, 6, 11);
            panel_icone.Name = "panel_icone";
            panel_icone.Size = new Size(239, 191);
            panel_icone.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.amlogo;
            pictureBoxLogo.Location = new Point(42, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(148, 156);
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
            panel_main.Location = new Point(239, 0);
            panel_main.Margin = new Padding(3, 1, 3, 1);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(1226, 702);
            panel_main.TabIndex = 1;
            // 
            // AvioesTimer
            // 
            AvioesTimer.Interval = 10;
            AvioesTimer.Tick += AvioesTimer_Tick;
            // 
            // ReservasTimer
            // 
            ReservasTimer.Interval = 10;
            ReservasTimer.Tick += ReservasTimer_Tick;
            // 
            // ManutencaoTimer
            // 
            ManutencaoTimer.Interval = 10;
            ManutencaoTimer.Tick += ManutencaoTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1465, 702);
            Controls.Add(panel_main);
            Controls.Add(panel_sidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aeromils";
            FormClosing += Form1_FormClosing;
            panel_sidebar.ResumeLayout(false);
            SobreContainer.ResumeLayout(false);
            ManutencaoContainer.ResumeLayout(false);
            ReservasContainer.ResumeLayout(false);
            AvioesContainer.ResumeLayout(false);
            DashboardContainer.ResumeLayout(false);
            panel_icone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_sidebar;
        private Button button_dashboard;
        private Panel panel_icone;
        private Button button_manutencao;
        private Button button_reservas;
        private Button button_avioes;
        private Button button_sobre;
        private Panel panel_main;
        private PictureBox pictureBoxLogo;
        private Button button_HistoricoReserva;
        private Panel AvioesContainer;
        private Button button_InserirAviao;
        private System.Windows.Forms.Timer AvioesTimer;
        private Panel ManutencaoContainer;
        private Panel ReservasContainer;
        private Button button_NovaReserva;
        private Button button2;
        private System.Windows.Forms.Timer ReservasTimer;
        private System.Windows.Forms.Timer ManutencaoTimer;
        private Button button_HistoricoManutencao;
        private Panel DashboardContainer;
        private Panel SobreContainer;
        private Button ExportCSV_button;
    }
}