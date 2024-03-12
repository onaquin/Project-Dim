using Godot;
using System;

public static class BoatLib
{
    public static Vector3 Lerp(Vector3 from, Vector3 to,float speed)
    {
        Vector3 result = new Vector3();
        result.X = Lerp(from.X, to.X, speed);
        result.Y = Lerp(from.Y, to.Y, speed);
        result.Z = Lerp(from.Z, to.Z, speed);
        return result;
    }
    public static float Lerp(float firstFloat, float secondFloat, float by)
    {
        return firstFloat * (1 - by) + secondFloat * by;
    }
}
