using Godot;
using System;
using System.Collections.Generic;

namespace ShooterGame.Scripts;
public partial class PowerUp : Area2D
{
    protected List<Texture> TextureList = new(3);

    protected void InitSprite(int spriteNum)
    {
        var sprite = GetNode<Sprite2D>("Sprite2D");
        sprite.Texture = (Texture2D)TextureList[spriteNum];
    }
}
