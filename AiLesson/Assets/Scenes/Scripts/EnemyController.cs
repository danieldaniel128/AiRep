using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{

    public Transform TargetDestination;
    public NavMeshAgent navMeshAgent;


    void Start()
    {
        navMeshAgent.SetDestination(TargetDestination.transform.position); 
    }
}
