using Godot;
using System;

public partial class Moving : Node
{
    Player player;
    [Export]public int Speed = 10;
    [Export]public float Acceleration = 5;
    [Export]public float Friction;
    [Export]
	float JumpHeight = -250;
	[Export]
	float timeToPeak = 0.5f;
	[Export]
	float timeToFall = 0.5f;
	[Export]
	float acceleration = 10f;
	[Export]
	float friction = 12f;
	[Export]
	float VariableJumpHeight = -125; 
    float JumpVelocity;
	float JumpGravity;
	float FallGravity;
	float VariableJumpGravity;
    public override void _Ready()
    {
        player = GetParent().GetParent() as Player;
        JumpVelocity = (2.0f * JumpHeight) / timeToPeak;
		JumpGravity = (-2.0f * JumpHeight) / (timeToPeak * timeToPeak);
		FallGravity = (-2.0f * JumpHeight) / (timeToFall * timeToFall);
		VariableJumpGravity = (JumpVelocity * JumpVelocity) / (2 * VariableJumpHeight);
    }
    public override void _Process(double delta)
    {   if(Global.currentState != Global.GameState.OVERWORLD && Global.currentState != Global.GameState.LEVEL)
            return;
        player.Velocity = GetMovement(delta);
        applyFriction();
        player.MoveAndSlide();
    }
    public override void _PhysicsProcess(double delta)
    {
        //Vector3 newYvel = new Vector3(player.Velocity.X,Mathf.Clamp(player.Velocity.Y+  get_gravity()* (float)delta, 45,56), player.Velocity.Z);
    }

    Vector3 GetMovement(double delta)
    {
        float x = Mathf.MoveToward(player.Velocity.X, player.InputVector.X * Speed, Acceleration * (float)delta);
        float z = Mathf.MoveToward(player.Velocity.Z, player.InputVector.Y * Speed, Acceleration * (float)delta);
        float y = player.Velocity.Y+  get_gravity()* (float)delta;
        return new Vector3(x, y, z);
    }
    void applyFriction()
    {
        if(player.InputVector != Vector2.Zero && player.IsOnFloor())
        {
            player.Velocity.MoveToward(Vector3.Zero, Friction);
        }
    }
float get_gravity()
	{
		if(player.Velocity.Y < 0){
			return JumpGravity;
		}
		else
		{
			return FallGravity;
		}
	}

}
