using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vanish : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))//各自タグに付けた名前を()の中に入れてください
        {
            // Playerに触れた場合の処理
            // 例: アイテムを消す
            Destroy(gameObject);
        }
    }
}