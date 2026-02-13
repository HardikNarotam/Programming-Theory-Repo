using UnityEngine;

public class AiPathFollower : MonoBehaviour
{

    public Transform[] points;
    public float speed = 2f;
    private int index = 0;

    // Update is called once per frame
    void Update()
    {
        Transform target = points[index];
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, target.position) < 0.1f)
        {
            index = (index + 1) % points.Length;
        }
    }
}
