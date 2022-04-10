using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actual_computer_science_project.sprites

{
    public class Sprite : Component
    {
        protected Texture2D atexture;//texture png file for future sprites
        public Vector2 Position { get; set; } // position of the sprite on the screen output
        public Rectangle Rectangle
        {
            get { return new Rectangle((int)Position.X, (int)Position.Y, atexture.Width, atexture.Height); } // box around the sprite
        }
        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(atexture, Position, Color.White);
        }
        public Sprite(Texture2D texture)
        {
            atexture = texture;
        }
        public override void Update(GameTime gameTime)
        {

        }
    }
}