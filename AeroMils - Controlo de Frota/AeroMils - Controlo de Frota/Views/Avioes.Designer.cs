using AeroMils___Controlo_de_Frota.Models;

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
            aviaoBGPanel = new Panel();
            aviaoLine1 = new Panel();
            aviaoLinha1EstadoChange = new Button();
            aviaoLinha1DataManutencao = new Label();
            aviaoLinha1Tipo = new Label();
            aviaoLinha1Estado = new Label();
            aviaoLinha1Modelo = new Label();
            aviaoLinha1ID = new Label();
            aviaoLine2 = new Panel();
            aviaoLinha2EstadoChange = new Button();
            aviaoLinha2DataManutencao = new Label();
            aviaoLinha2Tipo = new Label();
            aviaoLinha2Estado = new Label();
            aviaoLinha2Modelo = new Label();
            aviaoLinha2ID = new Label();
            aviaoLine4 = new Panel();
            aviaoLinha4EstadoChange = new Button();
            aviaoLinha4DataManutencao = new Label();
            aviaoLinha4Tipo = new Label();
            aviaoLinha4Estado = new Label();
            aviaoLinha4Modelo = new Label();
            aviaoLinha4ID = new Label();
            aviaoLine7 = new Panel();
            aviaoLinha7EstadoChange = new Button();
            aviaoLinha7DataManutencao = new Label();
            aviaoLinha7Tipo = new Label();
            aviaoLinha7Estado = new Label();
            aviaoLinha7Modelo = new Label();
            aviaoLinha7ID = new Label();
            aviaoLine6 = new Panel();
            aviaoLinha6EstadoChange = new Button();
            aviaoLinha6DataManutencao = new Label();
            aviaoLinha6Tipo = new Label();
            aviaoLinha6Estado = new Label();
            aviaoLinha6Modelo = new Label();
            aviaoLinha6ID = new Label();
            panel2 = new Panel();
            headerDetalhes = new Label();
            headerTipoAviao = new Label();
            headerEstado = new Label();
            headerModelo = new Label();
            headerID = new Label();
            aviaoLine3 = new Panel();
            aviaoLinha3EstadoChange = new Button();
            aviaoLinha3DataManutencao = new Label();
            aviaoLinha3Tipo = new Label();
            aviaoLinha3Estado = new Label();
            aviaoLinha3Modelo = new Label();
            aviaoLinha3ID = new Label();
            aviaoLine5 = new Panel();
            aviaoLinha5EstadoChange = new Button();
            aviaoLinha5DataManutencao = new Label();
            aviaoLinha5Tipo = new Label();
            aviaoLinha5Estado = new Label();
            aviaoLinha5Modelo = new Label();
            aviaoLinha5ID = new Label();
            avioesNextButton = new Button();
            avioesPreviousButton = new Button();
            filtrarPor_label = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)sQLiteDBContextBindingSource).BeginInit();
            aviaoBGPanel.SuspendLayout();
            aviaoLine1.SuspendLayout();
            aviaoLine2.SuspendLayout();
            aviaoLine4.SuspendLayout();
            aviaoLine7.SuspendLayout();
            aviaoLine6.SuspendLayout();
            panel2.SuspendLayout();
            aviaoLine3.SuspendLayout();
            aviaoLine5.SuspendLayout();
            SuspendLayout();
            // 
            // sQLiteDBContextBindingSource
            // 
            sQLiteDBContextBindingSource.DataSource = typeof(Data.DbContext.SQLiteDBContext);
            // 
            // aviaoBGPanel
            // 
            aviaoBGPanel.BackColor = SystemColors.AppWorkspace;
            aviaoBGPanel.Controls.Add(aviaoLine1);
            aviaoBGPanel.Controls.Add(aviaoLine2);
            aviaoBGPanel.Controls.Add(aviaoLine4);
            aviaoBGPanel.Controls.Add(aviaoLine7);
            aviaoBGPanel.Controls.Add(aviaoLine6);
            aviaoBGPanel.Controls.Add(panel2);
            aviaoBGPanel.Controls.Add(aviaoLine3);
            aviaoBGPanel.Controls.Add(aviaoLine5);
            aviaoBGPanel.Location = new Point(110, 98);
            aviaoBGPanel.Margin = new Padding(2, 3, 2, 3);
            aviaoBGPanel.Name = "aviaoBGPanel";
            aviaoBGPanel.Size = new Size(990, 525);
            aviaoBGPanel.TabIndex = 0;
            // 
            // aviaoLine1
            // 
            aviaoLine1.BackColor = SystemColors.Control;
            aviaoLine1.BorderStyle = BorderStyle.FixedSingle;
            aviaoLine1.Controls.Add(aviaoLinha1EstadoChange);
            aviaoLine1.Controls.Add(aviaoLinha1DataManutencao);
            aviaoLine1.Controls.Add(aviaoLinha1Tipo);
            aviaoLine1.Controls.Add(aviaoLinha1Estado);
            aviaoLine1.Controls.Add(aviaoLinha1Modelo);
            aviaoLine1.Controls.Add(aviaoLinha1ID);
            aviaoLine1.Location = new Point(0, 70);
            aviaoLine1.Margin = new Padding(2, 3, 2, 3);
            aviaoLine1.Name = "aviaoLine1";
            aviaoLine1.Size = new Size(990, 65);
            aviaoLine1.TabIndex = 5;
            aviaoLine1.MouseDoubleClick += aviaoLine1_MouseDoubleClick;
            aviaoLine1.MouseLeave += aviaoLine1_MouseLeave;
            aviaoLine1.MouseHover += aviaoLine1_MouseHover;
            // 
            // aviaoLinha1EstadoChange
            // 
            aviaoLinha1EstadoChange.Location = new Point(350, 16);
            aviaoLinha1EstadoChange.Name = "aviaoLinha1EstadoChange";
            aviaoLinha1EstadoChange.Size = new Size(36, 21);
            aviaoLinha1EstadoChange.TabIndex = 14;
            aviaoLinha1EstadoChange.Text = "<>";
            aviaoLinha1EstadoChange.UseVisualStyleBackColor = true;
            aviaoLinha1EstadoChange.Click += aviaoLinha1EstadoChange_Click;
            // 
            // aviaoLinha1DataManutencao
            // 
            aviaoLinha1DataManutencao.AutoSize = true;
            aviaoLinha1DataManutencao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha1DataManutencao.Location = new Point(788, 16);
            aviaoLinha1DataManutencao.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha1DataManutencao.Name = "aviaoLinha1DataManutencao";
            aviaoLinha1DataManutencao.Size = new Size(58, 21);
            aviaoLinha1DataManutencao.TabIndex = 4;
            aviaoLinha1DataManutencao.Text = "default";
            // 
            // aviaoLinha1Tipo
            // 
            aviaoLinha1Tipo.AutoSize = true;
            aviaoLinha1Tipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha1Tipo.Location = new Point(548, 16);
            aviaoLinha1Tipo.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha1Tipo.Name = "aviaoLinha1Tipo";
            aviaoLinha1Tipo.Size = new Size(58, 21);
            aviaoLinha1Tipo.TabIndex = 3;
            aviaoLinha1Tipo.Text = "default";
            // 
            // aviaoLinha1Estado
            // 
            aviaoLinha1Estado.AutoSize = true;
            aviaoLinha1Estado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha1Estado.Location = new Point(391, 16);
            aviaoLinha1Estado.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha1Estado.Name = "aviaoLinha1Estado";
            aviaoLinha1Estado.Size = new Size(58, 21);
            aviaoLinha1Estado.TabIndex = 2;
            aviaoLinha1Estado.Text = "default";
            // 
            // aviaoLinha1Modelo
            // 
            aviaoLinha1Modelo.AutoSize = true;
            aviaoLinha1Modelo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha1Modelo.Location = new Point(221, 16);
            aviaoLinha1Modelo.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha1Modelo.Name = "aviaoLinha1Modelo";
            aviaoLinha1Modelo.Size = new Size(58, 21);
            aviaoLinha1Modelo.TabIndex = 1;
            aviaoLinha1Modelo.Text = "default";
            // 
            // aviaoLinha1ID
            // 
            aviaoLinha1ID.AutoSize = true;
            aviaoLinha1ID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha1ID.Location = new Point(45, 16);
            aviaoLinha1ID.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha1ID.Name = "aviaoLinha1ID";
            aviaoLinha1ID.Size = new Size(58, 21);
            aviaoLinha1ID.TabIndex = 0;
            aviaoLinha1ID.Text = "default";
            // 
            // aviaoLine2
            // 
            aviaoLine2.BackColor = SystemColors.Control;
            aviaoLine2.BorderStyle = BorderStyle.FixedSingle;
            aviaoLine2.Controls.Add(aviaoLinha2EstadoChange);
            aviaoLine2.Controls.Add(aviaoLinha2DataManutencao);
            aviaoLine2.Controls.Add(aviaoLinha2Tipo);
            aviaoLine2.Controls.Add(aviaoLinha2Estado);
            aviaoLine2.Controls.Add(aviaoLinha2Modelo);
            aviaoLine2.Controls.Add(aviaoLinha2ID);
            aviaoLine2.Location = new Point(0, 135);
            aviaoLine2.Margin = new Padding(2, 3, 2, 3);
            aviaoLine2.Name = "aviaoLine2";
            aviaoLine2.Size = new Size(990, 65);
            aviaoLine2.TabIndex = 7;
            aviaoLine2.MouseDoubleClick += aviaoLine2_MouseDoubleClick;
            aviaoLine2.MouseLeave += aviaoLine2_MouseLeave;
            aviaoLine2.MouseHover += aviaoLine2_MouseHover;
            // 
            // aviaoLinha2EstadoChange
            // 
            aviaoLinha2EstadoChange.Location = new Point(350, 16);
            aviaoLinha2EstadoChange.Name = "aviaoLinha2EstadoChange";
            aviaoLinha2EstadoChange.Size = new Size(36, 21);
            aviaoLinha2EstadoChange.TabIndex = 15;
            aviaoLinha2EstadoChange.Text = "<>";
            aviaoLinha2EstadoChange.UseVisualStyleBackColor = true;
            aviaoLinha2EstadoChange.Click += aviaoLinha2EstadoChange_Click;
            // 
            // aviaoLinha2DataManutencao
            // 
            aviaoLinha2DataManutencao.AutoSize = true;
            aviaoLinha2DataManutencao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha2DataManutencao.Location = new Point(788, 16);
            aviaoLinha2DataManutencao.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha2DataManutencao.Name = "aviaoLinha2DataManutencao";
            aviaoLinha2DataManutencao.Size = new Size(58, 21);
            aviaoLinha2DataManutencao.TabIndex = 9;
            aviaoLinha2DataManutencao.Text = "default";
            // 
            // aviaoLinha2Tipo
            // 
            aviaoLinha2Tipo.AutoSize = true;
            aviaoLinha2Tipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha2Tipo.Location = new Point(548, 16);
            aviaoLinha2Tipo.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha2Tipo.Name = "aviaoLinha2Tipo";
            aviaoLinha2Tipo.Size = new Size(58, 21);
            aviaoLinha2Tipo.TabIndex = 8;
            aviaoLinha2Tipo.Text = "default";
            // 
            // aviaoLinha2Estado
            // 
            aviaoLinha2Estado.AutoSize = true;
            aviaoLinha2Estado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha2Estado.Location = new Point(391, 16);
            aviaoLinha2Estado.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha2Estado.Name = "aviaoLinha2Estado";
            aviaoLinha2Estado.Size = new Size(58, 21);
            aviaoLinha2Estado.TabIndex = 7;
            aviaoLinha2Estado.Text = "default";
            // 
            // aviaoLinha2Modelo
            // 
            aviaoLinha2Modelo.AutoSize = true;
            aviaoLinha2Modelo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha2Modelo.Location = new Point(221, 16);
            aviaoLinha2Modelo.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha2Modelo.Name = "aviaoLinha2Modelo";
            aviaoLinha2Modelo.Size = new Size(58, 21);
            aviaoLinha2Modelo.TabIndex = 6;
            aviaoLinha2Modelo.Text = "default";
            // 
            // aviaoLinha2ID
            // 
            aviaoLinha2ID.AutoSize = true;
            aviaoLinha2ID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha2ID.Location = new Point(45, 16);
            aviaoLinha2ID.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha2ID.Name = "aviaoLinha2ID";
            aviaoLinha2ID.Size = new Size(58, 21);
            aviaoLinha2ID.TabIndex = 5;
            aviaoLinha2ID.Text = "default";
            // 
            // aviaoLine4
            // 
            aviaoLine4.BackColor = SystemColors.Control;
            aviaoLine4.BorderStyle = BorderStyle.FixedSingle;
            aviaoLine4.Controls.Add(aviaoLinha4EstadoChange);
            aviaoLine4.Controls.Add(aviaoLinha4DataManutencao);
            aviaoLine4.Controls.Add(aviaoLinha4Tipo);
            aviaoLine4.Controls.Add(aviaoLinha4Estado);
            aviaoLine4.Controls.Add(aviaoLinha4Modelo);
            aviaoLine4.Controls.Add(aviaoLinha4ID);
            aviaoLine4.Location = new Point(0, 265);
            aviaoLine4.Margin = new Padding(2, 3, 2, 3);
            aviaoLine4.Name = "aviaoLine4";
            aviaoLine4.Size = new Size(990, 65);
            aviaoLine4.TabIndex = 8;
            aviaoLine4.MouseDoubleClick += aviaoLine4_MouseDoubleClick;
            aviaoLine4.MouseLeave += aviaoLine4_MouseLeave;
            aviaoLine4.MouseHover += aviaoLine4_MouseHover;
            // 
            // aviaoLinha4EstadoChange
            // 
            aviaoLinha4EstadoChange.Location = new Point(350, 16);
            aviaoLinha4EstadoChange.Name = "aviaoLinha4EstadoChange";
            aviaoLinha4EstadoChange.Size = new Size(36, 21);
            aviaoLinha4EstadoChange.TabIndex = 17;
            aviaoLinha4EstadoChange.Text = "<>";
            aviaoLinha4EstadoChange.UseVisualStyleBackColor = true;
            aviaoLinha4EstadoChange.Click += aviaoLinha4EstadoChange_Click;
            // 
            // aviaoLinha4DataManutencao
            // 
            aviaoLinha4DataManutencao.AutoSize = true;
            aviaoLinha4DataManutencao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha4DataManutencao.Location = new Point(788, 16);
            aviaoLinha4DataManutencao.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha4DataManutencao.Name = "aviaoLinha4DataManutencao";
            aviaoLinha4DataManutencao.Size = new Size(58, 21);
            aviaoLinha4DataManutencao.TabIndex = 9;
            aviaoLinha4DataManutencao.Text = "default";
            // 
            // aviaoLinha4Tipo
            // 
            aviaoLinha4Tipo.AutoSize = true;
            aviaoLinha4Tipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha4Tipo.Location = new Point(548, 16);
            aviaoLinha4Tipo.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha4Tipo.Name = "aviaoLinha4Tipo";
            aviaoLinha4Tipo.Size = new Size(58, 21);
            aviaoLinha4Tipo.TabIndex = 8;
            aviaoLinha4Tipo.Text = "default";
            // 
            // aviaoLinha4Estado
            // 
            aviaoLinha4Estado.AutoSize = true;
            aviaoLinha4Estado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha4Estado.Location = new Point(391, 16);
            aviaoLinha4Estado.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha4Estado.Name = "aviaoLinha4Estado";
            aviaoLinha4Estado.Size = new Size(58, 21);
            aviaoLinha4Estado.TabIndex = 7;
            aviaoLinha4Estado.Text = "default";
            // 
            // aviaoLinha4Modelo
            // 
            aviaoLinha4Modelo.AutoSize = true;
            aviaoLinha4Modelo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha4Modelo.Location = new Point(221, 16);
            aviaoLinha4Modelo.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha4Modelo.Name = "aviaoLinha4Modelo";
            aviaoLinha4Modelo.Size = new Size(58, 21);
            aviaoLinha4Modelo.TabIndex = 6;
            aviaoLinha4Modelo.Text = "default";
            // 
            // aviaoLinha4ID
            // 
            aviaoLinha4ID.AutoSize = true;
            aviaoLinha4ID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha4ID.Location = new Point(45, 16);
            aviaoLinha4ID.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha4ID.Name = "aviaoLinha4ID";
            aviaoLinha4ID.Size = new Size(58, 21);
            aviaoLinha4ID.TabIndex = 5;
            aviaoLinha4ID.Text = "default";
            // 
            // aviaoLine7
            // 
            aviaoLine7.BackColor = SystemColors.Control;
            aviaoLine7.BorderStyle = BorderStyle.FixedSingle;
            aviaoLine7.Controls.Add(aviaoLinha7EstadoChange);
            aviaoLine7.Controls.Add(aviaoLinha7DataManutencao);
            aviaoLine7.Controls.Add(aviaoLinha7Tipo);
            aviaoLine7.Controls.Add(aviaoLinha7Estado);
            aviaoLine7.Controls.Add(aviaoLinha7Modelo);
            aviaoLine7.Controls.Add(aviaoLinha7ID);
            aviaoLine7.Location = new Point(0, 460);
            aviaoLine7.Margin = new Padding(2, 3, 2, 3);
            aviaoLine7.Name = "aviaoLine7";
            aviaoLine7.Size = new Size(990, 65);
            aviaoLine7.TabIndex = 10;
            aviaoLine7.MouseDoubleClick += aviaoLine7_MouseDoubleClick;
            aviaoLine7.MouseLeave += aviaoLine7_MouseLeave;
            aviaoLine7.MouseHover += aviaoLine7_MouseHover;
            // 
            // aviaoLinha7EstadoChange
            // 
            aviaoLinha7EstadoChange.Location = new Point(350, 16);
            aviaoLinha7EstadoChange.Name = "aviaoLinha7EstadoChange";
            aviaoLinha7EstadoChange.Size = new Size(36, 21);
            aviaoLinha7EstadoChange.TabIndex = 20;
            aviaoLinha7EstadoChange.Text = "<>";
            aviaoLinha7EstadoChange.UseVisualStyleBackColor = true;
            aviaoLinha7EstadoChange.Click += aviaoLinha7EstadoChange_Click;
            // 
            // aviaoLinha7DataManutencao
            // 
            aviaoLinha7DataManutencao.AutoSize = true;
            aviaoLinha7DataManutencao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha7DataManutencao.Location = new Point(788, 16);
            aviaoLinha7DataManutencao.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha7DataManutencao.Name = "aviaoLinha7DataManutencao";
            aviaoLinha7DataManutencao.Size = new Size(58, 21);
            aviaoLinha7DataManutencao.TabIndex = 9;
            aviaoLinha7DataManutencao.Text = "default";
            // 
            // aviaoLinha7Tipo
            // 
            aviaoLinha7Tipo.AutoSize = true;
            aviaoLinha7Tipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha7Tipo.Location = new Point(548, 16);
            aviaoLinha7Tipo.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha7Tipo.Name = "aviaoLinha7Tipo";
            aviaoLinha7Tipo.Size = new Size(58, 21);
            aviaoLinha7Tipo.TabIndex = 8;
            aviaoLinha7Tipo.Text = "default";
            // 
            // aviaoLinha7Estado
            // 
            aviaoLinha7Estado.AutoSize = true;
            aviaoLinha7Estado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha7Estado.Location = new Point(391, 16);
            aviaoLinha7Estado.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha7Estado.Name = "aviaoLinha7Estado";
            aviaoLinha7Estado.Size = new Size(58, 21);
            aviaoLinha7Estado.TabIndex = 7;
            aviaoLinha7Estado.Text = "default";
            // 
            // aviaoLinha7Modelo
            // 
            aviaoLinha7Modelo.AutoSize = true;
            aviaoLinha7Modelo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha7Modelo.Location = new Point(221, 16);
            aviaoLinha7Modelo.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha7Modelo.Name = "aviaoLinha7Modelo";
            aviaoLinha7Modelo.Size = new Size(58, 21);
            aviaoLinha7Modelo.TabIndex = 6;
            aviaoLinha7Modelo.Text = "default";
            // 
            // aviaoLinha7ID
            // 
            aviaoLinha7ID.AutoSize = true;
            aviaoLinha7ID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha7ID.Location = new Point(45, 16);
            aviaoLinha7ID.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha7ID.Name = "aviaoLinha7ID";
            aviaoLinha7ID.Size = new Size(58, 21);
            aviaoLinha7ID.TabIndex = 5;
            aviaoLinha7ID.Text = "default";
            // 
            // aviaoLine6
            // 
            aviaoLine6.BackColor = SystemColors.Control;
            aviaoLine6.BorderStyle = BorderStyle.FixedSingle;
            aviaoLine6.Controls.Add(aviaoLinha6EstadoChange);
            aviaoLine6.Controls.Add(aviaoLinha6DataManutencao);
            aviaoLine6.Controls.Add(aviaoLinha6Tipo);
            aviaoLine6.Controls.Add(aviaoLinha6Estado);
            aviaoLine6.Controls.Add(aviaoLinha6Modelo);
            aviaoLine6.Controls.Add(aviaoLinha6ID);
            aviaoLine6.Location = new Point(0, 395);
            aviaoLine6.Margin = new Padding(2, 3, 2, 3);
            aviaoLine6.Name = "aviaoLine6";
            aviaoLine6.Size = new Size(990, 65);
            aviaoLine6.TabIndex = 9;
            aviaoLine6.MouseDoubleClick += aviaoLine6_MouseDoubleClick;
            aviaoLine6.MouseLeave += aviaoLine6_MouseLeave;
            aviaoLine6.MouseHover += aviaoLine6_MouseHover;
            // 
            // aviaoLinha6EstadoChange
            // 
            aviaoLinha6EstadoChange.Location = new Point(350, 16);
            aviaoLinha6EstadoChange.Name = "aviaoLinha6EstadoChange";
            aviaoLinha6EstadoChange.Size = new Size(36, 21);
            aviaoLinha6EstadoChange.TabIndex = 19;
            aviaoLinha6EstadoChange.Text = "<>";
            aviaoLinha6EstadoChange.UseVisualStyleBackColor = true;
            aviaoLinha6EstadoChange.Click += aviaoLinha6EstadoChange_Click;
            // 
            // aviaoLinha6DataManutencao
            // 
            aviaoLinha6DataManutencao.AutoSize = true;
            aviaoLinha6DataManutencao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha6DataManutencao.Location = new Point(788, 16);
            aviaoLinha6DataManutencao.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha6DataManutencao.Name = "aviaoLinha6DataManutencao";
            aviaoLinha6DataManutencao.Size = new Size(58, 21);
            aviaoLinha6DataManutencao.TabIndex = 9;
            aviaoLinha6DataManutencao.Text = "default";
            // 
            // aviaoLinha6Tipo
            // 
            aviaoLinha6Tipo.AutoSize = true;
            aviaoLinha6Tipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha6Tipo.Location = new Point(548, 16);
            aviaoLinha6Tipo.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha6Tipo.Name = "aviaoLinha6Tipo";
            aviaoLinha6Tipo.Size = new Size(58, 21);
            aviaoLinha6Tipo.TabIndex = 8;
            aviaoLinha6Tipo.Text = "default";
            // 
            // aviaoLinha6Estado
            // 
            aviaoLinha6Estado.AutoSize = true;
            aviaoLinha6Estado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha6Estado.Location = new Point(391, 16);
            aviaoLinha6Estado.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha6Estado.Name = "aviaoLinha6Estado";
            aviaoLinha6Estado.Size = new Size(58, 21);
            aviaoLinha6Estado.TabIndex = 7;
            aviaoLinha6Estado.Text = "default";
            // 
            // aviaoLinha6Modelo
            // 
            aviaoLinha6Modelo.AutoSize = true;
            aviaoLinha6Modelo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha6Modelo.Location = new Point(221, 16);
            aviaoLinha6Modelo.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha6Modelo.Name = "aviaoLinha6Modelo";
            aviaoLinha6Modelo.Size = new Size(58, 21);
            aviaoLinha6Modelo.TabIndex = 6;
            aviaoLinha6Modelo.Text = "default";
            // 
            // aviaoLinha6ID
            // 
            aviaoLinha6ID.AutoSize = true;
            aviaoLinha6ID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha6ID.Location = new Point(45, 16);
            aviaoLinha6ID.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha6ID.Name = "aviaoLinha6ID";
            aviaoLinha6ID.Size = new Size(58, 21);
            aviaoLinha6ID.TabIndex = 5;
            aviaoLinha6ID.Text = "default";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(54, 53, 67);
            panel2.Controls.Add(headerDetalhes);
            panel2.Controls.Add(headerTipoAviao);
            panel2.Controls.Add(headerEstado);
            panel2.Controls.Add(headerModelo);
            panel2.Controls.Add(headerID);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(990, 70);
            panel2.TabIndex = 1;
            // 
            // headerDetalhes
            // 
            headerDetalhes.AutoSize = true;
            headerDetalhes.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            headerDetalhes.ForeColor = SystemColors.Control;
            headerDetalhes.Location = new Point(788, 16);
            headerDetalhes.Margin = new Padding(2, 0, 2, 0);
            headerDetalhes.Name = "headerDetalhes";
            headerDetalhes.Size = new Size(133, 30);
            headerDetalhes.TabIndex = 4;
            headerDetalhes.Text = "Manutenção";
            // 
            // headerTipoAviao
            // 
            headerTipoAviao.AutoSize = true;
            headerTipoAviao.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            headerTipoAviao.ForeColor = SystemColors.Control;
            headerTipoAviao.Location = new Point(548, 16);
            headerTipoAviao.Margin = new Padding(2, 0, 2, 0);
            headerTipoAviao.Name = "headerTipoAviao";
            headerTipoAviao.Size = new Size(147, 30);
            headerTipoAviao.TabIndex = 3;
            headerTipoAviao.Text = "Tipo de Avião";
            // 
            // headerEstado
            // 
            headerEstado.AutoSize = true;
            headerEstado.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            headerEstado.ForeColor = SystemColors.Control;
            headerEstado.Location = new Point(391, 16);
            headerEstado.Margin = new Padding(2, 0, 2, 0);
            headerEstado.Name = "headerEstado";
            headerEstado.Size = new Size(77, 30);
            headerEstado.TabIndex = 2;
            headerEstado.Text = "Estado";
            // 
            // headerModelo
            // 
            headerModelo.AutoSize = true;
            headerModelo.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            headerModelo.ForeColor = SystemColors.Control;
            headerModelo.Location = new Point(221, 16);
            headerModelo.Margin = new Padding(2, 0, 2, 0);
            headerModelo.Name = "headerModelo";
            headerModelo.Size = new Size(73, 30);
            headerModelo.TabIndex = 1;
            headerModelo.Text = "Marca";
            // 
            // headerID
            // 
            headerID.AutoSize = true;
            headerID.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            headerID.ForeColor = SystemColors.Control;
            headerID.Location = new Point(45, 16);
            headerID.Margin = new Padding(2, 0, 2, 0);
            headerID.Name = "headerID";
            headerID.Size = new Size(94, 30);
            headerID.TabIndex = 0;
            headerID.Text = "ID Avião";
            // 
            // aviaoLine3
            // 
            aviaoLine3.BackColor = SystemColors.Control;
            aviaoLine3.BorderStyle = BorderStyle.FixedSingle;
            aviaoLine3.Controls.Add(aviaoLinha3EstadoChange);
            aviaoLine3.Controls.Add(aviaoLinha3DataManutencao);
            aviaoLine3.Controls.Add(aviaoLinha3Tipo);
            aviaoLine3.Controls.Add(aviaoLinha3Estado);
            aviaoLine3.Controls.Add(aviaoLinha3Modelo);
            aviaoLine3.Controls.Add(aviaoLinha3ID);
            aviaoLine3.Location = new Point(0, 200);
            aviaoLine3.Margin = new Padding(2, 3, 2, 3);
            aviaoLine3.Name = "aviaoLine3";
            aviaoLine3.Size = new Size(990, 65);
            aviaoLine3.TabIndex = 7;
            aviaoLine3.MouseDoubleClick += aviaoLine3_MouseDoubleClick;
            aviaoLine3.MouseLeave += aviaoLine3_MouseLeave;
            aviaoLine3.MouseHover += aviaoLine3_MouseHover;
            // 
            // aviaoLinha3EstadoChange
            // 
            aviaoLinha3EstadoChange.Location = new Point(350, 16);
            aviaoLinha3EstadoChange.Name = "aviaoLinha3EstadoChange";
            aviaoLinha3EstadoChange.Size = new Size(36, 21);
            aviaoLinha3EstadoChange.TabIndex = 16;
            aviaoLinha3EstadoChange.Text = "<>";
            aviaoLinha3EstadoChange.UseVisualStyleBackColor = true;
            aviaoLinha3EstadoChange.Click += aviaoLinha3EstadoChange_Click;
            // 
            // aviaoLinha3DataManutencao
            // 
            aviaoLinha3DataManutencao.AutoSize = true;
            aviaoLinha3DataManutencao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha3DataManutencao.Location = new Point(788, 16);
            aviaoLinha3DataManutencao.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha3DataManutencao.Name = "aviaoLinha3DataManutencao";
            aviaoLinha3DataManutencao.Size = new Size(58, 21);
            aviaoLinha3DataManutencao.TabIndex = 9;
            aviaoLinha3DataManutencao.Text = "default";
            // 
            // aviaoLinha3Tipo
            // 
            aviaoLinha3Tipo.AutoSize = true;
            aviaoLinha3Tipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha3Tipo.Location = new Point(548, 16);
            aviaoLinha3Tipo.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha3Tipo.Name = "aviaoLinha3Tipo";
            aviaoLinha3Tipo.Size = new Size(58, 21);
            aviaoLinha3Tipo.TabIndex = 8;
            aviaoLinha3Tipo.Text = "default";
            // 
            // aviaoLinha3Estado
            // 
            aviaoLinha3Estado.AutoSize = true;
            aviaoLinha3Estado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha3Estado.Location = new Point(391, 16);
            aviaoLinha3Estado.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha3Estado.Name = "aviaoLinha3Estado";
            aviaoLinha3Estado.Size = new Size(58, 21);
            aviaoLinha3Estado.TabIndex = 7;
            aviaoLinha3Estado.Text = "default";
            // 
            // aviaoLinha3Modelo
            // 
            aviaoLinha3Modelo.AutoSize = true;
            aviaoLinha3Modelo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha3Modelo.Location = new Point(221, 16);
            aviaoLinha3Modelo.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha3Modelo.Name = "aviaoLinha3Modelo";
            aviaoLinha3Modelo.Size = new Size(58, 21);
            aviaoLinha3Modelo.TabIndex = 6;
            aviaoLinha3Modelo.Text = "default";
            // 
            // aviaoLinha3ID
            // 
            aviaoLinha3ID.AutoSize = true;
            aviaoLinha3ID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha3ID.Location = new Point(45, 16);
            aviaoLinha3ID.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha3ID.Name = "aviaoLinha3ID";
            aviaoLinha3ID.Size = new Size(58, 21);
            aviaoLinha3ID.TabIndex = 5;
            aviaoLinha3ID.Text = "default";
            // 
            // aviaoLine5
            // 
            aviaoLine5.BackColor = SystemColors.Control;
            aviaoLine5.BorderStyle = BorderStyle.FixedSingle;
            aviaoLine5.Controls.Add(aviaoLinha5EstadoChange);
            aviaoLine5.Controls.Add(aviaoLinha5DataManutencao);
            aviaoLine5.Controls.Add(aviaoLinha5Tipo);
            aviaoLine5.Controls.Add(aviaoLinha5Estado);
            aviaoLine5.Controls.Add(aviaoLinha5Modelo);
            aviaoLine5.Controls.Add(aviaoLinha5ID);
            aviaoLine5.Location = new Point(0, 330);
            aviaoLine5.Margin = new Padding(2, 3, 2, 3);
            aviaoLine5.Name = "aviaoLine5";
            aviaoLine5.Size = new Size(990, 65);
            aviaoLine5.TabIndex = 9;
            aviaoLine5.MouseDoubleClick += aviaoLine5_MouseDoubleClick;
            aviaoLine5.MouseLeave += aviaoLine5_MouseLeave;
            aviaoLine5.MouseHover += aviaoLine5_MouseHover;
            // 
            // aviaoLinha5EstadoChange
            // 
            aviaoLinha5EstadoChange.Location = new Point(350, 16);
            aviaoLinha5EstadoChange.Name = "aviaoLinha5EstadoChange";
            aviaoLinha5EstadoChange.Size = new Size(36, 21);
            aviaoLinha5EstadoChange.TabIndex = 18;
            aviaoLinha5EstadoChange.Text = "<>";
            aviaoLinha5EstadoChange.UseVisualStyleBackColor = true;
            aviaoLinha5EstadoChange.Click += aviaoLinha5EstadoChange_Click;
            // 
            // aviaoLinha5DataManutencao
            // 
            aviaoLinha5DataManutencao.AutoSize = true;
            aviaoLinha5DataManutencao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha5DataManutencao.Location = new Point(788, 16);
            aviaoLinha5DataManutencao.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha5DataManutencao.Name = "aviaoLinha5DataManutencao";
            aviaoLinha5DataManutencao.Size = new Size(58, 21);
            aviaoLinha5DataManutencao.TabIndex = 9;
            aviaoLinha5DataManutencao.Text = "default";
            // 
            // aviaoLinha5Tipo
            // 
            aviaoLinha5Tipo.AutoSize = true;
            aviaoLinha5Tipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha5Tipo.Location = new Point(548, 16);
            aviaoLinha5Tipo.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha5Tipo.Name = "aviaoLinha5Tipo";
            aviaoLinha5Tipo.Size = new Size(58, 21);
            aviaoLinha5Tipo.TabIndex = 8;
            aviaoLinha5Tipo.Text = "default";
            // 
            // aviaoLinha5Estado
            // 
            aviaoLinha5Estado.AutoSize = true;
            aviaoLinha5Estado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha5Estado.Location = new Point(391, 16);
            aviaoLinha5Estado.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha5Estado.Name = "aviaoLinha5Estado";
            aviaoLinha5Estado.Size = new Size(58, 21);
            aviaoLinha5Estado.TabIndex = 7;
            aviaoLinha5Estado.Text = "default";
            // 
            // aviaoLinha5Modelo
            // 
            aviaoLinha5Modelo.AutoSize = true;
            aviaoLinha5Modelo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha5Modelo.Location = new Point(221, 16);
            aviaoLinha5Modelo.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha5Modelo.Name = "aviaoLinha5Modelo";
            aviaoLinha5Modelo.Size = new Size(58, 21);
            aviaoLinha5Modelo.TabIndex = 6;
            aviaoLinha5Modelo.Text = "default";
            // 
            // aviaoLinha5ID
            // 
            aviaoLinha5ID.AutoSize = true;
            aviaoLinha5ID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aviaoLinha5ID.Location = new Point(45, 16);
            aviaoLinha5ID.Margin = new Padding(2, 0, 2, 0);
            aviaoLinha5ID.Name = "aviaoLinha5ID";
            aviaoLinha5ID.Size = new Size(58, 21);
            aviaoLinha5ID.TabIndex = 5;
            aviaoLinha5ID.Text = "default";
            // 
            // avioesNextButton
            // 
            avioesNextButton.BackColor = Color.FromArgb(54, 53, 67);
            avioesNextButton.FlatStyle = FlatStyle.Flat;
            avioesNextButton.ForeColor = Color.White;
            avioesNextButton.Location = new Point(736, 649);
            avioesNextButton.Margin = new Padding(2, 3, 2, 3);
            avioesNextButton.Name = "avioesNextButton";
            avioesNextButton.Size = new Size(116, 38);
            avioesNextButton.TabIndex = 12;
            avioesNextButton.Text = "Next";
            avioesNextButton.UseVisualStyleBackColor = false;
            avioesNextButton.Click += avioesNextButton_Click;
            // 
            // avioesPreviousButton
            // 
            avioesPreviousButton.BackColor = Color.FromArgb(54, 53, 67);
            avioesPreviousButton.FlatStyle = FlatStyle.Flat;
            avioesPreviousButton.ForeColor = Color.White;
            avioesPreviousButton.Location = new Point(379, 649);
            avioesPreviousButton.Margin = new Padding(2, 3, 2, 3);
            avioesPreviousButton.Name = "avioesPreviousButton";
            avioesPreviousButton.Size = new Size(116, 38);
            avioesPreviousButton.TabIndex = 13;
            avioesPreviousButton.Text = "Previous";
            avioesPreviousButton.UseVisualStyleBackColor = false;
            avioesPreviousButton.Click += avioesPreviousButton_Click;
            // 
            // filtrarPor_label
            // 
            filtrarPor_label.AutoSize = true;
            filtrarPor_label.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            filtrarPor_label.Location = new Point(110, 34);
            filtrarPor_label.Name = "filtrarPor_label";
            filtrarPor_label.Size = new Size(118, 30);
            filtrarPor_label.TabIndex = 14;
            filtrarPor_label.Text = "Filtrar por:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Todos", "Em viagem", "No hangar" });
            comboBox1.Location = new Point(253, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 25);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Todos", "Comercial", "Particular", "Mercadoria", "Avioneta" });
            comboBox2.Location = new Point(438, 39);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 25);
            comboBox2.TabIndex = 16;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // Avioes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 663);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(filtrarPor_label);
            Controls.Add(avioesPreviousButton);
            Controls.Add(avioesNextButton);
            Controls.Add(aviaoBGPanel);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Avioes";
            Text = "Avioes";
            ((System.ComponentModel.ISupportInitialize)sQLiteDBContextBindingSource).EndInit();
            aviaoBGPanel.ResumeLayout(false);
            aviaoLine1.ResumeLayout(false);
            aviaoLine1.PerformLayout();
            aviaoLine2.ResumeLayout(false);
            aviaoLine2.PerformLayout();
            aviaoLine4.ResumeLayout(false);
            aviaoLine4.PerformLayout();
            aviaoLine7.ResumeLayout(false);
            aviaoLine7.PerformLayout();
            aviaoLine6.ResumeLayout(false);
            aviaoLine6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            aviaoLine3.ResumeLayout(false);
            aviaoLine3.PerformLayout();
            aviaoLine5.ResumeLayout(false);
            aviaoLine5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource sQLiteDBContextBindingSource;
        private FlowLayoutPanel airplaneSlideMenuFlowLayoutPanel;
        private Panel panel1;
        private Label headerID;
        private Label headerDetalhes;
        private Label headerTipoAviao;
        private Label headerEstado;
        private Label headerModelo;
        private Panel panel3;
        private Panel panel7;
        private Panel panel5;
        private Panel panel6;
        private Panel panel8;
        private Panel panel9;
        private Panel aviaoLine1;
        private Panel aviaoLine2;
        private Panel aviaoLine3;
        private Panel aviaoLine4;
        private Panel aviaoLine5;
        private Panel aviaoLine6;
        private Panel aviaoLine7;
        private Panel panel2;
        private Panel aviaoBGPanel;
        private Label aviaoLinha7DataManutencao;
        private Label aviaoLinha7Tipo;
        private Label aviaoLinha7Estado;
        private Label aviaoLinha7Modelo;
        private Label aviaoLinha7ID;
        private Label aviaoLinha4DataManutencao;
        private Label aviaoLinha4Tipo;
        private Label aviaoLinha4Estado;
        private Label aviaoLinha4Modelo;
        private Label aviaoLinha4ID;
        private Label aviaoLinha1DataManutencao;
        private Label aviaoLinha1Tipo;
        private Label aviaoLinha1Estado;
        private Label aviaoLinha1Modelo;
        private Label aviaoLinha1ID;
        private Label aviaoLinha2DataManutencao;
        private Label aviaoLinha2Tipo;
        private Label aviaoLinha2Estado;
        private Label aviaoLinha2Modelo;
        private Label aviaoLinha2ID;
        private Label aviaoLinha3DataManutencao;
        private Label aviaoLinha3Tipo;
        private Label aviaoLinha3Estado;
        private Label aviaoLinha3Modelo;
        private Label aviaoLinha3ID;
        private Label aviaoLinha5DataManutencao;
        private Label aviaoLinha5Tipo;
        private Label aviaoLinha5Estado;
        private Label aviaoLinha5Modelo;
        private Label aviaoLinha5ID;
        private Label aviaoLinha6DataManutencao;
        private Label aviaoLinha6Tipo;
        private Label aviaoLinha6Estado;
        private Label aviaoLinha6Modelo;
        private Label aviaoLinha6ID;
        private Button avioesNextButton;
        private Button avioesPreviousButton;
        private Button aviaoLinha1EstadoChange;
        private Button aviaoLinha2EstadoChange;
        private Button aviaoLinha3EstadoChange;
        private Button aviaoLinha4EstadoChange;
        private Button aviaoLinha5EstadoChange;
        private Button aviaoLinha6EstadoChange;
        private Button aviaoLinha7EstadoChange;
        private Label filtrarPor_label;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}