using Godot;
using System;

public partial class Player : CharacterBody3D
{
    public Vector2 InputVector;
    public Health Health;
    public Moving moving;
    public Sprite2D playerSprite;
    public Node3D Pivot;

    Attacking attackState;

    public Vector2 viewDirection;
    Inventory inventory;
    RayCast3D hitRay;

    public override void _Ready()
    {
        Global.Target = this;
        Global.Player = this;
        Pivot = GetNode("Pivot") as Node3D;
        attackState = GetNode("States").GetNode("Attacking") as Attacking;
        inventory = GetNode("Inventory") as Inventory;
        hitRay = Pivot.GetNode("RayCast3D") as RayCast3D;
        attackState.parent = this;
    }
    public override void _Input(InputEvent @event)
    {
        float x = Input.GetActionStrength("Move_Right") - Input.GetActionStrength("Move_Left");
        float y = Input.GetActionStrength("Move_Down") - Input.GetActionStrength("Move_Up");
        Vector2 input = new Vector2(x,y);
        if(input != Vector2.Zero){
            Pivot.Rotation = new Vector3(0,Mathf.Atan2(-y,x),0);
            viewDirection = input;
            
        }
        GD.Print(viewDirection);
        InputVector = input.Normalized();
        if(Input.IsActionJustPressed("Capture"))
        {
            
            inventory.Capture(hitRay.GetCollider() as Enemy);
        }
        
    }

}
