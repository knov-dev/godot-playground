using Godot;
using System;
[GlobalClass]
public partial class Wave : Resource
{
    [Export] public Godot.Collections.Array<EnemySequence> _enemySequence = new Godot.Collections.Array<EnemySequence>();
}
