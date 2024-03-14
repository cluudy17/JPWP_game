using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace JPWP_game
{
    public class Doggo
    {
        public bool GoLeft, GoRight, GoUp, fall;
        public bool Level2=true;
        public bool end = false;
        int Speed = 7;
        public int Score = 0;
        public string Where;
        public int doggoLeft, doggoWidth, doggoHeight, doggoTop, force, jumpSpeed;
        public PictureBox doggo = new PictureBox();
        private Form mainForm;
        public Doggo()
        {
        }
        public Doggo(Form form)
        {
            mainForm = form;
        }

        public void MakeDoggo(Form form)
        {
            doggo.Left =0;
            doggo.Top = 859;
            doggoLeft = doggo.Left;
            doggoTop = doggo.Top;
            doggo.SizeMode = PictureBoxSizeMode.Zoom;          
            doggo.Image = Properties.Resources.sit_right;
            doggo.BackColor = Color.Transparent;
            doggo.Size = new Size(100, 70);
            doggoWidth = doggo.Size.Width;
            doggoHeight = doggo.Size.Height;
            doggo.BringToFront();
            form.Controls.Add(doggo);
        }
        public void move(Form form)
        {
            doggo.BringToFront();

            if (GoLeft == true && doggo.Left > 0) //ruch w lewo
            {
                doggo.Image = Properties.Resources.walk_left; //zmiana wygladu
                Where = "left";
                doggo.Left -= Speed;
                doggoLeft = doggo.Left; //zmiana polozenia-wrazenie ruchu
            }

            if (GoRight == true && (doggo.Left + doggo.Width) < form.Width) //ruch w prawo
            {
                doggo.Image = Properties.Resources.walk_right; //zmiana wygladu
                doggo.Left += Speed;
                doggoLeft = doggo.Left; //zmiana polozenia-wrazenie ruchu
                Where = "right";
            }

            if (GoUp == true && (doggo.Top + doggo.Height > 50)) //skok
            {
                doggo.Top -= Speed;
                doggoTop = doggo.Top;
                force = Speed;
                if (Where == "left") //zmienia zdjecie, aby doggo byl zwrocony w strone, w ktora sie porusza
                {
                   doggo.Image = Properties.Resources.jump_left;
                }
                else
                {
                   doggo.Image = Properties.Resources.jump_right;
                }
            }
            else
            {
                if (doggo.Top < 859)   //"grawitacja"
                {
                    doggo.Top += force;
                    doggoTop = doggo.Top;

                }
            }

            if (GoRight == false && GoLeft == false && GoUp == false) //brak ruch - doggo stoi
            {
                if (Where == "left") //zwrot doggo zgodny z kierunkiem, w ktorym sie poruszal wczesniej
                {
                   doggo.Image = Properties.Resources.stand_left;
                }
                else
                {
                    doggo.Image = Properties.Resources.stand_right;
                }
            }

            foreach (Control x in form.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform") 
                {
                    if (doggo.Bounds.IntersectsWith(x.Bounds) && !GoUp)
                    {
                        doggo.Top = x.Top - doggo.Height;
                        force = 0;
                    }
                    if (!doggo.Bounds.IntersectsWith(x.Bounds) && GoRight || GoLeft)
                    {
                        force = 7;
                    }
                    if (doggo.Bounds.IntersectsWith(x.Bounds) && GoUp) //wskoczenie na platforme
                    {
                        doggo.Top = x.Top + doggo.Height;
                        GoUp = false;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "treat") 
                {
                    if (doggo.Bounds.IntersectsWith(x.Bounds)) //treat znika, jest zbierany przez doggo
                    {
                        Score += 1;
                        x.Dispose();
                    }
                }
                if (x is PictureBox && (string)x.Tag == "door" && Level2 == true) //przejscie do kolejnego poziomu
                {
                    if (doggo.Bounds.IntersectsWith(x.Bounds)) 
                     {
                        Level2 = false;
                        Level2 level2 = new Level2();
                        level2.ShowDialog();
                      

                     }
                }
                if (x is PictureBox && (string)x.Tag == "House" && end == false) //zakonczenie gry, dotarcie do domu
                {
                    if (doggo.Bounds.IntersectsWith(x.Bounds))
                    {
                        end =true;
                        Win win = new Win();
                        win.ShowDialog();


                    }
                }

                if (x is PictureBox && (string)x.Tag == "cat" && end== false) //koniec gry, po dotknieciu kota
                {
                     if (doggo.Bounds.IntersectsWith(x.Bounds))
                      {
                            end = true;
                          GameOver gameover = new GameOver();
                          gameover.ShowDialog();
                       }
                }

                if (x is PictureBox && (string)x.Tag == "friend") 
                {
                    if (doggo.Bounds.IntersectsWith(x.Bounds) && !GoUp) 
                    {
                        doggo.Top = x.Top - doggo.Height; 
                        force = 0;
                     
                    }

                }
            }
        }
    }
}