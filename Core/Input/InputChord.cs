using System;
using Microsoft.Xna.Framework.Input;

namespace CAT_Engine.Core.Input
{

    [Flags]
    public enum Modifiers
    {
        None = 0,
        Shift = 1 << 0,
        Alt = 1 << 1,
        Control = 1 << 2,
    }

    public struct InputChord
    {
        public Keys Key { get; set; }
        private byte modifiers;

        public InputChord()
        {
            Key = Keys.None;
            modifiers = (byte) Modifiers.None;
        }

        #region Modifiers
        public readonly bool GetModifier(Modifiers mod)
        {
            return (modifiers & (byte) mod) != 0;
        }

        public void SetModifier(Modifiers mod, bool value) {
            if (value)
            {
                modifiers |= (byte)mod;
            }
            else
            {
                modifiers &= (byte)~mod;
            }
        }
        #endregion
    }
}
