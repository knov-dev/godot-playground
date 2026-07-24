using Godot;
public partial class EnemySpawner : Node
{
	[Export] private Button _button;
	[Export] public Path3D _path3DNode;
	[Export] public float _timeBetweenEnemies;

    [Export] public Godot.Collections.Array<Wave> _enemyWaves = new Godot.Collections.Array<Wave>();
    public override void _Ready()
    {
        _button.Pressed += HandleButtonPressed;
    }

	private async void HandleButtonPressed()
	{
		foreach (Wave _wave in _enemyWaves)
		{
			foreach(EnemySequence _enemysequence in _wave._enemySequence)
			{
				for ( int i = 0; i < _enemysequence._amount; i++)
				{
					var instance = _enemysequence._enemy.Instantiate();
					_path3DNode.AddChild(instance);
					await ToSignal(GetTree().CreateTimer(_timeBetweenEnemies), "timeout");
				}
				await ToSignal(GetTree().CreateTimer(_enemysequence._time), "timeout");
			}
		}
		
	}

}
