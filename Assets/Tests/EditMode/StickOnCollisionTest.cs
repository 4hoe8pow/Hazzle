using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class StickOnCollisionTest
{
    StickOnCollision test = new StickOnCollision();
    // A Test behaves as an ordinary method
    [Test]
    public void ConvertToLessThan120_Input0_Returns0()
    {
        float result = test.ConvertToLessThan120(0f);
        Assert.AreEqual(0f, result);
    }

    [Test]
    public void ConvertToLessThan120_Input60_Returns60()
    {
        float result = test.ConvertToLessThan120(Mathf.PI / 3f); // 60 degrees in radians
        Assert.AreEqual(60f, result);
    }

    [Test]
    public void ConvertToLessThan120_Input180_Returns60()
    {
        float result = test.ConvertToLessThan120(Mathf.PI); // 180 degrees in radians
        Assert.AreEqual(60f, result);
    }

    [Test]
    public void ConvertToLessThan120_Input121_Returns1()
    {
        float result = test.ConvertToLessThan120(2.11474253f); // Approximately 121 degrees in radians
        Assert.AreEqual(1f, result);
    }

    [Test]
    public void ConvertToLessThan120_Input360_Returns0()
    {
        float result = test.ConvertToLessThan120(2 * Mathf.PI); // 360 degrees in radians
        Assert.AreEqual(0f, result);
    }
}
