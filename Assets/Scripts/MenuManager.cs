using UnityEngine;
using UnityEngine.SceneManagement; 

public class MenuManager : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("Loading"); 
    }

    public void goBackToManiMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void quit()
    {
        Application.Quit(); 
    }

}
