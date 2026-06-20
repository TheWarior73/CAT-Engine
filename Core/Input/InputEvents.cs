namespace CAT_Engine.Core.Input
{
    /// <summary>
    /// Represents an Event related to an action input
    /// </summary>
    public class InputActionEvent
    {
        /// <summary>
        /// The action name linked to the InputActionEvent
        /// </summary>
        public string actionName { get; private set; }

        /// <summary>
        /// Indicates wether the event has been consumed or not
        /// </summary>
        public bool isConsumed { get; private set; }

        /// <summary>
        /// Creates a new InputActionEvent with the action name
        /// </summary>
        /// <param name="actionName">The action name linked to the event</param>
        public InputActionEvent(string actionName)
        {
            this.actionName = actionName;
            this.isConsumed = false;
        }

        /// <summary>
        /// Consumes the targeted event
        /// </summary>
        public void Consume()
        {
            isConsumed = true;
        }
    }

    /// <summary>
    /// Represents an Event related to an axis input
    /// </summary>
    public class InputAxisEvent
    {
        /// <summary>
        /// The axis name linked to the InputAxisEvent
        /// </summary>
        public string axisName { get; private set; }

        /// <summary>
        /// The value linked to the InputAxisEvent
        /// </summary>
        public float value { get; private set; }

        /// <summary>
        /// Indicates wether the event has been consumed or not
        /// </summary>
        public bool isConsumed { get; private set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="AxisName">The axis name</param>
        /// <param name="axisValue">The axis value</param>
        public InputAxisEvent(string AxisName, float axisValue)
        {
            axisName = AxisName;
            value = axisValue;
            isConsumed = false;
        }

        /// <summary>
        /// Consumes the targeted event
        /// </summary>
        public void Consume()
        {
            isConsumed = true;
        }
    }
}
