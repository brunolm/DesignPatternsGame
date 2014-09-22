using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using DesingPatternsGame.Strategy;

namespace DesingPatternsGame
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class StrategyGame : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        // This is a texture we can render.
        Texture2D mainCharacter;

        // Set the coordinates to draw the sprite at.
        Vector2 spritePosition = Vector2.Zero;
        Vector2 spriteSpeed = new Vector2(100.0f, 100.0f);

        Random r = new Random();

        public GamePadState Controller1
        {
            get
            {
                return GamePad.GetState(PlayerIndex.One);
            }
        }

        public Color BackgroundColor { get; set; }

        public IMoveStrategy MoveStretegy { get; set; }


        public StrategyGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            BackgroundColor = Color.Black;
            MoveStretegy = new WalkStrategy();
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            mainCharacter = Content.Load<Texture2D>("Foulu");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }


        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

#if WINDOWS
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                this.Exit();
#endif

            if (Controller1.Buttons.LeftShoulder == ButtonState.Pressed)
            {
                BackgroundColor = new Color(r.Next(256), r.Next(256), r.Next(256));
            }

            if (Controller1.Buttons.RightShoulder == ButtonState.Pressed)
            {
                BackgroundColor = Color.Black;
            }


            if (MoveStretegy.GetType() != typeof(WalkStrategy))
                MoveStretegy = new WalkStrategy();

            if (Controller1.Buttons.B == ButtonState.Pressed)
            {
                MoveStretegy = new RunStrategy();
            }

            UpdateSprite(gameTime);

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(BackgroundColor);

            //
            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);
            spriteBatch.Draw(mainCharacter, spritePosition, new Rectangle(8, 0, 30, 60), Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }

        void UpdateSprite(GameTime gameTime)
        {
            spritePosition = MoveStretegy.Move(spritePosition, Controller1);
        }
    }
}
