using Godot;
using System;
using System.Net.Mime;
using System.Transactions;

namespace ShooterGame.Scripts;
public partial class PowerUpSpeed : PowerUp
{
    public override void _Ready() 
    {
        TextureList.Add((Texture)GD.Load("res://Assets/Power-ups/powerupGreen_bolt.png"));
        TextureList.Add((Texture)GD.Load("res://Assets/Power-ups/powerupBlue_bolt.png"));
        TextureList.Add((Texture)GD.Load("res://Assets/Power-ups/powerupRed_bolt.png"));
        InitSprite(new RandomNumberGenerator().RandiRange(0, 3));
    }
}
