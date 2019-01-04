using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B__FinalProject
{
    public partial class HittingView : Form
    {
       
        public HittingView()
        {
            InitializeComponent();
        }
       
        public void btnLow_Click(object sender, EventArgs e)
        {
            lowPower();
            var click = new AerialView();
            click.Show();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            public void lowPower()
            {
                int Out;
                int FoulBall;
                int Strike;
                int Safe;
                int minHit = 1;
                int maxHit = 5;
                int minPlay = 1;
                int MaxPlay =



                Random ranNumberGenerator = new Random();
                int randomNumber;
                randomNumber = ranNumberGenerator.Next(minHit, maxHit);



                if (randomNumber == 1)
                {
                    var foul = new AerialView();
                    foul.Show();
                }


            }
        }

        private void btnHigh_Click(object sender, EventArgs e)
        {
            public void lowPower()
            {
                int Out;
                int FoulBall;
                int Strike;
                int Safe;
                int minHit = 1;
                int maxHit = 5;
                int minPlay = 1;
                int MaxPlay =



                Random ranNumberGenerator = new Random();
                int randomNumber;
                randomNumber = ranNumberGenerator.Next(minHit, maxHit);



                if (randomNumber == 1)
                {
                    var foul = new AerialView();
                    foul.Show();
                }


            }
        }
    }
}
