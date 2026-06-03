using CAT_Engine.Core.Debug;
using CAT_Engine.Core.Interfaces;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Input
{
    public class InputManager : IsoUpdateableInterface
    {
        public void Initialize()
        {
        }

        public void Update(float delta)
        {
            if(Keyboard.GetState().IsKeyDown(Keys.Z))
            {
                IsoLogger.Assert(false, "I have been pressed yay!");
            }
        }
    }
}
