/*

using UnityEngine.SceneManagement;
using UnityEngine;

public class PreviousScene : MonoBehaviour
{
    public void EndGame()
    {
        Debug.Log("epic gg");
        Application.Quit();
    }
}

*/

using UnityEngine.SceneManagement;
using UnityEngine;

public class PreviousScene : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 12f;


    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        print(currentTime);

        if (currentTime < 0)
        {
            // public void Quit()
            {
                Debug.Log("epic gg");
                Application.Quit();

            }
        }



    }





}
