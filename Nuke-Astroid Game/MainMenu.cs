using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nuke_Astroid_Game
{
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
              this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void StartButton_Click(object sender, EventArgs e) //Starts Game Screen
        {
            Form mm = this.FindForm();
            mm.Controls.Remove(this);

            GameScreen gs = new GameScreen();
            mm.Controls.Add(gs);
            gs.Focus();
        }

        private void endGame_Click(object sender, EventArgs e) //Quits to "desktop"
        {
            Application.Exit();
        }

    }
}
