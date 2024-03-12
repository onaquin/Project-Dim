using Godot;
using System;

public partial class HealthBar : CanvasLayer
{
	Player player;
	const int HeartRowSize = 10;
	const float HeartOffset = 2.5f;

	Sprite2D hearts;

    public override void _Ready()
    {
		hearts = GetNode("Hearts") as Sprite2D;
        player = GetParent() as Player;
		player.Health = player.GetNode("Health") as Health;
		GD.Print(player);
		for(int i = 0; i < player.Health.maxHealth/4; i++)
		{
			newHeart();
		}
    }

    private void newHeart()
    {
        Sprite2D newHeart = new Sprite2D();
		newHeart.Texture = hearts.Texture;
		newHeart.Hframes = hearts.Hframes;
		newHeart.Vframes = hearts.Vframes;
		hearts.AddChild(newHeart);
		int index = newHeart.GetIndex();
		float x = (index % HeartRowSize) * HeartOffset;
		float y = (index / HeartRowSize) * HeartOffset;
		newHeart.Position = new Vector2(x, y);

    }

}
