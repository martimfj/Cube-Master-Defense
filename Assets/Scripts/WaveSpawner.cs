using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;
    public float timeBetweenWaves = 5f;
    public Text waveCounterText;
    private float countdown = 2f;
    private int waveIndex = 1;
    
    void Update()
    {
        if(!GameManager.gameEnded)
        {
            if(countdown <= 0f)
            {
                StartCoroutine(SpawnWave());
                countdown = timeBetweenWaves;
            }
            countdown -= Time.deltaTime;
        }
    }

    IEnumerator SpawnWave()
    {
        waveIndex++;
        waveCounterText.text = Mathf.Round(waveIndex).ToString();
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(Random.Range(0.5f, 1f));
        }
        yield return new WaitForSeconds(3f);
        
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }

}
