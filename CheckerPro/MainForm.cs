using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace CheckersPro
{
    public partial class MainForm : Form
    {
        private PictureBox selectedPiece = null;
        private bool isWhiteTurn = true;
        private int tileSize;
        private bool vsComputer = false; 

        public MainForm()
        {
            InitializeComponent();
            // Prevents the board from flickering when pieces move
            this.DoubleBuffered = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetupGame();
        }
        private void pnlBoard_Paint(object sender, PaintEventArgs e)
        {

        }
        private void SetupGame()
        {
            pnlBoard.Controls.Clear();
            // Force a layout update to ensure Width is not 0
            pnlBoard.Update();
            tileSize = pnlBoard.Width / 8;

            isWhiteTurn = true;
            CreatePieces();
        }

        private void CreatePieces()
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    // Logic for dark squares and starting rows
                    if ((row + col) % 2 != 0 && (row < 3 || row > 4))
                    {
                        PictureBox pb = new PictureBox
                        {
                            Size = new Size(tileSize - 10, tileSize - 10),
                            Location = new Point(col * tileSize + 5, row * tileSize + 5),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            BackColor = Color.Transparent,
                            Cursor = Cursors.Hand
                        };

                        // Load base piece images
                        Bitmap bmp = new Bitmap(row < 3 ? Properties.Resources.b : Properties.Resources.w);
                        bmp.MakeTransparent(Color.White);
                        pb.Image = bmp;

                        // Naming for turn logic
                        pb.Name = row < 3 ? $"black_{row}_{col}" : $"white_{row}_{col}";
                        pb.Tag = new Point(col, row);

                        pb.Click += Piece_Click;
                        pnlBoard.Controls.Add(pb);
                        pb.BringToFront(); // Crucial: Brings piece above the background
                    }
                }
            }
        }

        private void Piece_Click(object sender, EventArgs e)
        {
            PictureBox clickedPiece = (PictureBox)sender;
            bool isWhite = clickedPiece.Name.Contains("white");

            if (isWhite == isWhiteTurn)
            {
                if (selectedPiece != null) selectedPiece.BackColor = Color.Transparent;
                selectedPiece = clickedPiece;
                selectedPiece.BackColor = Color.FromArgb(120, Color.Yellow); // Selection highlight
            }
            else
            {
                TriggerVibration();
            }
        }

        private void pnlBoard_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (selectedPiece == null) return;

            int col = e.X / tileSize;
            int row = e.Y / tileSize;

            if (IsValidMove(selectedPiece, col, row))
            {
                // Update Coordinates
                selectedPiece.Location = new Point(col * tileSize + 5, row * tileSize + 5);
                selectedPiece.Tag = new Point(col, row);
                selectedPiece.BackColor = Color.Transparent;

                // Check if this move results in a King
                PromoteIfNecessary(selectedPiece, row);

                isWhiteTurn = !isWhiteTurn;
                selectedPiece = null;
            }
            else
            {
                TriggerVibration();
            }
        }

        private void PromoteIfNecessary(PictureBox pb, int row)
        {
            bool isWhite = pb.Name.Contains("white");
            bool isBlack = pb.Name.Contains("black");

            if ((isWhite && row == 0) || (isBlack && row == 7))
            {
                if (!pb.Name.Contains("king"))
                {
                    pb.Name += "_king";

                    // Create a composite image: Base Piece + Crown
                    Bitmap finalImg = new Bitmap(pb.Image);
                    Bitmap crownImg = new Bitmap(isWhite ? Properties.Resources.king2 : Properties.Resources.king1);
                    crownImg.MakeTransparent(Color.White);

                    using (Graphics g = Graphics.FromImage(finalImg))
                    {
                        // Draw the crown on top of the piece (centered)
                        g.DrawImage(crownImg, 0, 0, finalImg.Width, finalImg.Height);
                    }
                    pb.Image = finalImg;
                }
            }
        }

        private bool IsValidMove(PictureBox piece, int newCol, int newRow)
        {
            Point oldPos = (Point)piece.Tag;
            int rowDiff = newRow - oldPos.Y;
            int colDiff = Math.Abs(newCol - oldPos.X);
            bool isKing = piece.Name.Contains("king");

            // Check if destination square is occupied
            if (GetPieceAt(newCol, newRow) != null) return false;

            // 1. Standard Move (1 square)
            if (colDiff == 1)
            {
                if (isKing && Math.Abs(rowDiff) == 1) return true;
                if (piece.Name.Contains("white") && rowDiff == -1) return true;
                if (piece.Name.Contains("black") && rowDiff == 1) return true;
            }

            // 2. Capture/Jump (2 squares)
            if (colDiff == 2 && Math.Abs(rowDiff) == 2)
            {
                int midRow = (oldPos.Y + newRow) / 2;
                int midCol = (oldPos.X + newCol) / 2;
                PictureBox midPiece = GetPieceAt(midCol, midRow);

                if (midPiece != null)
                {
                    // Must be an enemy piece
                    bool isEnemy = (piece.Name.Contains("white") && midPiece.Name.Contains("black")) ||
                                   (piece.Name.Contains("black") && midPiece.Name.Contains("white"));

                    if (isEnemy)
                    {
                        pnlBoard.Controls.Remove(midPiece);
                        midPiece.Dispose();
                        return true;
                    }
                }
            }
            return false;
        }

        private PictureBox GetPieceAt(int col, int row)
        {
            foreach (Control c in pnlBoard.Controls)
            {
                if (c is PictureBox pb && pb.Tag is Point p && p.X == col && p.Y == row)
                    return pb;
            }
            return null;
        }

        private async void TriggerVibration()
        {
            Point origin = this.Location;
            Random r = new Random();
            for (int i = 0; i < 8; i++)
            {
                this.Location = new Point(origin.X + r.Next(-5, 5), origin.Y + r.Next(-5, 5));
                await System.Threading.Tasks.Task.Delay(20);
            }
            this.Location = origin;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            SetupGame();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to start a new game?",
                "New Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                SetupGame(); // This resets the board and pieces
            }
        }

        private void vsMultiplayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetupGame();
            MessageBox.Show("Local Multiplayer Mode Activated.\nPass the mouse to your friend!", "Mode Switched");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string instructions = "CHECKERS RULES:\n\n" +
                          "1. Move your pieces diagonally forward.\n" +
                          "2. Jump over enemy pieces to capture them.\n" +
                          "3. Reach the last row to become a KING.\n" +
                          "4. Kings can move and jump backwards!\n\n" +
                          "Invalid moves will trigger a screen vibration.";

            MessageBox.Show(instructions, "How to Play", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}