using UnityEngine;
using Pada1.BBCore;           // Code attributes
using Pada1.BBCore.Tasks;     // TaskStatus
using Pada1.BBCore.Framework; // BasePrimitiveAction

[Action("MyActions/Shoot")]
[Help("Get the tank Shooting")]
public class Shoot : BasePrimitiveAction
{
    [InParam("This Tank")]
    [Help("Reference to this tank")]
    public GameObject thisTank;

    public override TaskStatus OnUpdate()
    {
        Moves moves = thisTank.GetComponent<Moves>();
        moves.Shoot();
        return TaskStatus.COMPLETED;
    }
}