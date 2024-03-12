using Godot;
using static BoatLib;
using System;

public partial class CameraController : Node3D
{
	public SpringArm3D arm;
	Node3D Target;
	
	[Export] public float LerpSpeed = 0.5f;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Target = Global.Target;
		arm = GetChild(0) as SpringArm3D;
		Global.Camera = this;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Position = Lerp(Position, Global.Target.Position, LerpSpeed * (float)delta);
	}
	public void updateRotation(float newRotation)
    {
		if(arm.Rotation != new Vector3(Mathf.DegToRad(newRotation), 0f, 0f)){
		 Tween tween = CreateTween();
		
        tween.TweenProperty(arm, "rotation",new Vector3(Mathf.DegToRad(newRotation), 0f, 0f) , 0.5f);
		tween.Play();
		}

    }
}
