using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;
namespace JPWP_game
{   
    public class Friend
    {

        private PictureBox friend = new PictureBox();
        private Timer friendTimer = new Timer();
        private Form Form;
        public int FriendLeft, FriendTop, Image;
        bool message;
        public string question;
        string correct_answer;
       public int Score=0;

        public Friend(Form form, int FriendLeft, int FriendTop, string question, string correct_answer, int image)
        {
            this.correct_answer = correct_answer;
            this.question = question;
            this.Form = form;
            this.FriendLeft = FriendLeft;
            this.FriendTop = FriendTop;
            this.Image = image;
            friend.Left = FriendLeft;
            friend.Top = FriendTop;
            friend.Tag = "friend";
            friend.SizeMode = PictureBoxSizeMode.StretchImage;
            switch (Image) //wybiera wyglad psa zaleznie parametru
            {
                case 1:
                    friend.Image = Properties.Resources.dog1;

                    break;
                case 2:
                    friend.Image = Properties.Resources.dog2;
                    break;
                case 3:
                    friend.Image = Properties.Resources.dog3;
                    break;
                case 4:
                    friend.Image = Properties.Resources.dog4;
                    break;

            }
            friend.Size = new Size(100, 70);
            friend.BringToFront();
            form.Controls.Add(friend);
            friendTimer.Tick += new EventHandler(FriendTimerEvent);
            friendTimer.Start();
        }

        public void FriendTimerEvent(object sender, EventArgs e)
        {
            string answer;

            foreach (Control x in Form.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ball") 
                {
                    if (friend.Bounds.IntersectsWith(x.Bounds) && !message) //jesli Friend zostanie dotkniety przez pilke po raz pierwszy, wyswietla pytanie
                    {
                        string caption = "Pytanie";
                        DialogResult result;
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        result = MessageBox.Show(question, caption, buttons);
                        message = true;

                        if (result == DialogResult.Yes) //przypisanie zmiennej poprawnej odpowiedzi
                        { answer = "Y"; }
                        else { answer = "N"; }

                        if (answer == correct_answer) // sprawdzenie poprawnosci zaznaczonej przez gracza odpowiedzi 
                        {
                            MessageBox.Show("Poprawna odpowiedz");
                            Score += 100;
                        }
                        else
                        {
                            GameOver gameover = new GameOver();
                            gameover.ShowDialog();
                        }
                    }

                }

            }

        }
    }
}
