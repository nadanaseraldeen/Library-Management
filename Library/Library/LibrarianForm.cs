using Microsoft.EntityFrameworkCore;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace Library
{
    // This is a Librarian form
    public partial class LibrarianForm : Form
    {
        private CouchbaseManager couchbaseManager;

        // Constructor
        public LibrarianForm()
        {
            InitializeComponent();
            couchbaseManager = new CouchbaseManager();
        }

        // When load Librarian form call this method to display the data in comboBox
        private async void LibrarianForm_Load(object sender, EventArgs e)
        {
            await ComboBox2WithCatalogIds();
            await ComboBox4WithLibraryIds();
            await ComboBox1WithBooksIds();
            await ComboBox6WithBooksIds();
            await ComboBox5WithPatronsIds();
            await ComboBox7WithPatronsIds();
            await ComboBox8WithLibraryIds();
            await ComboBox9WithAuthorNames();
        }

        // To loading the catalog IDs in comboBox2
        private async Task ComboBox2WithCatalogIds()
        {
            try
            {
                List<int> catalogIds = await couchbaseManager.GetCatalogIds();
                comboBox2.DataSource = catalogIds;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading catalog IDs: {ex.Message}");
            }
        }

        // To loading the library IDs in comboBox4
        private async Task ComboBox4WithLibraryIds()
        {
            try
            {
                List<int> libraryIds = await couchbaseManager.GetLibraryIds();
                comboBox4.DataSource = libraryIds;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading library IDs: {ex.Message}");
            }
        }

        // To loading the book IDs in comboBox1
        private async Task ComboBox1WithBooksIds()
        {
            try
            {
                List<int> bookIds = await couchbaseManager.GetBookIds();
                comboBox1.DataSource = bookIds;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading book IDs: {ex.Message}");
            }
        }

        // To loading the book IDs in comboBox6
        private async Task ComboBox6WithBooksIds()
        {
            try
            {
                List<int> bookIds = await couchbaseManager.GetBookIds();
                comboBox6.DataSource = bookIds;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading book IDs: {ex.Message}");
            }
        }

        // To loading the patron IDs in comboBox5
        private async Task ComboBox5WithPatronsIds()
        {
            try
            {
                List<int> patronIds = await couchbaseManager.GetPatronIds();
                comboBox5.DataSource = patronIds;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading patron IDs: {ex.Message}");
            }
        }

        // To loading the patron IDs in comboBox7
        private async Task ComboBox7WithPatronsIds()
        {
            try
            {
                List<int> patronIds = await couchbaseManager.GetPatronIds();
                comboBox7.DataSource = patronIds;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading patron IDs: {ex.Message}");
            }
        }

        // To loading the library IDs in comboBox8
        private async Task ComboBox8WithLibraryIds()
        {
            try
            {
                List<int> libraryIds = await couchbaseManager.GetLibraryIds();
                comboBox8.DataSource = libraryIds;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading library IDs: {ex.Message}");
            }
        }

        // To loading the author name in comboBox9
        private async Task ComboBox9WithAuthorNames()
        {
            try
            {
                List<string> authorNames = await couchbaseManager.GetAuthorNames();
                comboBox9.DataSource = authorNames;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading author names: {ex.Message}");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        // Button To Create Book
        private void button1_Click(object sender, EventArgs e)
        {
            BookItem b = new BookItem()
            {
                ISBN = textBox2.Text,
                Title = textBox3.Text,
                Summary = textBox4.Text,
                Publisher = textBox5.Text,
                Language = textBox6.Text,
                barcode = textBox7.Text,
                tag = Int32.Parse(textBox8.Text),
                NumberOfPage = Int32.Parse(textBox10.Text),
                PublicationDate = dateTimePicker1.Text,
                isReferenceOnly = textBox11.Text,
                CatalogID = Convert.ToInt32(comboBox2.Text),
                LibraryID = Convert.ToInt32(comboBox4.Text),
                AuthorName = textBox1.Text,
            };

            couchbaseManager.CreateBook(b);

            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
            textBox8.Text = " ";
            textBox10.Text = " ";
            textBox11.Text = " ";
            dateTimePicker1.Value = DateTime.Now;
            textBox10.Text = " ";
            comboBox2.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            textBox1.Text = " ";

            MessageBox.Show("Book created successfully.");
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Button To Update book
        private async void button2_Click(object sender, EventArgs e)
        {
            string selectedBookId = comboBox1.Text;
            var document = await couchbaseManager.GetDocumentUpdateById(selectedBookId);

            if (document != null)
            {
                BookItem b = new BookItem()
                {
                    BookID = Int32.Parse(comboBox1.Text),
                    ISBN = textBox2.Text,
                    Title = textBox3.Text,
                    Summary = textBox4.Text,
                    Publisher = textBox5.Text,
                    Language = textBox6.Text,
                    barcode = textBox7.Text,
                    tag = Int32.Parse(textBox8.Text),
                    NumberOfPage = Int32.Parse(textBox10.Text),
                    PublicationDate = dateTimePicker1.Text,
                    isReferenceOnly = textBox11.Text,
                    CatalogID = Convert.ToInt32(comboBox2.Text),
                    LibraryID = Convert.ToInt32(comboBox4.Text),
                    AuthorName = textBox1.Text
                };

                await couchbaseManager.UpdateDocument(selectedBookId, b);

                comboBox1.SelectedIndex = 0;
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox10.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                textBox11.Text = "";
                comboBox2.SelectedIndex = 0;
                comboBox4.SelectedIndex = 0;
                textBox1.Text = "";

                MessageBox.Show($"Book with ID: {selectedBookId} updated.");
            }
            else
            {
                MessageBox.Show($"Book with ID {selectedBookId} not found.");
            }
        }

        // Button To Remove Book
        private async void button3_Click(object sender, EventArgs e)
        {
            string selectedBookId = comboBox1.Text;
            CouchbaseManager couchbaseManager = new CouchbaseManager();
            var result = await couchbaseManager.GetDocumentRemById(selectedBookId);

            if (result != null)
            {
                await couchbaseManager.RemoveDocument(selectedBookId);
                MessageBox.Show($"Book with ID: {selectedBookId} removed");
            }
            else
            {
                Console.WriteLine($"Book with ID {selectedBookId} not found.");
            }
        }

        // Button To Search Book
        private async void button4_Click(object sender, EventArgs e)
        {
            string bookTitleOrISBN = textBox12.Text;
            var bookExists = await couchbaseManager.BookExists(bookTitleOrISBN);

            if (bookExists)
            {
                MessageBox.Show("This book exists");
            }
            else
            {
                MessageBox.Show("This book does not exist");
            }
        }

        // Button to display the author name of a specific book 
        private async void button5_Click(object sender, EventArgs e)
        {
            string bookID = comboBox1.Text;
            var authors = await couchbaseManager.GetAuthorForBook(bookID);

            if (authors != null && authors.Any())
            {
                listBox1.DataSource = authors;
                listBox1.Refresh();
            }

            else
            {
                listBox1.DataSource = null;
                MessageBox.Show("Authors not found for the selected book.");
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        // Button to display book titles in English
        private async void button7_Click(object sender, EventArgs e)
        {
            var englishTitles = await couchbaseManager.GetEnglishBookTitles();
            if (englishTitles != null && englishTitles.Any())
            {
                listBox3.DataSource = englishTitles;
                listBox3.Refresh();
            }
            else
            {
                listBox3.DataSource = null;
                MessageBox.Show("Titles not found");
            }
        }

        // Button to display patron names
        private async void button8_ClickAsync(object sender, EventArgs e)
        {
            var patronNames = await couchbaseManager.GetPatronNames();

            if (patronNames != null && patronNames.Any())
            {
                listBox4.DataSource = patronNames;
                listBox4.Refresh();
            }
            else
            {
                listBox1.DataSource = null;
                MessageBox.Show("Patron names not found.");
            }
        }

        // Button to display the names of patrons whose account status is frozen
        private async void button9_Click(object sender, EventArgs e)
        {
            List<string> namesFrozen = await couchbaseManager.GetFrozenPatronNames();
            listBox5.DataSource = namesFrozen;
        }

        private void Patron_Click(object sender, EventArgs e)
        {

        }

        // Button to borrow a book
        private async void button10_Click(object sender, EventArgs e)
        {
            string bookId = comboBox6.Text;
            string patronId = comboBox5.Text;
            await couchbaseManager.UpdateBorrowDocument(bookId, patronId);
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        // Button to un-borrow a book
        private async void button13_Click(object sender, EventArgs e)
        {
            string bookId = comboBox6.Text;
            await couchbaseManager.UnborrowDocument(bookId);
        }

        // Button To Update patron
        private async void button12_Click(object sender, EventArgs e)
        {
            string selectedPatronId = comboBox7.Text;
            var document = await couchbaseManager.GetDocumentPatronUpdateById(selectedPatronId);

            if (document != null)
            {
                Patronn p = new Patronn()
                {
                    ID = Int32.Parse(comboBox7.Text),
                    name = textBox14.Text,
                    address = textBox15.Text,
                    LibraryID = Int32.Parse(comboBox8.Text),
                    History = textBox13.Text,
                    Opened = dateTimePicker2.Value
                };
                if (radioButton1.Checked)
                {
                    p.State = radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {
                    p.State = radioButton2.Text;
                }
                else if (radioButton3.Checked)
                {
                    p.State = radioButton3.Text;
                }

                await couchbaseManager.UpdatePatronDocument(selectedPatronId, p);

                textBox14.Text = "";
                textBox15.Text = "";
                comboBox8.SelectedIndex = 0;
                textBox13.Text = "";
                dateTimePicker2.Value = DateTime.Now;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;

                MessageBox.Show($"Patron with ID: {selectedPatronId} updated.");
            }
            else
            {
                MessageBox.Show($"Patron with ID {selectedPatronId} not found.");
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Buttonto to display the title of books by a specific author
        private async void button11_Click_1(object sender, EventArgs e)
        {
            string selectAuthorName = comboBox9.Text;
            List<string> booksName = await couchbaseManager.GetBooksByAuthor(selectAuthorName);
            listBox6.DataSource = booksName;
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Logout Button, when click go to Login form
        private void button14_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        // Logout Button, when click go to Login form
        private void Logout_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}
