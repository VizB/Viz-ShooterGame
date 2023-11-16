using Godot;
using System;

namespace ShooterGame.Scripts;

public partial class PowerUpHealth : PowerUp
{
    public override void _Ready()
    {
        TextureList.Add((Texture)GD.Load("res://Assets/Power-ups/powerupGreen_sheild.png"));
        TextureList.Add((Texture)GD.Load("res://Assets/Power-ups/powerupBlue_sheild.png"));
        TextureList.Add((Texture)GD.Load("res://Assets/Power-ups/powerupRed_sheild.png"));
        InitSprite(new RandomNumberGenerator().RandiRange(0, 3));
    }
}
