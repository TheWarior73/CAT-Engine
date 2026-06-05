using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Input
{
    public struct Axis
    {
        public float scale { get; set; }
        public InputChord[] keybinds;

        public Axis()
        {
            scale = 0.0f;
            keybinds = null;
        }
    }
}
