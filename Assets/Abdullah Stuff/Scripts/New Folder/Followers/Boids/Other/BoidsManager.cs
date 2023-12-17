using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BoidsManager : MonoBehaviour
{
    public Transform followTarget;
    public Transform[] avoidTarget;
    public Entity[] entityPrefab;
    
    List<Entity> entities = new List<Entity>();
    public BoidsBehavior behavior;
    [Range(1f, 100f)]
    public int startingCount = 100;
    [Range(10f, 500f)]
    public int spawnCircle= 250;

    const float AgentDensity = 0.08f;

    [Range(1f, 100f)]
    public float driveFactor = 10f;
    [Range(1f, 100f)]
    public float maxSpeed = 5f;
    [Range(1f, 10f)]
    public float sensorRadius = 1.5f;
    [Range(0f, 3f)]
    public float avoidanceRadiusMultiplier = 0.5f;

    Color myColor;
    //math Utility variabless 
    float squareMaxSpeed;
    float squaresensorRadius;
    float squareAvoidanceRadius;
    public float SquareAvoidanceRadius
    {
        get
        {
            return squareAvoidanceRadius;
        }
    }


    //list all Boids 
    private void Start()
    {
        squareMaxSpeed = maxSpeed * maxSpeed;
        squaresensorRadius = sensorRadius * sensorRadius;
        squareAvoidanceRadius = squaresensorRadius * avoidanceRadiusMultiplier * avoidanceRadiusMultiplier;

        for (int i = 0; i < startingCount;i=i)
        {
            Debug.Log("Enter1");
            foreach (Entity entity in entityPrefab)
            {

                if (i >= startingCount)
                {
                    break;
                }

                Vector3 vector = Random.insideUnitSphere * spawnCircle * AgentDensity;
                vector += gameObject.transform.position;
                vector.y = 0;
                Entity newEntity = Instantiate(entity, vector,Quaternion.Euler(Vector3.up * Random.Range(0f, 360f)), transform);
                newEntity.name = "Entity " + i;
                entities.Add(newEntity);
                ++i;
            }
        }
    }

    //Apply Calculation to each Boids
    private void Update()
    {
        foreach (Entity entity in entities)
        {
            List<Transform> Newinfo = GetNearbyObjects(entity);
            Vector3 move = behavior.calculateBehaviour(entity, Newinfo, this,followTarget,avoidTarget);
            move *= driveFactor;
            if (move.sqrMagnitude > squareMaxSpeed)
            {
                move = move.normalized * maxSpeed;

            }
            entity.Move(move);
        }
    }
    //list all detected boids for each 
    List<Transform> GetNearbyObjects(Entity entity)
    {
        List<Transform> info = new List<Transform>();
        Collider[] contextColliders = Physics.OverlapSphere(entity.transform.position, sensorRadius, ~4);
        foreach (Collider c in contextColliders)
        {
            if (c != entity.EntityCollider)
            {
                info.Add(c.transform);
            }

        }

        return info;
    }





}