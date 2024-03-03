using Godot;
using System;

public partial class PlayerMove : CharacterBody3D
{
    public Vector2 InputVector;

    public override void _Ready()
    {
        Global.Target = this;
        Global.Player = this;
    }
    public override void _Input(InputEvent @event)
    {
        float x = Input.GetActionStrength("Move_Right") - Input.GetActionStrength("Move_Left");
        float y = Input.GetActionStrength("Move_Down") - Input.GetActionStrength("Move_Up");
        Vector2 input = new Vector2(x,y);
        
        if(InputVector.X > 0 && InputVector.X < 1)
        {
            InputVector.X = 1;
        }
        else if(InputVector.X < 0 && InputVector.X > -1)
        {
            InputVector.X = -1;
        }
        if(InputVector.Y > 0 && InputVector.Y < 1)
        {
            InputVector.Y = 1;
        }
        else if(InputVector.Y < 0 && InputVector.Y > -1)
        {
            InputVector.Y = -1;
        }
        InputVector = input.Normalized();
    }
}
