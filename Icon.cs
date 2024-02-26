using Godot;
using System;

public partial class Icon : Sprite2D
{
	int speed = 10;
	bool direction;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		direction = true;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		var temp = Position;
		if(direction) {
			temp.X += speed;
		} else {
			temp.X -= speed;
		}
		if(temp.X > 1000 && direction) {
			direction = !direction; 
		}
		if(temp.X < 0 && !direction) {
			direction = !direction;
		}
		Position = temp;
	}
}
