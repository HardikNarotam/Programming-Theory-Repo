using UnityEngine;

public class PrimitiveBloons : MonoBehaviour
{
    protected int hitpoints;
    protected float speed;

    public PathCreator path;
    protected int currentWayPoint = 0;

    public virtual void Start()
    {

    }

    public virtual void Update()
    {
        FollowPath();
    }

    protected void FollowPath() // ABSTRACTION
    {
        Transform target = path.wayPoints[currentWayPoint];
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, target.position) < 0.1f)
        {
            currentWayPoint++;
        }
    }
}
