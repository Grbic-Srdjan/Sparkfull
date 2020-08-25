using UnityEngine;

public class LevelingUp : MonoBehaviour
{

    public GameObject PickUpLevelSound, PickUpLevelEffect;  

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(PickUpLevelSound, transform.position, Quaternion.identity);
            Instantiate(PickUpLevelEffect, transform.position, Quaternion.identity);
            PlayerController.Score = PlayerController.Score + 10; 
            if(PlayerController.PlatformsSpeed <= 5f )PlayerController.PlatformsSpeed++;
            Destroy(gameObject); 
        }
    }
}
