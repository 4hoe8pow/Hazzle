using System;
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
            float angleTotal = otherRotation.z + myRotation.z;
            Debug.Log(angleTotal);

            if (AreEdgesTouching(otherRotation.z, myRotation.z)) { Debug.Log("YES"); }
            // 位置を調整してオブジェクトをくっつける
            Vector3 newPosition = transform.position;
            transform.position = newPosition;
        }
    }

    public bool AreEdgesTouching(float x, float y)
    {
        // ラジアンを角度に変換して、120 で割ったあまりを計算し、2つのあまりを足す
        float totalMod = (ToDegrees(x) % 120) + (ToDegrees(y) % 120);

        // 57以上63未満の範囲にあるかどうかをチェックして結果を返す
        return totalMod >= 57 && totalMod < 63;
    }

    static float ToDegrees(float radians)
    {
        // ラジアンを度に変換する関数
        return radians * (180.0f / (float)Math.PI);
    }

}
