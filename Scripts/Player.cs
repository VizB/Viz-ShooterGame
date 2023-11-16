using System;
using Godot;

namespace ShooterGame.Scripts;

public partial class Player : Area2D
{
    [Export]
    public float Speed = 100f;

    private Vector2 _screenSize;
    private PackedScene _bulletScene;
    private bool _canShoot = true;

    public override void _Ready()
    {
        _screenSize = GetViewportRect().Size;
        // Preload bullet scene
        _bulletScene = GD.Load<PackedScene>("res://Scenes/Bullet.tscn");
    }

    public override void _Process(double delta)
    {
        var velocity = Vector2.Zero;
        
        if (Input.IsActionPressed("move_left")) velocity.X -= 1;
        if (Input.IsActionPressed("move_right")) velocity.X += 1;
        if (Input.IsActionPressed("move_backward")) velocity.Y += 1;
        if (Input.IsActionPressed("move_forward")) velocity.Y -= 1;
        if (Input.IsActionPressed("shoot") && _canShoot)
        {
            var bullet = (Bullet)_bulletScene.Instantiate();
            GetTree().Root.AddChild(bullet);
            //TODO: Fix this hardcoded value.
            bullet.Position = new Vector2(Position.X, Position.Y - 50);
            _canShoot = false;
        }
        // Making sure that the player doesn't move faster diagonally 
        velocity = velocity.Normalized() * Speed;
        
        Position += velocity;
        
        Position = new Vector2(
            Mathf.Clamp(Position.X, 0, _screenSize.X),
            Mathf.Clamp(Position.Y, 0, _screenSize.Y)
        );
    }

    private void OnGunTimerTimeout() { _canShoot = true; }

    private void OnPowerUpTouched()
    {
        GetNode<PowerUp>("").QueueFree();
    }
}