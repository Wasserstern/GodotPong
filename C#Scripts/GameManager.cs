using Godot;
using System;

public partial class GameManager : Node
{	[Export]
	public int maxScore;
	[Signal]
	public delegate void PlayerScoredEventHandler();
	public int scoreLeft;
	public int scoreRight;
	
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
