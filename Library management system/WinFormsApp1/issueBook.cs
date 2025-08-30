using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Library_Management_System
{
    public partial class issueBook : Form
    {
        public issueBook()
        {
            InitializeComponent();
            button2.Click += button2_Click; // Hook up OK button
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard c = new Dashboard();
            c.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Step 1: Validate fields
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string bookName = textBox1.Text.Trim();
            string isbn = textBox2.Text.Trim();
            string author = textBox3.Text.Trim();
            string issueDate = textBox4.Text.Trim();

            string booksFile = "E:\\coding\\Sem 4\\iteration 1 code\\WinFormsApp1\\WinFormsApp1\\books.json";
            string issuedBooksFile = "E:\\coding\\Sem 4\\iteration 1 code\\WinFormsApp1\\WinFormsApp1\\issuedbooks.json";

            if (!File.Exists(booksFile))
            {
                MessageBox.Show("books.json not found.");
                return;
            }

            // Step 2: Load books.json
            var booksData = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(File.ReadAllText(booksFile));

            // Step 3: Try to find a matching book
            var matchingBook = booksData.FirstOrDefault(b =>
                b.Value.TryGetValue("BookName", out var bn) && bn == bookName &&
                b.Value.TryGetValue("ISBN", out var isb) && isb == isbn &&
                b.Value.TryGetValue("Author", out var auth) && auth == author
            );

            if (matchingBook.Key == null)
            {
                MessageBox.Show("Book not found in library.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Step 4: Load issuedbooks.json
            Dictionary<string, Dictionary<string, string>> issuedBooksData = new();
            if (File.Exists(issuedBooksFile))
            {
                issuedBooksData = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(File.ReadAllText(issuedBooksFile));
            }

            // Step 5: Move book to issuedbooks.json
            issuedBooksData[matchingBook.Key] = matchingBook.Value;
            booksData.Remove(matchingBook.Key);

            File.WriteAllText(booksFile, JsonConvert.SerializeObject(booksData, Formatting.Indented));
            File.WriteAllText(issuedBooksFile, JsonConvert.SerializeObject(issuedBooksData, Formatting.Indented));

            MessageBox.Show("Book successfully issued!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFormFields();
        }

        private void ClearFormFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
