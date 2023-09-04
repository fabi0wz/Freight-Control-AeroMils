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
            SobreContainer = new Panel();
            button_sobre = new Button();
            AlertasContainer = new Panel();
            button_alertas = new Button();
            ManutencaoContainer = new Panel();
            button_NovaManutencao = new Button();
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
            AlertasContainer.SuspendLayout();
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
            panel_sidebar.Controls.Add(SobreContainer);
            panel_sidebar.Controls.Add(AlertasContainer);
            panel_sidebar.Controls.Add(ManutencaoContainer);
            panel_sidebar.Controls.Add(ReservasContainer);
            panel_sidebar.Controls.Add(AvioesContainer);
            panel_sidebar.Controls.Add(DashboardContainer);
            panel_sidebar.Controls.Add(panel_icone);
            panel_sidebar.Dock = DockStyle.Left;
            panel_sidebar.Location = new Point(0, 0);
            panel_sidebar.Margin = new Padding(3, 2, 3, 2);
            panel_sidebar.Name = "panel_sidebar";
            panel_sidebar.Size = new Size(274, 794);
            panel_sidebar.TabIndex = 0;
            // 
            // SobreContainer
            // 
            SobreContainer.BackColor = Color.FromArgb(54, 53, 67);
            SobreContainer.Controls.Add(button_sobre);
            SobreContainer.Dock = DockStyle.Bottom;
            SobreContainer.Location = new Point(0, 740);
            SobreContainer.Margin = new Padding(3, 4, 3, 4);
            SobreContainer.MaximumSize = new Size(317, 54);
            SobreContainer.MinimumSize = new Size(317, 54);
            SobreContainer.Name = "SobreContainer";
            SobreContainer.Size = new Size(317, 54);
            SobreContainer.TabIndex = 3;
            // 
            // button_sobre
            // 
            button_sobre.Dock = DockStyle.Top;
            button_sobre.FlatAppearance.BorderSize = 0;
            button_sobre.FlatStyle = FlatStyle.Flat;
            button_sobre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_sobre.ForeColor = Color.White;
            button_sobre.Image = Properties.Resources.Sobre;
            button_sobre.Location = new Point(0, 0);
            button_sobre.Margin = new Padding(3, 2, 3, 2);
            button_sobre.Name = "button_sobre";
            button_sobre.Size = new Size(317, 54);
            button_sobre.TabIndex = 1;
            button_sobre.Text = "Sobre";
            button_sobre.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_sobre.UseVisualStyleBackColor = true;
            button_sobre.Click += button_sobre_Click;
            // 
            // AlertasContainer
            // 
            AlertasContainer.BackColor = Color.FromArgb(54, 53, 67);
            AlertasContainer.Controls.Add(button_alertas);
            AlertasContainer.Dock = DockStyle.Top;
            AlertasContainer.Location = new Point(0, 470);
            AlertasContainer.Margin = new Padding(3, 4, 3, 4);
            AlertasContainer.MaximumSize = new Size(317, 54);
            AlertasContainer.MinimumSize = new Size(317, 54);
            AlertasContainer.Name = "AlertasContainer";
            AlertasContainer.Size = new Size(317, 54);
            AlertasContainer.TabIndex = 2;
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
            button_alertas.Location = new Point(0, 0);
            button_alertas.Margin = new Padding(3, 2, 3, 2);
            button_alertas.Name = "button_alertas";
            button_alertas.Size = new Size(317, 54);
            button_alertas.TabIndex = 1;
            button_alertas.Text = "Alertas";
            button_alertas.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_alertas.UseVisualStyleBackColor = true;
            button_alertas.Click += button_alertas_Click;
            // 
            // ManutencaoContainer
            // 
            ManutencaoContainer.BackColor = Color.FromArgb(54, 53, 67);
            ManutencaoContainer.Controls.Add(button_NovaManutencao);
            ManutencaoContainer.Controls.Add(button_HistoricoManutencao);
            ManutencaoContainer.Controls.Add(button_manutencao);
            ManutencaoContainer.Dock = DockStyle.Top;
            ManutencaoContainer.Location = new Point(0, 416);
            ManutencaoContainer.Margin = new Padding(3, 4, 3, 4);
            ManutencaoContainer.MaximumSize = new Size(317, 166);
            ManutencaoContainer.MinimumSize = new Size(317, 54);
            ManutencaoContainer.Name = "ManutencaoContainer";
            ManutencaoContainer.Size = new Size(317, 54);
            ManutencaoContainer.TabIndex = 1;
            // 
            // button_NovaManutencao
            // 
            button_NovaManutencao.Dock = DockStyle.Top;
            button_NovaManutencao.FlatAppearance.BorderSize = 0;
            button_NovaManutencao.FlatStyle = FlatStyle.Flat;
            button_NovaManutencao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_NovaManutencao.ForeColor = Color.White;
            button_NovaManutencao.Image = Properties.Resources.Manutencao;
            button_NovaManutencao.ImageAlign = ContentAlignment.MiddleLeft;
            button_NovaManutencao.Location = new Point(0, 108);
            button_NovaManutencao.Margin = new Padding(3, 2, 3, 2);
            button_NovaManutencao.Name = "button_NovaManutencao";
            button_NovaManutencao.Size = new Size(317, 54);
            button_NovaManutencao.TabIndex = 2;
            button_NovaManutencao.Text = "Nova Manutencao";
            button_NovaManutencao.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_NovaManutencao.UseVisualStyleBackColor = true;
            button_NovaManutencao.Click += button_NovaManutencao_Click;
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
            button_HistoricoManutencao.Location = new Point(0, 54);
            button_HistoricoManutencao.Margin = new Padding(3, 2, 3, 2);
            button_HistoricoManutencao.Name = "button_HistoricoManutencao";
            button_HistoricoManutencao.Size = new Size(317, 54);
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
            button_manutencao.Margin = new Padding(3, 2, 3, 2);
            button_manutencao.Name = "button_manutencao";
            button_manutencao.Size = new Size(317, 54);
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
            ReservasContainer.Location = new Point(0, 362);
            ReservasContainer.Margin = new Padding(3, 4, 3, 4);
            ReservasContainer.MaximumSize = new Size(317, 166);
            ReservasContainer.MinimumSize = new Size(317, 54);
            ReservasContainer.Name = "ReservasContainer";
            ReservasContainer.Size = new Size(317, 54);
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
            button_HistoricoReserva.Location = new Point(0, 108);
            button_HistoricoReserva.Margin = new Padding(3, 2, 3, 2);
            button_HistoricoReserva.Name = "button_HistoricoReserva";
            button_HistoricoReserva.Size = new Size(317, 54);
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
            button_NovaReserva.Location = new Point(0, 54);
            button_NovaReserva.Margin = new Padding(3, 2, 3, 2);
            button_NovaReserva.Name = "button_NovaReserva";
            button_NovaReserva.Size = new Size(317, 54);
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
            button_reservas.Margin = new Padding(3, 2, 3, 2);
            button_reservas.Name = "button_reservas";
            button_reservas.Size = new Size(317, 54);
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
            AvioesContainer.Location = new Point(0, 308);
            AvioesContainer.Margin = new Padding(3, 4, 3, 4);
            AvioesContainer.MaximumSize = new Size(317, 110);
            AvioesContainer.MinimumSize = new Size(317, 54);
            AvioesContainer.Name = "AvioesContainer";
            AvioesContainer.Size = new Size(317, 54);
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
            button_avioes.Margin = new Padding(3, 2, 3, 2);
            button_avioes.Name = "button_avioes";
            button_avioes.Size = new Size(317, 54);
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
            button_InserirAviao.Margin = new Padding(3, 2, 3, 2);
            button_InserirAviao.Name = "button_InserirAviao";
            button_InserirAviao.Size = new Size(317, 54);
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
            DashboardContainer.Location = new Point(0, 254);
            DashboardContainer.Margin = new Padding(3, 4, 3, 4);
            DashboardContainer.MaximumSize = new Size(317, 54);
            DashboardContainer.MinimumSize = new Size(317, 54);
            DashboardContainer.Name = "DashboardContainer";
            DashboardContainer.Size = new Size(317, 54);
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
            button_dashboard.Margin = new Padding(3, 2, 3, 2);
            button_dashboard.Name = "button_dashboard";
            button_dashboard.Size = new Size(317, 54);
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
            panel_icone.Margin = new Padding(11, 6, 6, 14);
            panel_icone.Name = "panel_icone";
            panel_icone.Size = new Size(274, 254);
            panel_icone.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.amlogo;
            pictureBoxLogo.Location = new Point(48, 16);
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
            panel_main.Location = new Point(274, 0);
            panel_main.Margin = new Padding(3, 2, 3, 2);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(1258, 794);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1532, 794);
            Controls.Add(panel_main);
            Controls.Add(panel_sidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aeromils";
            FormClosing += Form1_FormClosing;
            panel_sidebar.ResumeLayout(false);
            SobreContainer.ResumeLayout(false);
            AlertasContainer.ResumeLayout(false);
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
        private Button button_alertas;
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
        private Button button_NovaManutencao;
        private Panel AlertasContainer;
        private Panel DashboardContainer;
        private Panel SobreContainer;
    }
}