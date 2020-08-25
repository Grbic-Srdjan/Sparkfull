using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public GameObject[] Music;
    private int RandomNumber;

    private void Start()
    {
        RandomNumber = Random.Range(0, Music.Length);
        Instantiate(Music[RandomNumber], transform.position, Quaternion.identity); 
    }

}
