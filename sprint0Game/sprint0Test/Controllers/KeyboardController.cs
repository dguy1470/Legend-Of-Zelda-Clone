using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using sprint0Test.Interfaces;
using System.Collections.Generic;

namespace sprint0Test
{

    public class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> controllerMappings;
        private Game1 myGame;

        public KeyboardController(Game1 game)
        {
            myGame = game;
            controllerMappings = new Dictionary<Keys, ICommand>();
        }
    
        public void RegisterCommand()
        {
            controllerMappings.Add(Keys.NumPad0, new SetQuitCommand(myGame));
            controllerMappings.Add(Keys.NumPad1, new SetDispFixedSprite(myGame));
            controllerMappings.Add(Keys.NumPad2, new SetDispFixedAnimatedSprite(myGame));
            controllerMappings.Add(Keys.NumPad3, new SetDispUpDownSprite(myGame));
            controllerMappings.Add(Keys.NumPad4, new SetDispLeftRightSprite(myGame));
        }
        public void Update()
        {
            Keys[] pressedKeys = Keyboard.GetState().GetPressedKeys();
            foreach (Keys key in pressedKeys)
            {
                controllerMappings[key].Execute();
            }
        }
    }


}

