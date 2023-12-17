using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Boids/Behavior/NewCohesion")]

public class CohesionBehavior : BoidsBehavior
{
    public override Vector3 calculateBehaviour(Entity entity, List<Transform> info, BoidsManager boidsManager, Transform followTarget, Transform[] AvoidTarget)
    {

        //case nothing around us
        if (info.Count == 0) return Vector3.zero;
        //case other Entity are around us
        Vector3 cohesionMove = Vector3.zero;
        foreach(Transform detectedEntity in info)
        {
            cohesionMove += detectedEntity.position;
        }
        //average all the position
        cohesionMove /= info.Count;

        // direction of movement from the indivsual boid
        cohesionMove -= entity.transform.position;

        cohesionMove.y= 0;
        return cohesionMove;



    }



}
