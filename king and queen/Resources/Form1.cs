using System;
using System.Windows.Forms;
using king_and_queen.Resources;

namespace TicTacToeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Button Click: Start Game
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Form2 gameForm = new Form2();
            gameForm.Show();
            this.Hide();
        }

        // Button Click: Exit Application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
