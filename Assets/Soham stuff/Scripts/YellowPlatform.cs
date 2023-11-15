using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowPlatform : MonoBehaviour
{
    [SerializeField] private int startPoint;
    [SerializeField] private int pointIndex;

    [SerializeField] private float platformSpeed;

    [SerializeField] private Transform[] points;

    private void Update()
    {
        MovePlatform();
    }

    void MovePlatform()
    {
        transform.position = Vector2.MoveTowards(transform.position, points[pointIndex].position, platformSpeed * Time.deltaTime);

        if (Vector2.Distance(transform.position, points[pointIndex].position) < 0.01f)
        {
            pointIndex++;

            if (pointIndex == points.Length)
            {
                pointIndex = 0;
            }
        }
    }
}
