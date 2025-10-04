using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayMadDriver()
    {
        SceneManager.LoadScene("MadDriver");
        Debug.Log("MadDriver loaded");
    }

    public void PlayFlyBird()
    {
        SceneManager.LoadScene("FlyBird");
        Debug.Log("FlyBird loaded");
    }

    public void PlaySumo()
    {
        SceneManager.LoadScene("Sumo");
        Debug.Log("Sumo loaded");
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
