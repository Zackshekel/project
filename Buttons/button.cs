using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actual_computer_science_project
{
    public class Button : Component
    {
       

        private MouseState currentMouse; //checks if the mouse is left clicking 
        private SpriteFont afont; //variable for the font of the text to be displayed over the buttons in the menu(s)
        private bool Hovering; //determines if the mouse is hovering over the GUI or not
        private MouseState previousMouse;
        private Texture2D atexture; //variable to represent the texture files/main menu PNG files that will be displayed onto the pocket monsters main menu

        public event EventHandler Click; //assigns a method to click
        public bool Clicked { get; private set; }
        public Color PenColour { get; set; } //colour of the text inside the button
        public Vector2 Position { get; set; } // variable for the position of the button
        public Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, atexture.Width, atexture.Height); // used to check if the mouse is ontop of the button
            }
        }

        public string Text { get; set; }


        public Button(Texture2D texture, SpriteFont font) // constructor for the button
        {
            atexture = texture;
            afont = font;
            PenColour = Color.LightGray;
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            var colour = Color.White;
            if (Hovering)
                colour = Color.Gray; // mouse cursor becomes grey to show the player if the mouse is over the button to make it easier to see and more usable
            spriteBatch.Draw(atexture, Rectangle, colour);
            if (!string.IsNullOrEmpty(Text))
            {
                var x = (Rectangle.X + (Rectangle.Width / 2)) - (afont.MeasureString(Text).X / 2);
                var y = (Rectangle.Y + (Rectangle.Height / 2)) - (afont.MeasureString(Text).Y / 2);
                spriteBatch.DrawString(afont, Text, new Vector2(x, y), PenColour);
            }
        }

        public override void Update(GameTime gameTime)
        {
            previousMouse = currentMouse;
            currentMouse = Mouse.GetState();

            var mouseRectangle = new Rectangle(currentMouse.X, currentMouse.Y, 1, 1); //instantiates the mouse cursor

            Hovering = false;

            if (mouseRectangle.Intersects(Rectangle))
            {
                Hovering = true;

                if (currentMouse.LeftButton == ButtonState.Released && previousMouse.LeftButton == ButtonState.Pressed) // if the left mouse button is pressed and then let go, the click event occurs
                {
                    Click?.Invoke(this, new EventArgs()); // starts the click event
                }
            }
        }

    }
}