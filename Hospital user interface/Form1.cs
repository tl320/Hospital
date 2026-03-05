using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_user_interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string Email;
            string Password;
        }
        //btw if the UI form shows an error symbol when you exit and open up the project again, just go to where the project files are located and delete the obj and bin files, the form should show after that

        private void label1_Click(object sender, EventArgs e) //This section of code is jsut for the label named "EMAIL" this can be ignored
        {

        }

        private void label2_Click(object sender, EventArgs e) //The same is applied here except it is for "PASSWORD" label
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e) //This section of code is for the email textbox
        {
            string Email = Console.ReadLine(); 
            
        }

        public void textBox2_TextChanged(object sender, EventArgs e) // this section of code is for the password text box, an idea of development is to 'censor the text shown in the password box'
        {
            string Password = Console.ReadLine();
        }

        private void ExitButton_Click(object sender, EventArgs e) //code for the exit button, this is sued when the user wants to leave the login portal without entering any details
        {
            this.Close(); //this is tested and it works
        }

        private void LoginButton_Click(object sender, EventArgs e, string Email, string Password) //code for the login button, this might be very long
        {
            //this has not been tested yet, all just theory


            if (Email == Email || Password == Password) // variable scoping fixed, but currently trying to find a better comparison to check if the login credentials ae correct
            {
                MessageBox.Show("Invald Email or Password");
            }
            else //further ideas for development can be to make an else if statement for just email and password 
            {
                MessageBox.Show("Login Successful"); //if successful should give show a message prompt that the login was successful

                this.Hide();// should give an option to close the messagebox prompt
            }
        }

        private void Form1_Load(object sender, EventArgs e) //this is the code for the UI form
        {

        }
    }
}
