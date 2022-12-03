using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpControl : MonoBehaviour
{
    public bool isGrounded;

    void OnCollisionEnter()
    {
        isGrounded = true;
    }


    void Update() 
    {
      
       if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
       {
        isGrounded = false;
        GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
       }
           

    }


    