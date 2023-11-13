using Godot;
using System;

public partial class MainMenu : Node2D
{
    public override void _Process(double delta)
    {
    }

    public void onStartButtonPressed()
    {
        GetTree().ChangeSceneToFile("res://Scenes/Game.tscn");
    }
}
