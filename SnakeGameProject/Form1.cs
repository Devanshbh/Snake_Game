using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SnakeGameProject.Form1;

namespace SnakeGameProject
{
    public partial class Form1 : Form
    {
        Snake Nagini, Frampt;
        Food Apple;
        //create snake and food objects

        public Form1()
        {
            InitializeComponent();
            rbSinglePlayer.Checked = true;
            rbDefaultSpeed.Checked = true;
            Nagini = new Snake(true);
            Frampt = new Snake(false);

            Apple = new Food();
            Apple.CreateFood();
            //initialize object classes and randomize initial food generation

            foodUnderSnake(Nagini, Apple);
            //if apple generation is under snake
           
            btnReset.Enabled = false;
            btnPause.Enabled = false;
            btnChangeSpeed.Enabled = false;
            //set reset and pause to off 

            soloStats.roundSCore = 1;
            //initialize stats to 1 (point for head)
        }

        public struct ScoreBoard
        //score for solo
        {
            public int highScore;
            public int roundSCore;
        }
        ScoreBoard soloStats;

        public struct ScoreBoard2P
        //score for 2 player
        {
            public int win;
            public int tie;
        }
        ScoreBoard2P p1Stats, p2Stats;

        public class BodyPart
        {
            // Defined X and Y position in the 30 by 30 grid.
            public int pX;
            public int pY;
            Color clr;

            //default parameters
            public BodyPart()
            {
                //set snake head at middle of grid
                pX = 15;
                pY = 15;
                clr = Color.Black;
            }
            public BodyPart(int x, int y)
            //set snake parameters constructor
            {
                pX = x;
                pY = y;
                clr = Color.Black;
            }

            public void Draw(Graphics g)
            {
                SolidBrush bodyBrush = new SolidBrush(clr);
                SolidBrush bodyBrushOutline = new SolidBrush(Color.Black);

                g.FillRectangle(bodyBrushOutline, pX * 20 + 2, pY * 20 + 2, 16, 16);
                //create outline for snake part
                g.FillRectangle(bodyBrush, pX * 20, pY * 20, 20, 20);
                //snake body

                //20x20 per square
            }
            public void Draw(Graphics g, Color snakeColor)
            {
                SolidBrush bodyBrush = new SolidBrush(snakeColor);
                SolidBrush bodyBrushOutline = new SolidBrush(Color.Black);

                g.FillRectangle(bodyBrushOutline, pX * 20 + 2, pY * 20 + 2, 16, 16);
                //create outline for snake part

                g.FillRectangle(bodyBrush, pX * 20 + 2, pY * 20 + 2, 16, 16);
                //snake body

                //20x20 per square
            }


        }
        public class Snake
        {
            private int Direction;
            // 1: Up , -1 Down, 2: Right , -2: Left

            List<BodyPart> SnakeBody = new List<BodyPart>();
            //list to count each bodypart 

            public Color clr;
            public Snake()
            {
                SnakeBody.Clear();
                // Clears body parts list

                BodyPart Head = new BodyPart();
                SnakeBody.Add(Head);
                Direction = 2; // default direction - right
                clr = Color.Green;
            }

            public Snake(bool SnakeOne)
            {
                SnakeBody.Clear();
                // Clears body parts list
                if (SnakeOne == true)
                //if player one
                {
                    BodyPart Head = new BodyPart();
                    SnakeBody.Add(Head);
                    clr = Color.Green;
                }
                else
                //else player 2
                {
                    BodyPart Head = new BodyPart(5, 15);
                    //move X coords 10 units to the left
                    SnakeBody.Add(Head);
                    clr = Color.Blue;
                }
                Direction = 2; // default direction - right
            }

