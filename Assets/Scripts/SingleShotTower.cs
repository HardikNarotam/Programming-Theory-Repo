using UnityEngine;

public class SingleShotTower : Tower
{
    protected override void Awake()
    {
        // Encapsulation
        range = 3f;
        fireRate = 1f;
        damage = 1;
        projectileSpeed = 5f;
    }

    protected override void Shoot()
    {
        if (target != null)
        {
            // Instantiate projectile and set its target and damage
            GameObject proj = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            Projectile projectileScript = proj.GetComponent<Projectile>();
            projectileScript.SetTarget(target);
            projectileScript.SetDamage(damage);
            projectileScript.SetSpeed(projectileSpeed);
        }
    }
}
