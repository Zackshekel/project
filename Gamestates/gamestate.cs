using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using actual_computer_science_project.Sprites;
using actual_computer_science_project.core;
using actual_computer_science_project;
using actual_computer_science_project.sprites;

namespace actual_computer_science_project
{
    public class GameState : State
    {
        private camera _camera;

        private List<Component> _components;

        private Player _player;
        private Sprite _background;





        public GameState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content)
          : base(game, graphicsDevice, content)
        {

        }

        public override void LoadContent()
        {
            
            _camera = new camera();
            _player = new Player(Content.Load<Texture2D>("forwardfaceplayer"));
            _background = new Sprite(Content.Load<Texture2D>("background"));
            _components = new List<Component>()
            {
                _background, // adds my background to the component list
                _player // adds player to the component list
            };
            

        }
        public override void Update(GameTime gameTime)
        {
            foreach (var component in _components)
                component.Update(gameTime);
            this.Update(gameTime);
            _camera.Follow(_player);


        }
        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin(transformMatrix: _camera.Transform);
            foreach (var component in _components)
                component.Draw(gameTime, spriteBatch);
            spriteBatch.End();
        }

        public override void PostUpdate(GameTime gameTime)
        {

        }


    }
}