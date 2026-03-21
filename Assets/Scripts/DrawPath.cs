using Unity.VisualScripting;
using UnityEngine;

public class DrawPath : MonoBehaviour
{
    // Encapsulation
    public Transform[] points;
    private LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = gameObject.AddComponent<LineRenderer>();

        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
        lineRenderer.positionCount = points.Length;

        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
        lineRenderer.startColor = Color.white;
        lineRenderer.endColor = Color.white;

        lineRenderer.sortingOrder = -1;
        DrawLineThroughPoints();

        EdgeCollider2D edgeCollider = GetComponent<EdgeCollider2D>();
        Vector2[] edgePoints = new Vector2[points.Length];
        for (int i = 0; i < points.Length; i++)
        {
            edgePoints[i] = new Vector2(points[i].position.x, points[i].position.y);
        }
        edgeCollider.points = edgePoints;
    }

    void DrawLineThroughPoints()
    {
        for (int i = 0; i < points.Length; i++)
        {
            lineRenderer.SetPosition(i, points[i].position);
        }
    }
}
