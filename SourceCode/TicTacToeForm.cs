using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Properties;

namespace TicTacToe
{
    public partial class TicTacToeForm : Form
    {

        Settings gameSettings = Settings.Default;
        bool xTurn = true;
        int turnCount = 0;

        public TicTacToeForm()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) // Disables focus on buttons when using arrow keys
        {
            if ((keyData == Keys.Right) || (keyData == Keys.Left) ||
                (keyData == Keys.Up) || (keyData == Keys.Down))
            {
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Hide();
            ResetBoard();
            NewGame();
            this.Enabled = true;
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A simple Tic Tac Toe game. That's it.\r\n\r\nCreated by FutureFlash on 4/27/2021", "Tic Tac Toe (v1.1)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ticTacToeButtonClick(object sender, EventArgs e)
        {
            Button ticTacToeButton = (Button)sender;
            if (xTurn)
            {
                ticTacToeButton.Text = "X";
            }
            else
            {
                ticTacToeButton.Text = "O";
            }

            xTurn = !xTurn;
            ticTacToeButton.Enabled = false;
            turnCount++;
            CheckForWinner();

            if ((!xTurn) && (gameSettings.isAI))
            {
                AIPlay();
            }
        }

        private void ticTacToeMouseEnter(object sender, EventArgs e)
        {
            Button ticTacToeButton = (Button)sender;

            if (ticTacToeButton.Enabled)
            {
                if (xTurn)
                {
                    ticTacToeButton.Text = "X";
                }

                else
                {
                    ticTacToeButton.Text = "O";
                }
            }
        }

        private void ticTacToeMouseLeave(object sender, EventArgs e)
        {
            Button ticTacToeButton = (Button)sender;

            if (ticTacToeButton.Enabled)
            {
                ticTacToeButton.Text = "";
            }
        }

        private void CheckForWinner()
        {
            bool isWinner = false;
            Console.WriteLine(turnCount.ToString());

            // Horizontal win check
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                isWinner = true;
            }

            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                isWinner = true;
            }

            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                isWinner = true;
            }

