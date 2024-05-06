using Godot;
using System;

public partial class Ball : RigidBody2D
{
	[Export]
	float initialForce;
	[Export]
	Vector2 initialForceDirection;
	public override void _Ready()
	{
		this.ApplyImpulse(initialForceDirection * initialForce, new Vector2(0, 0));
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
