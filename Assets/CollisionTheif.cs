using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionTheif : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D Collision)
    {
        if(Collision.gameObject.CompareTag("owner"))
        {
            transform.Rotate(0f,180f,0f);
            SceneManager.LoadScene("GameOver");
        }
    }
}
