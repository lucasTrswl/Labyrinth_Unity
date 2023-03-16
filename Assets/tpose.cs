public NavMeshAgent agent;
public Transform player;

void Start()
{
    agent = GetComponent<NavMeshAgent>();
    player = GameObject.FindGameObjectWithTag("Player").transform;
}

void Update()
{
    agent.SetDestination(player.position);
}