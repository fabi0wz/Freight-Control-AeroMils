using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AeroMils___Controlo_de_Frota.Views
{
    public partial class Login : Form
    {

        Register register;

        public Login()
        {
            InitializeComponent();

            this.register = new Register(this);

            this.register.Hide();

        }

        // opens the register form
        private void CreateAccount_label_Click(object sender, EventArgs e)
        {
            this.register.Show();
            this.Hide();
        }

        private void LOGIN_button_Click(object sender, EventArgs e)
        {
            //if the fields are empty
            if (Username_textBox.Text == "" || Password_textBox.Text == "")
            {
                MessageBox.Show("Please fill in all the fields");

                //focus on the first empty field
                if (Username_textBox.Text == "")
                {
                    Username_textBox.Focus();
                }
                else if (Password_textBox.Text == "")
                {
                    Password_textBox.Focus();
                }
            }
            else
            {
                //if the username and password are correct
                if (Username_textBox.Text == "admin" && Password_textBox.Text == "admin")
                {
                    //opens the main form
                    Form main = new Form1(this);
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");

                    //clears the fields
                    Username_textBox.Text = "";
                    Password_textBox.Text = "";
                    Username_textBox.Focus();
                }
            }

            register.Close();
        }

        private void ShowPassword_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            //if the checkbox is checked the password is shown
            if (ShowPassword_checkBox.Checked)
            {
                Password_textBox.PasswordChar = '\0';
            }
            else
            {
                Password_textBox.PasswordChar = '•';
            }
        }

        //if the user presses enter in the username field the password field is focused using keydown event

        private void Username_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Password_textBox.Focus();

                //surpress the sound
                e.SuppressKeyPress = true;
            }
        }
        //if the user presses enter in the password field the login button is clicked

        private void Password_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LOGIN_button.PerformClick();

                //surpress the sound
                e.SuppressKeyPress = true;
            }
        }
    }
}
