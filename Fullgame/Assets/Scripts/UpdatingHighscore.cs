using UnityEngine;
using UnityEngine.UI; 

public class UpdatingHighscore : MonoBehaviour
{
    public Text YourHS;

    void Start()
    {
        YourHS.text = PlayerPrefs.GetInt("HighScore").ToString();
    }

    private void Update()
    {
        YourHS.GetComponent<Text>().text = "highscore: " + PlayerPrefs.GetInt("HighScore");
        if (PlayerController.Score > PlayerPrefs.GetInt("HighScore", 0)) PlayerPrefs.SetInt("HighScore", PlayerController.Score);
    }
}
