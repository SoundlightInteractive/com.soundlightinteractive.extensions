using UnityEngine;

namespace SoundlightInteractive.Extensions
{
    public static class FloatExtensions
    {
        public static float NormalizeTo01(this float value, float max)
        {
            return Mathf.Clamp01(value / max);
        }
    }
}