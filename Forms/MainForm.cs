using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace CrazyEights
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            
            MenuPanel.Left = MenuPanel.Width * -1;
            Cmb_NumOfOpp.SelectedIndex = 0;
            Btn_NewGameScreen.Click += NewGameScreen_Click;
            HeaderPanel.MouseDown += Utilities.MovingControlMouseDown;
            HeaderPanel.MouseUp += Utilities.MovingControlMouseUp;
            HeaderPanel.MouseMove += Utilities.MovingControlMouseMove;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void hamburgerMenuButton_Click(object sender, EventArgs e)
        {
            MenuPanel.BringToFront();
            Transition t = new Transition(new TransitionType_EaseInEaseOut(200));
            if (MenuPanel.Left < 0)            
                t.add(MenuPanel, "Left", 0);
            else
                t.add(MenuPanel, "Left", MenuPanel.Width * -1);
            t.run();
        }

        private void NewGameScreen_Click(object sender, EventArgs e)
        {
            if(MenuPanel.Left == 0)
            {
                MenuPanel.Left = MenuPanel.Width * -1;
            }
            
            //close open Forms
            List<Form> formsToClose = new List<Form>();
            foreach (Control control in Controls)
            {
                if (control.GetType().BaseType == typeof(Form))
                    formsToClose.Add((Form)control);
            }

            while (formsToClose.Count > 0)
            {
                formsToClose[0].Close();
                formsToClose.RemoveAt(0);
            }
        }

        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            Gameboard gameboard = new Gameboard(Cmb_NumOfOpp.SelectedIndex + 1);
            SetupNewForm(gameboard);
            MenuPanel.Left = MenuPanel.Width * -1;
        }

        private void Btn_Friends_Click(object sender, EventArgs e)
        {
            MenuPanel.Left = MenuPanel.Width * -1;
            Friends friends = new Friends();
            SetupNewForm(friends);
        }

        private void Btn_HighScore_Click(object sender, EventArgs e)
        {
            MenuPanel.Left = MenuPanel.Width * -1;
            HighScore scores = new HighScore();
            SetupNewForm(scores);
        }

        private void Btn_GameStatistics_Click(object sender, EventArgs e)
        {
            MenuPanel.Left = MenuPanel.Width * -1;
            Statistics stats = new Statistics();
            SetupNewForm(stats);
        }

        private void Btn_Settings_Click(object sender, EventArgs e)
        {
            MenuPanel.Left = MenuPanel.Width * -1;
            Settings settings = new Settings();
            SetupNewForm(settings);
        }

        private void SetupNewForm(Form form)
        {
            form.TopLevel = false;
            form.Parent = this;
            form.Top = HeaderPanel.Height;
            form.Left = 0;
            form.BringToFront();
            form.Show();
        }
    }
}
