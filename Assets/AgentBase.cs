using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentBase : MonoBehaviour
{
    private NavMeshAgent _agent;
    [SerializeField] private GameObject _cible;
    void Start()
    {
        
    }

    
    void Update()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.SetDestination(_cible.transform.position);
    }
}
