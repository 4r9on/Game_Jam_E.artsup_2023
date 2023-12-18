using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    Poursuite poursuite;

    private Burn fire;

    public Transform Target;
    public float detecDistance;
    public float distance;

    NavMeshAgent agent;
    public List<Transform> waypoints;
    int waypointIndex;
    Vector3 target;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, target) < 1)
        {
            IterateWaypointIndex();
            UpdateDestination();
        }
           
        Mouv();

    }

    void UpdateDestination()
    {
        target = waypoints[waypointIndex].position;
        agent.SetDestination(target);
    }

    void IterateWaypointIndex()
    {
        waypointIndex ++;

        if(waypointIndex == waypoints.Count)
        {
            waypointIndex = 0;
        }
    }

    public void Mouv()
    {

        distance = Vector3.Distance(Target.position, agent.destination);

        if (distance < detecDistance)
        {
            agent.SetDestination(agent.destination);
            agent.destination = Target.position;
        }
        

        /*if (fire.burn == 3)
        {
            agent.speed = 5;
        }
        else if (fire.burn == 4)
        {
            agent.speed = 7;
        }*/
    }
}