using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JPWP_game
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Application.OpenForms["Loading"].Hide(); // zamyka okno ładowania po otwarciu menu
        }

        // zmiana koloru przycisków po najechaniu kursorem
        private void play_MouseHover(object sender, EventArgs e)
        {
            play.BackgroundImage= Properties.Resources.play_h;

        }

        private void help_MouseHover(object sender, EventArgs e)
        {
            help.BackgroundImage = Properties.Resources.help_h;
        }

        private void exit_MouseHover(object sender, EventArgs e)
        {
            exit.BackgroundImage = Properties.Resources.exit_h;
        }
        //powrót przycisków do pierwotnego wygladu
        private void play_MouseLeave(object sender, EventArgs e)
        {
            play.BackgroundImage = Properties.Resources.play;
        }

        private void help_MouseLeave(object sender, EventArgs e)
        {
            help.BackgroundImage = Properties.Resources.help;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.BackgroundImage = Properties.Resources.exit;
        }

        //obsluga przyciskow
        private void play_Click(object sender, EventArgs e) // rozpoczyna gre od 1 levelu
        {
           Level1 level1= new Level1();
          level1.ShowDialog();
           
        }

        private void help_Click(object sender, EventArgs e) // wyswietla informacje jak grac w gre
        {
           HowToPlay help = new HowToPlay();
           help.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e) // wychodzi z gry 
        {
            Application.Exit();
        }
    }
}
