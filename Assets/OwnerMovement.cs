using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwnerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        Move();
    }

    void Move()
    {
       
        if (Input.GetKey(KeyCode.D))
        {
            
            float horizontalInput = 1f; 
            transform.Translate(Vector3.right * horizontalInput * moveSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            
            float horizontalInput = 1f; // Set to 1 for right movement
            transform.Translate(Vector3.left * horizontalInput * moveSpeed * Time.deltaTime);
        }
    }
}