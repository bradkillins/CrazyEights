using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyEights.Forms
{
    public partial class SuitSelector : Form
    {
        public char selectedSuit;
        public SuitSelector()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            selectedSuit = cmbSuitSelector.SelectedItem.ToString().ToCharArray()[0];
            this.Dispose();
        }

        private void SuitSelector_Load(object sender, EventArgs e)
        {
            cmbSuitSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSuitSelector.Items.Clear();
            cmbSuitSelector.Items.Add("D");
            cmbSuitSelector.Items.Add("H");
            cmbSuitSelector.Items.Add("S");
            cmbSuitSelector.Items.Add("C");
            cmbSuitSelector.SelectedIndex = 0;
        }
    }
}
