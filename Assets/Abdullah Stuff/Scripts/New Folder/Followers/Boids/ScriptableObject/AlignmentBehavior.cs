using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Boids/Behavior/NewAlignment")]
public class AlignmentBehavior : BoidsBehavior
{
    public override Vector3 calculateBehaviour(Entity entity, List<Transform> info, BoidsManager boidsManager)
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

        return alignmentMove;




    }
}