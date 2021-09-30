using UnityEngine;
using UnityEngine.AI;

public class ZombieMoveController : MonoBehaviour
{
    Animator animator;
    [SerializeField] private GameObject player;
    NavMeshAgent nav;
    private float distanceToPlayer;

    void Start()
    {
        animator = GetComponent<Animator>();
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        distanceToPlayer = Vector3.Distance(gameObject.transform.position, player.transform.position);
        if(distanceToPlayer < 50)
        {
            animator.SetBool("run", true);
            nav.SetDestination(player.transform.position);
        }
    }
}
