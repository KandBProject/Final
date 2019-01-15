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
                LowPowerFoul();
            }
            if (x == 2)
            {
                LowPowerOut();
            }
            if (x == 3)
            {
                LowPowerSafe();
            }
            if (x == 4)
            {
                medPowerFoul();
            }
            if (x == 5)
            {
                medPowerOut();
            }
            if (x == 6)
            {
                medPowerSafe();
            }
            if (x == 7)
            {
                highPowerFoul();
            }
            if (x == 8)
            {
                highPowerOut();
            }
            if (x == 9)
            {
                highPowerSafe();
            }
            if (x == 10)
            {
                homerun();
            }
            tmr = new System.Windows.Forms.Timer();
            tmr.Tick += delegate
            {
                this.Close();
            };
            tmr.Interval = (int)TimeSpan.FromSeconds(2.3).TotalMilliseconds;
            tmr.Start();
        }
        public void LowPowerFoul()
        {
            int minHit = 1;
            int maxHit = 2;
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
        }
        public void LowPowerSafe()
        {
            int minHit = 1;
            int maxHit = 2;


            Random ranNumberG = new Random();
            int randomNumber = ranNumberG.Next(minHit, maxHit);
            if (randomNumber == 1)
             {
                lblSafeLow1.Visible = true;
             }
             else if (randomNumber == 2)
             {
                lblSafeLow2.Visible = true;
             }
        }
        public void LowPowerOut()
        {
            lblOutLow.Visible = true;
        }
        public void medPowerFoul()
        {
            int minHit = 1;
            int maxHit = 2;

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
        }
        public void medPowerOut()
        {
            int minHit = 1;
            int maxHit = 4;

            Random ranNumberG = new Random();
            int randomNumber = ranNumberG.Next(minHit, maxHit);

            if (randomNumber == 1)
            {
                lblOutMedium1.Visible = true;
            }
            else if (randomNumber == 2)
            {
                lblOutMedium2.Visible = true;
            }
            else if (randomNumber == 3)
            {
                lblOutMedium3.Visible = true;
            }
            else if (randomNumber == 4)
            {
                lblOutMedium4.Visible = true;
            }
        }
        public void medPowerSafe()
        {
            int minHit = 1;
            int maxHit = 3;
            Random ranNumberG = new Random();
            int randomNumber = ranNumberG.Next(minHit, maxHit);


            if (randomNumber == 1)
            {
                lblSafeMedium1.Visible = true;
            }
            else if (randomNumber == 2)
            {
                lblSafeMedium2.Visible = true;
            }
            else if (randomNumber == 3)
            {
                lblSafeMedium3.Visible = true;
            }
        }
        public void highPowerFoul()
        {
            int minHit = 1;
            int maxHit = 2;
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
        }
        public void highPowerOut()
        {
            int minHit = 1;
            int maxHit = 3;
            Random ranNumberG = new Random();
            int randomNumber = ranNumberG.Next(minHit, maxHit);

            if (randomNumber == 1)
            {
                lblOutHigh1.Visible = true;
            }
            else if (randomNumber == 2)
            {
                lblOutHigh2.Visible = true;
            }
            else if (randomNumber == 3)
            {
                lblOutHigh3.Visible = true;
            }
        }
        public void highPowerSafe()
        {
            int minHit = 1;
            int maxHit = 4;
            Random ranNumberG = new Random();
            int randomNumber = ranNumberG.Next(minHit, maxHit);

            if (randomNumber == 1)
            {
                lblSafeHigh1.Visible = true;
            }
            else if (randomNumber == 2)
            {
                lblSafeHigh2.Visible = true;
            }
            else if (randomNumber == 3)
            {
                lblSafeHigh3.Visible = true;
            }
            else if (randomNumber == 4)
            {
                lblSafeHigh3.Visible = true;
            }

        }
        public void homerun()
        {
            int minHit = 1;
            int maxHit = 4;
            Random ranNumberG = new Random();
            int randomNumber = ranNumberG.Next(minHit, maxHit);

            if (randomNumber == 1)
            {
                lblHomeRun1.Visible = true;
            }
            else if (randomNumber == 2)
            {
                lblHomeRun2.Visible = true;
            }
            else if (randomNumber == 3)
            {
                lblHomeRun3.Visible = true;
            }
            else if (randomNumber == 4)
            {
                lblHomeRun4.Visible = true;
            }
        }

    }
}
