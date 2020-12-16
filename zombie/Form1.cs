using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zombie
{
    public partial class Form1 : Form
    {
        bool goLeft, goRight, goUp, goDown, gameOver;
        string facing = "up";
        int playerHealth = 100;
        int speed = 10;
        int ammo = 10;
        int Zombiespeed = 3;
        Random randomNum = new Random();
        List<PictureBox> zombieList = new List<PictureBox>();
        int score;
        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            if (playerHealth > 1)
            {
                HealthBar.Value = playerHealth;
               
            }
            else
            {
                gameOver = true;
                Player.Image = Properties.Resources.dead;
                GameTimer.Stop();
            }

            AmmoTxt.Text = "Ammo: " + ammo;
            KilsTxt.Text = "kills:" + score;

            if(goLeft == true && Player.Left>0)
            {
                Player.Left -= speed;
            }
            if(goRight ==true &&Player.Left + Player.Width < this.ClientSize.Width)
            {
                Player.Left += speed;
            }
            if(goUp == true && Player.Top>50)
            {
                Player.Top -= speed;
            }

            if(goDown == true && Player.Top + Player.Height < this.ClientSize.Height)
            {
                Player.Top += speed;
            }

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "ammo")
                {
                   
                    if (Player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 5;

                    }
                }
                if(x is PictureBox && (string)x.Tag == "zombie")
                {
                    if (Player.Bounds.IntersectsWith(x.Bounds)){
                        playerHealth -= 1;
                    }
                    if (x.Left > Player.Left)
                    {
                        x.Left -= Zombiespeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft;

                    }
                    if (x.Left <Player.Left)
                    {
                        x.Left += Zombiespeed;
                        ((PictureBox)x).Image = Properties.Resources.zright;

                    }
                    if (x.Top > Player.Top)
                    {
                        x.Top -= Zombiespeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown;

                    }
                    if (x.Top < Player.Top)
                    {
                        x.Top += Zombiespeed;
                        ((PictureBox)x).Image = Properties.Resources.zup;

                    }
                    foreach (Control j in this.Controls)
                    {
                        if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombie")
                        {
                            if (x.Bounds.IntersectsWith(j.Bounds))
                            {
                                score++;
                                this.Controls.Remove(j);
                                ((PictureBox)j).Dispose();


                                this.Controls.Remove(x);
                                ((PictureBox)x).Dispose();
                                zombieList.Remove(((PictureBox)x));
                                MakeZombies();
                            }
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
            if(e.KeyCode ==Keys.Left)
            {
                goLeft = true;
                facing = "left";
                Player.Image = Properties.Resources.left;
            }
            if(e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                Player.Image = Properties.Resources.right;
            }
            if(e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                Player.Image = Properties.Resources.up;
            }
            if(e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                Player.Image = Properties.Resources.down;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
            if(e.KeyCode ==Keys.Space && ammo > 0 && gameOver ==false)

            {
                ammo--;
                ShootBullets(facing);
                if(ammo<1)
                {
                    DropAmmo();
                }
            }
            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }
        }
        private void ShootBullets(string direction)
        {
            Bullets shootBullet = new Bullets();
            shootBullet.direction = direction;
            shootBullet.bulletsLeft = Player.Left + (Player.Width / 2);
            shootBullet.bulletTop = Player.Top + (Player.Height / 2);
            shootBullet.MakeBullets(this);

        }
        private void MakeZombies()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            zombie.Left = randomNum.Next(0, 900);
            zombie.Top = randomNum.Next(0, 800);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            zombieList.Add(zombie);
            this.Controls.Add(zombie);
            Player.BringToFront();

        }
        private void DropAmmo()
        {
            PictureBox ammu = new PictureBox();
            ammu.Image = Properties.Resources.ammo_Image;
            ammu.SizeMode = PictureBoxSizeMode.AutoSize;
            ammu.Left = randomNum.Next(10, this.ClientSize.Width - ammu.Width);
            ammu.Top = randomNum.Next(60, this.ClientSize.Height - ammu.Height);
            ammu.Tag = "ammo";
            this.Controls.Add(ammu);
            ammu.BringToFront();
            Player.BringToFront();
        }
        private void RestartGame()
        {
            Player.Image = Properties.Resources.up;
            foreach(PictureBox i in zombieList)
            {
                this.Controls.Remove(i);

            }
            zombieList.Clear();


            for(int i =0;i<3;i++)
            {
                MakeZombies();
            }
            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            gameOver = false; 

            playerHealth = 100;
            score = 0;
            ammo = 10;
            GameTimer.Start();
        }
    }
}
