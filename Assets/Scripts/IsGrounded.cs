using UnityEngine;

public class IsGrounded : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(!(other.gameObject.CompareTag("background"))) PlayerController.OnGround = true;     
    }
}
