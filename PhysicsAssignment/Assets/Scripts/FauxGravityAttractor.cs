using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityAttractor : MonoBehaviour
{

    //declaring variables
    public float gravity = -9.8f;
    public void Attract(Transform body, Rigidbody Rb)
    {
        //position of player from the center of the planet
        Vector3 gravityUp = (body.position - transform.position).normalized;
        //direction that the body is facing
        Vector3 bodyUp = body.up;
        //Always pulling body towards the center of the planet (negative force)
        Rb.AddForce(gravityUp * gravity);
        // body rotate accordingly
        Quaternion targetRotation = Quaternion.FromToRotation(bodyUp, gravityUp) * body.rotation;
        //smooth rotation at a certain speed
        body.rotation = Quaternion.Slerp(body.rotation, targetRotation, 50 * Time.deltaTime);
      
    }
}
