using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickOnCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // 三角形の回転
            Quaternion otherRotation = collision.gameObject.transform.rotation;
            Quaternion myRotation = transform.rotation;

            Debug.Log("other : " + ConvertToLessThan120(otherRotation.z));
            Debug.Log("me : " + ConvertToLessThan120(myRotation.z));

            // 位置を調整してオブジェクトをくっつける
            Vector3 newPosition = transform.position;
            transform.position = newPosition;
        }
    }

    public float ConvertToLessThan120(float radian)
    {
        float angle = Mathf.Rad2Deg * radian; // ラジアンを角度に変換
        float remainder = angle % 120f;
        return remainder >= 0f ? remainder : 120f + remainder;
    }

}
