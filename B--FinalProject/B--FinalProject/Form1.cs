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
           
        }
        public void lowPower()
        {
            int Out;
            int FoulBall;
            int Strike;
            int Safe;
          
            int minPlay = 1;
            int MaxPlay = 4;

            var foul = new AerialView();
            foul.Show();

            int minHit = 1;
            int maxHit = 5;
            Random ranNumberG = new Random();
            int randomNumber = ranNumberG.Next(minHit, maxHit);



            if (randomNumber == 1)
            {
                
            }
            else if(randomNumber == 2)
            {

            }


        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            medPower();
            var click = new AerialView();
            click.Show();

        }
        public void medPower()
        {
            int Out;
            int FoulBall;
            int Strike;
            int Safe;

            int minPlay = 1;
            int MaxPlay = 4;


            int minHit = 1;
            int maxHit = 7;
            Random ranNumberG = new Random();
            int randomNumber = ranNumberG.Next(minHit, maxHit);



            if (randomNumber == 1)
            {
             
            }
            else if (randomNumber == 2)
            {

            }
            
        }

        private void btnHigh_Click(object sender, EventArgs e)
        {
            highPower();
            var click = new AerialView();
            click.Show();
        }
        public void highPower()
        {
            int Out;
            int FoulBall;
            int Strike;
            int Safe;
     
            int minPlay = 1;
            int MaxPlay = 4;

            
            int minHit = 1;
            int maxHit = 4;
            Random ranNumberG = new Random();
            int randomNumber = ranNumberG.Next(minHit, maxHit);



            if (randomNumber == 1)
            {
                
            }
            else if (randomNumber == 2)
            {

            }

        }
    }
}
