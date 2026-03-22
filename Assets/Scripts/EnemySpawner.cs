using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour
{
    public List<Wave> waves;
    public GameObject redEnemyPrefab, yellowEnemyPrefab, blueEnemyPrefab;
    public float spawnInterval = 1f;
    public Button startWaveButton;
    private int currentWaveIndex = 0;

    public void StartWave()
    {
        if (currentWaveIndex < waves.Count)
        {
            Wave wave = waves[currentWaveIndex];
            StartCoroutine(SpawnWave(wave));
            currentWaveIndex++;
        }
    }

    IEnumerator SpawnWave(Wave wave)
    {
        for (int i = 0; i < wave.redCount; i++)
        {
            Instantiate(redEnemyPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);
        }
        for (int i = 0; i < wave.yellowCount; i++)
        {
            Instantiate(yellowEnemyPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);
        }
        for (int i = 0; i < wave.blueCount; i++)
        {
            Instantiate(blueEnemyPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
