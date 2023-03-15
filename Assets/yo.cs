using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDetection : MonoBehaviour
{
    public string playerTag = "Player";
    public int zonesRequired = 3;
    private int zonesEntered = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(playerTag))
        {
            // Le joueur est entré dans une zone de détection
            zonesEntered++;

            if (zonesEntered >= zonesRequired)
            {
                // Le joueur a entré dans toutes les zones nécessaires pour ouvrir la porte
                Debug.Log("All detection zones entered. Door unlocked!");
                // Code pour ouvrir la porte ici
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(playerTag))
        {
            // Le joueur est sorti d'une zone de détection
            zonesEntered--;
        }
    }
}