            public int GetHeadX()
            //snake head X coordinate
            {
                return SnakeBody[0].pX;
                //index 0 from snake list is head
            }
            public int GetHeadY()
            //snake head Y coordinate
            {
                return SnakeBody[0].pY;
            }
            public int GetDirection()
            //direction snake is moving towards
            {
                return Direction;
            }
            public void SetDirection(string dir)
            {
                if (SnakeBody.Count == 1)
                // snake is only head
                {
                    //if wasd, move in that direction
                    if (dir == "right")
                    //right
                    {
                        Direction = 2;
                    }
                    else if (dir == "left")
                    //left
                    {
                        Direction = -2;
                    }
                    else if (dir == "up")
                    //up
                    {
                        Direction = 1;
                    }
                    else if (dir == "down")
                    //down
                    {
                        Direction = -1;
                    }
                }
                else
                //else check if snake moves into itself
                {
                    if (dir == "right" && Direction != -2)
                    //if click right and NOT going left
                    {
                        Direction = 2;
                    }
                    else if (dir == "left" && Direction != 2)
                    //if click left and NOT going right
                    {
                        Direction = -2;
                    }
                    else if (dir == "up" && Direction != -1)
                    //if click up and NOT going down
                    {
                        Direction = 1;
                    }
                    else if (dir == "down" && Direction != 1)
                    //if click down and NOT going up
                    {
                        Direction = -1;
                    }
                }
            }
            public int CollideOther(Snake other)
            {

                if ((this.GetHeadX() == other.GetHeadX()) && (this.GetHeadY() == other.GetHeadY()))
                //if heads collide with eachother
                {
                    return -1;
                }
                for (int i = 1; i < other.SnakeBody.Count; i++)
                {
                    if ((this.GetHeadX() == other.SnakeBody[i].pX) && (this.GetHeadY() == other.SnakeBody[i].pY))
                    //if p1 head collides with p2 body
                    {
                        return 1;
                    }
                }
                return 0;
            }
            public void Move()
            {
                BodyPart newHead;
                int HeadPosX, HeadPosY;

                HeadPosX = SnakeBody[0].pX;
                HeadPosY = SnakeBody[0].pY;
                //set current head to X and Y of first body in list

                if (Direction == 2)
                {
                    HeadPosX += 1;
                    //increment X towards the right
                }
                else if (Direction == -2)
                {
                    HeadPosX -= 1;
                    //increment X towards the left
                }
                else if (Direction == 1) 
                {
                    HeadPosY -= 1;
                    //increment Y towards up
                }
                else if (Direction == -1) 
                {
                    HeadPosY += 1;
                    //increment Y towards down
                }

                newHead = new BodyPart(HeadPosX, HeadPosY);
                //create head with moved parameters

                SnakeBody.Insert(0, newHead);
                //replace old head
                SnakeBody.RemoveAt(SnakeBody.Count - 1);
                //remove body at end
            }

            public void DrawSnake(Graphics g)
            {
                for (int i = 0; i < SnakeBody.Count; i++)
                //go through snake body
                {
                    SnakeBody[i].Draw(g, clr);
                    //call draw method
                }
            }

            public bool FoodUnderSnake(Food f)
            //check if apple is generated under the snake
            {
                for (int i = 0; i < SnakeBody.Count; i++)
                //go through snake body
                {
                    if (SnakeBody[i].pX == f.fX && SnakeBody[i].pY == f.fY)
                    //if snake and apple coords match
                    {
                        return true;
                        //return true (under snake)
                    }
                }
                return false;
                //else no apple under snake
            }
            public void Grow()
            {
                BodyPart CurrentHead = new BodyPart();
                BodyPart NewHead;

                CurrentHead = SnakeBody[0];
                //set head to XY of first part in list

                int NewHeadX = CurrentHead.pX, NewHeadY = CurrentHead.pY;

                if (Direction == 1) 
                {
                    NewHeadY -= 1;
                    //increment Y towards up
                }
                else if (Direction == -1) 
                {
                    NewHeadY += 1;
                    //increment Y towards down
                }
                else if (Direction == 2) 
                {
                    NewHeadX += 1;
                    //increment X towards the right
                }
                else if (Direction == -2) 
                {
                    NewHeadX -= 1;
                    //increment Y towards the left
                }

                NewHead = new BodyPart(NewHeadX, NewHeadY);

                SnakeBody.Insert(0, NewHead);
                //replace head with new coords
            }


            public bool SelfCollisions()
            {
                for (int i = 1; i < SnakeBody.Count; i++)
                //go through snake body 
                {
                    if (SnakeBody[0].pX == SnakeBody[i].pX && SnakeBody[0].pY == SnakeBody[i].pY)
                    //if head and body coords match
                    {
                        return true;
                        //collided
                    }
                }
                if (GetHeadX() < 0 || GetHeadX() > 29 || GetHeadY() < 0 || GetHeadY() > 29)
                //if out of bounds
                {
                    return true;
                }
                return false;
                //else no collision
            }

