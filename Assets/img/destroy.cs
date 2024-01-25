using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // 衝突したオブジェクトがプレイヤーであるかどうかをタグで判定
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            // ここにスコアを増加させたり、他の処理を追加することができます
        }
    }
}
