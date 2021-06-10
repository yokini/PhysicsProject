using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityBody : MonoBehaviour
{
    public Rigidbody rb;
    public FauxGravityAttractor attractor;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        attractor.Attract(transform, rb);
    }
}
