using UnityEngine;

public class EngelSpawner : MonoBehaviour
{
    [SerializeField] GameObject engelPrefab; 
    [SerializeField] float spawnInterval = 0.3f; // spawn süresi
    [SerializeField] float minY = -1f;  // rastgele y alt sınır
    [SerializeField] float maxY = 2f;   // rastgele y üst sınır

    void Start()
    {
        InvokeRepeating(nameof(SpawnEngel), 1f, spawnInterval);
    }

    void SpawnEngel()
    {
        float randomY = Random.Range(minY, maxY);

        Vector3 spawnPos = new Vector3(transform.position.x, randomY, 0);
        Instantiate(engelPrefab, spawnPos, Quaternion.identity);
    }
}
