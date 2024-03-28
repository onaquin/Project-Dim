using Godot;
using System;

public partial class EnemyHealth : Health
{
    public override void _Ready()
    {
        currentHealth = maxHealth;
    }
}
