using System;
using System.Windows.Forms;

namespace TicTacToeApp
{
    public partial class Form2 : Form
    {
        private string currentPlayer = "King";  // King starts the game
        private Button[] buttons;  // Array to hold the buttons
        private bool gameOver = false;

        public Form2()
        {
            InitializeComponent();
            buttons = new Button[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };  // Link buttons to array
        }

        // Button Click: Handle Player Moves
        private void btnClick(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton.Text != "" || gameOver)
            {
                return; // If the button is already clicked or game is over, return
            }

            // Set the text of the button to the current player's emoji
            clickedButton.Text = (currentPlayer == "King") ? "👑" : "👸";  // Use emoji for King (👑) and Queen (👸)

            // Change text color based on player
            clickedButton.ForeColor = (currentPlayer == "King") ? System.Drawing.Color.Goldenrod : System.Drawing.Color.Pink;  // Gold for King, Pink for Queen

            if (CheckForWinner())
            {
                lblResult.Text = $"{currentPlayer} wins!";
                gameOver = true;
                DisableButtons();
            }
            else if (IsBoardFull())
            {
                lblResult.Text = "It's a tie!";
                gameOver = true;
            }
            else
            {
                // Switch turn
                currentPlayer = (currentPlayer == "King") ? "Queen" : "King";
                lblResult.Text = $"{currentPlayer}'s turn";
            }
        }

        // Check for a winner (rows, columns, diagonals)
        private bool CheckForWinner()
        {
            string[,] winPatterns = new string[,]
            {
                {btn1.Text, btn2.Text, btn3.Text},  // Row 1
                {btn4.Text, btn5.Text, btn6.Text},  // Row 2
                {btn7.Text, btn8.Text, btn9.Text},  // Row 3
                {btn1.Text, btn4.Text, btn7.Text},  // Column 1
                {btn2.Text, btn5.Text, btn8.Text},  // Column 2
                {btn3.Text, btn6.Text, btn9.Text},  // Column 3
                {btn1.Text, btn5.Text, btn9.Text},  // Diagonal 1
                {btn3.Text, btn5.Text, btn7.Text}   // Diagonal 2
            };

            for (int i = 0; i < 8; i++)
            {
                if (winPatterns[i, 0] == winPatterns[i, 1] && winPatterns[i, 1] == winPatterns[i, 2] && winPatterns[i, 0] != "")
                {
                    return true;
                }
            }

            return false;
        }

        // Check if the board is full (tie game)
        private bool IsBoardFull()
        {
            foreach (Button btn in buttons)
            {
                if (btn.Text == "")
                {
                    return false;
                }
            }
            return true;
        }

        // Disable all buttons when the game is over
        private void DisableButtons()
        {
            foreach (Button btn in buttons)
            {
                btn.Enabled = false;
            }
        }

        // New Game Button: Reset the game
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            foreach (Button btn in buttons)
            {
                btn.Text = "";
                btn.BackColor = System.Drawing.Color.White;
                btn.Enabled = true;
            }
            currentPlayer = "King";
            lblResult.Text = "King's turn";
            gameOver = false;
        }

        // Exit Button: Close the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
