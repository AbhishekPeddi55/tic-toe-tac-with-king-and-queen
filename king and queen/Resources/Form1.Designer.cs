namespace TicTacToeApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnExit;

        private void InitializeComponent()
        {
            btnStartGame = new Button();
            btnExit = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnStartGame
            // 
            btnStartGame.BackColor = Color.FromArgb(255, 192, 128);
            btnStartGame.Location = new Point(100, 70);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(109, 26);
            btnStartGame.TabIndex = 0;
            btnStartGame.Text = "Start Game";
            btnStartGame.UseVisualStyleBackColor = false;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 192, 128);
            btnExit.Location = new Point(100, 129);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(109, 29);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit Application";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Location = new Point(100, 102);
            button1.Name = "button1";
            button1.Size = new Size(108, 23);
            button1.TabIndex = 2;
            button1.Text = "Rules";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            BackgroundImage = king_and_queen.Properties.Resources.OIP;
            ClientSize = new Size(339, 181);
            Controls.Add(button1);
            Controls.Add(btnExit);
            Controls.Add(btnStartGame);
            Name = "Form1";
            Text = "Tic-Tac-Toe Menu";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        private Button button1;
    }
}
