using CAT_Engine.Core.Tiles;
using CAT_Engine.Core.Utility;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Rendering.Utility
{
    public static class RenderUtility
    {
        /// <summary>
        /// Turns a <see cref="Vector3"/> world position into a <see cref="Vector2"/> screen position
        /// </summary>
        /// <param name="vec3"></param>
        /// <returns></returns>
        public static Vector2 Vec3ToIso(Vector3 vec3)
        {
            return new Vector2(
                (vec3.X - vec3.Y) / 2f,
                (vec3.X + vec3.Y) / 2f - vec3.Z
            );
        }

        /// <summary>
        /// converts a <see cref="IsoTransform3"/> into a screen space Rectangle for rendering or screen space bounds checks
        /// </summary>
        /// <param name="transform"></param>
        /// <returns></returns>
        public static Rectangle IsoTransformToScreenRect(IsoTransform3 transform)
        {
            Vector2 screenPos = Vec3ToIso(transform.position);

            int w = (int)transform.scale.X;
            int h = (int)(transform.scale.Y / 2f + transform.scale.Z);

            return new Rectangle(
                (int)(screenPos.X - w / 2f),
                (int)(screenPos.Y - h),
                w, h
            );
        }
    }
}
