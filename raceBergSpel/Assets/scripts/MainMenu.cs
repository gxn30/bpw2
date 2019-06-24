using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("lol");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}