using actual_computer_science_project.sprites;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actual_computer_science_project.Sprites
{
    public class Player : Sprite
    {
        public Player(Texture2D texture)
            : base(texture) // inherits from the sprite class
        {

        }

        public override void Update(GameTime gameTime)
        {
            var velocityspeed = new Vector2();
            var speed = 1f; 
            Position += velocityspeed; //variable to represent position since velocityspeed has an X and Y coordinate for later use
            if (Keyboard.GetState().IsKeyDown(Keys.W))
                velocityspeed.Y = -speed;
            else if (Keyboard.GetState().IsKeyDown(Keys.A))
                velocityspeed.X = -speed;
            else if (Keyboard.GetState().IsKeyDown(Keys.S))
                velocityspeed.Y = speed;
            else if (Keyboard.GetState().IsKeyDown(Keys.D))
                velocityspeed.X = speed;
            
        }
        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {


            base.Draw(gameTime, spriteBatch);
        }
    }
}