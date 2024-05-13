using Couchbase.Core.IO.Operations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Library
{
    // This is a Login Form
    public partial class Form2 : Form
    {
        private readonly CouchbaseManager _couchbaseManager;

        public Form2()
        {
            InitializeComponent();
            _couchbaseManager = new CouchbaseManager();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        { 
        
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 250, 250, 250);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        // This button is Login Button
        private async void button1_Click(object sender, EventArgs e)
        {
            // When login as admin, I have one admin and the username and password are static
            string username = "Nada2002";
            float password = 2342002;
            if (radioButton1.Checked)
            {
                if (textBox1.Text == username && float.Parse(textBox2.Text) == password)
                {
                    this.Hide();
                    Admin a = new Admin();
                    a.Show();
                }
                else
                    MessageBox.Show("The username or password incorrect, Try again");
            }

            // When you login as a librarian, the username and password are created by the admin and stored in the database.
            else if (radioButton2.Checked)
            {
                string usernameLib = textBox1.Text;
                int passwordLib =Int32.Parse( textBox2.Text);
                var isValid = await _couchbaseManager.LibrarianLogin(usernameLib, passwordLib);
                if (isValid)
                {
                    this.Hide();
                    LibrarianForm lf = new LibrarianForm();
                    lf.Show();
                }
                else
                {
                    MessageBox.Show("The Username Or Password Incorrect, Try Again");
                }
            }
        }
    }
}
    

