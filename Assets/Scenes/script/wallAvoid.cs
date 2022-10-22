using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class wallAvoid : MonoBehaviour
{

    private Transform target;
    private UnityEngine.AI.NavMeshAgent nav;

    void Start(){
        target = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
         nav.SetDestination(target.position);
    }

    
}
