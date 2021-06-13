using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityBody : MonoBehaviour
{
    //variables
    public Rigidbody rb;

    //Reference to the FauxGravityAttractor Script
    public FauxGravityAttractor attractor;

    void Start()
    {
        //initialization
        rb = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        //Have the body attracted to the planet, attract method from the FauxGravityAttractor Script
        attractor.Attract(transform, rb);
    }
}
