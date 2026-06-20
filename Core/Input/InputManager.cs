using CAT_Engine.Core.Debug;
using CAT_Engine.Core.Interfaces;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace CAT_Engine.Core.Input
{
    /// <summary>
    /// Input Manager that handles input detection, then handles action and axis mappings and dispatches events corresponding to the hit keybind.
    /// </summary>
    public class InputManager : IsoUpdateableInterface
    {
        #region Action Mapping
        Dictionary<string, InputChord[]> _actionMapping;

        /// <summary>
        /// Adds a list of <see cref="InputChord"/> to the Action Mapping dictionary
        /// </summary>
        /// <param name="ActionName">The action name, ex: "Interact", "Menu"...</param>
        /// <param name="ActionKeybind">The list of <see cref="InputChord"/> that will trigger the Action</param>
        public void AddActionMapping(string ActionName, InputChord[] ActionKeybind)
        {
            bool status = _actionMapping.TryAdd(ActionName, ActionKeybind);

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
            bool status = _actionMapping.Remove(ActionName);

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
            _actionMapping[ActionName][keyIndex] = newKey;
        }

        /// <summary>
        /// Rebinds a whole inputChord set for a given action
        /// </summary>
        /// <param name="ActionName"></param>
        /// <param name="newKeys"></param>
        public void RebindActionMapping(string ActionName, InputChord[] newKeys)
        {
            _actionMapping[ActionName] = newKeys;
        }

        /// <summary>
        /// Retrieves the <see cref="InputChord"/> list associated with the given name
        /// </summary>
        /// <param name="ActionName">The Action Name in the dictionary</param>
        /// <returns>The <see cref="InputChord"/> list if found, null otherwise</returns>
        public InputChord[] GetActionMapping(string ActionName)
        {
            bool status = _actionMapping.TryGetValue(ActionName, out var inputList);

            if (!status)
            {
                IsoLogger.Log($"Action not found in Action Mapping : {ActionName}", IsoLogger.ELogVerbosity.Warning);

                inputList = null; // explicitely set the list to null to let the caller know that nothing was found.
            }
            return inputList;
        }
        #endregion

        #region Axis Mapping
        Dictionary<string, Axis> _axisMapping;

        /// <summary>
        /// Adds a list of <see cref="InputChord"/> to the Axis Mapping dictionary
        /// </summary>
        /// <param name="AxisName">The Axis name, ex: "Interact", "Menu"...</param>
        /// <param name="AxisKeybind">The Axis to be added</param>
        public void AddAxisMapping(string AxisName, Axis AxisKeybind)
        {
            bool status = _axisMapping.TryAdd(AxisName, AxisKeybind);

            if (!status)
            {
                IsoLogger.Log($"Axis already exists in AxisMapping : {AxisName}", IsoLogger.ELogVerbosity.Warning);
            }
        }

        /// <summary>
        /// Removes an Axis from the AxisMapping dictionary completely.
        /// </summary>
        /// <param name="AxisName">The Axis name in the Dictionary</param>
        public void RemoveAxisMapping(string AxisName)
        {
            bool status = _axisMapping.Remove(AxisName);

            if (!status)
            {
                IsoLogger.Log($"Axis not found in Axis Mapping : {AxisName}", IsoLogger.ELogVerbosity.Warning);
            }
        }

        /// <summary>
        /// Rebinds a specific inputChord set for a given Axis
        /// </summary>
        /// <param name="AxisName">The Axis to edit</param>
        /// <param name="newKey">The key that will replace an existing key</param>
        /// <param name="keyIndex">The position of the key in the Axis keybind list</param>
        public void RebindAxisMapping(string AxisName, InputChord newKey, int keyIndex)
        {
            _axisMapping[AxisName].keybinds[keyIndex] = newKey;
        }

        /// <summary>
        /// Rebinds a whole inputChord (keybind) set for a given Axis
        /// </summary>
        /// <param name="AxisName"></param>
        /// <param name="newKeys"></param>
        public void RebindAxisMapping(string AxisName, InputChord[] newKeys)
        {
            // Get
            Axis updatedAxis = _axisMapping[AxisName];

            // Update
            updatedAxis.keybinds = newKeys;

            // Set
            _axisMapping[AxisName] = updatedAxis;
        }

        /// <summary>
        /// Retrieves the <see cref="InputChord"/> (keybind) list associated with the given name
        /// </summary>
        /// <param name="AxisName">The Axis Name in the dictionary</param>
        /// <returns>The <see cref="InputChord"/> list if found, null otherwise</returns>
        public Axis GetAxisMapping(string AxisName)
        {
            bool status = _axisMapping.TryGetValue(AxisName, out var axis);

            if (!status)
            {
                IsoLogger.Log($"Axis not found in Axis Mapping : {AxisName}", IsoLogger.ELogVerbosity.Warning);

                axis = new Axis(); // explicitely set the axis to empty to let the caller know that nothing was found.
            }
            return axis;
        }
        #endregion

        #region KeyboardState
        /// <summary>
        /// The current state of the keyboard
        /// </summary>
        public KeyboardState _currentState { get; private set; } = new();

        /// <summary>
        /// The previous state of the keyboard
        /// </summary>
        public KeyboardState _previousState { get; private set; } = new();

        /// <summary>
        /// Checks if a key is newly pressed.
        /// </summary>
        /// <param name="key">the key to evaluate</param>
        /// <returns>true if keydown now and not before, otherwise false</returns>
        public bool IsKeyPressed(Keys key)
        {
            return _currentState.IsKeyDown(key) && _previousState.IsKeyUp(key);
        }

        /// <summary>
        /// Checks if a key if being held
        /// </summary>
        /// <param name="key">the key to evaluate</param>
        /// <returns>true if current state of the key is pressed, otherwise false</returns>
        public bool IsKeyHeld(Keys key)
        {
            return _currentState.IsKeyDown(key);
        }

        /// <summary>
        /// Checks if a key is being released
        /// </summary>
        /// <param name="key">the key to evaluate</param>
        /// <returns>true if the current key is up and the previous key is down, otherwise false</returns>
        public bool IsKeyReleased(Keys key)
        {
            return _currentState.IsKeyUp(key) && _previousState.IsKeyDown(key);
        }
        #endregion

        /// <summary>
        /// Initialises the InputManager
        /// </summary>
        public InputManager()
        {
            using var _ = new IsoScopeCycleStat("InputManager.Constructor");

            _currentState = Keyboard.GetState();
            _previousState = new();
            _axisMapping = new();
            _actionMapping = new();
        }

        #region Event Handling
        /// <summary>
        /// Event fired when an Action is Pressed
        /// </summary>
        public event Action<string> onActionPressed;

        /// <summary>
        /// Event fired when an Action is Released
        /// </summary>
        public event Action<string> onActionReleased;

        /// <summary>
        /// Constantly updates the axis (keyboards have 3 values: -1, 0, 1. controlers have a range [-1, 1])
        /// </summary>
        public event Action<string, float> onAxisUpdated;
        #endregion

        /// <summary>
        /// Fired whenever the InputManager needs to update itself<br/>
        /// Will fire events depending on the registered action and axis mappings.
        /// </summary>
        /// <param name="delta"></param>
        public void Update(float delta)
        {
            //using var _ = new IsoScopeCycleStat("InputManager.Update");

            // Keyboard state
            _previousState = _currentState;
            _currentState = Keyboard.GetState();

            // Action eval
            foreach (var currentAction in _actionMapping)
            {
                string actionName = currentAction.Key;

                foreach (var chord in currentAction.Value)
                {
                    if (IsKeyPressed(chord.Key))
                    {
                        onActionPressed?.Invoke(actionName);
                        break;
                    }
                    if (IsKeyReleased(chord.Key))
                    {
                        onActionReleased?.Invoke(actionName);
                        break;
                    }
                }

            }

            // Axis eval
            foreach (var currentAxis in _axisMapping)
            {
                string axisName = currentAxis.Key;
                Axis axis = currentAxis.Value;
                float axisValue = 0f;

                foreach (var chord in axis.keybinds)
                {
                    if (IsKeyHeld(chord.Key))
                    {
                        axisValue += axis.scale;
                    }
                }

                //axes should fire even if the axis value is 0 so were not stuck forever moving
                onAxisUpdated?.Invoke(axisName, axisValue);
            }
        }
    }
}
