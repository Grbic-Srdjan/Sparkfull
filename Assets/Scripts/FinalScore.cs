using UnityEngine;
using UnityEngine.UI; 

public class FinalScore : MonoBehaviour
{
    public GameObject ScoreText;

    private void Update()
    {
        ScoreText.GetComponent<Text>().text = "Score: " + PlayerController.Score; 
    }

}
