﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace JPWP_game
{
    class Ball
    {
        public string direction;
        public int ballLeft;
        public int ballTop;
        private int Speed = 20;
        private PictureBox ball = new PictureBox();
        private Timer ballTimer = new Timer();
        private Form mainForm;
        bool down = false;

        public Ball(Doggo doggo)
        {
            direction = doggo.Where;
            ballLeft = doggo.doggoLeft + (doggo.doggoWidth / 2); 
            ballTop = doggo.doggoTop + (doggo.doggoHeight / 2);
        }
        public void MakeBall(Form form)
        {
            mainForm = form;
            ball.Tag = "ball";
            ball.BackColor = Color.HotPink;
            ball.Size = new Size(10, 10);
            ball.Left = ballLeft;
            ball.Top = ballTop;
            ball.BringToFront();
            form.Controls.Add(ball);
            ballTimer.Interval = Speed;
            ballTimer.Tick += new EventHandler(BallTimerEvent);
            ballTimer.Start();
        }

        public void BallTimerEvent(object sender, EventArgs e)
        {
            if (direction == "left") //wyrzucenie w pilki, w kierunku w ktory skierowany jest doggo
            {
                ball.Left -= Speed;
            }
            if (direction == "right")
            {
                ball.Left += Speed;
            }

            if (ball.Left < 0 || ball.Left > mainForm.Width || ball.Top < 10 || ball.Top > mainForm.Height || down) //pilka znika 
            {
                ballTimer.Stop();           
                ballTimer.Dispose();
                ball.Dispose();
                ballTimer = null;
                ball = null;
                down = false;
            }
            if (ball != null)
            {
                foreach (Control x in mainForm.Controls)
                {
                    if (x is PictureBox && (string)x.Tag == "friend") 
                    {
                        if (ball.Bounds.IntersectsWith(x.Bounds))
                        {
                            down = true; //jesli pilka dotnie przyjaciela znika 
                        }

                    }
                }
            }
        }
    }
}