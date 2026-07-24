using Godot;
public partial class EnemySpawner : Node
{
	[Export] private Button _button;
	[Export] public Path3D _path3DNode;
    [Export] public Godot.Collections.Array<Wave> _enemyWaves = new Godot.Collections.Array<Wave>();
    public override void _Ready()
    {
        _button.Pressed += HandleButtonPressed;
    }

	private void HandleButtonPressed()
	{
		foreach (Wave _wave in _enemyWaves)
		{
			GD.Print(_wave);
			foreach(EnemySequence _enemysequence in _wave._enemySequence)
			{
				GD.Print(_enemysequence._enemy);
				GD.Print(_enemysequence._amount);
				GD.Print(_enemysequence._time);
				for ( int i = 0; i < _enemysequence._amount; i++)
				{
					var instance = _enemysequence._enemy.Instantiate();
					_path3DNode.AddChild(instance);
				}
				
			}
		}
		
	}
}
