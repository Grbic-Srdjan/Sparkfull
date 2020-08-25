using UnityEngine;
using UnityEngine.SceneManagement; 

public class Loading : MonoBehaviour
{
    public GameObject[] LoadScene;
    private int RandomNumber;

    private void Start()
    {
        RandomNumber = Random.Range(0, LoadScene.Length);
        LoadScene[RandomNumber].SetActive(true);
        PlayerController.PlatformsSpeed = 2f;
        PlayerController.Score = 0;
        PlayerController.Health = 5;
        SceneManager.LoadScene("Game"); 
    }

}
