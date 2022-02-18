using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyVelocity : MonoBehaviour
{
    public NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    // Update is called once per frame
    void Update()
    {
        if (ScoreManager.Instance.plus)
        {
            Debug.Log("Llego a 10");
                    agent.speed += 0.007f;
                }
   
        }
    }

