using Godot;
using System;

public static class Global
{
    public static Node3D Target;
    public static Node3D Player;
    public static CameraController Camera;
    public static float CameraRotation = -55;
    public static float DefaultCameraRotation = -55;

    public enum GameState
    {
        OVERWORLD,
        BATTLE,
        PAUSE,
        CUTSCENE,
    }
    public static GameState currentState;
    

}
