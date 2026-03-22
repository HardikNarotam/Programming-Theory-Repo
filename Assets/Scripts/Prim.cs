using UnityEngine;

// Abstraction
public abstract class Prim : MonoBehaviour
{
    // Encapsulation
    public int maxHealth;
    public float speed;
    public int damage;
    public GameObject shape;

    // Encapsulation: protected fields
    protected int currentHealth;
    protected Transform[] pathPoints;
    protected int currentPathIndex = 0;

    // Polymorphism: virtual allows subclasses to override Awake()
    protected virtual void Awake()
    {
        currentHealth = maxHealth;
        pathPoints = GameObject.FindFirstObjectByType<DrawPath>().points;
    }

    // Polymorphism
    protected virtual void Update()
    {
        Transform target = pathPoints[currentPathIndex];
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, target.position) < 0.1f)
        {
            if (currentPathIndex >= pathPoints.Length - 1)
                Pop();
            else
                currentPathIndex = (currentPathIndex + 1) % pathPoints.Length;
        }
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Pop();
        }
    }

    protected virtual void Pop()
    {
        // Play pop animation or effects here
        OnPop();
        Destroy(gameObject);
    }

    protected virtual void OnPop() { } // Abstract method for subclasses to implement specific pop behavior
}
