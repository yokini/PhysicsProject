using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    //variables
    public Rigidbody rb;
    public float movespeed;
    private Vector3 moveDir;

    
    void Start()
    {
        // initialization
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //inputs for movement
        moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
    }

    private void FixedUpdate()
    {
        //movement usinf Rigidbody.MovePosition
        rb.MovePosition(rb.position + transform.TransformDirection(moveDir) * movespeed * Time.deltaTime);

       
    }
}
