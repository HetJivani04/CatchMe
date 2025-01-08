using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheifMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        Move();
    }

    void Move()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {

            float horizontalInput = 1f; 
            transform.Translate(Vector3.right * horizontalInput * moveSpeed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {

            float horizontalInput = 1f; 
            transform.Translate(Vector3.left * horizontalInput * moveSpeed * Time.deltaTime);
        }
    }
}