using Godot;
using System;

namespace ShooterGame.Scripts;
public partial class Bullet : Area2D
{
    [Export] public int Speed = 400;
    [Export] public int Damage = 5;

    private Vector2 _velocity = new(0, -1);

    public override void _Process(double delta)
    {
        _velocity = _velocity.Normalized() * Speed;
        Position += _velocity;
    }
}
