using Godot;
using System;

public partial class Player : CharacterBody3D
{
    public Vector2 InputVector;
    public Health Health;
    public Moving moving;
    public Sprite2D playerSprite;

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
        InputVector = input.Normalized();
        
    }

}
