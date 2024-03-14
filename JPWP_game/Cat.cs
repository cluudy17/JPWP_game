using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace JPWP_game
{
    class Cat
    {
        int StartLeft, StartTop; //okreslaja lokalizacje na planszy, gdzie pojawia sie kot
        public PictureBox cat = new PictureBox();
        int Speed=1;

        public Cat(int StartLeft, int StartTop) 
        {
            this.StartLeft = StartLeft;
            this.StartTop = StartTop;
            cat.Left = StartLeft;
            cat.Top = StartTop;
            cat.Tag = "cat";
            cat.SizeMode = PictureBoxSizeMode.Zoom;
            cat.BackColor = Color.Transparent;
            cat.Size = new Size(100, 70);
            cat.BringToFront();
            cat.Image = Properties.Resources.cat;
        }

        public void Move(Form form) //poruszanie się kota po planszy
        {
            form.Controls.Add(cat);
            if (cat.Left > StartLeft +50) 
            {
                Speed-= 1; //wywola ruch w lewo
            }
            if (cat.Left < StartLeft - 50)
            {  
                  Speed += 1; // wywola ruch w prawo
              
            }
            cat.Left += Speed;
          

        }
    }

   

}
