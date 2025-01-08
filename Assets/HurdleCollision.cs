using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HurdleCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D Collision)
    {
        if(Collision.gameObject.CompareTag("owner"))
        {
            transform.Rotate(0f,180f,0f);
            SceneManager.LoadScene("GameOver");
        }
        else if(Collision.gameObject.CompareTag("theif"))
        {
            transform.Rotate(0f,180f,0f);
            SceneManager.LoadScene("GameOver");
        }
    }
}
