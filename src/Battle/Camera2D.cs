using Godot;
using System;

public partial class Camera2D : Godot.Camera2D
{
	[Export] Node3D camera3D;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Vector2 newPos = new Vector2();
		newPos.X = camera3D.Position.X * 2;
		newPos.Y = camera3D.Position.Z * 2;
		Position = newPos;

	}
}
