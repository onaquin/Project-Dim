using Godot;
using System;

public partial class Attacking : Node
{
    bool enemy_in_range = false;
    void _on_area_3d_body_entered(Node3D body)
    {
        
    }
    public override void _Input(InputEvent @event)
    {
        if(@event.IsActionPressed("Attack"))
        {
            GD.Print("Attacking");
        }
    }
}
