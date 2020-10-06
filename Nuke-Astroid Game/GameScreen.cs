﻿using System;
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
        List<PewPews> pewPelets = new List<PewPews>();

        SolidBrush fillBrush = new SolidBrush(Color.White);
        Pen tempBrush = new Pen (Color.White);

        Boolean leftArrowDown, rightArrowDown, upArrowDown, downArrowDown, spaceShootDown;

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

        public void MakePew()
        {
            PewPews newPews = new PewPews(charX + charSize / 8, charY - 10);
            pewPelets.Add(newPews);
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
                case Keys.Space:
                    spaceShootDown = true;
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
                case Keys.Space:
                    spaceShootDown = false;
                    break;
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            int count= Asters.Count;

            Rectangle shipRec = new Rectangle(charX, charY, charSize / 2, charSize);

            foreach (PewPews p in pewPelets)
            {
                Rectangle pewRec = new Rectangle(p.x, p.y, p.size, p.size);
            }

            foreach (Asteroids a in Asters)
            {
                Rectangle boxRec = new Rectangle(a.x, a.y, a.size, a.size);

                if (boxRec.IntersectsWith(shipRec))
                {
                    GameTimer.Enabled = false;
                }
                if (boxRec.IntersectsWith(pewRec))
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

            foreach (PewPews p in pewPelets)
            {
                p.Move();
            }

            if (Asters[0].y > this.Height)
            {
                Asters.RemoveAt(0);
            }
            if (pewPelets.Count > 0)
            {
                if (pewPelets[0].y < 0)
                {
                    pewPelets.RemoveAt(0);
                }
            }

            if (leftArrowDown == true && charX > 0)
            {
                charX = charX - 5;
            }
            if (rightArrowDown == true && charX < this.Width - 4 - charSize / 2 )
            {
                charX = charX + 5;
            }
            if (downArrowDown == true && charY < this.Height - 4 - charSize)
            {
                charY = charY + 5;
            }
            if (upArrowDown == true && charY > 0)
            {
                charY = charY - 5;
            }
            if (spaceShootDown == true && pewPelets.Count < 6)
            {
                MakePew();
            }

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(tempBrush, charX, charY, charSize / 2, charSize);
            
            foreach (Asteroids a in Asters)
            {
                e.Graphics.FillRectangle(fillBrush, a.x, a.y, a.size, a.size);
            }
            foreach (PewPews p in pewPelets)
            {
                e.Graphics.FillRectangle(fillBrush, p.x, p.y, p.size, p.size);
            }
        }

    }
}
