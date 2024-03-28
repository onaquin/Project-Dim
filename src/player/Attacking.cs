using Godot;
using System;
using System.Collections.Generic;

public partial class Attacking : Node
{
    bool enemy_in_range = false;
    [Export] public float step = 0.5f;
    public Player parent;
    bool attacking;
    List<Enemy> enemies = new List<Enemy>();
    void _on_area_3d_body_entered(Node3D body)
    {
            enemies.Add(body as Enemy);
    }
    public override void _Input(InputEvent @event)
    {
        if(@event.IsActionPressed("Attack"))
        {
            if(parent == null)
            {
                parent = GetParent().GetParent() as Player; 
            }
            GD.Print("Attacking");
            float x = step * parent.viewDirection.X;
            float z = step * parent.viewDirection.Y;
            parent.Velocity += new Vector3(x,0,z);
            foreach(Enemy enemy in enemies)
            {
                enemy.health.Damage(5);
            }
        }
    }
    void _on_area_3d_body_exited(Node3D body)
    {
        enemies.Remove(body as Enemy);
    }

}
