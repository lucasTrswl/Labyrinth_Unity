using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tpose : MonoBehaviour
{
    public GameObject target;

    void Start()
    {
        
    }

    void Update()
    {
        transform.LookAt(target.transform.position);
        transform.position += transform.forward * Time.deltaTime * 5.0f;
    }
}
