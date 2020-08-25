using UnityEngine;

public class PlatformDestroy : MonoBehaviour
{

    public GameObject DestroyEffect, DestroySound;

    private void Update()
    {
        if (transform.position.y <= -15.8)
        {
            Instantiate(DestroySound, transform.position, Quaternion.identity);
            Instantiate(DestroyEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

}
