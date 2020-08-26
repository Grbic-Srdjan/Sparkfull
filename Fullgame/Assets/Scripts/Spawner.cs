using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Platform;
    public float TimeToSpawn;
    private int RandomNumber;
    private float Pom;
    private GameObject AlreadySpawned;

    private void Start()
    {
        Pom = TimeToSpawn;
        if(Platform.Length > 1)AlreadySpawned = Platform[Platform.Length - 1]; 
    }

    private void Update()
    {
        TimeToSpawn -= 1 * Time.deltaTime; 
        if (TimeToSpawn <= 0) {
            TimeToSpawn = Pom;
            RandomNumber = Random.Range(0, Platform.Length);
            while (Platform[RandomNumber] == AlreadySpawned) RandomNumber = Random.Range(0, Platform.Length); 
            Instantiate(Platform[RandomNumber], Platform[RandomNumber].transform.position, Quaternion.identity);
            AlreadySpawned = Platform[RandomNumber];
        }
    }

}
