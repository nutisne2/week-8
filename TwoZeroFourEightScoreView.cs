using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class TwoZeroFourEightScoreView : Form
    {
     
        public TwoZeroFourEightScoreView(int passscore)
        {
            InitializeComponent();
            lblScore.Text = Convert.ToString(passscore);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TwoZeroFourEightView nfrom = new TwoZeroFourEightView(); 
            nfrom.Show();
            this.Hide();
        }
    }
}
