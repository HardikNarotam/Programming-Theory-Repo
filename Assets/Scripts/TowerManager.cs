using UnityEngine;
using UnityEngine.EventSystems;

public class TowerManager : MonoBehaviour
{
    private Tower currentTower;
    public float maxX;

    void Update()
    {
        if (currentTower != null && !currentTower.isPlaced)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = -Camera.main.transform.position.z;
            currentTower.transform.position = Camera.main.ScreenToWorldPoint(mousePos);
        }

        if (Input.GetMouseButtonDown(0)
        && currentTower != null
        && !currentTower.isPlaced
        && EventSystem.current.IsPointerOverGameObject() == false
        && currentTower.transform.position.x < maxX
        && Physics2D.OverlapPoint(currentTower.transform.position, LayerMask.GetMask("Path")) == null)
        {
            currentTower.isPlaced = true;
            currentTower = null;
        }
    }

    public void SelectTower(GameObject towerPrefab)
    {
        if (currentTower == null)
        {
            GameObject towerObj = Instantiate(towerPrefab);
            currentTower = towerObj.GetComponent<Tower>();
        }
    }
}
