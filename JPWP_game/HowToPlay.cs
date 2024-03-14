using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JPWP_game
{
    public partial class HowToPlay : Form
    {
        public HowToPlay()
        {
            InitializeComponent();
        }
//podswietlenie przycisku
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.back_h;
        }
// powrot przycisku do pierwotnego wygladu
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.back;
        }
// przycisk zamyka okno z informacjmi  i wraca do menu
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
