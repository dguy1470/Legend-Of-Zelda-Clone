using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using sprint0Test.Interfaces;
using sprint0Test.Sprites;

namespace sprint0Test;

public class Game1 : Game
{
    private Texture2D spriteTexture;
    //sprite file
    private int currentFrame;
    //Rect within sprite sheet

    private Vector2 spritePos;
    //where in the window we a drawing
    GraphicsDeviceManager graphics;
    SpriteBatch spriteBatch;
    List<object> controllerList;
    ISprite characterSprite;


    public Game1()
    {
        graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here
        controllerList = new List<object>();
        controllerList.Add(new KeyboardController(this));
        //controllerList.Add(new MouseController(this));
        base.Initialize();
    }

    protected override void LoadContent()
    {
        spriteBatch = new SpriteBatch(GraphicsDevice);
        spriteTexture = Content.Load<Texture2D>("mario");
        spritePos = Vector2.Zero;
        
        characterSprite = new StandingInPlacePlayerSprite(); 
        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        //foreach(IController controller in controllerList)
        //{
            //controller.Update();
        //}

        //characterSprite.Update();
        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        Rectangle sourceRect;
        Rectangle destRect;
        
        // TODO: Add your drawing code here
        spriteBatch.Begin();
        StandingInPlacePlayerSprite.Draw(spriteBatch, spritePos);
        //spriteBatch.Draw(spriteTexture, destRect, sourceRect, Color.White);
        spriteBatch.End();
        base.Draw(gameTime);
    }
}
