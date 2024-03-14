using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPWP_game
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            this.Opacity = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity < 100)
            {
                Opacity += 0.05;
                progressBar1.Increment(1); // pasek ładuje się
            }
            if (progressBar1.Value == 100) // gdy pasek ładowania bedzie pelen otwiera sie menu
            {
                timer1.Stop(); 
                Menu option = new Menu();
                option.ShowDialog();
            }
        }
    }
}
