using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Library_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addMember A = new addMember();
            A.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addBook D = new addBook();
            D.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            issueBook i = new issueBook();
            i.Show();
            this.Hide();
        }

        private void search_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            var title = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Please enter a book title.");
                return;
            }

            string filePath = "E:\\coding\\Sem 4\\iteration 1 code\\WinFormsApp1\\WinFormsApp1\\books.json";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("books.json not found.");
                return;
            }

            string jsonData = File.ReadAllText(filePath);
            var books = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(jsonData);

            var found = books.Values.FirstOrDefault(book =>
                book.TryGetValue("BookName", out string name) &&
                name.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (found != null)
            {
                string info = string.Join(Environment.NewLine, found.Select(kvp => $"{kvp.Key}: {kvp.Value}"));
                MessageBox.Show(info, "Book Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Book not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            returnBook r = new returnBook();
            r.Show();
            this.Hide();
        }
    }
}
