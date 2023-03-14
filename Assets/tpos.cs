using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tpos : MonoBehaviour
{
    public GameObject tar, ;, ; , ,get; // référence au personnage à suivre

    void Start()
    {
        
    }

    void Update()
    {
        // Faites en sorte que l'objet regarde vers la cible
        transform.LookAt(target.transform.position);

        // Déplacez l'objet dans la direction de la cible
        transform.position += transform.forward * Time.deltaTime * 5.0f;
    }
}
