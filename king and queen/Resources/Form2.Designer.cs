namespace TicTacToeApp
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;

        private void InitializeComponent()
        {
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            lblResult = new Label();
            btnNewGame = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.BackColor = Color.Black;
            btn1.Location = new Point(50, 50);
            btn1.Name = "btn1";
            btn1.Size = new Size(50, 50);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btnClick;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Black;
            btn2.Location = new Point(110, 50);
            btn2.Name = "btn2";
            btn2.Size = new Size(50, 50);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btnClick;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Black;
            btn3.Location = new Point(170, 50);
            btn3.Name = "btn3";
            btn3.Size = new Size(50, 50);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btnClick;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Black;
            btn4.Location = new Point(50, 110);
            btn4.Name = "btn4";
            btn4.Size = new Size(50, 50);
            btn4.TabIndex = 3;
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btnClick;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Black;
            btn5.Location = new Point(110, 110);
            btn5.Name = "btn5";
            btn5.Size = new Size(50, 50);
            btn5.TabIndex = 4;
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btnClick;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Black;
            btn6.Location = new Point(170, 110);
            btn6.Name = "btn6";
            btn6.Size = new Size(50, 50);
            btn6.TabIndex = 5;
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btnClick;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Black;
            btn7.Location = new Point(50, 170);
            btn7.Name = "btn7";
            btn7.Size = new Size(50, 50);
            btn7.TabIndex = 6;
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btnClick;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Black;
            btn8.Location = new Point(110, 170);
            btn8.Name = "btn8";
            btn8.Size = new Size(50, 50);
            btn8.TabIndex = 7;
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btnClick;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Black;
            btn9.Location = new Point(170, 170);
            btn9.Name = "btn9";
            btn9.Size = new Size(50, 50);
            btn9.TabIndex = 8;
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btnClick;
            // 
            // lblResult
            // 
            lblResult.ForeColor = Color.DarkBlue;
            lblResult.Location = new Point(50, 230);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(170, 30);
            lblResult.TabIndex = 9;
            lblResult.Text = "X's turn";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNewGame
            // 
            btnNewGame.BackColor = Color.LightGreen;
            btnNewGame.Location = new Point(50, 270);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(90, 40);
            btnNewGame.TabIndex = 10;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = false;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightCoral;
            btnExit.Location = new Point(150, 270);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 40);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form2
            // 
            BackColor = Color.LightSkyBlue;
            BackgroundImage = king_and_queen.Properties.Resources.tictactoe_image;
            ClientSize = new Size(280, 320);
            Controls.Add(btnExit);
            Controls.Add(btnNewGame);
            Controls.Add(lblResult);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Form2";
            Text = "Tic-Tac-Toe Game";
            ResumeLayout(false);
        }
    }
}
