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
    public partial class New_user_form : Form
    {
        
        public New_user_form()
        {
            InitializeComponent();
        }

        private void createAccButt_Click(object sender, EventArgs e)
        {
            string userandpass = "";
            //if the passwords match
            if (newPassword.Text == confPass.Text)
            {
                userandpass = newUsername.Text + "," + newPassword.Text + "\n";
                if (!File.Exists("C:/Users/mille/Python/Iced Tees Project/Website/Log-in system/bin/Debug/UNP.txt")) // If file does not exist
                {
                    File.Create("C:/Users/mille/Python/Iced Tees Project/Website/Log-in system/bin/Debug/UNP.txt").Close(); // Create file
                    using (StreamWriter sw = File.AppendText("C:/Users/mille/Python/Iced Tees Project/Website/Log-in system/bin/Debug/UNP.txt"))
                    {
                        sw.WriteLine(userandpass); // Write text to .txt file
                    }
                }
                else // If file already exists
                {
                    // File.WriteAllText("FILENAME.txt", String.Empty); // Clear file
                    using (StreamWriter sw = File.AppendText("C:/Users/mille/Python/Iced Tees Project/Website/Log-in system/bin/Debug/UNP.txt"))
                    {
                        sw.WriteLine(userandpass); // Write text to .txt file
                    }
                }
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Close(); // move back to the regular sign in page
            }
            else
            {

            }
        }


        private void New_user_form_Load(object sender, EventArgs e)
        {

        }
    }
}
