using Godot;
using System;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;

public partial class Icon : Sprite2D
{
	int speed = 10;
	int screenWidth;
	int screenHeight;
	bool direction;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		screenWidth = 1920;
		screenHeight = 1080;
		ProjectSettings.SetSetting("display/window/size/viewport_width",screenWidth);
		ProjectSettings.SetSetting("display/window/size/viewport_height",screenHeight);
		direction = true;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		var temp = Position;
		if(Input.IsKeyPressed(Key.W)) {
			temp.Y -= speed;
		} 
		if(Input.IsKeyPressed(Key.A)) {
			temp.X -= speed;
		} 
		if(Input.IsKeyPressed(Key.S)) {
			temp.Y += speed;
		} 
		if(Input.IsKeyPressed(Key.D)) {
			temp.X += speed;
		} 
		Position = temp;
		System.Console.Write("" + screenHeight + "" + screenWidth);
	}
}
