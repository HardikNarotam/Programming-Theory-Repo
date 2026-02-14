using UnityEngine;

public class CircleBloon : PrimitiveBloons // INHERITANCE
{

    public override void Start() // POLYMORPHISM
    {
        base.Start();
        speed = 3f;
        hitpoints = 2;
    }
}
