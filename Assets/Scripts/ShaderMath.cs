using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is a collection of the common glsl shader functions. It ported to the C#.
public class ShaderMath
{
    public static float mix(float x, float y, float a)
    {
        return x + (y - x) * a;
    }

    public static Vector3 mix(Vector3 x, Vector3 y, float a)
    {
        return x + (y - x) * a;
    }

    public static float step(float edge, float x)
    {
        return x < edge ? 0.0f : 1.0f;
    }

    public static float smoothstep(float edge0, float edge1, float x)
    {
        float t = Mathf.Clamp(((x - edge0) / (edge1 - edge0)), 0f, 1f);
        return t * t * (3f - 2f * t);
    }

    public static float fract(float x)
    {
        return x - Mathf.Floor(x);
    }

    public static Vector2 floor(Vector2 x)
    {
        x.x = Mathf.Floor(x.x);
        x.y = Mathf.Floor(x.y);
        return x;
    }

    public static Vector3 floor(Vector3 x)
    {
        x.x = Mathf.Floor(x.x);
        x.y = Mathf.Floor(x.y);
        x.z = Mathf.Floor(x.z);
        return x;
    }

    public static Vector2 fract(Vector2 x)
    {
        return x - floor(x);
    }

    public static Vector3 fract(Vector3 x)
    {
        return x - floor(x);
    }

    public static float mod(float a, float b)
    {
        int n = (int)(a / b);
        a -= n * b;
        if (a < 0)
        {
            a += b;
        }
        return a;
    }

    // based on "http://qiita.com/gaziya5/items/29a51b066cb7d24983d6"
    public static float scene(float t, float w, float s)
    {
        return Mathf.Clamp(t - w, 0.0f, s) / s;
    }

    public static Vector2 N22(Vector2 p)
    {
        Vector3 a = fract(new Vector3(p.x* 123.34f, p.y* 234.34f, p.x* 345.65f));
        Vector3 b = a;
        b.x = b.x + 34.45f;
        b.y = b.y + 34.45f;
        b.z = b.z + 34.45f;

        float c = Vector3.Dot(a, b);
        a.x += c;
        a.y += c;
        a.z += c;
        return fract(new Vector2(a.x * a.y, a.y * a.z));
    }
}
