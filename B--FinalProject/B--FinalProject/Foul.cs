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
        private System.Windows.Forms.Timer tmr;


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
            if (x == 3)
            {
                highPower();
            }
            tmr = new System.Windows.Forms.Timer();
            tmr.Tick += delegate {
                this.Close();
            };
            tmr.Interval = (int)TimeSpan.FromSeconds(2.3).TotalMilliseconds;
            tmr.Start();
        }
        public void LowPower()
        {
         
            //int Out;
            //int FoulBall;
            //int Safe;



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
            int maxHit = 9;
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
                lblOutMedium4.Visible = true;
            }
            else if (randomNumber == 7)
            {
                lblSafeMedium1.Visible = true;
            }
            else if (randomNumber == 8)
            {
                lblSafeMedium2.Visible = true;
            }
            else if (randomNumber == 9)
            {
                lblSafeMedium3.Visible = true;
            }

        }
        public void highPower()
        {
            //int Out;
            //int FoulBall;
            //int Strike;
            //int Safe;

            //int minPlay = 1;
            //int MaxPlay = 4;


            int minHit = 1;
            int maxHit = 13;
            Random ranNumberG = new Random();
            int randomNumber = ranNumberG.Next(minHit, maxHit);


            if (randomNumber == 1)
            {
                lblFoulHigh1.Visible = true;
            }
            else if (randomNumber == 2)
            {
                lblFoulHigh2.Visible = true;
            }
            else if (randomNumber == 3)
            {
                lblOutHigh1.Visible = true;
            }
            else if (randomNumber == 4)
            {
                lblOutHigh2.Visible = true;
            }
            else if (randomNumber == 5)
            {
                lblOutHigh3.Visible = true;
            }
            else if (randomNumber == 6)
            {
                lblSafeHigh1.Visible = true;
            }
            else if (randomNumber == 7)
            {
                lblSafeHigh2.Visible = true;
            }
            else if (randomNumber == 8)
            {
                lblSafeHigh3.Visible = true;
            }
            else if (randomNumber == 9)
            {
                lblSafeHigh3.Visible = true;
            }

        }
    }
