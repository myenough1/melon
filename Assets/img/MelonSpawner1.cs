using UnityEngine;

public class MelonSpawner1 : MonoBehaviour
{
    public GameObject melonPrefab; // メロンのプレハブをインスペクターからアサインします。
    public Transform spawnPoint; // スポーンポイントをインスペクターからアサインします。

    public float minSpawnInterval = 1.0f; // メロン生成の最小間隔（秒）
    public float maxSpawnInterval = 3.0f; // メロン生成の最大間隔（秒）

    private float nextSpawnTime;

    private void Start()
    {
        // 最初のメロンを生成するための時間を設定
        nextSpawnTime = Time.time + Random.Range(minSpawnInterval, maxSpawnInterval);
    }

    private void Update()
    {
        // 現在の時間が次のメロンを生成する時間になったら生成する
        if (Time.time >= nextSpawnTime)
        {
            SpawnMelon();
            // 次のメロンを生成するための時間を再設定
            nextSpawnTime = Time.time + Random.Range(minSpawnInterval, maxSpawnInterval);
        }
    }

    private void SpawnMelon()
    {
        // スポーンポイントの位置にメロンを生成
        Instantiate(melonPrefab, spawnPoint.position, Quaternion.identity);
    }
}