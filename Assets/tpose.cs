using UnityEngine;

public class YourClassName : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent agent;
    public Transform player;

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        agent.SetDestination(player.position);
    }
}
