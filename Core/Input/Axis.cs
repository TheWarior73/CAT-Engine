namespace CAT_Engine.Core.Input
{
    /// <summary>
    /// Represents an axis with it's associated scale [-1.0, 1.0] and <see cref="InputChord"/> (as keybind associated to the Axis trigger)
    /// </summary>
    public struct Axis
    {
        /// <summary>
        /// The scale of the axis
        /// </summary>
        public float scale { get; set; }

        /// <summary>
        /// The keybinds associated with the axis
        /// </summary>
        public InputChord[] keybinds;

        /// <summary>
        /// The default axis constructor<br/>
        /// - scale = 0.0f<br/>
        /// - keybinds = null
        /// </summary>
        public Axis()
        {
            scale = 0.0f;
            keybinds = null;
        }

        public Axis(float scale, InputChord[] chords)
        {
            this.scale = scale;
            keybinds = chords;
        }

        public Axis(float scale, InputChord chord)
        {
            this.scale = scale;
            keybinds = new InputChord[] { chord };
        }
    }
}
