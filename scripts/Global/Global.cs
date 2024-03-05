using Godot;
using System;

public static class Global
{
    public static Node3D Target;
    public static Node3D Player;
    public static CameraController Camera;
    public static float CameraRotation = -55;
    public static float DefaultCameraRotation = -55;

    public static Vector3 levelPlayerScale = Vector3.One;
    public static Vector3 overWorldPlayerScale = new Vector3(15, 15, 15);

    public static float levelSpringArmLength = 11.765f;
    public static float overWorldSpringArmLength = 11.765f * 15;
    public enum GameState
    {
        OVERWORLD,
        LEVEL,
        BATTLE,
        PAUSE,
        CUTSCENE,
        LOADING,
    }
    public static GameState currentState = GameState.LEVEL;
    

}
