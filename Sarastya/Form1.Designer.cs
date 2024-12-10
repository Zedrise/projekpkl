namespace Sarastya
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            txt_username = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(txt_username);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-4, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(807, 453);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(769, 9);
            label8.Name = "label8";
            label8.Size = new Size(23, 25);
            label8.TabIndex = 18;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(558, 405);
            label5.Name = "label5";
            label5.Size = new Size(131, 22);
            label5.TabIndex = 9;
            label5.Text = "Register here";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveBorder;
            label4.Location = new Point(346, 405);
            label4.Name = "label4";
            label4.Size = new Size(206, 25);
            label4.TabIndex = 8;
            label4.Text = "Don't have any account?";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = SystemColors.ActiveBorder;
            checkBox1.Location = new Point(630, 290);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(165, 26);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.ForeColor = Color.White;
            button1.Location = new Point(504, 324);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(309, 210);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(309, 239);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(483, 46);
            textBox2.TabIndex = 4;
            // 
            // txt_username
            // 
            txt_username.Cursor = Cursors.IBeam;
            txt_username.Location = new Point(309, 135);
            txt_username.Multiline = true;
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(483, 46);
            txt_username.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(309, 110);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14F);
            label1.Location = new Point(309, 50);
            label1.Name = "label1";
            label1.Size = new Size(243, 35);
            label1.TabIndex = 1;
            label1.Text = "Welcome Back!";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(3, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 450);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(78, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(81, 256);
            label7.Name = "label7";
            label7.Size = new Size(119, 29);
            label7.TabIndex = 1;
            label7.Text = "Academy";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(36, 227);
            label6.Name = "label6";
            label6.Size = new Size(221, 29);
            label6.TabIndex = 0;
            label6.Text = "Sarastya Intership";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox txt_username;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label8;
    }
}
