using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class PathCreator : MonoBehaviour
{
    public Transform[] wayPoints;
    private LineRenderer line;

    void Awake()
    {
        line = GetComponent<LineRenderer>();
    }

    void Start()
    {
        DrawPath();
    }

    void DrawPath()
    {
        line.positionCount = wayPoints.Length;

        // ABSTRACTION
        for (int i = 0; i < wayPoints.Length; i++)
        {
            line.SetPosition(i, wayPoints[i].position);
        }
    }
}
