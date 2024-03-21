using Couchbase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library
{
    // This is a Admin Form
    public partial class Admin : Form
    {
        private CouchbaseManager _couchbaseManager;

        // This is constructor 
        public Admin()
        {
            InitializeComponent();
            _couchbaseManager = new CouchbaseManager();
        }

        // When load Admin form call this method to display the Library ID in comboBox
        private async void Admin_Load(object sender, EventArgs e)
        {
            await ComboBox1WithLibraryIds();
            await ComboBox2WithLibraryIds();
        }

        // To loading the library IDs in comboBox1
        private async Task ComboBox1WithLibraryIds()
        {
            try
            {
                List<int> libraryIds = await _couchbaseManager.GetLibraryIds();
                comboBox1.DataSource = libraryIds; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading library IDs: {ex.Message}");
            }
        }

        // To loading the library IDs in comboBox2
        private async Task ComboBox2WithLibraryIds()
        {
            try
            {
                List<int> libraryIds = await _couchbaseManager.GetLibraryIds();
                comboBox2.DataSource = libraryIds;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading library IDs: {ex.Message}");
            }
        }

        // When choice Create Librarian
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (radioButton1.Checked)
                {
                    button1.Visible = true;
                    label5.Visible = false;
                    label2.Visible = true;
                    label3.Visible = false;
                    label4.Visible = false;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    label11.Visible = true;
                    label12.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    label13.Visible = false;
                    label14.Visible = false;
                    button2.Visible = false;
                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    label15.Visible = false;
                    label16.Visible = false;
                    textBox8.Visible = false;
                    textBox9.Visible = false;
                    button3.Visible = false;
                    label17.Visible = false;
                    textBox10.Visible = false;
                    button4.Visible = false;
                    comboBox1.Visible = false;
                    label18.Visible = false;
                    label20.Visible = false;
                    dateTimePicker1.Visible = false;
                    label22.Visible = false;
                    label21.Visible = false;
                    textBox12.Visible = false;
                    radioButton5.Visible = false;
                    radioButton6.Visible = false;
                    radioButton7.Visible = false;
                    label24.Visible = false;
                    comboBox2.Visible = false;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        // When choice Create Library
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                button1.Visible = false;
                label5.Visible = false;
                label2.Visible = false;
                label3.Visible = true;
                label4.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                label13.Visible = true;
                label14.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                button2.Visible = true;
                label15.Visible = false;
                label16.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                button3.Visible = false;
                label17.Visible = false;
                textBox10.Visible = false;
                button4.Visible = false;
                comboBox1.Visible = false;
                label18.Visible = false;
                label20.Visible = true;
                dateTimePicker1.Visible = true;
                label22.Visible = true;
                label21.Visible = true;
                textBox12.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;
                radioButton7.Visible = true;
                label24.Visible = true;
                comboBox2.Visible = true;
            }
        }

        // When choice Create Catalog
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                button1.Visible = false;
                label5.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = true;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                button2.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                label15.Visible = true;
                label16.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                button3.Visible = true;
                label17.Visible = false;
                textBox10.Visible = false;
                button4.Visible = false;
                comboBox1.Visible = false;
                label18.Visible = false;
                label20.Visible = false;
                dateTimePicker1.Visible = false;
                label22.Visible = false;
                label21.Visible = false;
                textBox12.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                label24.Visible = false;
                comboBox2.Visible = false;
            }
        }

        // When choice Create Patron
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                button1.Visible = false;
                label5.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                button2.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                button3.Visible = false;
                label17.Visible = true;
                textBox10.Visible = true;
                button4.Visible = true;
                comboBox1.Visible = true;
                label18.Visible = true;
                label20.Visible = false;
                dateTimePicker1.Visible = false;
                label22.Visible = false;
                label21.Visible = false;
                textBox12.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                label24.Visible = false;
                comboBox2.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Button To Create Librarian
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Librariann l = new Librariann
                {
                    Name = textBox1.Text,
                    Username = textBox2.Text,
                    Password = Int32.Parse(textBox3.Text), 
                    Address = textBox4.Text,
                    Position = textBox5.Text
                };

                CouchbaseManager _couchbaseManager = new CouchbaseManager();
                 _couchbaseManager.CreateLibrarian(l);

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

                MessageBox.Show("Librarian created successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating librarian: {ex.Message}");
            }
        }

        //Button To Create Library
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Libraryy li = new Libraryy { name = textBox8.Text, address = textBox9.Text };
                CouchbaseManager _couchbaseManager = new CouchbaseManager();
                _couchbaseManager.CreateLibrary(li);

                textBox8.Text = "";
                textBox9.Text = ""; 

                MessageBox.Show("Library created successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating library: {ex.Message}");
            }
        }

        // Button To Create Catalog
        private async void button4_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                Catalog c1 = new Catalog { Name = textBox10.Text };
                c1.LibraryID = Convert.ToInt32(comboBox1.Text); 

                _couchbaseManager.CreateCatalog(c1);

                textBox10.Text = "";
                comboBox1.SelectedIndex = 0;

                MessageBox.Show("Catalog created successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating catalog: {ex.Message}");
            }
        }

        // Button To Create Patron
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Patronn p = new Patronn { name = textBox6.Text, address = textBox7.Text,
                    History = textBox12.Text,
                    Opened = dateTimePicker1.Value,
                    LibraryID = Convert.ToInt32(comboBox2.SelectedValue),
                    State = radioButton5.Checked ? radioButton5.Text : radioButton6.Checked ? radioButton6.Text : radioButton7.Text
                };

                _couchbaseManager.CreatePatron(p);

                textBox6.Text = "";
                textBox7.Text = "";
                textBox12.Text = "";
                dateTimePicker1.Value = DateTime.Now; 
                comboBox2.SelectedIndex = 0; 
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;

                MessageBox.Show("Patron created successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating patron: {ex.Message}");
            }
        }

        // Logout Button, when click go to Login form
        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }   
    }
}
