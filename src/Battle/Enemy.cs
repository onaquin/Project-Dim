using Godot;
using System;

public partial class Enemy : CharacterBody3D
{
	public Health health;
	public ProgressBar healthBar;

    public override void _Ready()
    {
        health = GetChild(1) as Health;
		healthBar = GetChild(3).GetChild(0).GetChild(0) as ProgressBar;
		healthBar.MaxValue = health.maxHealth;
    }
    public override void _Process(double delta)
    {
        healthBar.Value = health.currentHealth;
    }
    void capture(){
        
    }

}
