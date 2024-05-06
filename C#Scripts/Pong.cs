using Godot;
using System;

public partial class Pong : StaticBody2D
{
	[Export]
	float moveSpeed;
	float initialXDirection;
	float yInput;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		yInput = Input.GetAxis("Up", "Down");
		GD.Print(yInput);

		if(yInput != 0){
			this.Position += new Vector2(0, moveSpeed * (float)delta * yInput);
		}
	}
}
