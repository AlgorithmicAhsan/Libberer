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
using Newtonsoft.Json;

namespace Library_Management_System
{
    public partial class addBook : Form
    {
        public addBook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard M = new Dashboard();
            M.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Validation for Book Name (required)
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Book Name is required.");
                return;
            }

            // Validation for ISBN (must be numeric and 10 or 13 digits)
            if (string.IsNullOrWhiteSpace(textBox2.Text) || !textBox2.Text.All(char.IsDigit) || (textBox2.Text.Length != 10 && textBox2.Text.Length != 13))
            {
                MessageBox.Show("Please enter a valid ISBN (10 or 13 digits).");
                return;
            }

            // Validation for Author (required)
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Author is required.");
                return;
            }

            // Validation for Published Date (must be a valid date)
            if (dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("Published Date cannot be in the future.");
                return;
            }

            // Validation for Edition (optional, but must be numeric if entered)
            if (!string.IsNullOrWhiteSpace(textBox5.Text) && !textBox5.Text.All(char.IsDigit))
            {
                MessageBox.Show("Edition must be a valid number if entered.");
                return;
            }

            // Validation for Description (optional)
            if (richTextBox1.Text.Length > 500)
            {
                MessageBox.Show("Description is too long. Please limit it to 500 characters.");
                return;
            }

            // Generate a unique key for the book (e.g., a GUID)
            string bookId = Guid.NewGuid().ToString();

            // Create dictionary with form values
            var bookData = new Dictionary<string, string>
    {
        { "BookName", textBox1.Text },
        { "ISBN", textBox2.Text },
        { "Author", textBox3.Text },
        { "PublishedDate", dateTimePicker1.Value.ToString("yyyy-MM-dd") },
        { "Edition", textBox5.Text },
        { "Description", richTextBox1.Text }
    };

            string jsonFilePath = "E:\\coding\\Sem 4\\iteration 1 code\\WinFormsApp1\\WinFormsApp1\\books.json";

            Dictionary<string, Dictionary<string, string>> booksDict;

            // Load existing books if file exists
            if (File.Exists(jsonFilePath))
            {
                string existingJson = File.ReadAllText(jsonFilePath);
                booksDict = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(existingJson)
                            ?? new Dictionary<string, Dictionary<string, string>>();
            }
            else
            {
                booksDict = new Dictionary<string, Dictionary<string, string>>();
            }

            // Add new book with its unique ID
            booksDict[bookId] = bookData;

            // Save updated dictionary back to file
            string updatedJson = JsonConvert.SerializeObject(booksDict, Formatting.Indented);
            File.WriteAllText(jsonFilePath, updatedJson);

            MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearFormFields();
        }



        private void ClearFormFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            richTextBox1.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

    }
}
