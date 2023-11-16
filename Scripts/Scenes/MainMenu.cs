using Godot;
using System;

namespace ShooterGame.Scripts.Scenes;

public partial class MainMenu : Node2D
{
    public override void _Process(double delta)
    {
        
    }

    private void OnStartButtonPressed()
    {
        GetTree().ChangeSceneToFile("res://Scenes/Game.tscn");
    }
}
