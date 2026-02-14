using UnityEngine;

public class CircleBloon : PrimitiveBloons
{
    public override void Start()
    {
        base.Start();
        speed = 3f;
        hitpoints = 2;
    }
}
