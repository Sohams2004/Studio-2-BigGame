using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Boids/Behavior/NewSeperate")]
public class SeperateBehavior : BoidsBehavior
{

    public override Vector3 calculateBehaviour(Entity entity, List<Transform> info, BoidsManager boidsManager)
    {

        if (info.Count == 0)
        {
            return Vector3.forward;
        }
        int avoidOthers=0;
        Vector3 seperateMove = Vector3.zero;
        foreach (Transform detectedEntity in info)
        {
            if (Vector3.SqrMagnitude(detectedEntity.position - entity.transform.position)< boidsManager.SquareAvoidanceRadius)
            {
                avoidOthers++;
                seperateMove += (entity.transform.position - detectedEntity.position);

            }
            seperateMove += detectedEntity.forward;

        }


        //average all Close entity position
        seperateMove /= avoidOthers;


        return seperateMove;





    }
}
