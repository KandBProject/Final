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
            LowPower.lowPower();
            var click = new AerialView();
            click.Show();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            MedPower.medPower();
            var click = new AerialView();
            click.Show();
        }
        private void btnHigh_Click(object sender, EventArgs e)
        {
            HighPower.highPower();
            var click = new AerialView();
            click.Show();
        }

      
}
