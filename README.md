# checkers-game
A Checkers game made with C# 

This is a C# game made with windows form application you can check out the checkers working game folder where the exported version is there and the code is in the checkerPro folder 
1. INSTALLATION REQUIREMENTS

Requirements:
- It may not work on Older visual studios because of the .slnx file
- and also since we made it on the visual studio 2026 it may not function on visual studio 12 because it uses .NET v10 

Database Setup:
The game will automatically create the database on first launch.
Make sure SQL Server Express is running on: localhost\SQLEXPRESS

Required Files:
- CheckersPro.exe - Main game executable
- rules.txt - Game rules (will be created automatically if missing)
- All resource images in the Resources folder:
  - board_classic.png, board_dark.png, board_wood.png
  - w.png, b.png, king1.png, king2.png
  - move_sound.wav, king_sound.wav, error_sound.wav


2. GETTING STARTED

Launching the Game:
1. Double-click CheckersPro.exe
2. The Landing Screen appears with two options:
   - "START GAME" -> Login or Register
   - "Continue as Guest" -> Play without account

Login Screen Flow:
1. Enter a username
2. System checks if username exists:
   - If EXISTS -> Enter password and click "Login"
   - If NEW -> Create password, confirm, click "Register"
3. Or click "Continue as Guest" to skip account creation

Guest Mode Limitations:
- No statistics saved
- No match history
- Cannot change password
- Cannot access profile features

After Login:
You will proceed to the Mode Selection screen automatically.


3. GAME MODES

Mode Selection Screen:
Two game modes are available:

MULTIPLAYER:
- 2 players on same PC
- Each player gets own window
- Supports dual monitors
- Controller minimizes to system tray

VS COMPUTER:
- Play against AI
- Choose difficulty level (Easy, Medium, Hard)
- Choose your color (White or Black)
- Perfect for solo play

Setup Screen Options:
- Your Name - Enter player name (auto-completes from existing users)
- Player 2 Name - (Multiplayer only)
- Play as - White/Black (vs Computer only)
- Time Limit - No Limit, 30s, 60s, 90s per move
- AI Difficulty - Easy, Medium, Hard (vs Computer only)
- Board Theme - Classic, Dark, Wood


4. HOW TO PLAY - BASIC RULES

The Board:
- 8x8 grid (64 squares)
- Only the 32 dark squares are used for play
- White player starts at the bottom
- Black player starts at the top

Basic Movement:
- Pieces move diagonally forward one square at a time
- White moves DOWN the board (toward row 7)
- Black moves UP the board (toward row 0)
- You cannot move onto a square occupied by another piece

Capturing (Jumping):
- To capture an opponent's piece, jump over it diagonally
- The landing square must be empty
- Captured pieces are removed from the board

MANDATORY CAPTURE RULE - VERY IMPORTANT!
- If a capture is available, you MUST take it!
- You cannot make a non-capturing move when a capture exists
- The game will force you to capture

Multiple Jumps:
- After capturing, if the same piece can capture again, you MUST continue
- The game will not end your turn until no more captures are possible

King Promotion:
- When a piece reaches the opposite end of the board, it becomes a KING
- White kings are created at row 0 (top)
- Black kings are created at row 7 (bottom)
- Kings are marked with a gold crown (♔)

Winning the Game:
- Capture ALL of your opponent's pieces
- OR block your opponent so they have no legal moves
- OR your opponent resigns


5. ADVANCED RULES - FLYING KINGS

International Checkers Rule:
- Kings can move ANY number of squares diagonally!
- Kings can capture from ANY distance!

King Movement Examples:
- A king can move 1, 2, 3, 4, 5, 6, or 7 squares diagonally
- All squares in between must be empty
- The king stops when it reaches another piece or the edge

King Capture (Flying Capture):
- A king can capture a piece from any distance
- It jumps over the opponent piece and lands on any empty square behind it
- Multiple captures are possible (even changing directions!)

Example:
Before:  K . . . . O . .
After:   . . . . . K . .
(King jumped over opponent piece 4 squares away)


6. CONTROLS & SHORTCUTS

