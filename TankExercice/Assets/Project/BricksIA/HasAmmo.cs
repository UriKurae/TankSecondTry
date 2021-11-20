using UnityEngine;

using Pada1.BBCore;
using Pada1.BBCore.Framework;

[Condition("MyConditions/Has Ammo?")]
[Help("Checks if the tank has ammo, false if no ammo")]
public class HasAmmo : ConditionBase
{
    [InParam("This Tank")]
    [Help("Reference to this tank")]
    public GameObject thisTank;

    public override bool Check()
    {
        Debug.Log("Has ammo");
        Moves moves = thisTank.GetComponent<Moves>();
        return (moves.ammo <= 0);
    }
}