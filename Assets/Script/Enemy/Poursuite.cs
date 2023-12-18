using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Poursuite : MonoBehaviour
{
    private Burn fire;

    public Transform Target;
    public float detecDistance;
    public float distance;

    public GameObject monster;

    public void Mouv()
    {

        NavMeshAgent agent = GetComponent<NavMeshAgent>();

        distance = Vector3.Distance(Target.position, agent.destination);

        if (distance < detecDistance)
        {
            agent.SetDestination(agent.destination);
            agent.destination = Target.position;

        }

        /*if(fire.burn == 1)
        {
            monster.SetActive(true);
        }*/
        if (fire.burn == 3)
        {
            agent.speed = 3;
        }
        else if (fire.burn == 4)
        {
            agent.speed = 5;
        }
    }
}