Mouse Controls:
- LEFT CLICK on a piece -> Select it (turns yellow)
- LEFT CLICK on a green circle -> Move selected piece there
- Hover over pieces -> Cursor changes to hand

Visual Indicators:
- Yellow highlight -> Selected piece
- Green circles -> Valid moves
- Orange highlight -> Mandatory capture (must jump)
- Red border on timer -> Time running low
- "MUST CAPTURE!" text -> Capture available

Game Display:
- Top of board shows coordinates (a-h, 8-1)
- Turn indicator shows whose turn it is
- Timer shows time remaining (if enabled)
- Undo counter shows remaining undos


7. GAME FEATURES

Timer System:
- Optional time limit per move (30s, 60s, 90s)
- Timer color coding:
  - Green -> Good time
  - Yellow -> 10 seconds or less
  - Red -> 5 seconds or less
- Time runs out -> Turn is skipped

Undo Feature:
- Maximum 3 undos per game
- Cannot undo capture moves
- Undo count resets on new game
- Shortcut: Ctrl+Z

Save & Resume:
- Auto-save option (enable in Settings)
- Game saves automatically on close
- Resume game on next launch
- Manual save via Game -> Save Game

Board Themes:
- Classic - Traditional wood colors
- Dark - Dark gray/black squares
- Wood - Dark wood texture

Sound Effects:
- Move sound - Plays when moving a piece
- King sound - Plays when piece becomes king
- Error sound - Plays on invalid moves
- Toggle on/off in Settings

AI Difficulties (vs Computer):
- EASY - Random moves with capture priority
- MEDIUM - Strategic play, prefers center, avoids edges
- HARD - Advanced evaluation, looks ahead 1-2 moves


8. SETTINGS MENU

Access Settings: Game Menu -> Settings

AUDIO:
- Sound Effects Volume - Adjust slider (0-100%)
- Enable Sound Effects - Toggle all sounds on/off

GAMEPLAY:
- Show Move Hints - Toggle green circle hints
- Auto-Save - Enable/disable auto-resume feature
- Animation Speed - Slow/Normal/Fast/Off
- Default Difficulty - Preset for vs Computer mode (Easy/Medium/Hard)
- Default Time Limit - Preset time limit for new games

VISUAL:
- Board Theme - Classic/Dark/Wood
- Piece Style - Classic/Modern


9. PROFILE & ACCOUNT MANAGEMENT

Access Profile: Account -> My Profile

Profile Tabs:

OVERVIEW:
- Username and Email
- Join date and Last Played
- Wins, Losses, Games Played, Win Rate
- Reset Statistics button

MATCH HISTORY:
- List of recent games (up to 20)
- Shows Date, Mode, Players, Winner, Result
- Green = Win, Red = Loss

CHANGE PASSWORD:
- Enter current password
- Enter new password (min 4 characters)
- Confirm new password

ACCOUNT (Danger Zone):
- Reset Statistics - Sets wins/games to zero
- Delete Account - Permanently removes account (requires "DELETE" confirm)


10. LEADERBOARD

Access Leaderboard: Account -> Leaderboard

Two Tabs:
- MULTIPLAYER - Rankings for multiplayer games only
- VS COMPUTER - Rankings for AI games only

Columns:
- # - Rank position (1, 2, 3 highlighted)
- Player - Username
- Wins - Number of victories
- Losses - Number of defeats
- Games - Total games played
- Last Played - Date and time of last game




11. KEYBOARD SHORTCUTS SUMMARY

SHORTCUT - ACTION
Ctrl + N - New Game
Ctrl + Z - Undo Move (max 3 per game)
Enter - Submit in Login/Register forms
Escape - Close current dialog



CheckersPro - The Ultimate Checkers Experience

Developed with C# and Windows Forms

Features:
- International Checkers Rules (Flying Kings)
- Single-player vs AI with 3 difficulty levels
- Two-player Multiplayer with separate windows
- Account system with secure password hashing
- Persistent settings and save games
- Customizable board themes
- Sound effects
- Statistics tracking and leaderboards
