namespace WinFormsApp9_Project
{
    partial class Form6
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
            label1 = new Label();
            pictureBox5 = new PictureBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ground;
            pictureBox1.Location = new Point(-1, 385);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(335, 65);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ground;
            pictureBox2.Location = new Point(330, 385);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(335, 65);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.ground;
            pictureBox3.Location = new Point(661, 385);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(140, 65);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.pipe;
            pictureBox4.Location = new Point(605, 185);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(196, 200);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(282, 29);
            label1.Name = "label1";
            label1.Size = new Size(217, 33);
            label1.TabIndex = 4;
            label1.Text = "LEADERBOARD";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.pipedown;
            pictureBox5.Location = new Point(12, -400);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(206, 563);
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(252, 185);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(280, 99);
            dataGridView1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(282, 98);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(229, 33);
            label2.TabIndex = 7;
            label2.Text = "TOP 3 PLAYERS:";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(295, 310);
            button1.Name = "button1";
            button1.Size = new Size(193, 42);
            button1.TabIndex = 8;
            button1.Text = "RETURN TO MAIN MENU ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox5);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form6";
            Text = "Leaderboard Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
        private PictureBox pictureBox5;
        private DataGridView dataGridView1;
        private Label label2;
        private Button button1;
    }
}