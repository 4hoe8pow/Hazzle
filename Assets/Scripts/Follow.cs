using UnityEngine;

public class DiagonalMovement : MonoBehaviour
{
    public float speed = 10f; // 移動速度

    private Rigidbody2D rb;

    void Start()
    {
        // Rigidbody コンポーネントを取得
        rb = GetComponent<Rigidbody2D>();

        // オブジェクトに初速度を与える
        rb.velocity = new Vector2(-1, -1).normalized * speed;
    }
}
