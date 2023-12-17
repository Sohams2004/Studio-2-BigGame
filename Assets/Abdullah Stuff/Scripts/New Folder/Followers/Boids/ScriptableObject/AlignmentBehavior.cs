using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Boids/Behavior/NewAlignment")]
public class AlignmentBehavior : BoidsBehavior
{
    public override Vector3 calculateBehaviour(Entity entity, List<Transform> info, BoidsManager boidsManager, Transform followTarget, Transform[] AvoidTarget)
    {

        if (info.Count == 0)
        {
            return entity.transform.forward;
        }

        Vector3 alignmentMove=Vector3.forward;
        foreach (Transform detectedEntity in info)
        {

            alignmentMove += detectedEntity.forward;


        }
        //average all the position
        alignmentMove /= info.Count;
        alignmentMove.y= 0;
        return alignmentMove;




    }
}