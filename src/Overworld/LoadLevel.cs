using Godot;
using System;

public partial class LoadLevel : Area3D
{
	[Export] public String levelToLoad;
	[Export] public Global.GameState newLevelState;
	public void _on_body_entered(Node3D body)
	{
		if(String.Equals(body.Name, "Player"))
		{
			PackedScene newLevel = GD.Load<PackedScene>(levelToLoad);
			Node3D loadedLevel = (Node3D)newLevel.Instantiate();
			GetTree().Root.AddChild(loadedLevel);
			
			if(newLevelState != Global.currentState)
			{
				if(newLevelState == Global.GameState.OVERWORLD)
				{
					Global.Player.Scale = Global.overWorldPlayerScale;
					Global.Camera.arm.SpringLength = Global.overWorldSpringArmLength;
				}
				else if (newLevelState == Global.GameState.LEVEL)
				{
					Global.Player.Scale = Global.levelPlayerScale;
					Global.Camera.arm.SpringLength = Global.levelSpringArmLength;
					GetParent().QueueFree();
				}
				Global.currentState = newLevelState;
			}
		}
	}
}
