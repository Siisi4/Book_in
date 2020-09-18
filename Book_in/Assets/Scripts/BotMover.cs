using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class BotMover : MonoBehaviour
{
    public Transform BotDirections;

    void Start()
    {
        //NavMeshAgent agent = GetComponent<NavMeshAgent>();
        //agent.destination = BotDirections.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            NavMeshAgent agent = GetComponent<NavMeshAgent>();
            agent.destination = BotDirections.position; 
        }
    }
}
