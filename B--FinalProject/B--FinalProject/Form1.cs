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
        int maxScore = 5;
        int Away = 0;

        public HittingView()
        {
            InitializeComponent();
            if (Out == 3)
            {
                Random Score = new Random();
                int score = Score.Next(minScore, maxScore);
                lblAwayValue.Text = "" + score;
            }
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
                int minHit = 1;
                int maxHit = 3;
                Random HitorMiss = new Random();
                int StrikeFoulOut = HitorMiss.Next(minHit, maxHit);
                if (StrikeFoulOut == 1)
                {
                    AerialView ar = new AerialView(1);
                    ar.ShowDialog();
                    Strike++;
                }
                else if (StrikeFoulOut == 2)
                {
                    AerialView ar = new AerialView(2);
                    ar.ShowDialog();
                    Out++;
                    Strike = 0;
                    Ball = 0;
                }
                else if (StrikeFoulOut == 3)
                {
                    AerialView ar = new AerialView(3);
                    ar.ShowDialog();
                    Players++;
                    Strike = 0;
                    Ball = 0;
                }
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
                Random AwayScore = new Random();
                Away = AwayScore.Next(minScore, maxScore);
                Players = 0;
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
                int minHit = 1;
                int maxHit = 3;
                Random HitorMiss = new Random();
                int StrikeFoulOut = HitorMiss.Next(minHit, maxHit);
                if (StrikeFoulOut == 1)
                {
                    AerialView ar = new AerialView(4);
                    ar.ShowDialog();
                    Strike++;
                }
                else if (StrikeFoulOut == 2)
                {
                    AerialView ar = new AerialView(5);
                    ar.ShowDialog();
                    Out++;
                    Strike = 0;
                    Ball = 0;
                }
                else if (StrikeFoulOut == 3)
                {
                    AerialView ar = new AerialView(6);
                    ar.ShowDialog();
                    Players++;
                    Strike = 0;
                    Ball = 0;
                }
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
                Players = 0;
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
                int minHit = 1;
                int maxHit = 6;
                Random HitorMiss = new Random();
                int StrikeFoulOut = HitorMiss.Next(minHit, maxHit);

                if (StrikeFoulOut == 1)
                {
                    AerialView ar = new AerialView(7);
                    ar.ShowDialog();
                    Strike++;
                }
                else if (StrikeFoulOut == 2)
                {
                    AerialView ar = new AerialView(8);
                    ar.ShowDialog();
                    Out++;
                    Strike = 0;
                    Ball = 0;
                }
                else if (StrikeFoulOut == 3)
                {
                    AerialView ar = new AerialView(9);
                    ar.ShowDialog();
                    Players++;
                    Strike = 0;
                    Ball = 0;
                }
                else if (StrikeFoulOut == 4)
                {
                    AerialView ar = new AerialView(10);
                    ar.ShowDialog();
                    int Homerun = Players + 1;
                    HomeScore = HomeScore + Homerun;
                }
                else if (StrikeFoulOut == 5)
                {
                    AerialView ar = new AerialView(9);
                    ar.ShowDialog();
                    Players++;
                    Strike = 0;
                    Ball = 0;
                }
                else if (StrikeFoulOut == 6)
                {
                    AerialView ar = new AerialView(7);
                    ar.ShowDialog();
                    Strike++;
                }

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
                Players = 0;
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
    }
}
