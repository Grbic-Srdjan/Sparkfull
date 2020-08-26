using UnityEngine;
using UnityEngine.SceneManagement; 

public class IsPierced : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("BigDeadlySpicke")) SceneManager.LoadScene("GameOver");
    }
}
