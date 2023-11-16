using Godot;
using System;

namespace ShooterGame.Scripts;
public partial class FPS : Label
{
    private Vector2 _playerPos;
    [Export] private string _buildId = "";
    
    public override void _Process(double delta)
    {
        Text = $"FPS: {Engine.GetFramesPerSecond()} BUILD ID: {_buildId}";
    }
}
