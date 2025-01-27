using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sprint0Test.Interfaces;

namespace sprint0Test
{
    class DispFixedAnimatedSprite : ICommand
    {
        private Game1 myGame;

        public DispFixedAnimatedSprite(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            myGame.Exit();
        }
    }
}