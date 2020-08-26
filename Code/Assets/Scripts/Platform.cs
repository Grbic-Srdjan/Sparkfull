using UnityEngine;

public class Platform : MonoBehaviour
{

    private void Start()
    {
        Destroy(gameObject, 32);
        if(PlayerController.PlatformsSpeed == 0) PlayerController.PlatformsSpeed = 2f;  
    }

    private void Update()
    {
        transform.Translate(-Vector2.up * (float)PlayerController.PlatformsSpeed * Time.deltaTime);

    }
}
