using Godot;
public partial class Inventory : Node
{

    public void Capture(Enemy enemy)
    {
        string Enemy = enemy.Name;
        enemy.health.Kill();
    }
}
