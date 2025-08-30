namespace Library_Management_System
{
    partial class UserRegister
    {

        private System.ComponentModel.IContainer components = null;


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
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.HideSelection = false;
            textBox1.Location = new Point(215, 262);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Username";
            textBox1.Size = new Size(179, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Username";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox_Enter;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.HideSelection = false;
            maskedTextBox1.Location = new Point(215, 295);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(179, 27);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.Text = "Password";
            maskedTextBox1.TextAlign = HorizontalAlignment.Center;
            maskedTextBox1.UseSystemPasswordChar = true;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            maskedTextBox1.Enter += maskedTextBox1_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = WinFormsApp1.Properties.Resources.download;
            pictureBox1.Location = new Point(187, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 244);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(215, 328);
            button2.Name = "button2";
            button2.Size = new Size(179, 29);
            button2.TabIndex = 4;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // UserRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 369);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UserRegister";
            Text = "UserLogin";
            Load += UserLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private PictureBox pictureBox1;
        private Button button2;
    }
}