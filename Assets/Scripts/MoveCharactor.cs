using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    private float speed = 0.01f;

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;

        // 左右の移動
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            position.x -= speed;
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            position.x += speed;
        }

        // 上下の移動
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            position.y += speed;
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            position.y -= speed;
        }

        transform.position = position;
    }
}
