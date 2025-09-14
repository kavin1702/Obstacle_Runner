using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    
    private Material originalMaterial;

    void Start()
    {
        originalMaterial = GetComponent<MeshRenderer>().material;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            GameManager.Instance.HitCounter();

        }
    }
    private void OnCollisionExit(Collision other)
    {
        GetComponent<MeshRenderer>().material.color = Color.yellow;
    }
}
