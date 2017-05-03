using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace NinjOut
{
    public class ScreenManager
    {
        #region Variaveis 

        GameScreen currentScreen;
        GameScreen newScreen;
        //Screen Manager Instance

        private static ScreenManager instance;

        // Saber qual screen está aberto e em qual ordem

        Stack<GameScreen> screenStack = new Stack<GameScreen>();

        //Dimensões do ecran (largura e altura)

        Vector2 dimensions;
        #endregion

        #region Propriedades 
        public static ScreenManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ScreenManager();
                }
                return instance;
            }
        }

        public Vector2 Dimensions
        {
            get { return dimensions; }
            set { dimensions = value; }
        }
        #endregion

        #region Main Methods

        public void AddScreen (GameScreen screen)
        {
            newScreen = screen;
            screenStack.Push(screen);
        }

        public void Initialize ()
        {

        }

        public void LoadContent (ContentManager Content)
        {

        }

        public void Update (GameTime gameTime)
        {
            currentScreen.Update(gameTime);
        }

        public void Draw (SpriteBatch spriteBatch)
        {
            currentScreen.Draw(spriteBatch);
        }

        #endregion
    }
}
