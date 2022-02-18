using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject player;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        agent.SetDestination(player.transform.position);
        //agent.speed = SpinManager.Instance.speedSpin;
    }
}