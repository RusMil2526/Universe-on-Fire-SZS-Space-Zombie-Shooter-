using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Universe_on_fire
{
    public partial class UniverseOnFire : Form
    {
        Boolean goLeft, goRight, goUp, goDown, gameOver, stopMenu, helpMenu, historyMenu;
        string facing = "up";
        int playerHealth = 100;
        int speed = 10;
        int ammo = 10;
        int score;
        int zombieShipspeed = 3;

        Random randNum = new Random();

        List<PictureBox> zombieShipList = new List<PictureBox>();

        public UniverseOnFire()
        {
            InitializeComponent();
            RestartGame();
        }


        private void MainTimerEvent(object sender, EventArgs e)
        {

            if(score == 100)
            {
                gameOver = true;
                GameOver("You win!");
            }
            if (playerHealth > 1)
            {
                healthBar.Value = playerHealth;

            }
            else
            {
                gameOver = true;
                player.Image = Properties.Resources.Dead;
                GameOver("You lose!");
            }

            txtAmmo.Text = "Ammo: " + ammo;
            txtScore.Text = "Destroyed: " + score; 

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= speed;
            }

            if(goRight == true && player.Left + player.Width < this.ClientRectangle.Width)
            {
                player.Left += speed;
            }

            if (goUp == true && player.Top > 47)
            {
                player.Top -= speed;
            }
            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "ammo")
                {
                    if(player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 5;
                    }
                }

                if(x is PictureBox && (string)x.Tag == "zombieShip")
                {
                    if(player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;
                    }

                    if(x.Left > player.Left)
                    {
                        x.Left -= zombieShipspeed;
                        ((PictureBox)x).Image = Properties.Resources.enLeft;
                    }

                    if (x.Left < player.Left)
                    {
                        x.Left += zombieShipspeed;
                        ((PictureBox)x).Image = Properties.Resources.enRight;

                    }

                    if (x.Top > player.Top)
                    {
                        x.Top -= zombieShipspeed;
                        ((PictureBox)x).Image = Properties.Resources.enUp;

                    }

                    if (x.Top < player.Top)
                    {
                        x.Top += zombieShipspeed;
                        ((PictureBox)x).Image = Properties.Resources.enDown;

                    }
                }

                foreach(Control j in this.Controls)
                {
                    if(j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombieShip")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            zombieShipList.Remove(((PictureBox)x));
                            MakeZombiesShip();
                        }
                    }
                }

            }
        }


        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(gameOver == true)
            {
                return;
            }
            if (e.KeyCode == Keys.Left) 
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.Left;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.Right;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.Up;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.Down;
            }

            if (e.KeyCode == Keys.Escape && stopMenu == true)
            {
                stopMenu = false;
                txtPauseM.Visible = true;
                panelPauseMenu.Visible = true;
                txtPauseResume.Visible = true;
                txtPauseExit.Visible = true;
                txtPauseHelp.Visible = true;
                player.Visible = false;
                txtPauseHistory.Visible = true;
                panelPauseMenu.Enabled = true;

                GameTimer.Enabled = false;



            }

            if (e.KeyCode == Keys.H && helpMenu == true)
            {
                helpMenu = false;
                panelSettings.Visible = true;
                panelSettings.Enabled = true;
                txtSettingsGoBack.Visible = true;
                pictureBoxSettingsEscape.Visible = true;
                pictureBoxSettingsSide.Visible = true;
                pictureBoxSettingsEnter.Visible = true;
                txtSettings.Visible = true;
                txtSettingsUp.Visible = true;
                txtSettingsLeft.Visible = true;
                txtSettingsRight.Visible = true;
                txtSettingsEnter.Visible = true;
                txtSettingsDown.Visible = true;
                txtSettingsEscape.Visible = true;
                txtSettingsGoal.Visible = true;
                txtSettingsGoalExplain.Visible = true;
                player.Visible = false;
                GameTimer.Enabled = false;
            }

            if (e.KeyCode == Keys.Tab && historyMenu == true)
            {
                historyMenu = false;
                panelHistory.Visible = true;
                panelHistory.Enabled = true;
                pictureBoxHistory_1.Visible = true;
                pictureBoxHistoryTheSavior.Visible = true;
                pictureBoxHistoryProfile.Visible = true;
                pictureBoxHistoryZombie.Visible = true;
                txtHistory_1.Visible = true;
                txtHistoryTheSavior.Visible = true;
                txtHistoryProfile.Visible = true;
                txtHistoryQuit.Visible = true;
                txtHistoryZombie.Visible = true;
                player.Visible = false;
                GameTimer.Enabled = false;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;

            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;

            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;

            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;

            }
            if(e.KeyCode ==  Keys.Space && ammo > 0 && gameOver == false)
            {
                ammo--;
                ShootBullet(facing);

                if(ammo < 1)
                {
                    DropAmmo();
                }
            }

            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }

            if (e.KeyCode == Keys.Escape && stopMenu == false)
            {

                stopMenu = true;
                txtPauseM.Visible = false;
                panelPauseMenu.Visible = false;
                panelPauseMenu.Enabled = false;
                txtPauseResume.Visible = false;
                txtPauseExit.Visible = false;
                txtPauseHelp.Visible = false;
                player.Visible = true;
                txtPauseHistory.Visible = false;
                GameTimer.Enabled = true;
            }

            if(e.KeyCode == Keys.H && helpMenu == false)
            {
                helpMenu = true;
                panelSettings.Visible = false;
                panelSettings.Enabled = false;
                txtSettingsGoBack.Visible = false;
                pictureBoxSettingsEscape.Visible = false;
                pictureBoxSettingsSide.Visible = false;
                pictureBoxSettingsEnter.Visible = false;
                txtSettings.Visible = false;
                txtSettingsUp.Visible = false;
                txtSettingsLeft.Visible = false;
                txtSettingsRight.Visible = false;
                txtSettingsEnter.Visible = false;
                txtSettingsDown.Visible = false;
                txtSettingsEscape.Visible = false;
                txtSettingsGoal.Visible = false;
                txtSettingsGoalExplain.Visible = false;
                player.Visible = true;
                GameTimer.Enabled = true;
            }

            if(e.KeyCode == Keys.Tab && historyMenu == false)
            {
                historyMenu = true;
                panelHistory.Enabled = false;
                panelHistory.Visible = false;
                pictureBoxHistory_1.Visible = false;
                pictureBoxHistoryTheSavior.Visible = false;
                pictureBoxHistoryProfile.Visible = false;
                pictureBoxHistoryZombie.Visible = false;
                txtHistory_1.Visible = false;
                txtHistoryTheSavior.Visible = false;
                txtHistoryProfile.Visible = false;
                txtHistoryQuit.Visible = false;
                txtHistoryZombie.Visible = false;
                player.Visible = true;
                GameTimer.Enabled = true;                                                                   
            }

            if(e.KeyCode == Keys.Q )
            {
                Close();
            }
        }



        private void butBackToMenu_Click(object sender, EventArgs e)
        {

        }

        private void butPauseSettings_Click(object sender, EventArgs e)
        {
                                                                                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSettings_Click(object sender, EventArgs e)
        {

        }







        private void txtSettingsGoalExplain_Click(object sender, EventArgs e)
        {

        }

        private void txtRestart_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxHistoryTheSavior_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxHistoryZombie_Click(object sender, EventArgs e)
        {

        }

        private void panelSettings_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShootBullet(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);
            shootBullet.MakeBullet(this);

        }

        private void GameOver(string message)
        {
            gameOver = true;
            GameTimer.Stop();

            txtGameIsOver.Text = message;
            txtGOScore.Text = "Score: " + score;
            txtGameIsOver.Visible = true;
            txtRestart.Visible = true;
            txtGOScore.Visible = true;
            panelGameOver.Visible = true;

        }

        private void MakeZombiesShip()
        {
            PictureBox zombieShip = new PictureBox();
            zombieShip.Tag = "zombieShip";
            zombieShip.Image = Properties.Resources.enDown;
            zombieShip.Left = randNum.Next(0, 900);
            zombieShip.Top = randNum.Next(0, 800);
            zombieShip.SizeMode = PictureBoxSizeMode.AutoSize;
            zombieShipList.Add(zombieShip);
            this.Controls.Add(zombieShip);
            player.BringToFront();
        }

        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(60, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);

            ammo.BringToFront();
            player.BringToFront();
        }



        private void RestartGame()
        {
            player.Image = Properties.Resources.Up;

            foreach(PictureBox i in zombieShipList)
            {
                this.Controls.Remove(i);
            }
            zombieShipList.Clear();
            for(int i = 0; i < 3; i++)
            {
                MakeZombiesShip();
            }
            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            gameOver = false;
            txtGameIsOver.Visible = false;
            txtRestart.Visible = false;
            txtGOScore.Visible = false;
            panelGameOver.Visible = false;
            score = 0;                      
            playerHealth = 100;
            ammo = 10;

            GameTimer.Start();
        }

    }
}
