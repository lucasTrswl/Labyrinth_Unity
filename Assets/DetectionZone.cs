using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionZone : MonoBehaviour
{
    public string playerTag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(playerTag))
        {
            // Le joueur est entré dans la zone de détection
            Debug.Log("Player entered detection zone.");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(playerTag))
        {
            // Le joueur est sorti de la zone de détection
            Debug.Log("Player exited detection zone.");
        }
    }
}