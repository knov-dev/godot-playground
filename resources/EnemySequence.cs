using Godot;
using System;

public partial class EnemySequence : Resource
{
    [Export] public PackedScene _enemy;
    [Export] public int _amount;
    [Export] public int _time;
    
}
