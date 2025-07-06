namespace FrogNewWinFormsApp
{
    partial class MainForm
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
            // MenuStrip
            menuStrip1 = new MenuStrip();
            gameToolStripMenuItem = new ToolStripMenuItem();
            restartToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            rulesToolStripMenuItem = new ToolStripMenuItem();

            leftPictureBox1 = new PictureBox();
            leftPictureBox2 = new PictureBox();
            leftPictureBox3 = new PictureBox();
            leftPictureBox4 = new PictureBox();
            rightPictureBox3 = new PictureBox();
            rightPictureBox2 = new PictureBox();
            rightPictureBox1 = new PictureBox();
            emptyPictureBox = new PictureBox();
            rightPictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)leftPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptyPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox4).BeginInit();
            // Настройка MenuStrip
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] {
                gameToolStripMenuItem,
                helpToolStripMenuItem});
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(992, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            gameToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                restartToolStripMenuItem,
                exitToolStripMenuItem});
            gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            gameToolStripMenuItem.Size = new Size(74, 29);
            gameToolStripMenuItem.Text = "Игра";
            // 
            // restartToolStripMenuItem
            // 
            restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            restartToolStripMenuItem.Size = new Size(252, 34);
            restartToolStripMenuItem.Text = "Начать сначала";
            restartToolStripMenuItem.Click += new EventHandler(restartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(252, 34);
            exitToolStripMenuItem.Text = "Выход";
            exitToolStripMenuItem.Click += new EventHandler(exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                rulesToolStripMenuItem});
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(104, 29);
            helpToolStripMenuItem.Text = "Помощь";

            // 
            // rulesToolStripMenuItem
            // 
            rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            rulesToolStripMenuItem.Size = new Size(252, 34);
            rulesToolStripMenuItem.Text = "Правила";
            rulesToolStripMenuItem.Click += new EventHandler(rulesToolStripMenuItem_Click);
            // 
            // leftPictureBox1
            // 
            leftPictureBox1.Image = Properties.Resources.frogLeft;
            leftPictureBox1.Location = new Point(0, menuStrip1.Height);
            leftPictureBox1.Name = "leftPictureBox1";
            leftPictureBox1.Size = new Size(110, 110);
            leftPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            leftPictureBox1.TabIndex = 0;
            leftPictureBox1.TabStop = false;
            leftPictureBox1.Click += PictureBox_Click;
            // 
            // leftPictureBox2
            // 
            leftPictureBox2.Image = Properties.Resources.frogLeft;
            leftPictureBox2.Location = new Point(110, menuStrip1.Height);
            leftPictureBox2.Name = "leftPictureBox2";
            leftPictureBox2.Size = new Size(110, 110);
            leftPictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            leftPictureBox2.TabIndex = 1;
            leftPictureBox2.TabStop = false;
            leftPictureBox2.Click += PictureBox_Click;
            // 
            // leftPictureBox3
            // 
            leftPictureBox3.Image = Properties.Resources.frogLeft;
            leftPictureBox3.Location = new Point(220, menuStrip1.Height);
            leftPictureBox3.Name = "leftPictureBox3";
            leftPictureBox3.Size = new Size(110, 110);
            leftPictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            leftPictureBox3.TabIndex = 2;
            leftPictureBox3.TabStop = false;
            leftPictureBox3.Click += PictureBox_Click;
            // 
            // leftPictureBox4
            // 
            leftPictureBox4.Image = Properties.Resources.frogLeft;
            leftPictureBox4.Location = new Point(330, menuStrip1.Height);
            leftPictureBox4.Name = "leftPictureBox4";
            leftPictureBox4.Size = new Size(110, 110);
            leftPictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            leftPictureBox4.TabIndex = 3;
            leftPictureBox4.TabStop = false;
            leftPictureBox4.Click += PictureBox_Click;
            // 
            // rightPictureBox3
            // 
            rightPictureBox3.Image = Properties.Resources.frogRight;
            rightPictureBox3.Location = new Point(770, menuStrip1.Height);
            rightPictureBox3.Name = "rightPictureBox3";
            rightPictureBox3.Size = new Size(110, 110);
            rightPictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            rightPictureBox3.TabIndex = 7;
            rightPictureBox3.TabStop = false;
            rightPictureBox3.Click += PictureBox_Click;
            // 
            // rightPictureBox2
            // 
            rightPictureBox2.Image = Properties.Resources.frogRight;
            rightPictureBox2.Location = new Point(660, menuStrip1.Height);
            rightPictureBox2.Name = "rightPictureBox2";
            rightPictureBox2.Size = new Size(110, 110);
            rightPictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            rightPictureBox2.TabIndex = 6;
            rightPictureBox2.TabStop = false;
            rightPictureBox2.Click += PictureBox_Click;
            // 
            // rightPictureBox1
            // 
            rightPictureBox1.Image = Properties.Resources.frogRight;
            rightPictureBox1.Location = new Point(550, menuStrip1.Height);
            rightPictureBox1.Name = "rightPictureBox1";
            rightPictureBox1.Size = new Size(110, 110);
            rightPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            rightPictureBox1.TabIndex = 5;
            rightPictureBox1.TabStop = false;
            rightPictureBox1.Click += PictureBox_Click;
            // 
            // emptyPictureBox
            // 
            emptyPictureBox.Image = Properties.Resources.list;
            emptyPictureBox.Location = new Point(440, menuStrip1.Height);
            emptyPictureBox.Name = "emptyPictureBox";
            emptyPictureBox.Size = new Size(110, 110);
            emptyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            emptyPictureBox.TabIndex = 4;
            emptyPictureBox.TabStop = false;
            // 
            // rightPictureBox4
            // 
            rightPictureBox4.Image = Properties.Resources.frogRight;
            rightPictureBox4.Location = new Point(880, menuStrip1.Height);
            rightPictureBox4.Name = "rightPictureBox4";
            rightPictureBox4.Size = new Size(110, 110);
            rightPictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            rightPictureBox4.TabIndex = 8;
            rightPictureBox4.TabStop = false;
            rightPictureBox4.Click += PictureBox_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 189 + menuStrip1.Height);
            Controls.Add(rightPictureBox4);
            Controls.Add(rightPictureBox3);
            Controls.Add(rightPictureBox2);
            Controls.Add(rightPictureBox1);
            Controls.Add(emptyPictureBox);
            Controls.Add(leftPictureBox4);
            Controls.Add(leftPictureBox3);
            Controls.Add(leftPictureBox2);
            Controls.Add(leftPictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Лягушки - Ходов: 0";
            ((System.ComponentModel.ISupportInitialize)leftPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptyPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox4).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gameToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem rulesToolStripMenuItem;
        private PictureBox leftPictureBox1;
        private PictureBox leftPictureBox2;
        private PictureBox leftPictureBox3;
        private PictureBox leftPictureBox4;
        private PictureBox rightPictureBox3;
        private PictureBox rightPictureBox2;
        private PictureBox rightPictureBox1;
        private PictureBox emptyPictureBox;
        private PictureBox rightPictureBox4;
    }
}
