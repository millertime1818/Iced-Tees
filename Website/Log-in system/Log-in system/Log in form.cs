using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Log_in_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void usernameCheck(string username)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_user_form new_user_form = new New_user_form();
            new_user_form.ShowDialog();
            this.Close();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string userandpass = userNbox.Text + "," + passBox.Text;
            {
                if (File.Exists("C:/Users/mille/Python/Iced Tees Project/Website/Log-in system/bin/Debug/UNP.txt")) // If file exists
                {
                    if (File.ReadAllText("C:/Users/mille/Python/Iced Tees Project/Website/Log-in system/bin/Debug/UNP.txt").Contains(userandpass))
                    {
                        errorMessage.Text = "Successful login";
                        this.Hide();
                        successful_login successful_login_form = new successful_login();
                        successful_login_form.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        errorMessage.Text = "username or password is wrong";
                    }
                }
                else
                {
                    errorMessage.Text = "Could not check usernames and passwords";
                }
              
            }
        }

    }
}
