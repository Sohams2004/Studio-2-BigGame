using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

[CreateAssetMenu(menuName = "Boids/Behavior/NewFollowTarget")]
public class FollowBehavior : BoidsBehavior
{
    public bool avoidMe;
    public float avoidDistance;

    public override Vector3 calculateBehaviour(Entity entity, List<Transform> info, BoidsManager boidsManager, Transform followTarget, Transform[] AvoidTarget)
    {
        Vector3 movementDirection = Vector3.zero;



        if (avoidMe == true)
        {

            foreach (Transform avoid in AvoidTarget)
            {

                var distance = (entity.transform.position - avoid.position);
                if (distance.magnitude < avoidDistance)
                {
                    movementDirection += (entity.transform.position - avoid.position);
                }
            }
            movementDirection /= AvoidTarget.Length;
            movementDirection.Normalize();
            movementDirection.y = 0f;
            return movementDirection;

        }


        movementDirection = followTarget.position - entity.transform.position;
        movementDirection.Normalize();
        movementDirection.y = 0f;
        return movementDirection;


    }


}


