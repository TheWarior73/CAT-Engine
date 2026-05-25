using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Rendering
{
    public class IsoCamera
    {
        public IsoCamera() 
        {
            position = new Vector2(0, 0);
        }

        public IsoCamera(Vector2 startPosition)
        {
            position = startPosition;
        }

        public Vector2 position;
        public float zoom;

        public void SetPosition(Vector2 inPosition)
        {
            position = inPosition;
        }

        public Vector2 GetPosition()
        {
            return position;
        }

        public void SetZoom(float inZoom)
        {
            zoom = inZoom;
        }

        public float GetZoom()
        {
            return zoom;
        }
    }
}
