using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class AOETower : Tower
{
    private SpriteRenderer aoeEffect;

    protected override void Awake()
    {
        // Encapsulation
        range = 1.5f;
        fireRate = .5f;
        damage = 1;
        projectileSpeed = 0f; // No projectile, instant effect

        aoeEffect = transform.Find("AOEEffect").GetComponent<SpriteRenderer>();
        aoeEffect.transform.localScale = new Vector3(range * 2, range * 2, 1);
        aoeEffect.color = new Color(1, 0, 0, 0.5f); // Semi-transparent red
        aoeEffect.enabled = false; // Hide effect until shooting
    }

    protected override void Shoot()
    {
        Collider2D[] targets = Physics2D.OverlapCircleAll(transform.position, range);
        foreach (Collider2D col in targets)
        {
            Prim prim = col.GetComponent<Prim>();
            if (prim != null)
            {
                StartCoroutine(showAOEEffect());
                prim.TakeDamage(damage);
            }
        }
    }

    IEnumerator showAOEEffect()
    {
        aoeEffect.enabled = true;
        yield return new WaitForSeconds(0.1f); // Show effect briefly
        aoeEffect.enabled = false;
    }
}
