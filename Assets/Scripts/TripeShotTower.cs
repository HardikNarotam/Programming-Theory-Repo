using UnityEngine;

public class TripeShotTower : Tower
{
    protected override void Awake()
    {
        // Encapsulation
        range = 3f;
        fireRate = 0.5f;
        damage = 1;
        projectileSpeed = 7f;
    }

    protected override void Shoot()
    {
        // Instantiate 3 projectiles with slight angle offsets
        for (int i = -1; i <= 1; i++)
        {
            Quaternion rotation = Quaternion.Euler(0, 0, i * 15); // Adjust angle offset as needed
            GameObject proj = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            Projectile projectileScript = proj.GetComponent<Projectile>();
            projectileScript.SetTargetPosition(target, transform.position, rotation, range);
            projectileScript.SetDamage(damage);
            projectileScript.SetSpeed(projectileSpeed);
        }
    }
}
