using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPWP_game
{
    public partial class Level1 : Form
    {
        Doggo doggo = new Doggo();
        
        

        public Level1()
        {
            InitializeComponent();
            Application.OpenForms["Menu"].Hide(); // zamyka okno ładowania po otwarciu menu  
            doggo.MakeDoggo(this);
            Friend friend1 = new Friend(this, 692, 600, "5x+3y+2x+6xy+4y=7x+7y+6xy", "Y", 1);
            Friend friend2 = new Friend(this, 102, 400, "3x^2+2x+5x^2=10x^2", "N", 2);
            Friend friend3 = new Friend(this, 142, 60, "(3x^2+5)⋅(7x−2)=21x^3−6x^2+35x−10", "Y", 3);
          
        }

        public void MainTimerEvent(object sender, EventArgs e)
        {
 
            doggo.move(this);
            if (doggo.Score > 5)
            {
                door.BackgroundImage = Properties.Resources.door_opem;
            }
   
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                doggo.GoLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                doggo.GoRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                doggo.GoUp = false;
            }
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                doggo.GoLeft = true;
                doggo.Where = "left";
            }

            if (e.KeyCode == Keys.Right)
            {
                doggo.GoRight = true;
                doggo.Where = "right";
            }

            if (e.KeyCode == Keys.Up)
            {
                doggo.GoUp = true;
            }

            if (e.KeyCode == Keys.A)
            {
                Ball throwaball = new Ball(doggo);
                throwaball.MakeBall(this);
            }

        }

        // przycisk menu
        private void menu_Click(object sender, EventArgs e) // otwiera menu
        {
            GameMenu menu = new GameMenu();
            menu.ShowDialog();
        }

        private void menu_MouseHover(object sender, EventArgs e)
        {
            menu.BackgroundImage = Properties.Resources.menu_h;
        }

        private void menu_MouseLeave(object sender, EventArgs e)
        {
            menu.BackgroundImage = Properties.Resources.menu;
        }
    }
}

