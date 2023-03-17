using UnityEngine;

public class Dinteract : MonoBehaviour
{
    public int keysNeeded = 3; // nombre de clés nécessaires pour ouvrir la porte
    private int keysCollected = 0; // nombre de clés collectées par le joueur
    public GameObject door; // la porte à ouvrir
    public float distanceToInteract = 2f; // distance maximale à laquelle le joueur peut interagir avec un objet

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TryToCollectKey();
        }
    }

    private void TryToCollectKey()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, distanceToInteract))
        {
            if (hit.collider.CompareTag("C moi"))
            {
                CollectKey(hit.collider.gameObject);
            }
        }
    }

    private void CollectKey(GameObject key)
    {
        keysCollected++;
        Destroy(key); // détruit la clé collectée
        Debug.Log("Clé collectée !");
        if (keysCollected >= keysNeeded)
        {
            OpenDoor();
        }
    }

    private void OpenDoor()
    {
        door.SetActive(false); // désactive la porte pour la faire disparaître
        Debug.Log("Porte ouverte !");
    }
}
