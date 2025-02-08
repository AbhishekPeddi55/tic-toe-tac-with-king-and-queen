using System;
using System.Diagnostics;
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

        // Open URL in Default Browser
        private void openUrl(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true,
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening link: " + ex.Message);
            }
        } // <-- Fixed missing closing bracket here

        // Button Click: Exit Application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Code to execute when Form1 loads (if needed)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add button1 click functionality if needed
        }

        // LinkLabel Click Event
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openUrl("https://www.gvsu.edu/cms4/asset/AF5F8044-C1CA-D385-2E8007C14930B056/not_your_normal_tic_tac_toe_game_rules.pdf");
        }
    }
}
