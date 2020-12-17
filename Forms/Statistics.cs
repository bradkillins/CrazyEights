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
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            string[]   data = Classes.Stats.GetStats().Split(',');

            lblWinsDisplay.Text = data[0];
            lblLossesDisplay.Text = data[1];
            lblLeastMovesDisplay.Text = data[2];
            lblMostMovesDisplay.Text = data[3];

        }
    }
}
