using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Text;
using System.Collections.Generic;

namespace sprint0Test.Sprites
{

    class FixedAnimatedPlayerSprite : ISprite
    {
        private Texture2D texture;
        private int currentFrame = 0;
        private int totalFrames = 4;    
        private Vector2 location; 
        public FixedAnimatedPlayerSprite (Texture2D texture)
        {
            this.texture = texture;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;
            if(currentFrame == 0)
            {
                sourceRectangle = new Rectangle(0, 0, 20, 20);
                //destinationRectangle = new Rectangle((int)location.X,
                //(int)location.Y, 56, 72);
                destinationRectangle = new Rectangle(0,
                0, 56, 72);
            }
            else if(currentFrame == 1)
            {
                sourceRectangle = new Rectangle(25, 0, 30, 20);
                destinationRectangle = new Rectangle(20,
                20, 56, 72);
            }
            else if(currentFrame == 2)
            {
                sourceRectangle = new Rectangle(60, 0, 20, 20);
                destinationRectangle = new Rectangle(40,
                40, 56, 72);
            }
            else if(currentFrame == 3)
            {
                sourceRectangle = new Rectangle(60, 0, 20, 20);
                destinationRectangle = new Rectangle(60,
                60, 56, 72);
            }
            else
            {
                sourceRectangle = new Rectangle(0, 0, 20, 20);
                //destinationRectangle = new Rectangle((int)location.X,
                //(int)location.Y, 56, 72);
                destinationRectangle = new Rectangle(0,
                0, 56, 72);
            }
            //spriteBatch.Begin();
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
            //spriteBatch.End();
            }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
            {
                currentFrame = 0;
            }   
        }
    }
}