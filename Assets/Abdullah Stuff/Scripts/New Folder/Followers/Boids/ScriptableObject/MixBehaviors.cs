using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Boids/Behavior Mixture/NewMixture")]
public class MixBehaviors : BoidsBehavior
{
    [Header("list all Behaviors ")]
    public BoidsBehavior[] boidsBehaviors;
    public float[] weights;

    public override Vector3 calculateBehaviour(Entity entity, List<Transform> info, BoidsManager boidsManager)
    {
        if (weights.Length != boidsBehaviors.Length)
        {
            Debug.LogError("Weight & BoidsBehaviros needs to be the same length"+ name, this);
            return Vector3.zero;
        }
        Vector3 move = Vector3.zero;


        //Check the weight of each behaviour and check it did not exeed the weigh limit. 
        for (int i = 0; boidsBehaviors.Length> i; i++ )
        {
            Vector3 mixedMovement = boidsBehaviors[i].calculateBehaviour(entity, info, boidsManager) * weights[i];
            if (mixedMovement != Vector3.zero)
            {
                if (mixedMovement.sqrMagnitude > weights[i] * weights[i])
                {
                    mixedMovement.Normalize();
                    mixedMovement *= weights[i];

                }
                move += mixedMovement;
            }
        }
            return move;
    }


}