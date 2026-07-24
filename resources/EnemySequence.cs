using Godot;

[GlobalClass]
public partial class EnemySequence : Resource
{
    [Export] public PackedScene _enemy;
    [Export] public int _amount;
    [Export] public int _time;

}
