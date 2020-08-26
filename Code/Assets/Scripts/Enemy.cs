using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int AmouthOfDamage;
    public GameObject AttackSound, AttackEffect; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) {
            PlayerController.Health -= AmouthOfDamage;
            Instantiate(AttackSound, transform.position, Quaternion.identity);
            Instantiate(AttackEffect, transform.position, Quaternion.identity); 
            Destroy(gameObject);
        }
    }

}
