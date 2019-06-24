using UnityEngine.SceneManagement;
using UnityEngine;

public class NextTimer : MonoBehaviour
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
                Debug.Log("next");
                //Application.Quit();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            }
        }



    }





}
