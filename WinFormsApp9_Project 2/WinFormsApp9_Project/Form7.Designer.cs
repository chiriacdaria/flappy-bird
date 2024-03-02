namespace WinFormsApp9_Project
{
    partial class Form7
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
            button1 = new Button();
            button3 = new Button();
            pictureBox5 = new PictureBox();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
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
            pictureBox1.Location = new Point(-5, 328);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(337, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ground;
            pictureBox2.Location = new Point(327, 328);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(337, 50);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pipe;
            pictureBox3.Location = new Point(469, 165);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(195, 163);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.pipedown;
            pictureBox4.Location = new Point(-5, -417);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(199, 551);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(254, 73);
            button1.Name = "button1";
            button1.Size = new Size(124, 70);
            button1.TabIndex = 4;
            button1.Text = "DELETE ACCOUNT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(400, 95);
            button3.Name = "button3";
            button3.Size = new Size(124, 27);
            button3.TabIndex = 6;
            button3.Text = "CONFIRM";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.bird;
            pictureBox5.Location = new Point(44, 165);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 62);
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(254, 282);
            button5.Name = "button5";
            button5.Size = new Size(124, 27);
            button5.TabIndex = 9;
            button5.Text = "EXIT";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(254, 238);
            button4.Name = "button4";
            button4.Size = new Size(124, 27);
            button4.TabIndex = 8;
            button4.Text = "MAIN MENU";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(254, 149);
            button2.Name = "button2";
            button2.Size = new Size(124, 70);
            button2.TabIndex = 5;
            button2.Text = "UPDATE PASSWORD";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(654, 378);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(pictureBox5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form7";
            Text = "Account Settings";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button button1;
        private Button button3;
        private PictureBox pictureBox5;
        private Button button5;
        private Button button4;
        private Button button2;
    }
}