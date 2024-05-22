﻿
namespace Race
{
    public partial class RaceGame : Form
    {
        public RaceGame()
        {
            InitializeComponent();
        }

        Label[] lanesOne;
        Label[] lanesTwo;
        Label[] lanesMenuOne;
        Label[] lanesMenuTwo;

        PictureBox[] coinsCollection;
        PictureBox[] towardCars;
        PictureBox[] menuCars;

        Random random = new Random();

        int score = 0;
        int coins = 0;
        int startSpeed = 2;
        int carSpeed = 2;
        int costRepairs = 15;


        private void RaceGame_Load(object sender, EventArgs e)
        {
            towardCars = new PictureBox[] { towardCar1, towardCar2, towardCar3 };
            menuCars = new PictureBox[] { menuCar1, menuCar2, menuCar3 };

            lanesOne = new Label[] { LaneOne1, LaneOne2, LaneOne3, LaneOne4, LaneOne5 };
            lanesTwo = new Label[] { LaneTwo1, LaneTwo2, LaneTwo3, LaneTwo4, LaneTwo5 };

            lanesMenuOne = new Label[] { MenuOneLane1, MenuOneLane2, MenuOneLane3, MenuOneLane4, MenuOneLane5 };
            lanesMenuTwo = new Label[] { MenuTwoLane1, MenuTwoLane2, MenuTwoLane3, MenuTwoLane4, MenuTwoLane5 };

            coinsCollection = new PictureBox[] { Coin1, Coin2, Coin3 };

            timerRoad.Stop();
            timerTowardCars.Stop();
            panelMenu.Show();
        }

        private void StartGame()
        {
            score = 0;
            coins = 0;
            carSpeed = startSpeed;

            timerRoad.Start();
            timerTowardCars.Start();
            timerMenu.Stop();

            for (int i = 0; i < towardCars.Length; i++)
            {
                StartTowardCar(i);
            }

            panelPause.Hide();
            panelGame.Show();
            panelMenu.Hide();
        }

        private void timerRoad_Tick(object sender, EventArgs e)
        {
            AddScore();

            MoveLanes(lanesOne);

            MoveLanes(lanesTwo);

            MoveCoins();

            CollectCoins();
        }

        private void RaceGame_KeyDown(object sender, KeyEventArgs e)
        {
            var stepSide = 9;
            var maxSpeed = 21;
            var carWidthHalf = mainCar.Width / 2;



            if (e.KeyCode == Keys.Right)
            {
                if (mainCar.Right < ClientSize.Width - carWidthHalf)
                {
                    mainCar.Left += stepSide;
                    return;
                }

                mainCar.Left = -carWidthHalf;

            }

            if (e.KeyCode == Keys.Left)
            {
                if (mainCar.Left > -carWidthHalf)
                {
                    mainCar.Left -= stepSide;
                    return;
                }

                mainCar.Left = ClientSize.Width - carWidthHalf;
            }

            if (e.KeyCode == Keys.Up)
            {
                if (carSpeed < maxSpeed)
                {
                    carSpeed++;
                    return;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (carSpeed > 0)
                {
                    carSpeed--;
                    return;
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                timerRoad.Enabled = false;
                timerTowardCars.Enabled = false;
                panelPause.Show();
            }
        }

        private void timerTowardCars_Tick(object sender, EventArgs e)
        {
            var speedDifference = new int[] { 4, 2, 3 };

            for (int i = 0; i < towardCars.Length; i++)
            {
                towardCars[i].Top += carSpeed + speedDifference[i];

                if (towardCars[i].Top > Height)
                {
                    StartTowardCar(i);
                }
            }

            for (int i = 0; i < towardCars.Length; i++)
            {
                if (mainCar.Bounds.IntersectsWith(towardCars[i].Bounds))
                {
                    GameOver();
                    return;
                }
            }
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            MoveLanes(lanesMenuOne);

            MoveLanes(lanesMenuTwo);

            var speedDifference = new int[] { 5, 3, 4 };


            for (int i = 0; i < menuCars.Length; i++)
            {
                menuCars[i].Top += carSpeed + speedDifference[i];

                if (menuCars[i].Top > Height)
                {
                    StartMenuCar(i);
                }
            }
        }

        private void GameOver()
        {
            timerRoad.Stop();
            timerTowardCars.Stop();

            if (coins < costRepairs)
            {
                MessageBox.Show("Game Over!", "Приехали!");
                panelPause.Show();
                panelMenu.Show();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Продолжить? (-15 coins)", "Приехали!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                    Restart();

                else if (dialogResult == DialogResult.No)
                {
                    panelPause.Show();
                    panelMenu.Show();
                }
            }
        }

        private void Restart()
        {
            coins -= costRepairs;
            labelCoins.Text = "Coins: " + coins;
            carSpeed = startSpeed;

            timerRoad.Start();
            timerTowardCars.Start();

            for (int i = 0; i < towardCars.Length; i++)
            {
                StartTowardCar(i);
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {

            timerRoad.Enabled = false;
            timerTowardCars.Enabled = false;
            panelPause.Show();
        }

        private void buttonResume_Click(object sender, EventArgs e)
        {
            timerRoad.Enabled = true;
            timerTowardCars.Enabled = true;
            panelPause.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            panelMenu.Show();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"..\..\..\help.chm");
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            StartGame();
            panelGame.Show();
            panelMenu.Hide();
        }

        private void buttonMenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MoveLanes(Label[] lanes)
        {
            for (int i = 0; i < lanes.Length; ++i)
            {
                lanes[i].Top += carSpeed;

                if (lanes[i].Top >= Height)
                {
                    lanes[i].Top = -lanes[i].Height;
                }
            }
        }

        private void StartMenuCar(int index)
        {
            GetNewPictureBoxLocation(menuCars[index]);
        }

        private void StartTowardCar(int index)
        {
            GetNewPictureBoxLocation(towardCars[index]);
        }

        private void GetNewCoinLocation(int index)
        {
            GetNewPictureBoxLocation(coinsCollection[index]);
        }

        private void GetNewPictureBoxLocation(PictureBox pictureBox)
        {
            pictureBox.Top = -pictureBox.Height;
            pictureBox.Left = random.Next(0, ClientSize.Width - pictureBox.Width);
        }


        private void MoveCoins()
        {
            for (int i = 0; i < coinsCollection.Length; i++)
            {
                PushCoin(i);

                if (coinsCollection[i].Top > Height)
                {
                    GetNewCoinLocation(i);
                }
            }
        }

        private void PushCoin(int index)
        {
            coinsCollection[index].Top += carSpeed; ;
        }

        private void CollectCoins()
        {
            for (int i = 0; i < coinsCollection.Length; i++)
            {
                if (mainCar.Bounds.IntersectsWith(coinsCollection[i].Bounds))
                {
                    AddCoinsNumber();
                    GetNewCoinLocation(i);
                }
            }
        }

        private void AddScore()
        {
            if (carSpeed != 0)
            {
                score++;
                labelScore.Text = "Score: " + score / 10;
            }
        }

        private void AddCoinsNumber()
        {
            coins++;
            labelCoins.Text = "Coins: " + coins;
        }
    }
}

