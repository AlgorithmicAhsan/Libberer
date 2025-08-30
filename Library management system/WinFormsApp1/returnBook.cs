using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class returnBook : Form
    {
        public returnBook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard c = new Dashboard();
            c.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bookName = textBox1.Text.Trim();
            string isbn = textBox2.Text.Trim();
            string author = textBox3.Text.Trim();
            string returnDate = textBox4.Text.Trim();

            // Check for empty fields
            if (string.IsNullOrWhiteSpace(bookName) || string.IsNullOrWhiteSpace(isbn) ||
                string.IsNullOrWhiteSpace(author) || string.IsNullOrWhiteSpace(returnDate))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string issuedPath = "E:\\coding\\Sem 4\\iteration 1 code\\WinFormsApp1\\WinFormsApp1\\issuedbooks.json";
            string booksPath = "E:\\coding\\Sem 4\\iteration 1 code\\WinFormsApp1\\WinFormsApp1\\books.json";

            var issuedJson = File.Exists(issuedPath) ? File.ReadAllText(issuedPath) : "{}";
            var bookJson = File.Exists(booksPath) ? File.ReadAllText(booksPath) : "{}";

            var issuedDict = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(issuedJson)
                             ?? new Dictionary<string, Dictionary<string, string>>();

            var booksDict = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(bookJson)
                            ?? new Dictionary<string, Dictionary<string, string>>();

            // Try to find the book in issued books
            var bookEntry = issuedDict.FirstOrDefault(entry =>
                entry.Value.TryGetValue("BookName", out string name) && name == bookName &&
                entry.Value.TryGetValue("ISBN", out string bIsbn) && bIsbn == isbn &&
                entry.Value.TryGetValue("Author", out string bAuthor) && bAuthor == author
            );

            if (!string.IsNullOrEmpty(bookEntry.Key))
            {
                // Move it back to books.json
                booksDict[bookEntry.Key] = bookEntry.Value;
                issuedDict.Remove(bookEntry.Key);

                // Write back to files
                File.WriteAllText(booksPath, JsonConvert.SerializeObject(booksDict, Formatting.Indented));
                File.WriteAllText(issuedPath, JsonConvert.SerializeObject(issuedDict, Formatting.Indented));

                MessageBox.Show("Book successfully returned!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFormFields();
            }
            else
            {
                MessageBox.Show("Book not found in issued list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
