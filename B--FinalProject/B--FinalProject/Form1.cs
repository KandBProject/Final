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
        int Strike = 0;
        int Ball = 0;
        int Out = 0;
        int Inning = 1;
        int Players = 0;
        int HomeScore = 0;
        int minScore = 0;
        int maxScore = 7;
        int Away = 0;
        public HittingView()
        {
            InitializeComponent();

        }
        public void btnLow_Click(object sender, EventArgs e)
        {
            int minPlay = 1;
            int maxPlay = 4;

            Random StrikeBallHit = new Random();
            int play = StrikeBallHit.Next(minPlay, maxPlay);
            
            if (play == 1)
            {
                //strike
                Strike++;
            }
            else if (play == 2)
            {
                //hit
                AerialView ar = new AerialView(1);
                ar.ShowDialog();
                Strike = 0;
                Ball = 0;
                Players++;
            }
            else if (play == 3)
            {
                //Ball
                Ball++;
            }
            if(Strike == 3)
            {
                //Out
                Out++;
                Strike = 0;
                Ball = 0;
            }
            if (Out == 3)
            {
                Inning++;
                Out = 0;
                Random AwayScore = new Random();
                Away = AwayScore.Next(minScore, maxScore);

            }
            if (Ball == 4)
            {
                Players++;
                Ball = 0;
                Strike = 0;
            }
            if(Players == 4)
            {
                HomeScore++;
                Players = 3;
                Ball = 0;
                Strike = 0;
            }
            lblStrikeValue.Text = "" + Strike;
            lblBallValue.Text = "" + Ball;
            lblOutValue.Text = "" + Out;
            lblInningValue.Text = "" + Inning;
            lblHomeValue.Text = "" + HomeScore;
            lblPlayersOnBase.Text = "" + Players;
            lblAwayValue.Text = "" + Away;
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            int minPlay = 1;
            int maxPlay = 4;

            Random StrikeBallHit = new Random();
            int play = StrikeBallHit.Next(minPlay, maxPlay);

            if (play == 1)
            {
                //strike
                Strike++;
            }
            else if (play == 2)
            {
                //hit
                AerialView ar = new AerialView(1);
                ar.ShowDialog();
                Strike = 0;
                Ball = 0;
            }
            else if (play == 3)
            {
                //Ball
                Ball++;
            }
            if (Strike == 3)
            {
                //Out
                Out++;
                Strike = 0;
                Ball = 0;
            }
            if (Out == 3)
            {
                Inning++;
                Out = 0;
            }
            if (Ball == 4)
            {
                Players++;
                Ball = 0;
                Strike = 0;
            }
            if (Players == 4)
            {
                HomeScore++;
                Players = 0;
                Ball = 0;
                Strike = 0;
            }
            lblStrikeValue.Text = "" + Strike;
            lblBallValue.Text = "" + Ball;
            lblOutValue.Text = "" + Out;
            lblInningValue.Text = "" + Inning;
            lblHomeValue.Text = "" + HomeScore;
            lblPlayersOnBase.Text = "" + Players;
        }

        private void btnHigh_Click(object sender, EventArgs e)
        {
            int minPlay = 1;
            int maxPlay = 4;


    }
}
