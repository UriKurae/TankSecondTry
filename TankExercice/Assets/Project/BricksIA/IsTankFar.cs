using UnityEngine;

using Pada1.BBCore;
using Pada1.BBCore.Framework;

[Condition("MyConditions/Is Tank far?")]
[Help("Checks if the enemy tank is far, true if it's far")]
public class IsTankFar : ConditionBase
{
    [InParam("This Tank")]
    [Help("Reference to this tank")]
    public GameObject thisTank;

    [InParam("Enemy Tank")]
    [Help("Reference to Enemy tank")]
    public GameObject EnemyTank;
    public override bool Check()
    {
        Debug.Log("Tank far");
        return Vector3.Distance(thisTank.transform.position, EnemyTank.transform.position) > 10.0f;
    }
}