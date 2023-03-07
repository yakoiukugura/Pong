using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int speedx = -2, speedy = -1;
        int score1 = 0, score2 = 0;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                player2.Location = new Point(player2.Location.X, player2.Location.Y - 20);
            else if (e.KeyCode == Keys.Down)
                player2.Location = new Point(player2.Location.X, player2.Location.Y + 20);
            else if (e.KeyCode == Keys.W)
                player1.Location = new Point(player1.Location.X, player1.Location.Y - 20);
            else if (e.KeyCode == Keys.S)
                player1.Location = new Point(player1.Location.X, player1.Location.Y + 20);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ball.Top += speedy;
            ball.Left += speedx;
            if (ball.Left < 0)
            {
                score2++;
                ball.Location = new Point(335, 215);
            }
            if (ball.Left + ball.Width > 688)
            {
                score1++;
                ball.Location = new Point(335, 215);
            }
            if (ball.Top < 0 || ball.Top + ball.Height > 448)
            {
                speedy = -speedy;
            }
            if (ball.Bounds.IntersectsWith(player1.Bounds) || ball.Bounds.IntersectsWith(player2.Bounds))
            {
                speedx = -speedx;
                if (ball.Location.Y > player1.Location.Y && ball.Location.Y < player1.Location.Y + player1.Height / 2)
                    speedy = -1;
                else if (ball.Location.Y > player2.Location.Y && ball.Location.Y < player2.Location.Y + player2.Height / 2)
                    speedy = -1;
                else
                    speedy = 1;
            }
            player1_score.Text = score1.ToString();
            player2_score.Text = score2.ToString();
        }
    }
}
