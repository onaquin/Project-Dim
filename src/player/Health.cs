using Godot;
using System;

public partial class Health : Node
{
    public int currentHealth;
    Player player;
    [Export]public int maxHealth;

    public override void _Ready()
    {
       // player = GetParent() as Player;
     //   player.Health = this;
        
    }
    public void Damage(int damage)
    {
        currentHealth -= damage;
        if(currentHealth <= 0)
        {
            Kill();
        }
    }

    public void Kill()
    {
        if(player != null)
            Global.currentState = Global.GameState.LOADING;
        else{
            GetParent().QueueFree();
        }
    }

}
