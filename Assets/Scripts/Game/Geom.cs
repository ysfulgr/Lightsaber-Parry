using UnityEngine;

public static class Geom
{
    public static bool GetAngle(float f1, float f2, float c)
    {
        return Mathf.Abs(f1 - f2) < c;
    }

    public static bool RotationEqual(float f1, float f2)
    {
        return (f1.Equals(f2) || (f1 == f2));
    }
}