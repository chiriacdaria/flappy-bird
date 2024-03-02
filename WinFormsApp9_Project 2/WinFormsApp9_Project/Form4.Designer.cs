namespace WinFormsApp9_Project
{
    partial class Form4
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
            startBtn = new Button();
            button2 = new Button();
            exitBtn = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(196, 45);
            label1.Name = "label1";
            label1.Size = new Size(152, 30);
            label1.TabIndex = 0;
            label1.Text = "MAIN MENU";
            // 
            // startBtn
            // 
            startBtn.BackgroundImageLayout = ImageLayout.Center;
            startBtn.Cursor = Cursors.No;
            startBtn.FlatStyle = FlatStyle.Flat;
            startBtn.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            startBtn.Location = new Point(196, 155);
            startBtn.Margin = new Padding(3, 2, 3, 2);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(161, 42);
            startBtn.TabIndex = 1;
            startBtn.Text = "LEADERBOARD";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(196, 94);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(161, 45);
            button2.TabIndex = 2;
            button2.Text = "CHOOSE BIRD";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // exitBtn
            // 
            exitBtn.FlatStyle = FlatStyle.Popup;
            exitBtn.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            exitBtn.Location = new Point(196, 274);
            exitBtn.Margin = new Padding(3, 2, 3, 2);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(161, 35);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "EXIT";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bird;
            pictureBox1.Location = new Point(58, 110);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 61);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ground;
            pictureBox2.Location = new Point(1, 329);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(296, 46);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.ground;
            pictureBox3.Location = new Point(294, 329);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(296, 46);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.pipe;
            pictureBox4.Location = new Point(455, 187);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(135, 145);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(196, 210);
            button1.Name = "button1";
            button1.Size = new Size(161, 55);
            button1.TabIndex = 8;
            button1.Text = "ACCOUNT SETTINGS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(591, 375);
            Controls.Add(button1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(exitBtn);
            Controls.Add(button2);
            Controls.Add(startBtn);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form4";
            Text = "Main menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button startBtn;
        private Button button2;
        private Button exitBtn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button button1;
    }
}