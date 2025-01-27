using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Text;
using System.Collections.Generic;

namespace sprint0Test.Sprites
{

    class StandingInPlacePlayerSprite : ISprite
    {
        private Texture2D texture;
        private int currentFrame;
        private int totalFrames;    
        private Vector2 location; 
        public StandingInPlacePlayerSprite (Texture2D texture)
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
                destinationRectangle = new Rectangle((int)location.X,
                (int)location.Y, 20, 20);
            }
            else if(currentFrame == 1)
            {
                sourceRectangle = new Rectangle(25, 0, 30, 20);
                destinationRectangle = new Rectangle((int)location.X,
                (int)location.Y, 30, 20);
            }
            else if(currentFrame == 2)
            {
                sourceRectangle = new Rectangle(60, 0, 20, 20);
                destinationRectangle = new Rectangle((int)location.X,
                (int)location.Y, 20, 20);
            }
            else
            {
                sourceRectangle = new Rectangle(60, 0, 20, 20);
                destinationRectangle = new Rectangle((int)location.X,
                (int)location.Y, 20, 20);
            }
            spriteBatch.Begin();
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
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