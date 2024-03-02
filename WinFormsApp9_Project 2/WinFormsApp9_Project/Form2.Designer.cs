namespace WinFormsApp9_Project
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(189, 59);
            label1.Name = "label1";
            label1.Size = new Size(95, 18);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(189, 113);
            label2.Name = "label2";
            label2.Size = new Size(101, 18);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Elephant", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(290, 56);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Elephant", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(290, 104);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(132, 27);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(250, 188);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(202, 43);
            button1.TabIndex = 4;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Elephant", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(290, 157);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(132, 27);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(111, 160);
            label3.Name = "label3";
            label3.Size = new Size(173, 18);
            label3.TabIndex = 6;
            label3.Text = "Confirm password:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ground;
            pictureBox1.Location = new Point(0, 281);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(338, 57);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ground;
            pictureBox2.Location = new Point(335, 281);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(338, 57);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.ground;
            pictureBox3.Location = new Point(644, 281);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(62, 57);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.pipe;
            pictureBox4.Location = new Point(498, 132);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(190, 149);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.pipedown;
            pictureBox5.Location = new Point(-3, -398);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(196, 555);
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(250, 233);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(202, 43);
            button2.TabIndex = 12;
            button2.Text = "RETURN TO LOGIN";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(700, 338);
            Controls.Add(button2);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Sign up page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox3;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button button2;
    }
}