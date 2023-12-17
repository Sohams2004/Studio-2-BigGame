using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public abstract class BoidsBehavior : ScriptableObject
{
    //                                   indvisual boid,     other boids + enviroment,       Flock as a group
    public abstract Vector3 calculateBehaviour(Entity entity, List<Transform> info, BoidsManager boidsManager,Transform followTarget, Transform[]AvoidTarget );


}
