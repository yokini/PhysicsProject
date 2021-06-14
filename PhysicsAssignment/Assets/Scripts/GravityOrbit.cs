using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityOrbit : MonoBehaviour
{
    //declaring variables
    public float Gravity;


    private void OnTriggerEnter(Collider other)
    {
        //detecting objects with the Gravity Control Script, i.e is player
        if(other.GetComponent<GravityControl>())
        {
            other.GetComponent<GravityControl>().Gravity = this.GetComponent<GravityOrbit>();
        }

    }
}