            public void resetSnake(int x, int y)
            //reset to default
            {
                SnakeBody.Clear();

                BodyPart Head = new BodyPart(x, y);
                SnakeBody.Add(Head);
                Direction = 2; // default direction is move right

            }

        }

        public class Food
        {
            public Random xyRand;
            //use one random generator to prevent seeding
            public int fX;
            public int fY;
            public Color clr;

            public Food()
            //default constructor
            {
                clr = Color.Red;
                xyRand = new Random();

                //initialize random food generation
            }
            public void CreateFood()
            //randomly generate food coords
            {
                fX = xyRand.Next(0, 30);
                fY = xyRand.Next(0, 30);

                while ((fX == 0 && fY == 0) || (fX == 29 && fY == 0) || (fX == 0 && fY == 29) || (fX == 29 && fY == 29))
                //if apple spawns in any corner
                {
                    fX = xyRand.Next(0, 30);
                    fY = xyRand.Next(0, 30);
                    //randomize pos again
                }
            }
            public void Draw(Graphics g)
            //draw apple
            {
                SolidBrush bodyBrush = new SolidBrush(clr);
                g.FillEllipse(bodyBrush, fX * 20, fY * 20, 20, 20);
            }
        }

        public void foodUnderSnake(Snake snake, Food food)
        {
            while (snake.FoodUnderSnake(food) == true)
            //if apple generation is under snake
            {
                food.CreateFood();
                //regenerate food
                pbPlayArea.Invalidate();
            }
        }

        public void endGame()
        {
            timer.Stop();

            if (rb2Player.Checked == false)
                //if player one
            {
                if (soloStats.roundSCore > soloStats.highScore)
                //if score is bigger than current highscore
                {
                    txtSoloHighScore.Text = soloStats.roundSCore.ToString();
                    soloStats.highScore = soloStats.roundSCore;
                    soloStats.roundSCore = 1;
                    //reset score and update highscore
                }
            }
            else
            {
                btn2PResetScore.Enabled = true;
                //allow user to reset scoreboard
            }

            btnPause.Enabled = false;
            //end game
        }
        public void ReadStatsFromFile()
        {
            try
            {
                TextReader tr = new StreamReader("GameStat.txt");
                //open gamestat txt
                string strInput;
                while ((strInput = tr.ReadLine()) != null)
                    //while reader is reading text
                {
                    soloStats.highScore = Convert.ToInt16(strInput);
                    //output value back into struct stats
                }
                tr.Close();
                //close file
            }
            catch
            {
                MessageBox.Show("File Error!");
                return;
            }
        }


        public void WriteStatsToFile()
        {
            try
            {
                TextWriter tw = new StreamWriter("GameStat.txt");
                tw.WriteLine(soloStats.highScore);
                tw.Close();
            }
            catch
            {
                MessageBox.Show("File Error!");
            }
        }


