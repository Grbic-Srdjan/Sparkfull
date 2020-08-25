using UnityEngine;

public class HealthGiving : MonoBehaviour
{
    public GameObject HealthGiveSound, HealthGiveEffect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(HealthGiveSound, transform.position, Quaternion.identity);
            PlayerController.Health++;

            Instantiate(HealthGiveEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

}
