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

        int speedx = -2, speedy = -1; //Initializam viteza bilei pe axa X cu -2 si viteza pe axa Y cu -1
        int score1 = 0, score2 = 0; //Initializam scorul la 0 pentru ambele jucatori

        //Actiunea butonului de start joc
        private void start_button_Click(object sender, EventArgs e)
        {
            //Ascundem meniul si titlul jocului, dezactivam butoanele "Start" si "Quit"
            menu.Enabled = false;
            menu.Visible = false;

            title.Enabled = false;
            title.Visible = false;

            start_button.Enabled = false;
            start_button.Visible = false;

            quit_button.Enabled = false;
            quit_button.Visible = false;

            timer1.Enabled = true; //Pornim timerul care controleaza jocul

            score1 = 0; //Initializam scorul la 0 pentru jucatorul 1
            score2 = 0; //Initializam scorul la 0 pentru jucatorul 2
        }

        //Actiunea butonului de iesire din joc
        private void quit_button_Click(object sender, EventArgs e)
        {
            //Afisam o fereastra de dialog care intreaba daca jucatorul este sigur ca doreste sa iasa din joc
            if (MessageBox.Show("Are you sure you want to quit?", "Quit Game", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close(); //Daca jucatorul alege "Yes", inchidem jocul
        }

        //Actiunea tastelor apasate
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Jucatorul 1 se poate deplasa in sus sau in jos cu tastele "W" si "S"
            if (e.KeyCode == Keys.Up)
                player2.Location = new Point(player2.Location.X, player2.Location.Y - 20);
            else if (e.KeyCode == Keys.Down)
                player2.Location = new Point(player2.Location.X, player2.Location.Y + 20);
            //Jucatorul 2 se poate deplasa in sus sau in jos cu tastele "UpArrow" si "DownArrow"
            else if (e.KeyCode == Keys.W)
                player1.Location = new Point(player1.Location.X, player1.Location.Y - 20);
            else if (e.KeyCode == Keys.S)
                player1.Location = new Point(player1.Location.X, player1.Location.Y + 20);
        }

        //Functia apelata de timerul jocului la fiecare tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Mișcă mingea în sus sau în jos cu viteza speedy și la stânga sau la dreapta cu viteza speedx.
            ball.Top += speedy;
            ball.Left += speedx;

            // Verifică dacă mingea a trecut dincolo de marginea din stânga a terenului (în afara câmpului de joc).
            if (ball.Left < 0)
            {
                // Incrementează scorul jucătorului 2.
                score2++;

                // Repune mingea în centrul terenului.
                ball.Location = new Point(335, 215);
            }

            // Verifică dacă mingea a trecut dincolo de marginea din dreapta a terenului (în afara câmpului de joc).
            if (ball.Left + ball.Width > 688)
            {
                // Incrementează scorul jucătorului 1.
                score1++;

                // Repune mingea în centrul terenului.
                ball.Location = new Point(335, 215);
            }

            // Verifică dacă mingea a atins marginea superioară sau inferioară a terenului.
            if (ball.Top < 0 || ball.Top + ball.Height > 448)
            {
                // Inversează direcția de mișcare pe axa Y (mingea se va mișca în direcția opusă).
                speedy = -speedy;
            }

            // Verifică dacă mingea a intrat în contact cu unul dintre jucători.
            if (ball.Bounds.IntersectsWith(player1.Bounds) || ball.Bounds.IntersectsWith(player2.Bounds))
            {
                // Inversează direcția de mișcare pe axa X (mingea va fi reflectată).
                speedx = -speedx;

                // Modifică viteza mingii în funcție de punctul de contact cu paleta jucătorului.
                if (ball.Location.Y > player1.Location.Y && ball.Location.Y < player1.Location.Y + player1.Height / 2)
                    speedy = -1;
                else if (ball.Location.Y > player2.Location.Y && ball.Location.Y < player2.Location.Y + player2.Height / 2)
                    speedy = -1;
                else
                    speedy = 1;
            }

            // Actualizează scorul afișat în interfața de utilizator.
            player1_score.Text = score1.ToString();
            player2_score.Text = score2.ToString();

            // Verifică dacă unul dintre jucători a ajuns la scorul maxim și declanșează finalul jocului.
            if (score1 == 5)
            {
                gameOver(1);
            }
            else if (score2 == 5)
            {
                gameOver(2);
            }
        }

        private void gameOver(int player)
        {
            // Activam meniul, titlul si butoanele
            menu.Enabled = true;
            menu.Visible = true;

            if (player == 1)
                title.Text = "Player1 Wins!";
            else
                title.Text = "Player2 Wins!";
            title.Enabled = true;
            title.Visible = true;

            start_button.Enabled = true;
            start_button.Visible = true;

            quit_button.Enabled = true;
            quit_button.Visible = true;

            timer1.Enabled = false;
        }
    }
}
