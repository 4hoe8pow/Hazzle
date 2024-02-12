using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class EdgeTouchingTest
{
    StickOnCollision test = new StickOnCollision();
    // A Test behaves as an ordinary method
    [Test]
    public void TestEdgesTouching()
    {
        // テスト用のGameObjectを作成
        GameObject gameObject = new GameObject();

        // テスト用のTransformを取得
        Transform myTransform = gameObject.transform;

        // 自分自身の角度を設定
        myTransform.eulerAngles = new Vector3(0f, 0f, 120f); // 120度

        // テスト用の別のGameObjectを作成
        GameObject otherGameObject = new GameObject();

        // テスト用の別のTransformを取得
        Transform otherTransform = otherGameObject.transform;

        // 別のオブジェクトの角度を設定
        otherTransform.eulerAngles = new Vector3(0f, 0f, 240f); // 240度

        // AreEdgesTouching 関数を呼び出して結果を取得
        bool result = test.AreEdgesTouching(otherTransform.eulerAngles.z, myTransform.eulerAngles.z);

        // 期待される結果は true であるべき
        Assert.IsTrue(result);
    }
}
