namespace WinFormsApp9_Project
{
    partial class Form8
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ground;
            pictureBox1.Location = new Point(0, 403);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(336, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ground;
            pictureBox2.Location = new Point(311, 403);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(336, 50);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.ground;
            pictureBox3.Location = new Point(360, 403);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(336, 50);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.pipe;
            pictureBox4.Location = new Point(474, 250);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(213, 153);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.pipedown;
            pictureBox5.Location = new Point(0, -404);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(198, 614);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(227, 107);
            label1.Name = "label1";
            label1.Size = new Size(224, 20);
            label1.TabIndex = 5;
            label1.Text = "INSERT NEW PASSWORD:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Elephant", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(236, 157);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(215, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Elephant", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(236, 213);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(215, 27);
            textBox2.TabIndex = 7;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(236, 302);
            button1.Name = "button1";
            button1.Size = new Size(215, 49);
            button1.TabIndex = 8;
            button1.Text = "RETURN TO MAIN MENU";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(288, 369);
            button2.Name = "button2";
            button2.Size = new Size(98, 28);
            button2.TabIndex = 9;
            button2.Text = "EXIT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(288, 250);
            button3.Name = "button3";
            button3.Size = new Size(98, 28);
            button3.TabIndex = 10;
            button3.Text = "UPDATE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(670, 449);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form8";
            Text = "Update Password";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}