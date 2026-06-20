using System;
using Microsoft.Xna.Framework.Input;

namespace CAT_Engine.Core.Input
{

    /// <summary>
    /// InputChord modifier keys:<br/>
    /// - None    - No      modifier key<br/>
    /// - Shift<br/>
    /// - Alt<br/>
    /// - Control<br/>
    /// These modifiers can be combined together to make for more advanced modifier keys, example: CTRL + SHIFT + Z
    /// </summary>
    [Flags]
    public enum Modifiers
    {
        /// <summary>
        /// None modifier key: no modifiers
        /// </summary>
        None = 0,

        /// <summary>
        /// Shift modifier key: SHIFT has to be pressed
        /// </summary>
        Shift = 1 << 0,

        /// <summary>
        /// Alt modifier key: ALT has to be pressed
        /// </summary>
        Alt = 1 << 1,

        /// <summary>
        /// Control modifier key: CTRL has to be pressed
        /// </summary>
        Control = 1 << 2,
    }

    /// <summary>
    /// Representation of an input sequence (ex: CTRL + Z, with CTRL being a <see cref="modifiers"/>, and Z a <see cref="Keys"/>) 
    /// </summary>
    public struct InputChord
    {
        /// <summary>
        /// The associated key
        /// </summary>
        public Keys Key { get; set; }
        private byte modifiers;

        /// <summary>
        /// InputChord constructor
        /// </summary>
        public InputChord()
        {
            Key = Keys.None;
            modifiers = (byte) Modifiers.None;
        }

        /// <summary>
        /// InputChord constructor
        /// </summary>
        /// <param name="key">The associated key of the inputChord</param>
        public InputChord(Keys key)
        {
            this.Key = key;
            modifiers = (byte) Modifiers.None;
        }

        /// <summary>
        /// InputChord constructor
        /// </summary>
        /// <param name="key">The associated key of the inputChord</param>
        /// <param name="mods">The associated modifiers of the inputChord</param>
        public InputChord(Keys key, Modifiers mods)
        {
            this.Key = key;
            modifiers = (byte) mods;
        }

        #region Modifiers
        /// <summary>
        /// Obtains the specified modifier for an InputChord
        /// </summary>
        /// <param name="mod">the modifier to get</param>
        /// <returns>the status of the modifier as a boolean</returns>
        public readonly bool GetModifier(Modifiers mod)
        {
            return (modifiers & (byte) mod) != 0;
        }

        /// <summary>
        /// Sets the specified modifier (<paramref name="mod"/>) to the specified <paramref name="value"/>
        /// </summary>
        /// <param name="mod">the modifier to edit</param>
        /// <param name="value">the value to be set</param>
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
