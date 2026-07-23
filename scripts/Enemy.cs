using Godot;
using System;

public partial class Enemy : PathFollow3D
{
	[Export] public float _Speed;
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if(ProgressRatio < 1){
			ProgressRatio += (float)delta/2 * _Speed;
			SetProgressRatio(ProgressRatio);
		}
        else
        {
            QueueFree();
		}
	}
}
