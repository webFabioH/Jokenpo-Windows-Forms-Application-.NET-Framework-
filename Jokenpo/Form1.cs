using Jokenpo.Entities;
using Jokenpo.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jokenpo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            StartGame(0);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            StartGame(2);
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            StartGame(1);
        }

        private void StartGame(int option)
        {
            labelResult.Visible = false;
            Game game = new Game();

            switch (game.Play(option))
            {
                case Result.Win:
                    picResult.BackgroundImage = Image.FromFile("images/Ganhar.png");
                    goto default;
                case Result.Lose:
                    picResult.BackgroundImage = Image.FromFile("images/Perder.png");
                    goto default;
                case Result.Draw:
                    picResult.BackgroundImage = Image.FromFile("images/Empatar.png");
                    goto default;
                default:
                    pictureBox1.Image = game.ImgPlayer;
                    pictureBox2.Image = game.ImgPC;
                    break;
            }
        }
    }
}
