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
    public partial class GameScreen : UserControl
    {
        List<Asteroids> Asters = new List<Asteroids>();

        SolidBrush fillBrush = new SolidBrush(Color.White);
        SolidBrush tempBrush = new SolidBrush(Color.Red);

        Boolean leftArrowDown, rightArrowDown, upArrowDown, downArrowDown;

        int charX = 210, charY = 400, charSize = 20;

        Random randNum = new Random();

        public GameScreen()
        {
            InitializeComponent();
            MakeAst();
        }
        private void GameScreen_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        public void MakeAst()
        {
            int sizeAst = randNum.Next(10, 30);
            int xAst = randNum.Next(1, this.Width - sizeAst);

            //add box
            Asteroids newAst = new Asteroids(xAst, 0, sizeAst);
            Asters.Add(newAst);

        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
            }
        }
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            int count= Asters.Count;

            Rectangle shipRec = new Rectangle(charX, charY, charSize / 2, charSize);

            foreach (Asteroids a in Asters)
            {
                Rectangle boxRec = new Rectangle(.x, .y, .size, .size);

                if (shipRec.IntersectsWith(heroRec))
                {
                    GameTimer.Enabled = false;
                }
            }
            if (Asters[Asters.Count - 1].y > 35)
            {
                MakeAst();
            }

            foreach (Asteroids a in Asters)
            {
                a.Move();
            }

            if (Asters[0].y > this.Height)
            {
                Asters.RemoveAt(0);
            }

            if (leftArrowDown == true)
            {
                charX = charX - 5;
            }
            if (rightArrowDown == true)
            {
                charX = charX + 5;
            }
            if (downArrowDown == true)
            {
                charY = charY + 5;
            }
            if (upArrowDown == true)
            {
                charY = charY - 5;
            }

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(tempBrush, charX, charY, charSize / 2, charSize);

            foreach (Asteroids a in Asters)
            {
                e.Graphics.FillRectangle(fillBrush, a.x, a.y, a.size, a.size);
            }
        }

    }
}
