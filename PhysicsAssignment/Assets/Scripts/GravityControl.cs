using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityControl : MonoBehaviour
{
   
    //reference Gravity from GravityOrbit script
    public GravityOrbit Gravity;

    //variables
    private Rigidbody Rb;
   
    void Start()
    {
        //initialization
        Rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(Gravity)
        {
            //position of player from the center of the planet
            Vector3 gravityUp = Vector3.zero;
            gravityUp = (transform.position - Gravity.transform.position).normalized;

            //direction that the body is facing
            Vector3 localUp = transform.up;

            // body rotate accordingly
            Quaternion targetRotation = Quaternion.FromToRotation(localUp, gravityUp) * transform.rotation;

            //smooth rotation at a certain speed
            transform.up = Vector3.Lerp(transform.up, gravityUp, 50 * Time.deltaTime);

            //Always pulling body towards the center of the planet (negative force)
            Rb.AddForce((-gravityUp * Gravity.Gravity) * Rb.mass);

        }
    }
}
