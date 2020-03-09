using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshUpdate : MonoBehaviour
{
    private NavMeshAgent _nav;
    void Start()
    {
        _nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        _nav.SetDestination(GameObject.FindGameObjectWithTag("Player").transform.position);
    }
}
