using Godot;
using static BoatLib;
using System;

public partial class Camera : Node3D
{
	SpringArm3D camera;
	Node3D Target;
	
	[Export] public float LerpSpeed = 0.5f;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Target = Global.Target;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Position = Lerp(Position, Target.Position, LerpSpeed * (float)delta);
	}
}
