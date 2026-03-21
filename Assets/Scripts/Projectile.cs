using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Prim target;
    public float speed;
    public int damage;

    private void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, target.transform.position) < 0.1f)
        {
            target.TakeDamage(damage);
            Destroy(gameObject);
        }
    }

    public void SetTarget(Prim target)
    {
        this.target = target;
    }

    public void SetDamage(int damageAmount)
    {
        damage = damageAmount;
    }

    public void SetSpeed(float speed)
    {
        this.speed = speed;
    }
}
