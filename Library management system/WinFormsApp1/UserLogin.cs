using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Library_Management_System
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var username = textBox1.Text;
            var password = maskedTextBox1.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username or Password cannot be empty");
                return;
            }

            var jsonFilePath = "E:\\coding\\Sem 4\\iteration 1 code\\WinFormsApp1\\WinFormsApp1\\Credentials.json";

            if (!File.Exists(jsonFilePath))
            {
                MessageBox.Show("Path to Credentials.json not valid");
                return;
            }

            var jsonData = File.ReadAllText(jsonFilePath);
            var users = JsonConvert.DeserializeObject<List<User>>(jsonData);

            if (users == null)
            {
                MessageBox.Show("No users found in the credentials file");
                return;
            }

            if (users.Exists(user => user.Username == username && user.Password == password))
            {
                MessageBox.Show("Login Success!!!");
                Dashboard DB = new Dashboard();
                DB.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login denied!!!");
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            var registerForm = new UserRegister();
            registerForm.Show();
            this.Hide();
        }

        private void UserLogin_Load(object sender, EventArgs e) { }
    }
}