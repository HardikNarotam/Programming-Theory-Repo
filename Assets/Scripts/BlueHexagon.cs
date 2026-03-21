using UnityEngine;

public class BlueHexagon : Prim
{
    protected override void Awake()
    {
        maxHealth = 3;
        speed = 1.5f;
        damage = 1;
        shape = GetComponentInChildren<SpriteRenderer>().gameObject;

        base.Awake();
    }
}

