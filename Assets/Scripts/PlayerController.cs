﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  private float turnSpeed = 80; 
  private float speed = 9.0f; 
  private float horizontalInput; 
  private float verticalInput; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      horizontalInput = Input.GetAxis("Horizontal");
      verticalInput = Input.GetAxis("Vertical");
       // Move the vehicle forward
     transform.Translate(Vector3.forward* Time.deltaTime * speed * verticalInput);
     transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
