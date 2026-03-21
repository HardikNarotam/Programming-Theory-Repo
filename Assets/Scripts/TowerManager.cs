using UnityEngine;

public class TowerManager : MonoBehaviour
{
    public GameObject towerPrefab;
    private Tower currentTower;

    void Update()
    {
        if (currentTower != null && !currentTower.isPlaced)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = -Camera.main.transform.position.z;
            currentTower.transform.position = Camera.main.ScreenToWorldPoint(mousePos);
        }

        if (Input.GetMouseButtonDown(0) && currentTower != null && !currentTower.isPlaced)
        {
            currentTower.isPlaced = true;
            currentTower = null;
        }
    }

    public void SelectTower()
    {
        if (currentTower == null)
        {
            GameObject towerObj = Instantiate(towerPrefab);
            currentTower = towerObj.GetComponent<Tower>();
        }
    }
}
