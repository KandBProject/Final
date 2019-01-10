﻿using System;
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
        int TotalStrike = 0;

        public HittingView(int s)
        {
            InitializeComponent();
            TotalStrike = s;
        }

        public void btnLow_Click(object sender, EventArgs e)
        {
            AerialView ar = new AerialView(1);
            ar.ShowDialog();
            lblStrikeValue.Text = TotalStrike.ToString();
         
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            AerialView ar = new AerialView(2);
            ar.ShowDialog();
        }
        private void btnHigh_Click(object sender, EventArgs e)
        {
            AerialView ar = new AerialView(3);
            ar.ShowDialog();
        }

    }
}
