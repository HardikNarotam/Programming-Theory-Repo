using UnityEngine;

// Inheritance
public class YellowCircle : Prim
{
    // Polymorphism
    protected override void Awake()
    {
        maxHealth = 1;
        speed = 3f;
        damage = 1;
        shape = GetComponentInChildren<SpriteRenderer>().gameObject;

        base.Awake();
    }

}
