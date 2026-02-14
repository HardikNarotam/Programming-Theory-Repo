using UnityEngine;

public class TringleBloon : PrimitiveBloons // INHERITANCE
{
    public override void Start() // POLYMORPHISM
    {
        base.Start();
        speed = 1f;
        hitpoints = 1;
    }
}
