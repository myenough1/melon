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
        // �Փ˂����I�u�W�F�N�g���v���C���[�ł��邩�ǂ������^�O�Ŕ���
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            // �����ɃX�R�A�𑝉���������A���̏�����ǉ����邱�Ƃ��ł��܂�
        }
    }
}