            // Vertical win check
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                isWinner = true;
            }

            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                isWinner = true;
            }

            if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                isWinner = true;
            }

            // Diagonal win check
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                isWinner = true;
            }

            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
            {
                isWinner = true;
            }


            if (isWinner)
            {
                DisableButtons();
                string winner = "";

                if (xTurn)
                {
                    winner = "O";
                    playerOScore.Text = (int.Parse(playerOScore.Text) + 1).ToString();
                    gameSettings.playerOWinCount++;
                    gameSettings.Save();
                }

                else
                {
                    winner = "X";
                    playerXScore.Text = (int.Parse(playerXScore.Text) + 1).ToString();
                    gameSettings.playerXWinCount++;
                    gameSettings.Save();
                }

                MessageBox.Show($"Player {winner} wins. LOL", "Loser");
                ResetBoard();
            }

            else
            {
                if ((turnCount == 9) && (!isWinner))
                {
                    MessageBox.Show("A tie.. That's lame", "bro?");
                    tiesScore.Text = (int.Parse(tiesScore.Text) + 1).ToString();
                    gameSettings.numberOfTies++;
                    gameSettings.Save();
                    ResetBoard();
                    turnCount = 0;
                }
            }
        }

        private void DisableButtons()
        {
            foreach (Control c in Controls)
            {
                try
                {
                    Button ticTacToeButton = (Button)c;
                    ticTacToeButton.Enabled = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        private void NewGame()
        {
            ResetBoard();
            MessageBoxManager.Yes = "Single Player";
            MessageBoxManager.No = "Multiplayer";
            MessageBoxManager.Register();

            DialogResult addAI = MessageBox.Show("Select your game mode to start", "Select Game Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (addAI == DialogResult.Yes)
            {
                gameSettings.isAI = true;
                LoadScoreboard();
                MessageBoxManager.Unregister();
                Console.WriteLine(gameSettings.isAI.ToString());
            }
            if (addAI == DialogResult.No)
            {
                gameSettings.isAI = false;
                LoadScoreboard();
                MessageBoxManager.Unregister();
                Console.WriteLine(gameSettings.isAI.ToString());
            }
        }

        private void LoadScoreboard()
        {
            playerOScore.Text = gameSettings.playerOWinCount.ToString();
            playerXScore.Text = gameSettings.playerXWinCount.ToString();
            tiesScore.Text = gameSettings.numberOfTies.ToString();
        }

        private void ResetBoard()
        {
            xTurn = true;
            turnCount = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button ticTacToeButton = (Button)c;
                    ticTacToeButton.Text = "";
                    ticTacToeButton.Enabled = true;
                    ticTacToeButton.TabStop = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        private void TicTacToeForm_Load(object sender, EventArgs e)
        {
            darkModeToolStripMenuItem.Visible = false;
            darkModeToolStripMenuItem.Enabled = false;

            if (gameSettings.isDarkMode) // Check for Dark Mode
            {
                DarkMode();
            }

            else
            {
                LightMode();
            }

            foreach (Control c in Controls)
            {
                try
                {
                    Button ticTacToeButton = (Button)c;
                    ticTacToeButton.TabStop = false;
                    ticTacToeButton.FlatAppearance.BorderSize = 1;
                    ticTacToeButton.FlatAppearance.BorderColor = Color.Gray;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            NewGame();
        }

        private void clearScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult confirmScoreReset = MessageBox.Show("Are you sure you want to reset the scoreboard and your current settings? This action can't be undone.\r\n\r\nNote: Resetting will clear  your scoreboard and will reset your dark mode settings", "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (confirmScoreReset == DialogResult.Yes)
            {
                gameSettings.Reset();
                gameSettings.Save();
                LightMode();
                ResetBoard();
                LoadScoreboard();
            }
            if (confirmScoreReset == DialogResult.No)
            {

            }
        }

        private void AIPlay()
        {
            Button move = null;

            move = WinOrBlock("O");
            if (move == null)
            {
                move = WinOrBlock("X");
                if (move == null)
                {
                    move = LookForACorner();
                    if (move == null)
                    {
                        move = LookForOpenBoxes();
                    }
                }
            }

            move.PerformClick();
        }

        private Button LookForOpenBoxes()
        {
            Console.WriteLine("Looking for an open space");
            Button ticTacToeButton = null;

            foreach (Control c in Controls)
            {
                ticTacToeButton = c as Button;
                if (ticTacToeButton != null)
                {
                    if (ticTacToeButton.Text == "")
                    {
                        return ticTacToeButton;
                    }
                }
            }

            return null;
        }

        private Button LookForACorner()
        {
            Console.WriteLine("Looking for a corner");

            if (A1.Text == "O")
            {
                if (A3.Text == "")
                {
                    return A3;
                }

                if (C3.Text == "")
                {
                    return C3;
                }

                if (C1.Text == "")
                {
                    return C1;
                }
            }

            if (A3.Text == "O")
            {
                if (A1.Text == "")
                {
                    return A1;
                }

                if (C3.Text == "")
                {
                    return C3;
                }

                if (C1.Text == "")
                {
                    return C1;
                }
            }

            if (C3.Text == "O")
            {
                if (A1.Text == "")
                {
                    return A3;
                }

                if (A3.Text == "")
                {
                    return A3;
                }

                if (C1.Text == "")
                {
                    return C1;
                }
            }

            if (C1.Text == "O")
            {
                if (A1.Text == "")
                {
                    return A3;
                }

                if (A3.Text == "")
                {
                    return A3;
                }

                if (C3.Text == "")
                {
                    return C3;
                }
            }

            if (A1.Text == "")
            {
                return A1;
            }

            if (A3.Text == "")
            {
                return A3;
            }

            if (C1.Text == "")
            {
                return C1;
            }

            if (C3.Text == "")
            {
                return C3;
            }

            return null;
        }

        private Button WinOrBlock(string mark)
        {
            Console.WriteLine("Looking for a way to win or to block an " + mark);

            // Horizontal Space Check
            if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == ""))
            {
                return A3;
            }

            if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == ""))
            {
                return A1;
            }

            if ((A1.Text == mark) && (A3.Text == mark) && (A2.Text == ""))
            {
                return A2;
            }

            if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == ""))
            {
                return B3;
            }

            if ((B2.Text == mark) && (B3.Text == mark) && (B1.Text == ""))
            {
                return B1;
            }

            if ((B1.Text == mark) && (B3.Text == mark) && (B2.Text == ""))
            {
                return B2;
            }

            if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == ""))
            {
                return C3;
            }

            if ((C2.Text == mark) && (C3.Text == mark) && (C1.Text == ""))
            {
                return C1;
            }

            if ((C1.Text == mark) && (C3.Text == mark) && (C2.Text == ""))
            {
                return C2;
            }


            // Vertical Space Check
            if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == ""))
            {
                return C1;
            }

            if ((B1.Text == mark) && (C1.Text == mark) && (A1.Text == ""))
            {
                return A1;
            }

            if ((A1.Text == mark) && (C1.Text == mark) && (B1.Text == ""))
            {
                return B1;
            }

            if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == ""))
            {
                return C2;
            }

            if ((B2.Text == mark) && (C2.Text == mark) && (A2.Text == ""))
            {
                return A2;
            }

            if ((A2.Text == mark) && (C2.Text == mark) && (B2.Text == ""))
            {
                return B2;
            }

            if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == ""))
            {
                return C3;
            }

            if ((B3.Text == mark) && (C3.Text == mark) && (A3.Text == ""))
            {
                return A3;
            }

            if ((A3.Text == mark) && (C3.Text == mark) && (B3.Text == ""))
            {
                return B3;
            }



            // Diagonal Space Check
            if ((A1.Text == mark) && (B2.Text == mark) && (C3.Text == ""))
            {
                return C3;
            }

            if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == ""))
            {
                return A1;
            }

            if ((A1.Text == mark) && (C3.Text == mark) && (B2.Text == ""))
            {
                return B2;
            }

            if ((A3.Text == mark) && (B2.Text == mark) && (C1.Text == ""))
            {
                return C1;
            }

            if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == ""))
            {
                return A3;
            }

            if ((A3.Text == mark) && (C1.Text == mark) && (B2.Text == ""))
            {
                return B2;
            }

            return null;
        }

        private void changeGameModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gameSettings.isAI == true)
            {
                gameSettings.isAI = false;
                MessageBox.Show("Game mode is now Multiplayer");
                ResetBoard();
            }
            else if (gameSettings.isAI == false)
            {
                gameSettings.isAI = true;
                MessageBox.Show("Game mode is now Single Player");
                ResetBoard();
            }
        }

        private void ToggleDarkModeButton()
        {
            if (!darkModeToolStripMenuItem.Visible)
            {
                darkModeToolStripMenuItem.Visible = true;
                darkModeToolStripMenuItem.Enabled = true;
            }

            else
            {
                darkModeToolStripMenuItem.Visible = false;
                darkModeToolStripMenuItem.Enabled = false;
            }
        }

        private void DarkMode()
        {
            this.BackColor = SystemColors.ControlDarkDark;
            menuStrip1.BackColor = SystemColors.ControlDarkDark;
            darkModeToolStripMenuItem.BackColor = SystemColors.ControlLight;
            aboutToolStripMenuItem.BackColor = Color.Silver;
            darkModeToolStripMenuItem.Text = "Light Mode";
            scoreBoardLabel.ForeColor = SystemColors.ControlLight;
            playerOLabel.ForeColor = SystemColors.ControlLight;
            playerOScore.ForeColor = SystemColors.ControlLight;
            playerXLabel.ForeColor = SystemColors.ControlLight;
            playerXScore.ForeColor = SystemColors.ControlLight;
            tiesLabel.ForeColor = SystemColors.ControlLight;
            tiesScore.ForeColor = SystemColors.ControlLight;
            gameSettings.isDarkMode = true;
            gameSettings.Save();
        }

        private void LightMode()
        {
            this.BackColor = SystemColors.Control;
            menuStrip1.BackColor = SystemColors.Control;
            darkModeToolStripMenuItem.BackColor = SystemColors.AppWorkspace;
            aboutToolStripMenuItem.BackColor = Color.LightCoral;
            darkModeToolStripMenuItem.Text = "Dark Mode";
            scoreBoardLabel.ForeColor = SystemColors.ControlText;
            playerOLabel.ForeColor = SystemColors.ControlText;
            playerOScore.ForeColor = SystemColors.ControlText;
            playerXLabel.ForeColor = SystemColors.ControlText;
            playerXScore.ForeColor = SystemColors.ControlText;
            tiesLabel.ForeColor = SystemColors.ControlText;
            tiesScore.ForeColor = SystemColors.ControlText;
            gameSettings.isDarkMode = false;
            gameSettings.Save();
        }

        private void TicTacToeForm_DoubleClick(object sender, EventArgs e)
        {
            ToggleDarkModeButton();
        }

        private void menuStrip1_DoubleClick(object sender, EventArgs e)
        {
            ToggleDarkModeButton();
        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.BackColor == SystemColors.Control)
            {
                DarkMode();
            }

            else if (this.BackColor == SystemColors.ControlDarkDark)
            {
                LightMode();
            }
        }
    }
}
