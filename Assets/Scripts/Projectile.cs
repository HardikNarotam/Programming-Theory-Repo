using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Prim target;
    public float speed;
    public int damage;
    private Vector2 targetPosition;

    private void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }

    public void SetTarget(Prim target)
    {
        this.target = target;
        targetPosition = target.transform.position;
    }

    public void SetDamage(int damageAmount)
    {
        damage = damageAmount;
    }

    public void SetSpeed(float speed)
    {
        this.speed = speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Prim prim = other.GetComponent<Prim>();
        if (prim != null)
        {
            prim.TakeDamage(damage);
            Destroy(gameObject);
        }

    }

    public void SetTargetPosition(Prim target, Vector3 position, Quaternion rotation, float range)
    {
        this.target = target;
        Vector2 direction = (target.transform.position - position).normalized;
        Vector2 rotatedDirection = rotation * direction;
        Vector2 spreadTarget = (Vector2)transform.position + rotatedDirection * range;
        targetPosition = spreadTarget;
    }
}
