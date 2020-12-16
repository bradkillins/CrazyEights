using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyEights
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
            //#region Testing
            ////Parameters are as follows
            ////int playerWon, int playerLost, int leastNumberOfCardsPlayed, int mostNumberOfCardsPlayed)
            //CrazyEights.Classes.Stats.UdpateStats(false,5);

            ////This will return ',' seperated string like 1,0,10,20,
            //MessageBox.Show(CrazyEights.Classes.Stats.GetStats());
            //#endregion

            //lblLeastMovesDisplay
            //lblMostMovesDisplay
            //lblWinsDisplay
            //lblLossesDisplay
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            string[] data = Classes.Stats.GetStats().Split(',');

            lblWinsDisplay.Text = data[0];
            lblLossesDisplay.Text = data[1];
            lblLeastMovesDisplay.Text = data[2];
            lblMostMovesDisplay.Text = data[3];

        }
    }
}
