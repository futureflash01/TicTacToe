
namespace TicTacToe
{
    partial class TicTacToeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToeForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeGameModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetScoreboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.scoreBoardLabel = new System.Windows.Forms.Label();
            this.playerXLabel = new System.Windows.Forms.Label();
            this.tiesLabel = new System.Windows.Forms.Label();
            this.playerOLabel = new System.Windows.Forms.Label();
            this.playerXScore = new System.Windows.Forms.Label();
            this.tiesScore = new System.Windows.Forms.Label();
            this.playerOScore = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.darkModeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(258, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.DoubleClick += new System.EventHandler(this.menuStrip1_DoubleClick);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.changeGameModeToolStripMenuItem,
            this.resetScoreboardToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // changeGameModeToolStripMenuItem
            // 
            this.changeGameModeToolStripMenuItem.Name = "changeGameModeToolStripMenuItem";
            this.changeGameModeToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.changeGameModeToolStripMenuItem.Text = "Change Game Mode";
            this.changeGameModeToolStripMenuItem.Click += new System.EventHandler(this.changeGameModeToolStripMenuItem_Click);
            // 
            // resetScoreboardToolStripMenuItem
            // 
            this.resetScoreboardToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetScoreboardToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.resetScoreboardToolStripMenuItem.Name = "resetScoreboardToolStripMenuItem";
            this.resetScoreboardToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.resetScoreboardToolStripMenuItem.Text = "Reset Scoreboard and Settings";
            this.resetScoreboardToolStripMenuItem.Click += new System.EventHandler(this.clearScoreToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.LightCoral;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // darkModeToolStripMenuItem
            // 
            this.darkModeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            this.darkModeToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.darkModeToolStripMenuItem.Text = "Dark Mode";
            this.darkModeToolStripMenuItem.Click += new System.EventHandler(this.darkModeToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.A1.Location = new System.Drawing.Point(9, 31);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 75);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.ticTacToeButtonClick);
            this.A1.MouseEnter += new System.EventHandler(this.ticTacToeMouseEnter);
            this.A1.MouseLeave += new System.EventHandler(this.ticTacToeMouseLeave);
            // 
            // A2
            // 
            this.A2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.A2.Location = new System.Drawing.Point(90, 31);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 75);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.ticTacToeButtonClick);
            this.A2.MouseEnter += new System.EventHandler(this.ticTacToeMouseEnter);
            this.A2.MouseLeave += new System.EventHandler(this.ticTacToeMouseLeave);
            // 
            // A3
            // 
            this.A3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.A3.Location = new System.Drawing.Point(171, 31);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 75);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.ticTacToeButtonClick);
            this.A3.MouseEnter += new System.EventHandler(this.ticTacToeMouseEnter);
            this.A3.MouseLeave += new System.EventHandler(this.ticTacToeMouseLeave);
            // 
            // B3
            // 
            this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.B3.Location = new System.Drawing.Point(171, 112);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 75);
            this.B3.TabIndex = 6;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.ticTacToeButtonClick);
            this.B3.MouseEnter += new System.EventHandler(this.ticTacToeMouseEnter);
            this.B3.MouseLeave += new System.EventHandler(this.ticTacToeMouseLeave);
            // 
            // B2
            // 
            this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.B2.Location = new System.Drawing.Point(90, 112);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 75);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.ticTacToeButtonClick);
            this.B2.MouseEnter += new System.EventHandler(this.ticTacToeMouseEnter);
            this.B2.MouseLeave += new System.EventHandler(this.ticTacToeMouseLeave);
            // 
            // B1
            // 
            this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.B1.Location = new System.Drawing.Point(9, 112);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 75);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.ticTacToeButtonClick);
            this.B1.MouseEnter += new System.EventHandler(this.ticTacToeMouseEnter);
            this.B1.MouseLeave += new System.EventHandler(this.ticTacToeMouseLeave);
            // 
            // C3
            // 
            this.C3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.C3.Location = new System.Drawing.Point(171, 193);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 75);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.ticTacToeButtonClick);
            this.C3.MouseEnter += new System.EventHandler(this.ticTacToeMouseEnter);
            this.C3.MouseLeave += new System.EventHandler(this.ticTacToeMouseLeave);
            // 
            // C2
            // 
            this.C2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.C2.Location = new System.Drawing.Point(90, 193);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 75);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.ticTacToeButtonClick);
            this.C2.MouseEnter += new System.EventHandler(this.ticTacToeMouseEnter);
            this.C2.MouseLeave += new System.EventHandler(this.ticTacToeMouseLeave);
            // 
            // C1
            // 
            this.C1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.C1.Location = new System.Drawing.Point(9, 193);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 75);
            this.C1.TabIndex = 7;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.ticTacToeButtonClick);
            this.C1.MouseEnter += new System.EventHandler(this.ticTacToeMouseEnter);
            this.C1.MouseLeave += new System.EventHandler(this.ticTacToeMouseLeave);
            // 
            // scoreBoardLabel
            // 
            this.scoreBoardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreBoardLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.scoreBoardLabel.Location = new System.Drawing.Point(6, 277);
            this.scoreBoardLabel.Name = "scoreBoardLabel";
            this.scoreBoardLabel.Size = new System.Drawing.Size(240, 23);
            this.scoreBoardLabel.TabIndex = 10;
            this.scoreBoardLabel.Text = "Scoreboard";
            this.scoreBoardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerXLabel
            // 
            this.playerXLabel.AutoSize = true;
            this.playerXLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playerXLabel.Location = new System.Drawing.Point(28, 304);
            this.playerXLabel.Name = "playerXLabel";
            this.playerXLabel.Size = new System.Drawing.Size(46, 13);
            this.playerXLabel.TabIndex = 11;
            this.playerXLabel.Text = "Player X";
            // 
            // tiesLabel
            // 
            this.tiesLabel.AutoSize = true;
            this.tiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiesLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tiesLabel.Location = new System.Drawing.Point(113, 304);
            this.tiesLabel.Name = "tiesLabel";
            this.tiesLabel.Size = new System.Drawing.Size(27, 13);
            this.tiesLabel.TabIndex = 12;
            this.tiesLabel.Text = "Ties";
            // 
            // playerOLabel
            // 
            this.playerOLabel.AutoSize = true;
            this.playerOLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playerOLabel.Location = new System.Drawing.Point(181, 304);
            this.playerOLabel.Name = "playerOLabel";
            this.playerOLabel.Size = new System.Drawing.Size(47, 13);
            this.playerOLabel.TabIndex = 13;
            this.playerOLabel.Text = "Player O";
            // 
            // playerXScore
            // 
            this.playerXScore.AutoSize = true;
            this.playerXScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playerXScore.Location = new System.Drawing.Point(41, 327);
            this.playerXScore.Name = "playerXScore";
            this.playerXScore.Size = new System.Drawing.Size(13, 13);
            this.playerXScore.TabIndex = 14;
            this.playerXScore.Text = "0";
            // 
            // tiesScore
            // 
            this.tiesScore.AutoSize = true;
            this.tiesScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tiesScore.Location = new System.Drawing.Point(120, 327);
            this.tiesScore.Name = "tiesScore";
            this.tiesScore.Size = new System.Drawing.Size(13, 13);
            this.tiesScore.TabIndex = 15;
            this.tiesScore.Text = "0";
            // 
            // playerOScore
            // 
            this.playerOScore.AutoSize = true;
            this.playerOScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playerOScore.Location = new System.Drawing.Point(197, 327);
            this.playerOScore.Name = "playerOScore";
            this.playerOScore.Size = new System.Drawing.Size(13, 13);
            this.playerOScore.TabIndex = 16;
            this.playerOScore.Text = "0";
            // 
            // TicTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 350);
            this.Controls.Add(this.playerOScore);
            this.Controls.Add(this.tiesScore);
            this.Controls.Add(this.playerXScore);
            this.Controls.Add(this.playerOLabel);
            this.Controls.Add(this.tiesLabel);
            this.Controls.Add(this.playerXLabel);
            this.Controls.Add(this.scoreBoardLabel);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TicTacToeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.TicTacToeForm_Load);
            this.DoubleClick += new System.EventHandler(this.TicTacToeForm_DoubleClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Label scoreBoardLabel;
        private System.Windows.Forms.Label playerXLabel;
        private System.Windows.Forms.Label tiesLabel;
        private System.Windows.Forms.Label playerOLabel;
        private System.Windows.Forms.Label playerXScore;
        private System.Windows.Forms.Label tiesScore;
        private System.Windows.Forms.Label playerOScore;
        private System.Windows.Forms.ToolStripMenuItem resetScoreboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeGameModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
    }
}

