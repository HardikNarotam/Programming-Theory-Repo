using UnityEngine;

public class TringleBloon : PrimitiveBloons
{
    public override void Start()
    {
        base.Start();
        speed = 1f;
        hitpoints = 1;
    }
}
