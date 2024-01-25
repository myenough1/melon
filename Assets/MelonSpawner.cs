using UnityEngine;

public class MelonSpawner : MonoBehaviour
{
    public GameObject melonPrefab;
    public Vector2 spawnArea;

    void Start()
    {
        SpawnMelon();
    }

    void SpawnMelon()
    {
        Vector2 randomPosition = new Vector2(Random.Range(spawnArea.x, spawnArea.y), Random.Range(spawnArea.x, spawnArea.y));
        Instantiate(melonPrefab, randomPosition, Quaternion.identity);
    }
}