using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;


namespace actual_computer_science_project
{
    public class MenuState : State
    {
        private Vector2 position1;
        private Vector2 position2;
        private List<Component> components;
        private void LoadgameButton_Click(Object sender, EventArgs a)
        {
            Console.WriteLine("Load game");
        }
        private void NewgameButton_Click(Object sender, EventArgs a)
        {
            game.ChangeState(new GameState(game, Content));
        }
        private void QuitgameButton_Click(Object sender, EventArgs a)
        {
            game.Exit();
        }
        public MenuState(Game1 game, GraphicsDevice graphicsdevice, ContentManager content) : base(game, graphicsdevice)
        {
            position1 = new Vector2(100, 100);
            position2 = new Vector2(200, 100);
            var buttontexturemenu = content.Load<Texture2D>("realmenu");
            var buttonfontmenu = content.Load<SpriteFont>("Fonts/Font");
            var menubutton = new Button(buttontexturemenu, buttonfontmenu)
            {
                Position = new Vector2(0,0),
                Text = ""
            };
            var buttontextureload = content.Load<Texture2D>("Buttons/button"); //loads the png file for my load button
            var buttonfontload = content.Load<SpriteFont>("Fonts/Font"); //loads the font file for the buttons text 
            var LoadGamebutton = new Button(buttontextureload, buttonfontload) // instantiates the load game button
            {
                Position = new Vector2(50, 150), // using the x and y coordinates to place the Load game button at the top like my design
                Text = "Load game"
            };
            LoadGamebutton.Click += LoadgameButton_Click;

            var buttontexturenew = content.Load<Texture2D>("Buttons/new"); //loads the png file for my new game button onto this variable
            var buttonfontnew = content.Load<SpriteFont>("Fonts/Font");
            var NewGamebutton = new Button(buttontexturenew, buttonfontnew) // instantiates the new game button
            {
                Position = new Vector2(50, 250),
                Text = "New game"
            };
            NewGamebutton.Click += NewgameButton_Click;
            
            var buttontexturequit = content.Load<Texture2D>("Buttons/quit"); //loads the png file for my quit game button onto this variable
            var buttonfontquit = content.Load<SpriteFont>("Fonts/Font");
            var Quitgamebutton = new Button(buttontexturequit, buttonfontquit) // instantiates the quit game button
            {
                Position = new Vector2(50, 400),
                Text = "Quit game"
            };
            Quitgamebutton.Click += QuitgameButton_Click;
            
            components = new List<Component>()
            {
                menubutton,
                NewGamebutton,
                LoadGamebutton,
                Quitgamebutton,
                
            };
        }


        public override void LoadContent()
        {
            throw new NotImplementedException();
        }
        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {         
            spriteBatch.Begin(); 
            foreach (var component in components)
                component.Draw(gameTime, spriteBatch);
            spriteBatch.End();
        }

        public override void PostUpdate(GameTime gameTime)
        {
            // not needed yet
        }

        public override void Update(GameTime gameTime)
        {
            foreach (var component in components)
                component.Update(gameTime); //updates the running game for each component to keep the game running constantly
        }


        

    }
}