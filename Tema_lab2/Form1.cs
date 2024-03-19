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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tema_lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void butLog_Click(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader("users.txt", true);
            string line = string.Empty;

            while ((line = streamReader.ReadLine()) != null)
            {
                string[] temp = line.Split(' ');
                if (temp[0] == textUser.Text && temp[1] == textPass.Text)
                { 
                    this.Hide();
                    Form2 secondForm = new Form2();
                    secondForm.Show();
                    return;
                }
                      
            }
            MessageBox.Show("Incorrect username or password!","Validation violated!!");
            streamReader.Close();

        }

        private void butReg_Click(object sender, EventArgs e)
        {
            string[] strings = File.ReadAllLines("users.txt");
            
            foreach(string s in strings)
            {
                string[] words = s.Split(' ');
                if (words.Contains(textUser.Text))
                {
                    MessageBox.Show("There is already an account with this username", "Error");
                    return;
                }
            }
            


            if (textPass.Text=="" || textUser.Text == "")
            {
                MessageBox.Show("Add a new username and password!","Invalid register");
                return;
            }
            
            using (StreamWriter streamWriter = new StreamWriter("users.txt", true))
            {

                
                streamWriter.WriteLine(textUser.Text + " " + textPass.Text);
            }
            MessageBox.Show("Tthe account has been created!", "Congrats!");
            this.Hide();
            Form2 secondForm = new Form2();
            secondForm.Show();

        }

        private void bttCreate_Click(object sender, EventArgs e)
        {
            labelReg.Text = "Register a new account:";
            butReg.Visible = true;
        }
    }
}
