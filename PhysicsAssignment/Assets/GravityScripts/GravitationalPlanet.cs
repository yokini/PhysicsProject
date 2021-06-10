using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitationalPlanet : MonoBehaviour
{
    public Rigidbody rb;


    // Update is called once per frame
    void FixedUpdate()
    {
        GravitationalPlanet[] planets = FindObjectsOfType<GravitationalPlanet>();
        foreach (GravitationalPlanet planet in planets)
        {
            if(planet != this)
            Attract(planet);
        }
    }

    void Attract(GravitationalPlanet planetToAttract)
    {
        Rigidbody rbToAttract = planetToAttract.rb;

        Vector3 direction = rb.position - rbToAttract.position;
        float distance = direction.magnitude;

        float forceMagnitude = (rb.mass * rbToAttract.mass) / Mathf.Pow(distance,2);
        Vector3 force = direction.normalized * forceMagnitude;

        rbToAttract.AddForce(force);
    }


}
