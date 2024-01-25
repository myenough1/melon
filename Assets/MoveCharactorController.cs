using UnityEngine;

public class MoveCharactorController : MonoBehaviour
{
    public float speed = 5.0f; // プレイヤーの移動速度
    public float jumpForce = 700f; // ジャンプの力
    private Rigidbody2D rb;
    private bool isGrounded; // 地面に接触しているかどうか

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 水平方向の入力
        float moveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveX * speed, rb.velocity.y);

        // ジャンプの処理
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
            isGrounded = false;
        }
    }

    // 地面との接触判定
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
}