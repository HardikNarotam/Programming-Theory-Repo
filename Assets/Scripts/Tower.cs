using UnityEngine;

public abstract class Tower : MonoBehaviour
{
    public float range;
    public float fireRate;
    public int damage;
    public float projectileSpeed;
    public bool isPlaced = false;

    // Encapsulation
    protected float cooldown;
    protected Prim target;
    [SerializeField] protected GameObject projectilePrefab;

    protected abstract void Awake();

    protected virtual void Update()
    {
        cooldown -= Time.deltaTime;
        Collider2D[] targets = Physics2D.OverlapCircleAll(transform.position, range);

        foreach (Collider2D col in targets)
        {
            Prim prim = col.GetComponent<Prim>();
            if (prim != null)
            {
                target = prim;
                break;
            }
        }

        if (cooldown <= 0 && target != null)
        {
            Shoot();
            cooldown = 1f / fireRate;
        }
    }

    protected abstract void Shoot();

    private void OnMouseDown()
    {

    }

    private void OnMouseDrag()
    {
        if (isPlaced) return;
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = -Camera.main.transform.position.z;
        transform.position = Camera.main.ScreenToWorldPoint(mousePos);
    }

    private void OnMouseUp()
    {
        isPlaced = true;
    }
}
