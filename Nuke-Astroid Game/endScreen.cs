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
    public partial class endScreen : UserControl
    {
        public endScreen()
        {
            InitializeComponent();
        }

        private void endScreen_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            scoreLabel.Text = "SCORE: " + GameScreen.score;
        }

        private void StartButton_Click(object sender, EventArgs e) //back to main menu
        {
            Form es = this.FindForm();
            es.Controls.Remove(this);

            MainMenu mm = new MainMenu();
            es.Controls.Add(mm);
            mm.Focus();
        }
    }
}
