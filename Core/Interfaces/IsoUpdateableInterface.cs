namespace CAT_Engine.Core.Interfaces
{
    /// <summary>
    /// Interface for updateable components that have to provide update methods.
    /// </summary>
    public interface IsoUpdateableInterface
    {
        /// <summary>
        /// Update function to allow for the component's update
        /// </summary>
        /// <param name="delta">Elapsed time since last update</param>
        public abstract void Update(float delta);
    }
}
