using System.Collections.Generic;
using CAT_Engine.Core.Debug;
using CAT_Engine.Core.Interfaces;
using Microsoft.Xna.Framework.Input;

namespace CAT_Engine.Core.Input
{
    public class InputManager : IsoUpdateableInterface
    {
        #region Action Mapping
        Dictionary<string, InputChord[]> _ActionMapping;

        /// <summary>
        /// Adds a list of <see cref="InputChord"/> to the Action Mapping dictionary
        /// </summary>
        /// <param name="ActionName">The action name, ex: "Interact", "Menu"...</param>
        /// <param name="ActionKeybind">The list of <see cref="InputChord"/> that will trigger the Action</param>
        public void AddActionMapping(string ActionName, InputChord[] ActionKeybind)
        {
            bool status = _ActionMapping.TryAdd(ActionName, ActionKeybind);

            if (!status)
            {
                IsoLogger.Log($"Action already exists in ActionMapping : {ActionName}", IsoLogger.ELogVerbosity.Warning);
            }
        }

        /// <summary>
        /// Removes an action from the ActionMapping dictionary completely.
        /// </summary>
        /// <param name="ActionName">The action name in the Dictionary</param>
        public void RemoveActionMapping(string ActionName)
        {
            bool status = _ActionMapping.Remove(ActionName);

            if (!status)
            {
                IsoLogger.Log($"Action not found in Action Mapping : {ActionName}", IsoLogger.ELogVerbosity.Warning);
            }
        }

        /// <summary>
        /// Rebinds a specific inputChord set for a given action
        /// </summary>
        /// <param name="ActionName">The action to edit</param>
        /// <param name="newKey">The key that will replace an existing key</param>
        /// <param name="keyIndex">The position of the key in the action InputChord list</param>
        public void RebindActionMapping(string ActionName, InputChord newKey, int keyIndex)
        {
            _ActionMapping[ActionName][keyIndex] = newKey;
        }

        /// <summary>
        /// Rebinds a whole inputChord set for a given action
        /// </summary>
        /// <param name="ActionName"></param>
        /// <param name="newKeys"></param>
        public void RebindActionMapping(string ActionName, InputChord[] newKeys)
        {
            _ActionMapping[ActionName] = newKeys;
        }

        /// <summary>
        /// Retrieves the <see cref="InputChord"/> list associated with the given name
        /// </summary>
        /// <param name="ActionName">The Action Name in the dictionary</param>
        /// <returns>The <see cref="InputChord"/> list if found, null otherwise</returns>
        public InputChord[] GetActionMapping(string ActionName)
        {
            bool status = _ActionMapping.TryGetValue(ActionName, out var inputList);

            if (!status)
            {
                IsoLogger.Log($"Action not found in Action Mapping : {ActionName}", IsoLogger.ELogVerbosity.Warning);

                inputList = null; // explicitely set the list to null to let the caller know that nothing was found.
            }
            return inputList;
        }
        #endregion

        // Axis Mapping
        Dictionary<string, InputChord[]> _AxisMapping;

        // KeyboardState
        public InputChord CurrentKey { get; private set; } = new InputChord();
        public InputChord PreviousKey { get; private set; } = new InputChord();



        public void Initialize()
        {
        }

        public void Update(float delta)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Z))
            {
                IsoLogger.Assert(false, "I have been pressed yay!");
            }
        }
    }
}
