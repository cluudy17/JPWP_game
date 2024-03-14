using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JPWP_game
{
    public partial class Win : Form
    {
        public Win()
        {

            FormCollection fc = Application.OpenForms; // sprawdza, ktory level jest otwarty i zamyka go

            foreach (Form frm in fc)
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

        private void pictureBox2_Click(object sender, EventArgs e) // restart gry
        {
            Level1 level1 = new Level1();
            level1.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e) // wyjscie z gry
        {
            Application.Exit();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e) // podswietlenie przycisku
        {
            pictureBox2.BackgroundImage = Properties.Resources.restart_h;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.restart;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)// podswietlenie przycisku
        {
            pictureBox1.BackgroundImage = Properties.Resources.exit_h;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.exit;
        }
    }
}
