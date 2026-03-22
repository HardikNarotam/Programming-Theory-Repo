using UnityEngine;

// Inheritance
public class RedSquare : Prim
{
    // Polymorphism
    protected override void Awake()
    {
        // Encapsulation
        maxHealth = 1;
        speed = 2f;
        damage = 1;
        shape = GetComponentInChildren<SpriteRenderer>().gameObject;

        // Inheritance: base.Awake() calls Prim's Awake() to ensure pathPoints is assigned.
        base.Awake();
    }
}
