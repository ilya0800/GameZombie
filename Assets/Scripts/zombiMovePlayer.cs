using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class zombiMovePlayer : MonoBehaviour
{
    Animator animator;
    public GameObject Player;
    NavMeshAgent nav;
    public float distanceToPlayer;
    void Start()
    {
        animator = GetComponent<Animator>();
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        distanceToPlayer = Vector3.Distance(gameObject.transform.position, Player.transform.position);
        if(distanceToPlayer < 50)
        {
            animator.SetBool("run", true);
            nav.SetDestination(Player.transform.position);
        }
    }
}
