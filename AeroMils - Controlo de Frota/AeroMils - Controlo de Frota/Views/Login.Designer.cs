namespace AeroMils___Controlo_de_Frota.Views
{
    partial class Login
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
            DontHaveAnAccount_label = new Label();
            CreateAccount_label = new Label();
            LOGIN_button = new Button();
            ShowPassword_checkBox = new CheckBox();
            label1 = new Label();
            Password_textBox = new TextBox();
            Password_label = new Label();
            pictureBoxLogo = new PictureBox();
            Username_textBox = new TextBox();
            Username_label = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // DontHaveAnAccount_label
            // 
            DontHaveAnAccount_label.AutoSize = true;
            DontHaveAnAccount_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DontHaveAnAccount_label.ForeColor = Color.White;
            DontHaveAnAccount_label.Location = new Point(70, 461);
            DontHaveAnAccount_label.Name = "DontHaveAnAccount_label";
            DontHaveAnAccount_label.Size = new Size(150, 17);
            DontHaveAnAccount_label.TabIndex = 34;
            DontHaveAnAccount_label.Text = "Don't Have an Account";
            // 
            // CreateAccount_label
            // 
            CreateAccount_label.AutoSize = true;
            CreateAccount_label.Cursor = Cursors.Hand;
            CreateAccount_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CreateAccount_label.ForeColor = Color.FromArgb(255, 98, 45);
            CreateAccount_label.Location = new Point(95, 478);
            CreateAccount_label.Name = "CreateAccount_label";
            CreateAccount_label.Size = new Size(101, 17);
            CreateAccount_label.TabIndex = 33;
            CreateAccount_label.Text = "Create Account";
            CreateAccount_label.Click += CreateAccount_label_Click;
            // 
            // LOGIN_button
            // 
            LOGIN_button.BackColor = Color.FromArgb(255, 98, 45);
            LOGIN_button.Cursor = Cursors.Hand;
            LOGIN_button.FlatAppearance.BorderSize = 0;
            LOGIN_button.FlatStyle = FlatStyle.Flat;
            LOGIN_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LOGIN_button.ForeColor = Color.White;
            LOGIN_button.ImageAlign = ContentAlignment.MiddleLeft;
            LOGIN_button.Location = new Point(34, 394);
            LOGIN_button.Margin = new Padding(3, 2, 3, 2);
            LOGIN_button.Name = "LOGIN_button";
            LOGIN_button.Size = new Size(216, 41);
            LOGIN_button.TabIndex = 32;
            LOGIN_button.Text = "LOGIN";
            LOGIN_button.TextImageRelation = TextImageRelation.ImageBeforeText;
            LOGIN_button.UseVisualStyleBackColor = false;
            LOGIN_button.Click += LOGIN_button_Click;
            // 
            // ShowPassword_checkBox
            // 
            ShowPassword_checkBox.AutoSize = true;
            ShowPassword_checkBox.Cursor = Cursors.Hand;
            ShowPassword_checkBox.FlatStyle = FlatStyle.Flat;
            ShowPassword_checkBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ShowPassword_checkBox.ForeColor = Color.White;
            ShowPassword_checkBox.Location = new Point(131, 348);
            ShowPassword_checkBox.Name = "ShowPassword_checkBox";
            ShowPassword_checkBox.Size = new Size(119, 21);
            ShowPassword_checkBox.TabIndex = 31;
            ShowPassword_checkBox.Text = "Show Password";
            ShowPassword_checkBox.UseVisualStyleBackColor = true;
            ShowPassword_checkBox.CheckedChanged += ShowPassword_checkBox_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(70, 183);
            label1.Name = "label1";
            label1.Size = new Size(142, 32);
            label1.TabIndex = 28;
            label1.Text = "Get Started";
            // 
            // Password_textBox
            // 
            Password_textBox.Location = new Point(34, 319);
            Password_textBox.Name = "Password_textBox";
            Password_textBox.PasswordChar = '•';
            Password_textBox.Size = new Size(216, 23);
            Password_textBox.TabIndex = 27;
            Password_textBox.KeyDown += Password_textBox_KeyDown;
            // 
            // Password_label
            // 
            Password_label.AutoSize = true;
            Password_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Password_label.ForeColor = Color.White;
            Password_label.Location = new Point(34, 295);
            Password_label.Name = "Password_label";
            Password_label.Size = new Size(82, 21);
            Password_label.TabIndex = 26;
            Password_label.Text = "Password";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.amlogo;
            pictureBoxLogo.Location = new Point(61, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(163, 156);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 25;
            pictureBoxLogo.TabStop = false;
            // 
            // Username_textBox
            // 
            Username_textBox.Location = new Point(34, 253);
            Username_textBox.Name = "Username_textBox";
            Username_textBox.Size = new Size(216, 23);
            Username_textBox.TabIndex = 24;
            Username_textBox.KeyDown += Username_textBox_KeyDown;
            // 
            // Username_label
            // 
            Username_label.AutoSize = true;
            Username_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Username_label.ForeColor = Color.White;
            Username_label.Location = new Point(34, 229);
            Username_label.Name = "Username_label";
            Username_label.Size = new Size(87, 21);
            Username_label.TabIndex = 23;
            Username_label.Text = "Username";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 53, 67);
            ClientSize = new Size(285, 511);
            Controls.Add(DontHaveAnAccount_label);
            Controls.Add(CreateAccount_label);
            Controls.Add(LOGIN_button);
            Controls.Add(ShowPassword_checkBox);
            Controls.Add(label1);
            Controls.Add(Password_textBox);
            Controls.Add(Password_label);
            Controls.Add(pictureBoxLogo);
            Controls.Add(Username_textBox);
            Controls.Add(Username_label);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DontHaveAnAccount_label;
        private Label CreateAccount_label;
        private Button LOGIN_button;
        private CheckBox ShowPassword_checkBox;
        private Label label1;
        private TextBox Password_textBox;
        private Label Password_label;
        private PictureBox pictureBoxLogo;
        private TextBox Username_textBox;
        private Label Username_label;
    }
}