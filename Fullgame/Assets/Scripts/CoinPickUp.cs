using UnityEngine;

public class CoinPickUp : MonoBehaviour
{
    public GameObject PickUpSound; 
    public GameObject PickUpEffect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) {
            Instantiate(PickUpSound, transform.position, Quaternion.identity);
            Instantiate(PickUpEffect, transform.position, Quaternion.identity);
            PlayerController.Score++;
            Destroy(gameObject); 
        }
    }

}
