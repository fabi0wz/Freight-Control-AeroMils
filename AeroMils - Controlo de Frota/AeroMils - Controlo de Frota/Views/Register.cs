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
    public partial class Register : Form
    {

        Login login;

        public Register(Login login)
        {
            InitializeComponent();

            this.login = login;
        }

        // opens the login form
        private void BackToLogin_label_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Hide();
        }


        private void Register_button_Click(object sender, EventArgs e)
        {
            //if the fields are empty
            if (Username_textBox.Text == "" || Password_textBox.Text == "" || ConfirmPassword_textBox.Text == "")
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
                else
                {
                    ConfirmPassword_textBox.Focus();
                }
            }
            else
            {
                //if the passwords match
                if (Password_textBox.Text == ConfirmPassword_textBox.Text)
                {
                    MessageBox.Show("Account Created");
                    //opens the login form
                    login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Passwords do not match");

                    //clears the fields
                    Password_textBox.Text = "";
                    ConfirmPassword_textBox.Text = "";
                    Password_textBox.Focus();
                }
            }
        }

        //if the checkbox is checked the password is shown
        private void ShowPassword_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword_checkBox.Checked)
            {
                Password_textBox.PasswordChar = '\0';
                ConfirmPassword_textBox.PasswordChar = '\0';
            }
            else
            {
                Password_textBox.PasswordChar = '•';
                ConfirmPassword_textBox.PasswordChar = '•';
            }
        }

        //if the user presses enter in the username field the password field is focused
        private void Username_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Password_textBox.Focus();

                //surpress the sound
                e.SuppressKeyPress = true;
            }
        }

        //if the user presses enter in the password field the confirm password field is focused
        private void Password_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConfirmPassword_textBox.Focus();

                //surpress the sound
                e.SuppressKeyPress = true;
            }
        }

        //if the user presses enter in the confirm password field the register button is clicked
        private void ConfirmPassword_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Register_button.PerformClick();

                //surpress the sound
                e.SuppressKeyPress = true;
            }
        }
    }
}
