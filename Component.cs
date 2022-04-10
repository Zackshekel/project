using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actual_computer_science_project
{
    public abstract class Component // abstract class that it's inherited and shouldn't be instantiated so that the sprites can be listed later
    {
        public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch); // draws the sprites to be used in the menu

        public abstract void Update(GameTime gameTime); //updates the sprites by a set timer which is the gametime
    }
}
