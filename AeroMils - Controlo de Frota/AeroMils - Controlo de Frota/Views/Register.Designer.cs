namespace AeroMils___Controlo_de_Frota.Views
{
    partial class Register
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
            BackToLogin_label = new Label();
            Register_button = new Button();
            ShowPassword_checkBox = new CheckBox();
            ConfirmPassword_textBox = new TextBox();
            ConfirmPassword_label = new Label();
            label1 = new Label();
            Password_textBox = new TextBox();
            Password_label = new Label();
            pictureBoxLogo = new PictureBox();
            Username_textBox = new TextBox();
            Username_label = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // BackToLogin_label
            // 
            BackToLogin_label.AutoSize = true;
            BackToLogin_label.Cursor = Cursors.Hand;
            BackToLogin_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BackToLogin_label.ForeColor = Color.FromArgb(255, 98, 45);
            BackToLogin_label.Location = new Point(93, 537);
            BackToLogin_label.Name = "BackToLogin_label";
            BackToLogin_label.Size = new Size(89, 17);
            BackToLogin_label.TabIndex = 21;
            BackToLogin_label.Text = "Back to login";
            BackToLogin_label.Click += BackToLogin_label_Click;
            // 
            // Register_button
            // 
            Register_button.BackColor = Color.FromArgb(255, 98, 45);
            Register_button.Cursor = Cursors.Hand;
            Register_button.FlatAppearance.BorderSize = 0;
            Register_button.FlatStyle = FlatStyle.Flat;
            Register_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Register_button.ForeColor = Color.White;
            Register_button.ImageAlign = ContentAlignment.MiddleLeft;
            Register_button.Location = new Point(34, 460);
            Register_button.Margin = new Padding(3, 2, 3, 2);
            Register_button.Name = "Register_button";
            Register_button.Size = new Size(216, 41);
            Register_button.TabIndex = 20;
            Register_button.Text = "Register";
            Register_button.TextImageRelation = TextImageRelation.ImageBeforeText;
            Register_button.UseVisualStyleBackColor = false;
            Register_button.Click += Register_button_Click;
            // 
            // ShowPassword_checkBox
            // 
            ShowPassword_checkBox.AutoSize = true;
            ShowPassword_checkBox.Cursor = Cursors.Hand;
            ShowPassword_checkBox.FlatStyle = FlatStyle.Flat;
            ShowPassword_checkBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ShowPassword_checkBox.ForeColor = Color.White;
            ShowPassword_checkBox.Location = new Point(131, 416);
            ShowPassword_checkBox.Name = "ShowPassword_checkBox";
            ShowPassword_checkBox.Size = new Size(119, 21);
            ShowPassword_checkBox.TabIndex = 19;
            ShowPassword_checkBox.Text = "Show Password";
            ShowPassword_checkBox.UseVisualStyleBackColor = true;
            ShowPassword_checkBox.CheckedChanged += ShowPassword_checkBox_CheckedChanged;
            // 
            // ConfirmPassword_textBox
            // 
            ConfirmPassword_textBox.Location = new Point(34, 387);
            ConfirmPassword_textBox.Name = "ConfirmPassword_textBox";
            ConfirmPassword_textBox.PasswordChar = '•';
            ConfirmPassword_textBox.Size = new Size(216, 23);
            ConfirmPassword_textBox.TabIndex = 18;
            ConfirmPassword_textBox.KeyDown += ConfirmPassword_textBox_KeyDown;
            // 
            // ConfirmPassword_label
            // 
            ConfirmPassword_label.AutoSize = true;
            ConfirmPassword_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ConfirmPassword_label.ForeColor = Color.White;
            ConfirmPassword_label.Location = new Point(34, 363);
            ConfirmPassword_label.Name = "ConfirmPassword_label";
            ConfirmPassword_label.Size = new Size(148, 21);
            ConfirmPassword_label.TabIndex = 17;
            ConfirmPassword_label.Text = "Confirm Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(70, 183);
            label1.Name = "label1";
            label1.Size = new Size(142, 32);
            label1.TabIndex = 16;
            label1.Text = "Get Started";
            // 
            // Password_textBox
            // 
            Password_textBox.Location = new Point(34, 319);
            Password_textBox.Name = "Password_textBox";
            Password_textBox.PasswordChar = '•';
            Password_textBox.Size = new Size(216, 23);
            Password_textBox.TabIndex = 15;
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
            Password_label.TabIndex = 14;
            Password_label.Text = "Password";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.amlogo;
            pictureBoxLogo.Location = new Point(61, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(163, 156);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 13;
            pictureBoxLogo.TabStop = false;
            // 
            // Username_textBox
            // 
            Username_textBox.Location = new Point(34, 253);
            Username_textBox.Name = "Username_textBox";
            Username_textBox.Size = new Size(216, 23);
            Username_textBox.TabIndex = 12;
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
            Username_label.TabIndex = 11;
            Username_label.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(61, 520);
            label2.Name = "label2";
            label2.Size = new Size(163, 17);
            label2.TabIndex = 22;
            label2.Text = "Already Have an Account";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 53, 67);
            ClientSize = new Size(285, 569);
            Controls.Add(label2);
            Controls.Add(BackToLogin_label);
            Controls.Add(Register_button);
            Controls.Add(ShowPassword_checkBox);
            Controls.Add(ConfirmPassword_textBox);
            Controls.Add(ConfirmPassword_label);
            Controls.Add(label1);
            Controls.Add(Password_textBox);
            Controls.Add(Password_label);
            Controls.Add(pictureBoxLogo);
            Controls.Add(Username_textBox);
            Controls.Add(Username_label);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BackToLogin_label;
        private Button Register_button;
        private CheckBox ShowPassword_checkBox;
        private TextBox ConfirmPassword_textBox;
        private Label ConfirmPassword_label;
        private Label label1;
        private TextBox Password_textBox;
        private Label Password_label;
        private PictureBox pictureBoxLogo;
        private TextBox Username_textBox;
        private Label Username_label;
        private Label label2;
    }
}