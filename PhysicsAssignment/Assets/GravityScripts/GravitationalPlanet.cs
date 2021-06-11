using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitationalPlanet : MonoBehaviour
{

    //variables
    public Rigidbody rb;
    // G being 6.674 * 10 ^-11 m^3 kg^-1 s^-2
    const float G = 6.67f;

    void FixedUpdate()
    {
        //create array of all planets in the scene
        GravitationalPlanet[] planets = FindObjectsOfType<GravitationalPlanet>();
        foreach (GravitationalPlanet planet in planets)
        {
            //attract planet except current planet
            if(planet != this)
            Attract(planet);
        }
    }

    void Attract(GravitationalPlanet planetToAttract)
    {
        //accessing planet to be attracted's Rigid body
        Rigidbody rbToAttract = planetToAttract.rb;

        //finding the distance between 2 planets
        Vector3 direction = rb.position - rbToAttract.position;
        float distance = direction.magnitude;

        //Applying Newton's law of gravitation, the universal gravitation equation being F= GMm/r^2
        float forceMagnitude = G* (rb.mass * rbToAttract.mass) / Mathf.Pow(distance,2);

        //apply force in the direction of planet
        Vector3 force = direction.normalized * forceMagnitude;
        rbToAttract.AddForce(force);
    }


}
