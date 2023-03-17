using UnityEngine;

<<<<<<< HEAD
public class YourClassName : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent agent;
    public Transform player;
=======
public class tpose : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent agent;
    public Transform player;
    public bool isRunning = false;
>>>>>>> 3f559ab31c4b1ed5ed906a0e403fa98ac3dfe69d

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update()
    {
        agent.SetDestination(player.position);
<<<<<<< HEAD
    }
}
=======

         // Active l'animation de course si l'ennemi est en train de courir
        if (isRunning && agent.velocity.magnitude > 0.1f) {
            GetComponent<Animator>().SetTrigger("Run");
        }
    }
}
>>>>>>> 3f559ab31c4b1ed5ed906a0e403fa98ac3dfe69d
