using Godot;
using System;

public partial class Moving : Node
{
    PlayerMove player;
    [Export]public int Speed = 10;
    [Export]public float Acceleration = 5;
    [Export]public float Friction;
    public override void _Ready()
    {
        player = GetParent().GetParent() as PlayerMove;
    }
    public override void _Process(double delta)
    {   if(Global.currentState != Global.GameState.OVERWORLD && Global.currentState != Global.GameState.LEVEL)
            return;
        player.Velocity = GetMovement(delta);
        applyFriction();
        player.MoveAndSlide();
    }
    Vector3 GetMovement(double delta)
    {
        float x = Mathf.MoveToward(player.Velocity.X, player.InputVector.X * Speed, Acceleration * (float)delta);
        float z = Mathf.MoveToward(player.Velocity.Z, player.InputVector.Y * Speed, Acceleration * (float)delta);
        return new Vector3(x, 0, z);
    }
    void applyFriction()
    {
        if(player.InputVector != Vector2.Zero && player.IsOnFloor())
        {
            player.Velocity.MoveToward(Vector3.Zero, Friction);
        }
    }

}
