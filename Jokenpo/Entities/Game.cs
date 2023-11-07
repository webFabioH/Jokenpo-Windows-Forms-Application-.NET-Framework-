using Jokenpo.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo.Entities
{
    class Game
    {
        public Image ImgPC { get; private set; }
        public Image ImgPlayer { get; private set; }

        public Result Play(int player)
        {
            int pc = PCPlay();

            ImgPlayer = images[player];
            ImgPC = images[pc];

            if (player == pc)
            {
                return Result.Draw;
            }
            else if ((player == 0 && pc == 1) || (player == 1 && pc == 2) || (player == 2 && pc == 0))
            {
                return Result.Win;
            }
            else
            {
                return Result.Lose;
            }
            
        }

        private int PCPlay()
        {
            int mil = DateTime.Now.Millisecond;
            if (mil < 333)
            {
                return 0;
            }
            else if (mil >= 333 && mil < 667)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public static Image[] images =
        {
            Image.FromFile("images/Pedra.png"),
            Image.FromFile("images/Tesoura.png"),
            Image.FromFile("images/Papel.png")
        };
    }
}
