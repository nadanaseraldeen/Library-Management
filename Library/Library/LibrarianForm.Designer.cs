

namespace Library
{
    partial class LibrarianForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            Book = new TabPage();
            panel2 = new Panel();
            textBox12 = new TextBox();
            Logout = new Button();
            label22 = new Label();
            listBox3 = new ListBox();
            label20 = new Label();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            label11 = new Label();
            comboBox4 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label14 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button7 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label12 = new Label();
            label10 = new Label();
            textBox2 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ISBN = new Label();
            Patron = new TabPage();
            panel1 = new Panel();
            comboBox9 = new ComboBox();
            label18 = new Label();
            label17 = new Label();
            textBox15 = new TextBox();
            label16 = new Label();
            textBox14 = new TextBox();
            label23 = new Label();
            radioButton3 = new RadioButton();
            listBox6 = new ListBox();
            radioButton2 = new RadioButton();
            button11 = new Button();
            radioButton1 = new RadioButton();
            label30 = new Label();
            label31 = new Label();
            dateTimePicker2 = new DateTimePicker();
            button12 = new Button();
            label29 = new Label();
            textBox13 = new TextBox();
            label28 = new Label();
            comboBox8 = new ComboBox();
            label26 = new Label();
            comboBox7 = new ComboBox();
            label27 = new Label();
            comboBox6 = new ComboBox();
            label15 = new Label();
            comboBox5 = new ComboBox();
            listBox5 = new ListBox();
            label25 = new Label();
            label24 = new Label();
            listBox4 = new ListBox();
            button14 = new Button();
            button13 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            label13 = new Label();
            tabControl1.SuspendLayout();
            Book.SuspendLayout();
            panel2.SuspendLayout();
            Patron.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(Book);
            tabControl1.Controls.Add(Patron);
            tabControl1.Dock = DockStyle.Top;
            tabControl1.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1048, 475);
            tabControl1.TabIndex = 0;
            tabControl1.Click += radioButton1_CheckedChanged;
            // 
            // Book
            // 
            Book.BackColor = Color.White;
            Book.BackgroundImage = Properties.Resources._82;
            Book.BackgroundImageLayout = ImageLayout.Stretch;
            Book.Controls.Add(panel2);
            Book.ForeColor = Color.Goldenrod;
            Book.Location = new Point(4, 35);
            Book.Name = "Book";
            Book.Padding = new Padding(3);
            Book.Size = new Size(1040, 436);
            Book.TabIndex = 0;
            Book.Text = "Book";
            Book.Click += radioButton1_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox12);
            panel2.Controls.Add(Logout);
            panel2.Controls.Add(label22);
            panel2.Controls.Add(listBox3);
            panel2.Controls.Add(label20);
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(comboBox4);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox11);
            panel2.Controls.Add(textBox10);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(ISBN);
            panel2.Location = new Point(-4, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(1048, 310);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // textBox12
            // 
            textBox12.Font = new Font("Constantia", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox12.Location = new Point(36, 7);
            textBox12.Name = "textBox12";
            textBox12.PlaceholderText = "Search for a book by title or ISBN";
            textBox12.Size = new Size(780, 28);
            textBox12.TabIndex = 53;
            textBox12.TextChanged += textBox12_TextChanged;
            // 
            // Logout
            // 
            Logout.BackColor = Color.Goldenrod;
            Logout.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Logout.ForeColor = Color.Black;
            Logout.Location = new Point(402, 274);
            Logout.Name = "Logout";
            Logout.Size = new Size(125, 33);
            Logout.TabIndex = 36;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = false;
            Logout.Click += Logout_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.Black;
            label22.Location = new Point(594, 176);
            label22.Name = "label22";
            label22.Size = new Size(191, 38);
            label22.TabIndex = 51;
            label22.Text = "Names of books written\r\n            in English";
            label22.Click += label22_Click;
            // 
            // listBox3
            // 
            listBox3.DisplayMember = "h";
            listBox3.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 19;
            listBox3.Location = new Point(811, 162);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(230, 118);
            listBox3.TabIndex = 50;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(594, 49);
            label20.Name = "label20";
            label20.Size = new Size(210, 38);
            label20.TabIndex = 46;
            label20.Text = "Author name for a specific\r\n                book ID";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(811, 46);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(230, 99);
            listBox1.TabIndex = 45;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(423, 180);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 27);
            textBox1.TabIndex = 43;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(282, 183);
            label11.Name = "label11";
            label11.Size = new Size(63, 19);
            label11.TabIndex = 41;
            label11.Text = "Author";
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(423, 244);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(156, 27);
            comboBox4.TabIndex = 39;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(423, 213);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(156, 27);
            comboBox2.TabIndex = 38;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(110, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(156, 27);
            comboBox1.TabIndex = 37;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(12, 49);
            label14.Name = "label14";
            label14.Size = new Size(73, 19);
            label14.TabIndex = 34;
            label14.Text = "Book ID";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(423, 113);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(156, 27);
            dateTimePicker1.TabIndex = 33;
            // 
            // button7
            // 
            button7.BackColor = Color.RosyBrown;
            button7.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(626, 226);
            button7.Name = "button7";
            button7.Size = new Size(147, 31);
            button7.TabIndex = 32;
            button7.Text = "English Books";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkSalmon;
            button5.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(626, 101);
            button5.Name = "button5";
            button5.Size = new Size(147, 31);
            button5.TabIndex = 30;
            button5.Text = "Name of Author";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.CornflowerBlue;
            button4.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(832, 7);
            button4.Name = "button4";
            button4.Size = new Size(185, 30);
            button4.TabIndex = 29;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(271, 274);
            button3.Name = "button3";
            button3.Size = new Size(125, 33);
            button3.TabIndex = 28;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSteelBlue;
            button2.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(140, 274);
            button2.Name = "button2";
            button2.Size = new Size(125, 33);
            button2.TabIndex = 27;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Peru;
            button1.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(7, 274);
            button1.Name = "button1";
            button1.Size = new Size(127, 33);
            button1.TabIndex = 26;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox11
            // 
            textBox11.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox11.Location = new Point(423, 147);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(156, 27);
            textBox11.TabIndex = 23;
            // 
            // textBox10
            // 
            textBox10.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox10.Location = new Point(423, 81);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(156, 27);
            textBox10.TabIndex = 22;
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.Location = new Point(423, 46);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(156, 27);
            textBox8.TabIndex = 20;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(110, 243);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(156, 27);
            textBox7.TabIndex = 19;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(110, 210);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(156, 27);
            textBox6.TabIndex = 18;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(110, 176);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(156, 27);
            textBox5.TabIndex = 17;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(110, 143);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(156, 27);
            textBox4.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(110, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(156, 27);
            textBox3.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(282, 247);
            label12.Name = "label12";
            label12.Size = new Size(87, 19);
            label12.TabIndex = 14;
            label12.Text = "Library ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(282, 213);
            label10.Name = "label10";
            label10.Size = new Size(91, 19);
            label10.TabIndex = 12;
            label10.Text = "Catalog ID";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(110, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 27);
            textBox2.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(282, 150);
            label9.Name = "label9";
            label9.Size = new Size(132, 19);
            label9.TabIndex = 10;
            label9.Text = "Is Refrence only";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(282, 49);
            label8.Name = "label8";
            label8.Size = new Size(36, 19);
            label8.TabIndex = 9;
            label8.Text = "Tag";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(12, 247);
            label7.Name = "label7";
            label7.Size = new Size(73, 19);
            label7.TabIndex = 8;
            label7.Text = "Barcode";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(12, 213);
            label6.Name = "label6";
            label6.Size = new Size(83, 19);
            label6.TabIndex = 7;
            label6.Text = "Language";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(282, 84);
            label5.Name = "label5";
            label5.Size = new Size(135, 19);
            label5.TabIndex = 6;
            label5.Text = "Number Of Page";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(282, 118);
            label4.Name = "label4";
            label4.Size = new Size(138, 19);
            label4.TabIndex = 5;
            label4.Text = "Publication Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 179);
            label3.Name = "label3";
            label3.Size = new Size(82, 19);
            label3.TabIndex = 4;
            label3.Text = "Publisher";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 146);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 3;
            label2.Text = "Summary";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 113);
            label1.Name = "label1";
            label1.Size = new Size(44, 19);
            label1.TabIndex = 2;
            label1.Text = "Title";
            // 
            // ISBN
            // 
            ISBN.AutoSize = true;
            ISBN.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ISBN.ForeColor = Color.Black;
            ISBN.Location = new Point(12, 81);
            ISBN.Name = "ISBN";
            ISBN.Size = new Size(46, 19);
            ISBN.TabIndex = 0;
            ISBN.Text = "ISBN";
            // 
            // Patron
            // 
            Patron.BackColor = Color.White;
            Patron.BackgroundImage = Properties.Resources._81;
            Patron.BackgroundImageLayout = ImageLayout.Stretch;
            Patron.Controls.Add(panel1);
            Patron.ForeColor = Color.Goldenrod;
            Patron.Location = new Point(4, 35);
            Patron.Name = "Patron";
            Patron.Padding = new Padding(3);
            Patron.Size = new Size(1040, 436);
            Patron.TabIndex = 1;
            Patron.Text = "Patron";
            Patron.Click += Patron_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox9);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(textBox15);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(textBox14);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(listBox6);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(label30);
            panel1.Controls.Add(label31);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(button12);
            panel1.Controls.Add(label29);
            panel1.Controls.Add(textBox13);
            panel1.Controls.Add(label28);
            panel1.Controls.Add(comboBox8);
            panel1.Controls.Add(label26);
            panel1.Controls.Add(comboBox7);
            panel1.Controls.Add(label27);
            panel1.Controls.Add(comboBox6);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(comboBox5);
            panel1.Controls.Add(listBox5);
            panel1.Controls.Add(label25);
            panel1.Controls.Add(label24);
            panel1.Controls.Add(listBox4);
            panel1.Controls.Add(button14);
            panel1.Controls.Add(button13);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(label13);
            panel1.Location = new Point(-4, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 339);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // comboBox9
            // 
            comboBox9.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox9.FormattingEnabled = true;
            comboBox9.Location = new Point(414, 198);
            comboBox9.Name = "comboBox9";
            comboBox9.Size = new Size(153, 27);
            comboBox9.TabIndex = 43;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(282, 167);
            label18.Name = "label18";
            label18.Size = new Size(285, 19);
            label18.TabIndex = 42;
            label18.Text = "Names of books by a specific author";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(282, 14);
            label17.Name = "label17";
            label17.Size = new Size(297, 19);
            label17.TabIndex = 41;
            label17.Text = "Borrow a book for a particular patron";
            // 
            // textBox15
            // 
            textBox15.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox15.Location = new Point(105, 80);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(153, 27);
            textBox15.TabIndex = 40;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(7, 83);
            label16.Name = "label16";
            label16.Size = new Size(70, 19);
            label16.TabIndex = 39;
            label16.Text = "Address";
            // 
            // textBox14
            // 
            textBox14.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox14.Location = new Point(105, 47);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(153, 27);
            textBox14.TabIndex = 38;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.Black;
            label23.Location = new Point(7, 50);
            label23.Name = "label23";
            label23.Size = new Size(54, 19);
            label23.TabIndex = 37;
            label23.Text = "Name";
            label23.Click += label23_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.ForeColor = Color.Black;
            radioButton3.Location = new Point(104, 251);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(74, 23);
            radioButton3.TabIndex = 35;
            radioButton3.Text = "Closed";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // listBox6
            // 
            listBox6.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox6.FormattingEnabled = true;
            listBox6.ItemHeight = 19;
            listBox6.Location = new Point(287, 231);
            listBox6.Name = "listBox6";
            listBox6.Size = new Size(280, 61);
            listBox6.TabIndex = 36;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.ForeColor = Color.Black;
            radioButton2.Location = new Point(182, 220);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(76, 23);
            radioButton2.TabIndex = 34;
            radioButton2.Text = "Frozen";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.BackColor = Color.SteelBlue;
            button11.Font = new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button11.ForeColor = Color.Black;
            button11.Location = new Point(349, 298);
            button11.Name = "button11";
            button11.Size = new Size(155, 32);
            button11.TabIndex = 35;
            button11.Text = "Names of books";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click_1;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.Black;
            radioButton1.Location = new Point(104, 222);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(72, 23);
            radioButton1.TabIndex = 33;
            radioButton1.TabStop = true;
            radioButton1.Text = "Active";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label30.ForeColor = Color.Black;
            label30.Location = new Point(7, 222);
            label30.Name = "label30";
            label30.Size = new Size(72, 38);
            label30.TabIndex = 32;
            label30.Text = "Account\r\n  State";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label31.ForeColor = Color.Black;
            label31.Location = new Point(282, 201);
            label31.Name = "label31";
            label31.Size = new Size(127, 19);
            label31.TabIndex = 32;
            label31.Text = "Authors' names";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Location = new Point(105, 179);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(153, 27);
            dateTimePicker2.TabIndex = 31;
            // 
            // button12
            // 
            button12.BackColor = Color.MediumAquamarine;
            button12.Font = new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button12.ForeColor = Color.Black;
            button12.Location = new Point(53, 288);
            button12.Name = "button12";
            button12.Size = new Size(146, 32);
            button12.TabIndex = 13;
            button12.Text = "Update account";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label29.ForeColor = Color.Black;
            label29.Location = new Point(7, 184);
            label29.Name = "label29";
            label29.Size = new Size(70, 19);
            label29.TabIndex = 30;
            label29.Text = "Opened";
            // 
            // textBox13
            // 
            textBox13.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox13.Location = new Point(105, 146);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(153, 27);
            textBox13.TabIndex = 29;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label28.ForeColor = Color.Black;
            label28.Location = new Point(7, 149);
            label28.Name = "label28";
            label28.Size = new Size(65, 19);
            label28.TabIndex = 28;
            label28.Text = "History";
            // 
            // comboBox8
            // 
            comboBox8.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox8.FormattingEnabled = true;
            comboBox8.Location = new Point(105, 113);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(153, 27);
            comboBox8.TabIndex = 27;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label26.ForeColor = Color.Black;
            label26.Location = new Point(7, 116);
            label26.Name = "label26";
            label26.Size = new Size(87, 19);
            label26.TabIndex = 26;
            label26.Text = "Library ID";
            // 
            // comboBox7
            // 
            comboBox7.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(105, 14);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(153, 27);
            comboBox7.TabIndex = 25;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label27.ForeColor = Color.Black;
            label27.Location = new Point(7, 17);
            label27.Name = "label27";
            label27.Size = new Size(84, 19);
            label27.TabIndex = 24;
            label27.Text = "Patron ID";
            // 
            // comboBox6
            // 
            comboBox6.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(395, 83);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(153, 27);
            comboBox6.TabIndex = 22;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(296, 83);
            label15.Name = "label15";
            label15.Size = new Size(73, 19);
            label15.TabIndex = 21;
            label15.Text = "Book ID";
            // 
            // comboBox5
            // 
            comboBox5.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(395, 47);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(153, 27);
            comboBox5.TabIndex = 20;
            // 
            // listBox5
            // 
            listBox5.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 19;
            listBox5.Location = new Point(803, 137);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(233, 137);
            listBox5.TabIndex = 19;
            listBox5.SelectedIndexChanged += listBox5_SelectedIndexChanged;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label25.ForeColor = Color.Black;
            label25.Location = new Point(606, 146);
            label25.Name = "label25";
            label25.Size = new Size(179, 57);
            label25.TabIndex = 18;
            label25.Text = "  Names of patrons \r\nwhose account state is\r\n            Frozen";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = Color.Black;
            label24.Location = new Point(606, 37);
            label24.Name = "label24";
            label24.Size = new Size(167, 19);
            label24.TabIndex = 17;
            label24.Text = "All names of patrons";
            // 
            // listBox4
            // 
            listBox4.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 19;
            listBox4.Location = new Point(803, 17);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(233, 99);
            listBox4.TabIndex = 16;
            listBox4.SelectedIndexChanged += listBox4_SelectedIndexChanged_1;
            // 
            // button14
            // 
            button14.BackColor = Color.Goldenrod;
            button14.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button14.ForeColor = Color.Black;
            button14.Location = new Point(905, 298);
            button14.Name = "button14";
            button14.Size = new Size(133, 32);
            button14.TabIndex = 15;
            button14.Text = "Logout";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.Gold;
            button13.Font = new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button13.ForeColor = Color.Black;
            button13.Location = new Point(415, 122);
            button13.Name = "button13";
            button13.Size = new Size(153, 32);
            button13.TabIndex = 14;
            button13.Text = "Un-Borrow a book";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.OliveDrab;
            button10.Font = new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = Color.Black;
            button10.Location = new Point(282, 122);
            button10.Name = "button10";
            button10.Size = new Size(127, 32);
            button10.TabIndex = 11;
            button10.Text = "Borrow a book";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.RosyBrown;
            button9.Font = new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = Color.Black;
            button9.Location = new Point(620, 216);
            button9.Name = "button9";
            button9.Size = new Size(143, 32);
            button9.TabIndex = 10;
            button9.Text = "Names of patrons\r\n";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.LightSalmon;
            button8.Font = new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.Black;
            button8.Location = new Point(620, 70);
            button8.Name = "button8";
            button8.Size = new Size(143, 32);
            button8.TabIndex = 9;
            button8.Text = "Names of patrons";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_ClickAsync;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(296, 50);
            label13.Name = "label13";
            label13.Size = new Size(84, 19);
            label13.TabIndex = 1;
            label13.Text = "Patron ID";
            label13.Click += label13_Click;
            // 
            // LibrarianForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1048, 474);
            Controls.Add(tabControl1);
            Name = "LibrarianForm";
            Text = "LibrarianForm";
            Load += LibrarianForm_Load;
            tabControl1.ResumeLayout(false);
            Book.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            Patron.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }





        #endregion

        private TabControl tabControl1;
        private TabPage Book;
        private TabPage Patron;
        private Panel panel2;
        private Panel panel1;
        private Label ISBN;
        private TextBox textBox2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button7;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label12;
        private Label label10;
        private Label label13;
        private Label label14;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox17;
        private TextBox textBox16;
        private TextBox textBox14;
        private Label label17;
        private Label label16;
        private Button button13;
        private Button button12;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button Logout;
        private Button button14;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox4;
        private TextBox textBox1;
        private Label label11;
        private Label label20;
        private ListBox listBox1;
        private ListBox listBox3;
        private Label label22;
        private TextBox textBox12;
        private Label label24;
        private ListBox listBox4;
        private ListBox listBox5;
        private Label label25;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private Label label15;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label30;
        private DateTimePicker dateTimePicker2;
        private Label label29;
        private TextBox textBox13;
        private Label label28;
        private ComboBox comboBox8;
        private Label label26;
        private ComboBox comboBox7;
        private Label label27;
        private ListBox listBox6;
        private Button button11;
        private ComboBox comboBox9;
        private Label label31;
        private Label label23;
        private TextBox textBox15;
        private Label label18;
    }
}