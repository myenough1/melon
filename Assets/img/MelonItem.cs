using UnityEngine;

public class MelonItem : MonoBehaviour
{
    public int pointValue = 10; // メロン1つあたりのポイント

    private void OnTriggerEnter(Collider other)
    {
        // 衝突したオブジェクトがプレイヤーであるかを確認
        if (other.CompareTag("Player"))
        {
            // ゲームマネージャーにポイントを追加
            GameManager.Instance.AddPoints(pointValue);

            // メロンを破棄（回収された）
            Destroy(gameObject);
        }
    }
}