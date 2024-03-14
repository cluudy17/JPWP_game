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
    public partial class Level2 : Form
    {   
        Doggo doggo = new Doggo();
        Cat cat1 = new Cat( 600, 650);
        Cat cat2 = new Cat(230, 180);
        Cat cat3 = new Cat(300, 500);



        public Level2()
        {
            InitializeComponent();
            Application.OpenForms["Level1"].Close();  //zamyka level1 po otwarciu level2 
            doggo.MakeDoggo(this);
            Friend friend1 = new Friend(this, 692, 600, "xyz", "Y", 1);
            Friend friend2 = new Friend(this, 200, 770, "3x+x-1=2x+5 ; x=3", "Y", 2);
            Friend friend3 = new Friend(this, 722, 65, "3(2−3x)=x−4; x=2", "N", 1);
            
        }

       

        private void KeyIsUp(object sender, KeyEventArgs e) //obsluga przyciskow
        {
            if (e.KeyCode == Keys.Left) 
            {
                doggo.GoLeft = false; //poruszanie w lewo niemożliwe
            }

            if (e.KeyCode == Keys.Right) 
            {
                doggo.GoRight = false; //poruszanie prawo niemożliwe
            }

            if (e.KeyCode == Keys.Up)
            {
                doggo.GoUp = false; //skok niemożliwy
            }
        }
        private void KeyIsDown(object sender, KeyEventArgs e) //obsluga przyciskow
        {
            if (e.KeyCode == Keys.Left)
            {
                doggo.GoLeft = true; //poruszanie w lewo możliwe
                doggo.Where = "left"; // okreslenie kierunku, w ktory zwrocony jest pies
            }

            if (e.KeyCode == Keys.Right)
            {
                doggo.GoRight = true; //poruszanie prawo możliwe
                doggo.Where = "right"; // okreslenie kierunku, w ktory zwrocony jest pies
            }

            if (e.KeyCode == Keys.Up)
            {
                doggo.GoUp = true; //skok możliwy
            }

            if (e.KeyCode == Keys.A) // powoduje wyrzucenie pilki
            {
                Ball throwaball = new Ball(doggo); 
                throwaball.MakeBall(this);
            }

        }

        // przycisk menu
        private void menu_Click(object sender, EventArgs e) // otwiera menu
        {

        }

        private void menu_MouseHover(object sender, EventArgs e)
        {
           // menu.BackgroundImage = Properties.Resources.menu_h;
        }

        private void menu_MouseLeave(object sender, EventArgs e)
        {
         //   menu.BackgroundImage = Properties.Resources.menu;
        }

        private void menu_Click_1(object sender, EventArgs e)
        {
            GameMenu menu = new GameMenu();
            menu.ShowDialog();
        }

        private void menu_MouseHover_1(object sender, EventArgs e)
        {
            menu.BackgroundImage = Properties.Resources.menu_h;
        }

        private void menu_MouseLeave_1(object sender, EventArgs e)
        {
            menu.BackgroundImage = Properties.Resources.menu;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            doggo.move(this);
            cat1.Move(this);
            cat2.Move(this);
            cat3.Move(this);

        }
    }
}

