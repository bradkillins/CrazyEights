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
    public partial class SuitSelector : Form
    {
        public SuitSelector()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            cmb_Suit.SelectedIndexChanged += OnSuitSelect;
            btn_Okay.Click += OkayClick;
            AcceptButton = btn_Okay;
            cmb_Suit.Items.AddRange(new object[] {
            "Clubs",
            "Diamonds",
            "Hearts",
            "Spades"});
            cmb_Suit.SelectedIndex = 0;
        }

        public char SelectedSuit { get; set; }

        private void OkayClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnSuitSelect(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            switch (box.SelectedIndex)
            {
                case 0:
                    SelectedSuit = 'C';
                    break;
                case 1:
                    SelectedSuit = 'D';
                    break;
                case 2:
                    SelectedSuit = 'H';
                    break;
                case 3:
                    SelectedSuit = 'S';
                    break;
                default:
                    break;
            }
        }
    }
}
