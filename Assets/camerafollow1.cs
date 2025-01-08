using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform player1; 
    public Transform player2; 
    public float smoothSpeed = 0.125f;  

    void LateUpdate()
    {
        if (player1 != null && player2 != null)
        {
            
            Vector3 centerPosition = (player1.position + player2.position) / 2f;

            
            Vector3 desiredPosition = new Vector3(centerPosition.x, transform.position.y, transform.position.z);

            
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

            
            transform.position = smoothedPosition;
        }
    }
}
