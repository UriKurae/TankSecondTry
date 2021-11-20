using UnityEngine;
using Pada1.BBCore;           // Code attributes
using Pada1.BBCore.Tasks;     // TaskStatus
using Pada1.BBCore.Framework; // BasePrimitiveAction

[Action("MyActions/Wander")]
[Help("Get the tank roaming")]
public class Wander : BasePrimitiveAction
{
    [InParam("This Tank")]
    [Help("Reference to this tank")]
    public GameObject thisTank;

    public override TaskStatus OnUpdate()
    {
        Moves moves = thisTank.GetComponent<Moves>();
        moves.Wander();
        return TaskStatus.COMPLETED;
    }
}