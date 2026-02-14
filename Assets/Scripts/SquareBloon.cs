using UnityEngine;

public class SquareBloon : PrimitiveBloons // INHERITANCE
{
    public override void Start() // POLYMORPHISM
    {
        base.Start();
        speed = 2f;
        hitpoints = 3;
    }
}
