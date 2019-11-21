using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// resource:https://github.com/glslify/glsl-easings
public class ShaderEasings
{
    public static float HALF_PI = 1.5707963267948966f;

    public static float backInOut(float t)
    {
        float f = t < 0.5f
          ? 2.0f * t
          : 1.0f - (2.0f * t - 1.0f);

        float g = Mathf.Pow(f, 3.0f) - f * Mathf.Sin(f * Mathf.PI);

        return t < 0.5f
          ? 0.5f * g
          : 0.5f * (1.0f - g) + 0.5f;
    }

    public static float backIn(float t)
    {
        return Mathf.Pow(t, 3.0f) - t * Mathf.Sin(t * Mathf.PI);
    }

    public static float backOut(float t)
    {
        float f = 1.0f - t;
        return 1.0f - (Mathf.Pow(f, 3.0f) - f * Mathf.Sin(f * Mathf.PI));
    }

    public static float bounceInOut(float t)
    {
        return t < 0.5f
          ? 0.5f * (1.0f - bounceOut(1.0f - t * 2.0f))
          : 0.5f * bounceOut(t * 2.0f - 1.0f) + 0.5f;
    }

    public static float bounceIn(float t)
    {
        return 1.0f - bounceOut(1.0f - t);
    }

    public static float bounceOut(float t)
    {
        const float a = 4.0f / 11.0f;
        const float b = 8.0f / 11.0f;
        const float c = 9.0f / 10.0f;

        const float ca = 4356.0f / 361.0f;
        const float cb = 35442.0f / 1805.0f;
        const float cc = 16061.0f / 1805.0f;

        float t2 = t * t;

        return t < a
          ? 7.5625f * t2
          : t < b
            ? 9.075f * t2 - 9.9f * t + 3.4f
            : t < c
              ? ca * t2 - cb * t + cc
              : 10.8f * t * t - 20.52f * t + 10.72f;
    }

    public static float circularInOut(float t)
    {
        return t < 0.5f
          ? 0.5f * (1.0f - Mathf.Sqrt(1.0f - 4.0f * t * t))
          : 0.5f * (Mathf.Sqrt((3.0f - 2.0f * t) * (2.0f * t - 1.0f)) + 1.0f);
    }

    public static float circularIn(float t)
    {
        return 1.0f - Mathf.Sqrt(1.0f - t * t);
    }

    public static float circularOut(float t)
    {
        return Mathf.Sqrt((2.0f - t) * t);
    }

    public static float cubicInOut(float t)
    {
        return t < 0.5f
        ? 4.0f * t * t * t
        : 0.5f * Mathf.Pow(2.0f * t - 2.0f, 3.0f) + 1.0f;
    }

    public static float cubicIn(float t)
    {
        return t * t * t;
    }

    public static float cubicOut(float t)
    {
        float f = t - 1.0f;
        return f * f * f + 1.0f;
    }

    public static float elasticInOut(float t)
    {
        return t < 0.5f
          ? 0.5f * Mathf.Sin(13.0f * HALF_PI * 2.0f * t) * Mathf.Pow(2.0f, 10.0f * (2.0f * t - 1.0f))
          : 0.5f * Mathf.Sin(-13.0f * HALF_PI * ((2.0f * t - 1.0f) + 1.0f)) * Mathf.Pow(2.0f, -10.0f * (2.0f * t - 1.0f)) + 1.0f;
    }
    
    public static float elasticIn(float t)
    {
        return Mathf.Sin(13.0f * t * HALF_PI) * Mathf.Pow(2.0f, 10.0f * (t - 1.0f));
    }

    public static float elasticOut(float t)
    {
        return Mathf.Sin(-13.0f * (t + 1.0f) * HALF_PI) * Mathf.Pow(2.0f, -10.0f * t) + 1.0f;
    }

    public static float exponentialInOut(float t)
    {
        return t == 0.0f || t == 1.0f
          ? t
          : t < 0.5f
            ? +0.5f * Mathf.Pow(2.0f, (20.0f * t) - 10.0f)
            : -0.5f * Mathf.Pow(2.0f, 10.0f - (t * 20.0f)) + 1.0f;
    }

    public static float exponentialIn(float t)
    {
        return t == 0.0f ? t : Mathf.Pow(2.0f, 10.0f * (t - 1.0f));
    }

    public static float exponentialOut(float t)
    {
        return t == 1.0f ? t : 1.0f - Mathf.Pow(2.0f, -10.0f * t);
    }

    public static float quadraticInOut(float t)
    {
        float p = 2.0f * t * t;
        return t < 0.5f ? p : -p + (4.0f * t) - 1.0f;
    }

    public static float quadraticIn(float t)
    {
        return t * t;
    }

    public static float quadraticOut(float t)
    {
        return -t * (t - 2.0f);
    }

    public static float quarticInOut(float t)
    {
        return t < 0.5f
          ? +8.0f * Mathf.Pow(t, 4.0f)
          : -8.0f * Mathf.Pow(t - 1.0f, 4.0f) + 1.0f;
    }

    public static float quarticIn(float t)
    {
        return Mathf.Pow(t, 4.0f);
    }

    public static float quarticOut(float t)
    {
        return Mathf.Pow(t - 1.0f, 3.0f) * (1.0f - t) + 1.0f;
    }

    public static float qinticInOut(float t)
    {
        return t < 0.5f
          ? +16.0f * Mathf.Pow(t, 5.0f)
          : -0.5f * Mathf.Pow(2.0f * t - 2.0f, 5.0f) + 1.0f;
    }

    public static float qinticIn(float t)
    {
        return Mathf.Pow(t, 5.0f);
    }

    public static float qinticOut(float t)
    {
        return 1.0f - (Mathf.Pow(t - 1.0f, 5.0f));
    }

    public static float sineInOut(float t)
    {
        return -0.5f * (Mathf.Cos(Mathf.PI * t) - 1.0f);
    }

    public static float sineIn(float t)
    {
        return Mathf.Sin((t - 1.0f) * HALF_PI) + 1.0f;
    }

    public static float sineOut(float t)
    {
        return Mathf.Sin(t * HALF_PI);
    }

    public static float linear(float t)
    {
        return t;
    }
}
