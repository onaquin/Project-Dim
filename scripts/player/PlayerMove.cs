using Godot;
using System;

public partial class PlayerMove : CharacterBody3D
{
    public Vector2 InputVector;

    public override void _Ready()
    {
        Global.Target = this;
    }
    public override void _Input(InputEvent @event)
    {
        float x = Input.GetActionStrength("Move_Right") - Input.GetActionStrength("Move_Left");
        float y = Input.GetActionStrength("Move_Down") - Input.GetActionStrength("Move_Up");
        Vector2 input = new Vector2(x,y);
        InputVector = input.Normalized();
    }
}
