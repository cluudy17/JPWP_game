using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JPWP_game
{
    public partial class GameMenu : Form
    {
        public GameMenu()
        {
            InitializeComponent();
        }

//podswietlenie przycisków
        private void resume_MouseHover(object sender, EventArgs e)
        {
            resume.BackgroundImage = Properties.Resources.resume_h;
        }

        private void help_MouseHover(object sender, EventArgs e)
        {
            help.BackgroundImage = Properties.Resources.help_h;
        }

        private void exit_MouseHover(object sender, EventArgs e)
        {
            exit.BackgroundImage = Properties.Resources.exit_h;
        }
// powrót przycisków do "normalnych"
        private void resume_MouseLeave(object sender, EventArgs e)
        {
            resume.BackgroundImage = Properties.Resources.resume;
        }

        private void help_MouseLeave(object sender, EventArgs e)
        {
            help.BackgroundImage = Properties.Resources.help;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.BackgroundImage = Properties.Resources.exit;
        }
// obsluga przycisków
        private void resume_Click(object sender, EventArgs e) // wznawia grę, zamyka menu
        {
            Application.OpenForms["GameMenu"].Close();
        }

        private void help_Click(object sender, EventArgs e) //wyswietla informacje jak grac
        {
            HowToPlay help = new HowToPlay();
            help.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e) // zamyka aplikacje
        {
            Application.Exit();
        }
    }
}
