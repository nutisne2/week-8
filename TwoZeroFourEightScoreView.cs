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
    public partial class TwoZeroFourEightScoreView : Form , View
    {
        public void Notify(Model m)
        {
            UpdateScore(((TwoZeroFourEightModel)m).GetBoard());
        }

        private void UpdateScore(int[,] board)
        {
           int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sum += board[i, j];
                    lblScore.Text = Convert.ToString(sum);
                }
            }

        }

        public TwoZeroFourEightScoreView()
        {

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
