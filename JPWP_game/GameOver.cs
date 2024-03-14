using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JPWP_game
{
    public partial class GameOver : Form
    {
        public GameOver()
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc) //sprawdza, ktory level jest otwarty i go zamyka
            {
               
                if (frm.Name == "Level1")
                {
                    Application.OpenForms["Level1"].Hide();
                }
                if (frm.Name == "Level2")
                {
                    Application.OpenForms["Level2"].Hide();
                }
            }

            InitializeComponent();
  
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            Level1 level1 = new Level1();
            level1.ShowDialog(); 
        }
        // podswietlenie przyciskow po najechaniu kursorem
        private void exit_MouseHover(object sender, EventArgs e)
        {
            exit.BackgroundImage = Properties.Resources.exit_h;
        }

        private void restart_MouseHover(object sender, EventArgs e)
        {
            restart.BackgroundImage = Properties.Resources.restart_h;
        }
        // powrot przyciskow do normalnego wygladu
        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.BackgroundImage = Properties.Resources.exit;
        }

        private void restart_MouseLeave(object sender, EventArgs e)
        {
            restart.BackgroundImage = Properties.Resources.restart;
        }
    }
}
