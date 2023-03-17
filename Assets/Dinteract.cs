using UnityEngine;

public class Dinteract : MonoBehaviour
{
    public int keysNeeded = 3; // nombre de clés nécessaires pour ouvrir la porte
    private int keysCollected = 0; // nombre de clés collectées par le joueur
    public GameObject door; // la porte à ouvrir


    public void CollectKey()
    {
        keysCollected++;
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
