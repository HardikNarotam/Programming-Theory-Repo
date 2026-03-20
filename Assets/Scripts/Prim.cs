using UnityEngine;

// Abstraction
public abstract class Prim : MonoBehaviour
{
    // Encapsulation
    public int health;
    public float speed;
    public int damage;
    public GameObject shape;

    // Encapsulation: protected fields
    protected Transform[] pathPoints;
    protected int currentPathIndex = 0;

    // Polymorphism: virtual allows subclasses to override Awake()
    protected virtual void Awake()
    {
        pathPoints = GameObject.FindFirstObjectByType<DrawPath>().points;
    }

    // Polymorphism
    protected virtual void Update()
    {
        Transform target = pathPoints[currentPathIndex];
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, target.position) < 0.1f)
        {
            currentPathIndex = (currentPathIndex + 1) % pathPoints.Length;
        }
    }
}
