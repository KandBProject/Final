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
    public partial class AerialView : Form
    {
        public AerialView(int x)
        {

            InitializeComponent();
            if (x == 1)
            {
                LowPower();
            }
            if (x == 2) {
                medPower();
            }
        }
        public void LowPower()
        {
         
            //int Out;
            //int FoulBall;
            //int Strike;
            //int Safe;

            //int minPlay = 1;
            //int MaxPlay = 4;


            int minHit = 1;
            int maxHit = 5;
            Random ranNumberG = new Random();
            int randomNumber = ranNumberG.Next(minHit, maxHit);



                if (randomNumber == 1)
                {
                    lblFoulLow1.Visible = true;
                }
                else if (randomNumber == 2)
                {
                    lblFoulLow2.Visible = true;
                }
                else if (randomNumber == 3)
                {
                    lblSafeLow1.Visible = true;
                }
                else if (randomNumber == 4)
                {
                    lblSafeLow2.Visible = true;
                }
                else if (randomNumber == 5)
                {
                    lblOutLow.Visible = true;
                }
        }
        public void medPower()
        {
            //int Out;
            //int FoulBall;
            //int Strike;
            //int Safe;

            //int minPlay = 1;
            //int MaxPlay = 4;


            int minHit = 1;
            int maxHit = 7;
            Random ranNumberG = new Random();
            int randomNumber = ranNumberG.Next(minHit, maxHit);



            if (randomNumber == 1)
            {
                lblFoulMedium1.Visible = true;
            }
            else if (randomNumber == 2)
            {
                lblFoulMedium2.Visible = true;
            }
            else if (randomNumber == 3)
            {
                lblOutMedium1.Visible = true;
            }
            else if (randomNumber == 4)
            {
                lblOutMedium2.Visible = true;
            }
            else if (randomNumber == 5)
            {
                lblOutMedium3.Visible = true;
            }
            else if (randomNumber == 6)
            {
                lblSafeMedium1.Visible = true;
            }
            else if (randomNumber == 7)
            {
                lblSafeMedium2.Visible = true;
            }

        }

    }
}