        public int winChecker()
        {

            //1 = tie, 2 = p1 win, 3 = p2 win

            int collideHeadp2, collideHeadp1;
            bool collideSelfp1, collideSelfp2;

            collideHeadp2 = Frampt.CollideOther(Nagini);
            collideHeadp1 = Nagini.CollideOther(Frampt);
            collideSelfp1 = Nagini.SelfCollisions();
            collideSelfp2 = Frampt.SelfCollisions();
            //call all game end checks

            if (collideHeadp1 == 1 && collideHeadp2 == 1)
            //if both players collide their heads with eachother body
            {
                return 1;
            }
            else if (collideHeadp1 == -1)
            //if both players collide head on
            {
                return 1;
            }
            else if (collideSelfp1 == true && collideSelfp2 == true)
            //if both players collide with their own body or go out of bounds
            {
                return 1;
            }
            else if ((collideSelfp1 == true && collideHeadp2 == 1) || (collideHeadp1 == 1 && collideSelfp2 == true))
            //if p1 collides with self or go out of bounds and p2 collides with p1 body (vice versa)
            {
                return 1;
            }
            else if (collideSelfp1 == true)
            //if p1 goes out of bounds or collides with itself
            {
                return 3;
            }
            else if (collideSelfp2 == true)
            //if p2 goes out of bounds or collides with itself
            {
                return 2;
            }
            else if (collideHeadp1 == 1)
            //if p1 collides with p2 body
            {
                return 3;
            }
            else if (collideHeadp2 == 1)
            //if p2 collides with p1 body
            {
                return 2;
            }
            return 0;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                timer.Start();
                //start game ticker
                btnStart.Enabled = false;
                btnReset.Enabled = true;
                btnPause.Enabled = true;
                gbPlayerMode.Enabled = false;
                gbColChange.Enabled = false;
                gbSpeed.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Error! Please try again");
                return;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (rbSinglePlayer.Checked == true)
                {
                    Nagini.Move();
                    pbPlayArea.Invalidate();
                    //move snakes and refresh paint

                    bool selfCollision = Nagini.SelfCollisions();

                    if (selfCollision == true)
                    //if head collides with body or out of bounds
                    {
                        endGame();
                        MessageBox.Show("Game over!");
                    }
                    else if (Nagini.GetHeadX() == Apple.fX && Nagini.GetHeadY() == Apple.fY)
                    //if nagini head on apple
                    {
                        Nagini.Grow();

                        Apple.CreateFood();
                        //regenerate food and grow snake

                        foodUnderSnake(Nagini, Apple);
                        //if apple generation is under snake


                        soloStats.roundSCore++;
                        txtSoloRoundScore.Text = soloStats.roundSCore.ToString();
                        //update scoreboard
                    }
                }
                else if (rb2Player.Checked == true)
                {
                    Nagini.Move();
                    Frampt.Move();
                    pbPlayArea.Invalidate();
                    //move snakes and refresh paint

                    int winCheck = winChecker();

                    if (winCheck == 1)
                    //if tie
                    {
                        endGame();
                        MessageBox.Show("Game over - Tie!");
                        p1Stats.tie++;
                        p2Stats.tie++;

                        txtTies.Text = p1Stats.tie.ToString();
                        //update ties scoreboard
                    }
                    else if (winCheck == 2)
                    //if p1 win
                    {
                        endGame();
                        MessageBox.Show("Player 1 wins!");
                        p1Stats.win++;

                        txtP1Wins.Text = p1Stats.win.ToString();
                        //update p1 scoreboard
                    }
                    else if (winCheck == 3)
                    //if p2 win
                    {
                        endGame();
                        MessageBox.Show("Player 2 wins!");
                        p2Stats.win++;

                        txtP2Wins.Text = p2Stats.win.ToString();
                        //update p2 scoreboard
                    }
                    else if (Nagini.GetHeadX() == Apple.fX && Nagini.GetHeadY() == Apple.fY)
                    //if p1 head on apple
                    {
                        Nagini.Grow();
                        Apple.CreateFood();
                        //regenerate food and grow snake

                        foodUnderSnake(Nagini, Apple);
                        //if apple generation is under snake
                    }
                    else if (Frampt.GetHeadX() == Apple.fX && Frampt.GetHeadY() == Apple.fY)
                    //if p2 head on apple
                    {
                        Frampt.Grow();
                        //NaginiStats.roundSCore++;
                        Apple.CreateFood();
                        //regenerate food and grow snake

                        foodUnderSnake(Frampt, Apple);
                        //if apple generation is under snak
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error! Please try again");
                return;
            }
        }

        private void pbPlayArea_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Graphics g;
                g = e.Graphics;
                //initialize grid graphics

                int alternator = 0;
                Color colPrimary = Color.FromArgb(162, 199, 109);
                SolidBrush myBrush = new SolidBrush(colPrimary);
                Color colSecondary = Color.FromArgb(164, 212, 97);
                SolidBrush myBrushSecondary = new SolidBrush(colSecondary);
                //create two colours to alternate between

                Pen myPen = new Pen(Color.Black, 3);
                //sets the default values for brush and pen

                for (int col = 0; col < 30; col++)
                {
                    for (int row = 0; row < 30; row++)
                        //go through rows and columns of grid
                    {
                        if (alternator % 2 == 0)
                            //if the "alternator" is even
                        {
                            g.FillRectangle(myBrush, col * 20, row * 20, 20, 20);
                            //create light green squares
                        }
                        else
                        {
                            g.FillRectangle(myBrushSecondary, col * 20, row * 20, 20, 20);
                            //create green squares
                        }
                        alternator++;
                        //increment for each row
                    }
                    alternator++;
                    //incremement when going to a new column
                }
                    if (rb2Player.Checked == true)
                    //if 2 player mode, draw 2nd snake
                {
                    Frampt.DrawSnake(e.Graphics);
                }
                    Nagini.DrawSnake(e.Graphics);
                    Apple.Draw(e.Graphics);
                
                //draw snakes and apple
            }
            catch
            {
                MessageBox.Show("Error! Please try again");
                return;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                string KeyLetter = e.KeyCode.ToString().ToLower();
                //player 1 WASD
                string KeyLetter2p = e.KeyCode.ToString().ToLower();
                //player 2 IJKL

                if (KeyLetter == "d")
                {
                    Nagini.SetDirection("right");
                }
                else if (KeyLetter == "a")
                {
                    Nagini.SetDirection("left");
                }
                else if (KeyLetter == "w")
                {
                    Nagini.SetDirection("up");
                }
                else if (KeyLetter == "s")
                {
                    Nagini.SetDirection("down");
                }
                //get keyletter for p1 (WASD) when pressed down and set to direction term 

                if (rb2Player.Checked == true)
                {
                    if (KeyLetter2p == "l")
                    {
                        Frampt.SetDirection("right");
                    }
                    else if (KeyLetter2p == "j")
                    {
                        Frampt.SetDirection("left");
                    }
                    else if (KeyLetter2p == "i")
                    {
                        Frampt.SetDirection("up");
                    }
                    else if (KeyLetter2p == "k")
                    {
                        Frampt.SetDirection("down");
                    }
                }
                //get keyletter for p2 (IJKL) when pressed down and set to direction term 

            }
            catch
            {
                MessageBox.Show("Error! Please try again");
                return;
            }
        }

