namespace WinFormsApp9_Project
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            flappyBird = new PictureBox();
            pipeTop = new PictureBox();
            pipeBottom = new PictureBox();
            ground = new PictureBox();
            scoreText = new Label();
            timer = new System.Windows.Forms.Timer(components);
            btnStart = new Button();
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            SuspendLayout();
            // 
            // flappyBird
            // 
            flappyBird.Image = Properties.Resources.bird;
            flappyBird.Location = new Point(95, 128);
            flappyBird.Margin = new Padding(3, 2, 3, 2);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(109, 46);
            flappyBird.SizeMode = PictureBoxSizeMode.StretchImage;
            flappyBird.TabIndex = 0;
            flappyBird.TabStop = false;
            // 
            // pipeTop
            // 
            pipeTop.Image = Properties.Resources.pipedown;
            pipeTop.Location = new Point(430, -2);
            pipeTop.Margin = new Padding(3, 2, 3, 2);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(109, 124);
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 1;
            pipeTop.TabStop = false;
            pipeTop.Click += pictureBox2_Click;
            // 
            // pipeBottom
            // 
            pipeBottom.Image = Properties.Resources.pipe;
            pipeBottom.Location = new Point(350, 300);
            pipeBottom.Margin = new Padding(3, 2, 3, 2);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(109, 121);
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 2;
            pipeBottom.TabStop = false;
            // 
            // ground
            // 
            ground.Image = Properties.Resources.ground;
            ground.Location = new Point(-2, 421);
            ground.Margin = new Padding(3, 2, 3, 2);
            ground.Name = "ground";
            ground.Size = new Size(648, 46);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            scoreText.Location = new Point(21, 26);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(81, 20);
            scoreText.TabIndex = 4;
            scoreText.Text = "SCORE:0";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 20;
            timer.Tick += timerEvent;
            // 
            // btnStart
            // 
            btnStart.FlatStyle = FlatStyle.Popup;
            btnStart.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.Location = new Point(276, 191);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(118, 37);
            btnStart.TabIndex = 5;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(646, 464);
            Controls.Add(btnStart);
            Controls.Add(scoreText);
            Controls.Add(ground);
            Controls.Add(pipeBottom);
            Controls.Add(pipeTop);
            Controls.Add(flappyBird);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form3";
            Text = "Flappy Bird Game";
            KeyDown += gameKeyDown;
            KeyUp += gameKeyUp;
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox flappyBird;
        private PictureBox pipeTop;
        private PictureBox pipeBottom;
        private PictureBox ground;
        private Label scoreText;
        private System.Windows.Forms.Timer timer;
        private Button btnStart;
    }
}