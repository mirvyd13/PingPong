using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        private int speed_vertical = 2;
        private int speed_horizontal = 2;
        private int score = 0;
        private int speed_panel = 10;
        
        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
             
            gamePanel.Top = background.Bottom - (background.Bottom / 20);

            LossText.Visible = false;
            LossText.Left = (background.Width / 2) - (LossText.Width / 2);
            LossText.Top = (background.Height / 2) - (LossText.Height / 2);

            restart.Visible = false;
            restart.Left = (background.Width / 3) - (LossText.Width / 3);
            restart.Top = (background.Height / 3) - (LossText.Height / 3);
        }

        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode==Keys.Enter)
            {
                gameBol.Top = 50;
                gameBol.Left = 70;
                speed_horizontal = 2;
                speed_vertical = 2;
                score = 0;
                LossText.Visible=false;
                restart.Visible = false;
                timer1.Enabled = true;
                result.Text = "Счет:  ";
            }
            //int bottom = background.Bottom - (background.Bottom / 25);
            //if (e.KeyCode==Keys.A && gamePanel.Left >= background.Left)
            //{
            //    gamePanel.Left-=speed_panel;
            //}
            //if (e.KeyCode == Keys.D && gamePanel.Right <= background.Right)
            //{
            //    gamePanel.Left += speed_panel;
            //}
            //if (e.KeyCode == Keys.W)
            //{
            //    gamePanel.Top -= speed_panel;
            //}
            //if (e.KeyCode == Keys.S && gamePanel.Bottom<bottom)
            //{
            //    gamePanel.Top += speed_panel;
            //}
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            gamePanel.Left = Cursor.Position.X - (gamePanel.Width / 2);
            gameBol.Left += speed_horizontal;
            gameBol.Top += speed_vertical;

            if (gameBol.Left<=background.Left)
            {
                speed_horizontal *= -1;
            }

            if (gameBol.Right >= background.Right)
            {
                speed_horizontal *= -1;
            }

            if (gameBol.Top <= background.Top)
            {
                speed_vertical *= -1;
            }

            if (gameBol.Bottom>=gamePanel.Top && gameBol.Bottom<=gamePanel.Bottom && 
                gameBol.Left>=gamePanel.Left && gameBol.Right<=gamePanel.Right)
            {
                speed_horizontal += 2;
                speed_vertical += 2;
                speed_vertical *= -1;
                score += 1;
                result.Text = "Счет:  " + score.ToString();
                speed_panel += 4;

                Random randcollor = new Random();
                background.BackColor = Color.FromArgb(randcollor.Next(150, 255), 
                    randcollor.Next(150, 255), randcollor.Next(150, 255));
            }

            if (gameBol.Bottom >= background.Bottom)
            {
                LossText.Visible = true;
                restart.Visible = true;
                timer1.Enabled = false;               
            }
        }      
    }
}
