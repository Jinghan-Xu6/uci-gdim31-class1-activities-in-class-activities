using UnityEngine;
using UnityEngine.AI;

public class DeerW5 : MonoBehaviour
{
    [SerializeField] private bool _flipWSControls;
    [SerializeField] private Transform target;
    private NavMeshAgent _agent;

    private void Start(){
        _agent = GetComponent<NavMeshAgent>();
        _agent.SetDestination(target.position);
    }


}

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...