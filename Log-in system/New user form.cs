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
        //private bool checkPasswords(string a, string b)
        //{
        //    string str1 = a;
        //    string str2 = b;
        //    int length = str1.Length;
        //    //if the passwords match
        //    // vector for storing character occurrences
        //    bool[] v = new bool[47];

        //    // Arrays.fill(v,false);
        //    for (int i = 0; i < 47; i++)
        //        v[i] = false;

        //    // increment vector index for
        //    // every character of str1
        //    for (int i = 0; i < (b.Length); i++)
        //        v[str1[i] - 'a'] = true;

        //    // checking common substring of str2 in str1
        //    for (int i = 0; i < (a.Length); i++)
        //        if (v[str2[i] - 'a'])
        //            return true;

        //    return false;
        //}

        private void createAccButt_Click(object sender, EventArgs e)
        {
            
            if (newPassword.Text == confPass.Text /*&& checkPasswords("!@#$%^&*{}+=~`<>?;:,.", newPassword.Text)== true*/)
            {
                string userandpass = "";
                userandpass = newUsername.Text + "," + newPassword.Text + "\n";
                if (!File.Exists("UNP.txt")) // If file does not exist
                {
                    File.Create("UNP.txt").Close(); // Create file
                    using (StreamWriter sw = File.AppendText("UNP.txt"))
                    {
                        sw.WriteLine(userandpass); // Write text to .txt file
                    }
                }
                else // If file already exists
                {
                    // File.WriteAllText("FILENAME.txt", String.Empty); // Clear file
                    using (StreamWriter sw = File.AppendText("UNP.txt"))
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
                errorBox.Text = "Passwords do not match, or do not contain a special character. please reenter passwords";
                newPassword.Text = "";
                confPass.Text = "";
            }
        }


        private void New_user_form_Load(object sender, EventArgs e)
        {

        }
    }
}
