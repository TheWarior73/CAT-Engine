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
        Dictionary<string, Axis[]> _axisMapping;

        /// <summary>
        /// Adds a list of <see cref="InputChord"/> to the Axis Mapping dictionary
        /// </summary>
        /// <param name="AxisName">The Axis name, ex: "Interact", "Menu"...</param>
        /// <param name="AxisKeybind">The Axis to be added</param>
        public void AddAxisMapping(string AxisName, Axis[] AxisKeybind)
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
        /// <param name="newAxis">The axis that will replace an existing axis</param>
        /// <param name="axisIndex">The position of the axis in the Axis keybind list</param>
        public void RebindAxisMapping(string AxisName, Axis newAxis, int axisIndex)
        {
            _axisMapping[AxisName][axisIndex] = newAxis;
        }

        /// <summary>
        /// Rebinds a whole inputChord (keybind) set for a given Axis
        /// </summary>
        /// <param name="AxisName">The axis name to be rebound</param>
        /// <param name="newAxises">The list of new axises to be associated with the axis name</param>
        public void RebindAxisMapping(string AxisName, Axis[] newAxises)
        {
            _axisMapping[AxisName] = newAxises;
        }

        /// <summary>
        /// Retrieves the <see cref="InputChord"/> (keybind) list associated with the given name
        /// </summary>
        /// <param name="AxisName">The Axis Name in the dictionary</param>
        /// <returns>The <see cref="InputChord"/> list if found, null otherwise</returns>
        public Axis[] GetAxisMapping(string AxisName)
        {
            bool status = _axisMapping.TryGetValue(AxisName, out var axis);

            if (!status)
            {
                IsoLogger.Log($"Axis not found in Axis Mapping : {AxisName}", IsoLogger.ELogVerbosity.Warning);

                axis = []; // explicitely set the axis to empty to let the caller know that nothing was found.
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
            using var _ = new IsoScopeCycleStat("InputManager.Init");

            _currentState = Keyboard.GetState();
            _previousState = new();
            _axisMapping = [];
            _actionMapping = [];
            _actionPressedListeners = [];
            _actionReleasedListeners = [];
        }

        #region Event Handling

        #region actionPressed
        /// <summary>
        /// Priority list for action Pressed events. HIGHEST priority starts at 0, then lessens the higher the value
        /// </summary>
        private Dictionary<string, List<(int Priority, Action<InputActionEvent> Callback)>> _actionPressedListeners = new();

        /// <summary>
        /// Subscribes an action to the priority list with it's subsequent priority<br/>
        /// The list is also sorted in priority order during this step.
        /// </summary>
        /// <param name="priority">The priority level. 0 is the HIGHEST priority, then it goes up.</param>
        /// <param name="callback">The callback function when the action is pressed</param>
        /// <param name="actionName">The action name</param>
        public void RegisterActionPressed(string actionName, int priority, Action<InputActionEvent> callback)
        {
            if (!_actionPressedListeners.ContainsKey(actionName))
            {
                _actionPressedListeners[actionName] = new();
            }

            _actionPressedListeners[actionName].Add((priority, callback));

            _actionPressedListeners[actionName].Sort((a, b) => a.Priority.CompareTo(b.Priority));
        }

        /// <summary>
        /// Unsubscribes all actions with the same callback from the priority list.
        /// </summary>
        /// <param name="actionName">The action name</param>
        /// <param name="callback">The callback function associated in the priority list.</param>
        public void UnregisterActionPressed(string actionName, Action<InputActionEvent> callback)
        {
            if (_actionPressedListeners.TryGetValue(actionName, out var targetListeners))
            {
                targetListeners.RemoveAll(x => x.Callback == callback);

                // Delete the list if emptied by this removal
                if (targetListeners.Count == 0)
                {
                    _actionPressedListeners.Remove(actionName);
                }
            }
        }
        #endregion

        // * * * - - - - - - - - - - - - - * * * //

        #region action Released
        /// <summary>
        /// Priority list for action Released events. HIGHEST priority starts at 0, then lessens the higher the value.
        /// </summary>
        private Dictionary<string, List<(int Priority, Action<InputActionEvent> Callback)>> _actionReleasedListeners = new();

        /// <summary>
        /// Subscribes an event to the action released priority list
        /// </summary>
        /// <param name="actionName">The action Name</param>
        /// <param name="priority">The priority level. 0 is the HITGHEST priority.</param>
        /// <param name="callback">The callback</param>
        public void RegisterActionReleased(string actionName, int priority, Action<InputActionEvent> callback)
        {
            if (!_actionReleasedListeners.ContainsKey(actionName))
            {
                _actionReleasedListeners[actionName] = new();
            }

            _actionReleasedListeners[actionName].Add((priority, callback));

            _actionReleasedListeners[actionName].Sort((a, b) => a.Priority.CompareTo(b.Priority));
        }

        /// <summary>
        /// Unsubscribes all events with the same callback from the action released priority list
        /// </summary>
        /// <param name="actionName">The action name</param>
        /// <param name="callback">The callback.</param>
        public void UnregisterActionReleased(string actionName, Action<InputActionEvent> callback)
        {
            if (_actionReleasedListeners.TryGetValue(actionName, out var targetListeners))
            {
                targetListeners.RemoveAll(x => x.Callback == callback);

                // Delete the list if emptied by this removal
                if (targetListeners.Count == 0)
                {
                    _actionReleasedListeners.Remove(actionName);
                }
            }
        }

        #endregion

        // * * * - - - - - - - - - - - - - * * * //

        #region axis Updated
        /// <summary>
        /// Priority list for axisUpdated events. HIGHEST priority starts at 0, then lessens the higher the value.
        /// </summary>
        private Dictionary<string, List<(int Priority, Action<InputAxisEvent> Callback)>> _axisUpdatedListeners = new();

        /// <summary>
        /// Subscribed an event to the axis Updated priority list
        /// </summary>
        /// <param name="actionName">The action name.</param>
        /// <param name="priority">The priority. 0 is the HIGHEST priority.</param>
        /// <param name="callback">the callback.</param>
        public void RegisterAxisUpdated(string actionName, int priority, Action<InputAxisEvent> callback)
        {
            if (!_axisUpdatedListeners.ContainsKey(actionName))
            {
                _axisUpdatedListeners[actionName] = new();
            }

            _axisUpdatedListeners[actionName].Add((priority, callback));
        }

        /// <summary>
        /// Unsubscribes all events with the same callback from the axis updated priority list
        /// </summary>
        /// <param name="actionName">The action name</param>
        /// <param name="callback">The callback.</param>
        public void UnregisterAxisUpdated(string actionName, Action<InputActionEvent> callback)
        {
            if (_actionPressedListeners.TryGetValue(actionName, out var targetListeners))
            {
                targetListeners.RemoveAll(x => x.Callback == callback);

                // Delete the list if emptied by this removal
                if (targetListeners.Count == 0)
                {
                    _actionPressedListeners.Remove(actionName);
                }
            }
        }
        #endregion

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
                        if (_actionPressedListeners.TryGetValue(actionName, out var targetListener))
                        {
                            var inputEvent = new InputActionEvent(actionName);

                            foreach (var listener in targetListener)
                            {
                                listener.Callback.Invoke(inputEvent);

                                if (inputEvent.isConsumed)
                                {
                                    break;
                                }
                            }
                        }
                        break;
                    }
                    if (IsKeyReleased(chord.Key))
                    {
                        if (_actionReleasedListeners.TryGetValue(actionName, out var targetListener))
                        {

                            var releaseEvent = new InputActionEvent(actionName);

                            foreach (var listener in targetListener)
                            {
                                listener.Callback.Invoke(releaseEvent);

                                if (releaseEvent.isConsumed)
                                {
                                    break;
                                }
                            }
                        }
                        break;
                    }
                }

            }

            // Axis eval
            foreach (var currentAxisList in _axisMapping)
            {
                string axisName = currentAxisList.Key;
                Axis[] axisList = currentAxisList.Value;
                float axisValue = 0f;

                foreach (var axis in axisList)
                {
                    foreach (var chord in axis.keybinds)
                    {
                        if (IsKeyHeld(chord.Key))
                        {
                            axisValue += axis.scale;
                        }
                    }
                }

                //axes should fire even if the axis value is 0 so were not stuck forever moving

                if (_axisUpdatedListeners.TryGetValue(axisName, out var targetListener))
                {

                    var axisEvent = new InputAxisEvent(axisName, axisValue);
                    foreach (var listener in targetListener)
                    {
                        listener.Callback.Invoke(axisEvent);

                        if (axisEvent.isConsumed)
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}
