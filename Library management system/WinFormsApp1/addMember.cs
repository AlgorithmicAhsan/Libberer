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
    public partial class addMember : Form
    {
        public addMember()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard B = new Dashboard();
            B.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validation for Full Name (required)
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Full Name is required.");
                return;
            }

            // Validation for Address (required)
            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                MessageBox.Show("Address is required.");
                return;
            }

            // Validation for DOB (must be a valid date and not in the future)
            if (dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("DOB cannot be in the future.");
                return;
            }

            // Validation for Gender (must be selected)
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Please select a gender.");
                return;
            }

            // Validation for Phone Number (required and numeric)
            if (string.IsNullOrWhiteSpace(textBox2.Text) || !textBox2.Text.All(char.IsDigit))
            {
                MessageBox.Show("Phone number is required and must be numeric.");
                return;
            }

            // Validation for Email (must be in a valid email format)
            if (string.IsNullOrWhiteSpace(textBox3.Text) || !IsValidEmail(textBox3.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            // Validation for Occupation (optional, but if entered, must be a valid string)
            if (!string.IsNullOrWhiteSpace(textBox4.Text) && textBox4.Text.Length > 100)
            {
                MessageBox.Show("Occupation description is too long. Please limit it to 100 characters.");
                return;
            }

            // Determine selected gender
            string gender = radioButton1.Checked ? "Male" :
                            radioButton2.Checked ? "Female" : "Unspecified";

            // Create a dictionary to hold member data
            var memberData = new Dictionary<string, string>
    {
        { "FullName", textBox1.Text },
        { "Address", richTextBox1.Text },
        { "DOB", dateTimePicker1.Value.ToString("yyyy-MM-dd") },
        { "Gender", gender },
        { "Phone", textBox2.Text },
        { "Email", textBox3.Text },
        { "Occupation", textBox4.Text }
    };

            // Generate unique Member ID
            string memberId = Guid.NewGuid().ToString();

            // Define path for JSON file
            string jsonFilePath = "E:\\coding\\Sem 4\\iteration 1 code\\WinFormsApp1\\WinFormsApp1\\members.json";

            // Load existing members
            Dictionary<string, Dictionary<string, string>> membersDict;
            if (File.Exists(jsonFilePath))
            {
                string existingJson = File.ReadAllText(jsonFilePath);
                membersDict = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(existingJson)
                              ?? new Dictionary<string, Dictionary<string, string>>();
            }
            else
            {
                membersDict = new Dictionary<string, Dictionary<string, string>>();
            }

            // Add new member to the dictionary
            membersDict[memberId] = memberData;

            // Write updated data to file
            string updatedJson = JsonConvert.SerializeObject(membersDict, Formatting.Indented);
            File.WriteAllText(jsonFilePath, updatedJson);

            // Show confirmation
            MessageBox.Show("Member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Optional: clear form
            ClearFormFields();
        }

        // Helper method to validate email format
        private bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return mail.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void ClearFormFields()
        {
            textBox1.Clear();
            richTextBox1.Clear();
            dateTimePicker1.Value = DateTime.Now;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

    }
}
