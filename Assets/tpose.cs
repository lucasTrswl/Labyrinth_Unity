using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tpose : MonoBehaviour
{
    public Transform target;
    public Transform player1;
    public Transform player2;
    public float moveSpeed = 5f;
    public float rotationSpeed = 5f;

    void Update()
    {
        // Calculer la direction du player2 vers le player1
        Vector3 direction = target.position - player2.position;
        direction.y = 0;

        // Faire tourner le player2 vers le player1
        Quaternion rotation = Quaternion.LookRotation(direction);
        player2.rotation = Quaternion.Slerp(player2.rotation, rotation, rotationSpeed * Time.deltaTime);

        // Faire avancer le player2 vers le player1
        player2.Translate(0, 0, moveSpeed * Time.deltaTime);

        // Vérifier si le player2 a rattrapé le player1
        if (Vector3.Distance(player1.position, player2.position) <= 1f)
        {
            Debug.Log("Player 2 a attrapé Player 1 !");
        }

        // Faire tourner le player1
        float horizontalInput = Input.GetAxis("Horizontal");
        player1.Rotate(0, horizontalInput * rotationSpeed * Time.deltaTime, 0);
    }
}