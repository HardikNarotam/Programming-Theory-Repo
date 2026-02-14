using UnityEngine;

public class SquareBloon : PrimitiveBloons
{
    public override void Start()
    {
        base.Start();
        speed = 2f;
        hitpoints = 3;
    }
}
