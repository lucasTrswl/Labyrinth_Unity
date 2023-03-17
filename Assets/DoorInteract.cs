using UnityEngine;

public class DoorController : MonoBehaviour
{
    public int keysNeeded = 3; // nombre de clés nécessaires pour ouvrir la porte
    private int keysCollected = 0; // nombre de clés collectées par le joueur
    public GameObject door; // la porte à ouvrir

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            keysCollected++;
            Destroy(other.gameObject); // détruit la clé collectée
            Debug.Log("Clé collectée !");
            if (keysCollected >= keysNeeded)
            {
                OpenDoor();
            }
        }
    }

    private void OpenDoor()
    {
        door.SetActive(false); // désactive la porte pour la faire disparaître
        Debug.Log("Porte ouverte !");
    }
}
