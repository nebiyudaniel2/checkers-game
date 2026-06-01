namespace CheckersPro
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
            pnlBoard = new Panel();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            gameModeToolStripMenuItem = new ToolStripMenuItem();
            vsMultiplayerToolStripMenuItem = new ToolStripMenuItem();
            vsComputerToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            howToPlayToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBoard
            // 
            pnlBoard.BackgroundImage = Properties.Resources.Board;
            pnlBoard.BackgroundImageLayout = ImageLayout.Stretch;
            pnlBoard.Location = new Point(12, 51);
            pnlBoard.Name = "pnlBoard";
            pnlBoard.Size = new Size(600, 600);
            pnlBoard.TabIndex = 0;
            pnlBoard.Paint += pnlBoard_Paint;
            pnlBoard.MouseClick += pnlBoard_MouseClick_1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(878, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, gameModeToolStripMenuItem, exitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(73, 29);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(270, 34);
            newGameToolStripMenuItem.Text = "New game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // gameModeToolStripMenuItem
            // 
            gameModeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vsMultiplayerToolStripMenuItem, vsComputerToolStripMenuItem });
            gameModeToolStripMenuItem.Name = "gameModeToolStripMenuItem";
            gameModeToolStripMenuItem.Size = new Size(270, 34);
            gameModeToolStripMenuItem.Text = "Game Mode";
            // 
            // vsMultiplayerToolStripMenuItem
            // 
            vsMultiplayerToolStripMenuItem.Name = "vsMultiplayerToolStripMenuItem";
            vsMultiplayerToolStripMenuItem.Size = new Size(225, 34);
            vsMultiplayerToolStripMenuItem.Text = "Vs Multiplayer";
            vsMultiplayerToolStripMenuItem.Click += vsMultiplayerToolStripMenuItem_Click;
            // 
            // vsComputerToolStripMenuItem
            // 
            vsComputerToolStripMenuItem.Name = "vsComputerToolStripMenuItem";
            vsComputerToolStripMenuItem.Size = new Size(225, 34);
            vsComputerToolStripMenuItem.Text = "Vs Computer";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(270, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { howToPlayToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // howToPlayToolStripMenuItem
            // 
            howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            howToPlayToolStripMenuItem.Size = new Size(270, 34);
            howToPlayToolStripMenuItem.Text = "How to play";
            howToPlayToolStripMenuItem.Click += howToPlayToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 744);
            Controls.Add(pnlBoard);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "CheckersPro";
            Shown += MainForm_Shown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlBoard;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem gameModeToolStripMenuItem;
        private ToolStripMenuItem vsMultiplayerToolStripMenuItem;
        private ToolStripMenuItem vsComputerToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem howToPlayToolStripMenuItem;
    }
}
