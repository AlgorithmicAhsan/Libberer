namespace Library_Management_System
{
    partial class Dashboard
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
            menuStrip1 = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            aboutUsToolStripMenuItem = new ToolStripMenuItem();
            contactUsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            askQuestionToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            button5 = new Button();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Orange;
            menuStrip1.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, aboutUsToolStripMenuItem, contactUsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1199, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(84, 26);
            booksToolStripMenuItem.Text = "Books";
            // 
            // aboutUsToolStripMenuItem
            // 
            aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            aboutUsToolStripMenuItem.Size = new Size(112, 26);
            aboutUsToolStripMenuItem.Text = "About us";
            // 
            // contactUsToolStripMenuItem
            // 
            contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            contactUsToolStripMenuItem.Size = new Size(132, 26);
            contactUsToolStripMenuItem.Text = "Contact us";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { askQuestionToolStripMenuItem, exitToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(69, 26);
            helpToolStripMenuItem.Text = "Help";
            // 
            // askQuestionToolStripMenuItem
            // 
            askQuestionToolStripMenuItem.Name = "askQuestionToolStripMenuItem";
            askQuestionToolStripMenuItem.Size = new Size(213, 26);
            askQuestionToolStripMenuItem.Text = "Ask question";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(213, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // button1
            // 
            button1.Font = new Font("Elephant", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(186, 71);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(696, 52);
            button1.TabIndex = 1;
            button1.Text = "Add book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(186, 370);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(696, 46);
            button2.TabIndex = 2;
            button2.Text = "Add member";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Elephant", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(186, 178);
            button3.Margin = new Padding(4, 4, 4, 4);
            button3.Name = "button3";
            button3.Size = new Size(696, 52);
            button3.TabIndex = 5;
            button3.Text = "Issue book";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Elephant", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(186, 278);
            button4.Margin = new Padding(4, 4, 4, 4);
            button4.Name = "button4";
            button4.Size = new Size(696, 56);
            button4.TabIndex = 6;
            button4.Text = "Return book";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PapayaWhip;
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button4);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(206, 64);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(1102, 563);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(393, 38);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(591, 23);
            textBox1.TabIndex = 9;
            textBox1.Text = "Search for book by title";
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += search_Enter;
            // 
            // button5
            // 
            button5.Location = new Point(989, 38);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(101, 22);
            button5.TabIndex = 10;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1199, 562);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Dashboard";
            Text = "mainDashboard";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem askQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private TextBox textBox1;
        private Button button5;
    }
}