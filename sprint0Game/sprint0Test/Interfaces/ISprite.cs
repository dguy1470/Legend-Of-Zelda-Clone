using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;



namespace sprint0Test
{
    public interface ISprite
    {
        Rectangle GetSpriteRect();
        void Draw(SpriteBatch spriteBatch, Vector2 location);
        void Update();
    
    }
}