        private void btnChangeCol_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbSnake.Checked == false && rbSnakeP2.Checked == false && rbApple.Checked == false)
                {
                    MessageBox.Show("Please select something to change the colour of.");
                }
                else if (ColDialog.ShowDialog() == DialogResult.OK)
                //if user selects OK
                {
                    Color col = ColDialog.Color;

                    if (rbSnake.Checked)
                    //if snake selected
                    {
                        if (rbSnakeP2.Checked == true && col == Frampt.clr)
                        //to prevent confusion with snakes being same colour; if col selected for p1 is same as p2
                        {
                            MessageBox.Show("Player 2 using this colour. Select a different colour.");
                            return;
                        }
                        Nagini.clr = col;
                        //change snake colour
                    }
                    else if (rbSnakeP2.Checked)
                    //if snake p2 selected
                    {
                        if (col == Nagini.clr)
                        //if col selected for p2 is same as p1
                        {
                            MessageBox.Show("Player 1 using this colour. Select a different colour.");
                            return;
                        }
                        Frampt.clr = col;
                    }
                    else if (rbApple.Checked)
                    //if apple selected
                    {
                        Apple.clr = col;
                    }
                    pbPlayArea.Invalidate();
                    MessageBox.Show("Colour changed!");
                }
            }
            catch
            {
                MessageBox.Show("Error! Try again.");
                return;
            }

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            try
            {
                if (timer.Enabled == true)
                //if game not paused
                {
                    timer.Stop();
                    //stop timer
                    btnPause.Text = "Unpause";
                }
                else
                //else game is puased
                {
                    timer.Start();
                    //unpause timer
                    btnPause.Text = "Pause";
                }
            }
            catch
            {
                MessageBox.Show("Error! Try again");
                return;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {

                timer.Stop();
                //stop ticks
                Apple.CreateFood();

                if (rbSnakeP2.Checked == true)
                //if p2 selected
                {
                    foodUnderSnake(Frampt, Apple);
                    //if apple generation is under snake
                }
                else
                {
                    foodUnderSnake(Nagini, Apple);
                    //if apple generation is under snake
                }

                Nagini.resetSnake(15, 15);
                if (rb2Player.Checked == true)
                {
                    Frampt.resetSnake(5, 15);
                }
                soloStats.roundSCore = 1;
                //regenerate food and reset snake 

                btnStart.Enabled = true;
                btnPause.Enabled = false;
                btnReset.Enabled = false;
                btnPause.Text = "Pause";
                //disable pause and reset until game is started
                gbSpeed.Enabled = true;
                gbColChange.Enabled = true;
                gbPlayerMode.Enabled = true;

                pbPlayArea.Invalidate();
                //refresh board
            }
            catch
            {
                MessageBox.Show("Error! Try again");
                return;
            }
        }

        private void rb2Player_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rb2Player.Checked == true)
                {
                    foodUnderSnake(Frampt, Apple);
                    //if apple generation is under snak
                    rbSnakeP2.Visible = true;
                    gb2PScore.Visible = true;
                    gbSoloScore.Visible = false;
                    //if two player, allow user to change p2 snake colour
                    pbPlayArea.Invalidate();
                }
            }
            catch
            {
                MessageBox.Show("Error! Try again.");
                return;
            }
        }

        private void btnColReset_Click(object sender, EventArgs e)
        {
            try
            {
                Apple.clr = Color.Red;
                Nagini.clr = Color.Green;
                if (rb2Player.Checked == true)
                {
                    Frampt.clr = Color.Blue;
                }
                //reset to base colours 

                pbPlayArea.Invalidate();
            }
            catch
            {
                MessageBox.Show("Error! Try again.");
                return;
            }
        }
        private void btn2PResetScore_Click(object sender, EventArgs e)
        {
            try
            {
                p1Stats.win = 0;
                p1Stats.tie = 0;
                p2Stats.win = 0;
                p2Stats.tie = 0;

                txtP1Wins.Text = 0.ToString();
                txtP2Wins.Text = 0.ToString();
                txtTies.Text = 0.ToString();

                btn2PResetScore.Enabled = false;
                //reset stats
            }
            catch
            {
                MessageBox.Show("Error! Try again.");
                return;
            }
        }
        private void rbSinglePlayer_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbSinglePlayer.Checked == true)
                {
                    pbPlayArea.Invalidate();
                }
                rbSnakeP2.Visible = false;
                gb2PScore.Visible = false;
                gbSoloScore.Visible = true;
                //if single player, remove p2 snake col change
            }
            catch
            {
                MessageBox.Show("Error! Try again.");
                return;
            }
        }

        private void btnChangeSpeed_Click(object sender, EventArgs e)
        {
            try
            {
                if (rb150Interval.Checked)
                //if 1.5x speed selected
                {
                    timer.Interval = 150;
                    //change timer interval
                }
                else if (rb100Interval.Checked)
                //else if 2x speed selected
                {
                    timer.Interval = 100;
                }
                else
                //else default speed
                {
                    timer.Interval = 200;
                }
                MessageBox.Show("Speed changed!");
                btnChangeSpeed.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Error! Try again");
                return;
            }
        }

        private void rbDefaultSpeed_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbDefaultSpeed.Checked == true)
                    //if select speed
                {
                    btnChangeSpeed.Enabled = true;
                    //enable speed change
                }
            }
            catch
            {
                MessageBox.Show("Error! Try again");
                return;
            }
        }

        private void rb150Interval_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rb150Interval.Checked == true)
                //if select speed
                {
                    btnChangeSpeed.Enabled = true;
                    //enable speed change
                }
            }
            catch
            {
                MessageBox.Show("Error! Try again");
                return;
            }
        }

        private void rb100Interval_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rb100Interval.Checked == true)
                //if select speed
                {
                    btnChangeSpeed.Enabled = true;
                    //enable speed change
                }
            }
            catch
            {
                MessageBox.Show("Error! Try again");
                return;
            }
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            try
            {
                // If project is closed save file
                WriteStatsToFile();
            }
            catch
            {
                MessageBox.Show("Error! Try again");
                return;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            try
            {
                // call to open saved file
                ReadStatsFromFile();

                txtSoloHighScore.Text = soloStats.highScore.ToString();
            }
            catch
            {
                MessageBox.Show("Error! Try again");
                return;
            }
        }
    } 
}