using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class EnemyAStarBehavior : MonoBehaviour
{
    public Transform target;
    public float speed = 200f;
    public float chaseDistance = 5f;
    Rigidbody2D rb;
    public float nextWaypointDistance = 3f;
    Path path;
    int currentWaypoint = 0;
    bool reachedEndOfPath = false;
    Seeker seeker;
    AIPath pathFinder;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        seeker = GetComponent<Seeker>();
        InvokeRepeating("UpdatePath", 0, 0.5f);
        pathFinder = GetComponent<AIPath>();
    }

    void UpdatePath()
    {
        if (seeker.IsDone())
        {
            
            seeker.StartPath(rb.position, target.position, OnPathComplete);
            
        }
    }
    void OnPathComplete(Path p)
    {
        if (!p.error)
        {
            path = p;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (path == null)
        {
            return;
        }

        if (path.GetTotalLength() < chaseDistance)
        {
            pathFinder.maxSpeed = speed;
        }
        else
        {
            pathFinder.maxSpeed = 0;
        }
    }
    
}
