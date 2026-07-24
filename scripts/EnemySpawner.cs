using Godot;
using System;

public partial class EnemySpawner : Node
{
	[Export] private Button _button;
	[Export] public Path3D _path3DNode;
	[Export] public PackedScene _enemy;
    [Export] public Godot.Collections.Array<Wave> _enemyWaves = new Godot.Collections.Array<Wave>();
    public override void _Ready()
    {
        _button.Pressed += HandleButtonPressed;
    }

	private void HandleButtonPressed()
	{
		var instance = _enemy.Instantiate();
		_path3DNode.AddChild(instance);
	}
}
