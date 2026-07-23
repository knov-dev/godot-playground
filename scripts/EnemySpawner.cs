using Godot;
using System;

public partial class EnemySpawner : Node
{
	[Export] private Button _button;
	[Export] public Path3D _Path3DNode;
	[Export] public PackedScene _Enemy;
    public override void _Ready()
    {
        _button.Pressed += HandleButtonPressed;
    }

	private void HandleButtonPressed()
	{
		var instance = _Enemy.Instantiate();
		_Path3DNode.AddChild(instance);
	}
}
