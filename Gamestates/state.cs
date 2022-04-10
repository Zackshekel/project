using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actual_computer_science_project
{
    public abstract class State // other states inherit from this class
    {
        protected ContentManager Content; // used to load content
        protected GraphicsDevice agraphicsDevice; // used for graphics and textures in the output etc
        protected Game1 game;
        private object graphicsDevice;

        public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);
        public abstract void PostUpdate(GameTime gameTime); //removes components from the list later on
        public State(Game1 game, GraphicsDevice graphicsDevice, ContentManager content)
        {
            this.game = game;
            agraphicsDevice = graphicsDevice;
            Content = content;
        }

        protected State(Game1 game, object graphicsDevice)
        {
            this.game = game;
            this.graphicsDevice = graphicsDevice;
        }

        public abstract void Update(GameTime gameTime);

        public abstract void LoadContent();

    }
}