using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Library_Management_System
{
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
        }

        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            username = textBox1.Text;
            password = maskedTextBox1.Text;

            string jsonFilePath = "C:\\Users\\Adam\\Downloads\\iteration 1 code\\WinFormsApp1\\WinFormsApp1\\Credentials.json";

            if (!File.Exists(jsonFilePath))
            {
                return;
            }

            string jsonData = File.ReadAllText(jsonFilePath);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonData);

            User newUser = new User
            {
                Username = username,
                Password = password
            };

            users.Add(newUser);
            string updatedJson = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(jsonFilePath, updatedJson);

            MessageBox.Show("Registered Successfully!");
            Dashboard DB = new Dashboard();
            DB.Show();
            this.Hide();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { }

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "Password")
            {
                maskedTextBox1.Text = "";
                maskedTextBox1.PasswordChar = '*';
            }
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
            }
        }

        private void UserLogin_Load(object sender, EventArgs e) { }
    }
}