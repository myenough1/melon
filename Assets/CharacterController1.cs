using UnityEngine;

public class CharacterController1 : MonoBehaviour
{
    private int score = 0; // スコアを格納する変数

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item")) // アイテムのタグを適切に設定してください
        {
            // アイテムを回収
            Destroy(other.gameObject); // アイテムを削除または非表示にするなど

            // スコアを加算
            score += 10;
            Debug.Log("スコア: " + score); // スコアを表示するなどの処理を追加できます
        }
    }
}