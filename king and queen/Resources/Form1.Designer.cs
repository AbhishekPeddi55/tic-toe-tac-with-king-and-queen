namespace TicTacToeApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.LinkLabel linkLabel1;

        private void InitializeComponent()
        {
            btnStartGame = new Button();
            btnExit = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // btnStartGame
            // 
            btnStartGame.BackColor = Color.FromArgb(255, 192, 128);
            btnStartGame.Location = new Point(100, 64);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(109, 32);
            btnStartGame.TabIndex = 0;
            btnStartGame.Text = "Start Game";
            btnStartGame.UseVisualStyleBackColor = false;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 192, 128);
            btnExit.Location = new Point(100, 133);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(109, 28);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit Application";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.BackColor = Color.FromArgb(255, 192, 128);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(100, 99);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(109, 31);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Game Rules";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // Form1
            // 
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = king_and_queen.Properties.Resources.OIP;
            ClientSize = new Size(344, 180);
            Controls.Add(linkLabel1);
            Controls.Add(btnExit);
            Controls.Add(btnStartGame);
            Name = "Form1";
            Text = "Tic-Tac-Toe Menu";
            Load += Form1_Load;
            ResumeLayout(false);
        }
    }
}
