using Godot;
using Godot.NativeInterop;
using System;

public partial class Capture : Control
{
	Vector2 MouseMotion = Vector2.Zero;
	Line2D CaptureLine = new Line2D();
	Vector2[] LinePoints = new Vector2[0];
	int lineWidth = 10;
	Node2D SegmnentNode;
	Node2D LoopNode;
	[Export] int maxPoints = 60;
	[Export] int minLength = 40;

	const int frameDelay = 2;
	const float maxVelocity = 10.0f;

	Vector2[] lastMousePosition;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		CaptureLine.Name = "CaptureLine";
		CaptureLine.JointMode = Line2D.LineJointMode.Round;
		CaptureLine.BeginCapMode = Line2D.LineCapMode.Round;
		CaptureLine.EndCapMode = Line2D.LineCapMode.Round;
		CaptureLine.TextureMode = Line2D.LineTextureMode.Tile;
		AddChild(CaptureLine);

		SegmnentNode.Name = "SegmnentNode";
		AddChild(SegmnentNode);

		LoopNode.Name = "LoopNode";
		AddChild(LoopNode);
	}
    public override void _Input(InputEvent @event)
    {
        if(@event is InputEventMouseMotion eventMouseMotionEvent)
		{
			MouseMotion = eventMouseMotionEvent.Position;
		}
    }
    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
	{
		if(Input.IsActionJustPressed("Draw"))
		{
			ProcessLine(MouseMotion);
		}
		else if(Input.IsActionJustReleased("Draw"))
		{
			ClearPoints(LinePoints.Length);
		}
	}

    private void ClearPoints(int length)
    {
        throw new NotImplementedException();
    }


    private void ProcessLine(Vector2 mouseMotion)
    {
        throw new NotImplementedException();
    }

}
