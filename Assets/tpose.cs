using UnityEngine;

public class tpose : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent agent;
    public Transform player;
    public bool isRunning = false;

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        agent.SetDestination(player.position);

         // Active l'animation de course si l'ennemi est en train de courir
        if (isRunning && agent.velocity.magnitude > 0.1f) {
            GetComponent<Animator>().SetTrigger("Run");
        }
    }
}