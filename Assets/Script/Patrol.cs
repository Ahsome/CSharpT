using UnityEngine;
using System.Collections;

public class Patrol : MonoBehaviour
    {
    public Transform[] patrolPoints;

    private int currentPoint;

    void Start()
        {
        transform.position = patrolPoints[0].position;
        currentPoint = 0;
        }

    void Update()
        {
        if (transform.position == patrolPoints[currentPoint].position)
            {
            currentPoint++;
            }
        }
    }
