using Godot;
using System;

public partial class StartBattle : Area3D
{
	public float overrideCameraRotation = -80;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	public void _on_body_entered(Node3D body)
	{
		Global.Camera.updateRotation(overrideCameraRotation); // update
		Global.Target = GetParent() as Node3D;
		Global.currentState = Global.GameState.BATTLE; 
		Node3D playerSprite = Global.Player.GetChild(0) as Node3D;
		if(playerSprite.GlobalPosition.Z != playerSprite.GlobalPosition.Z - 50){
			Tween tween = CreateTween();
		
        	tween.TweenProperty(playerSprite, "global_position",new Vector3(playerSprite.GlobalPosition.X, playerSprite.GlobalPosition.Y, playerSprite.GlobalPosition.Z + 50) , 0.9f);
			tween.Play();
		}
		Node3D HealthBar = GetParent().GetChild(2) as Node3D;
		HealthBar.Show();
	}
}
