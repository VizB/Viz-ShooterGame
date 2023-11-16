using Godot;

namespace ShooterGame.Scripts.Scenes;

public partial class Game : Node2D
{
    private PackedScene _asteroidScene;
    private PackedScene _powerUpScene;
    private RandomNumberGenerator _rand;
    public override void _Ready()
    {
        // Preloads scenes
        _asteroidScene = GD.Load<PackedScene>("res://Scenes/Asteroid.tscn");
        _powerUpScene = GD.Load<PackedScene>("res://Scenes/PowerUp.tscn");
    }

    private void OnAsteroidTimerTimeout()
    {
        var asteroid = (Asteroid)_asteroidScene.Instantiate();
        GetTree().Root.AddChild(asteroid);
    }
    
    private void OnPowerUpTimerTimeout()
    {
        var xPos = _rand.RandiRange(0, 600);
        var yPos = _rand.RandiRange(0, 800);
        var powerUp = (PowerUp)_powerUpScene.Instantiate();
        powerUp.Position = new Vector2(_rand.RandiRange(0, 600), _rand.RandiRange(0, 800));
        GD.Print();
        GetTree().Root.AddChild(powerUp);
    }
}
