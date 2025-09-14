using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropper : MonoBehaviour
{
    Rigidbody rigidbody ;
    MeshRenderer renderer;
    [SerializeField] float timeToWait = 5f;
  
    void Start()
    {
       renderer = GetComponent<MeshRenderer>();
       rigidbody = GetComponent<Rigidbody>();


       renderer.enabled = false;
       rigidbody.useGravity  =false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
