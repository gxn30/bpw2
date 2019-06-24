using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    //float timeLeft = 30.0f;
    public Text timerText;
    public float startTime;
    //private float gameTimer;
    //private bool gamePaused = false;
    public GameObject Car;
    //GameObject player;
    
    public float t;

    //void Start()
    //{
    //  startTime = Time.time;  
    //}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            timerText.enabled = false;
    }

    void Update()
    {
        t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f0");

        timerText.text = minutes + ":" + seconds ;


        t -= Time.deltaTime;

        //timerText.text = Time.deltaTime;


        if(timerText.enabled)
        { 
            if (t > 0)
            {
                //Debug.Log("GameOver()");
                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                // void DestroyGameObject()
                //{
                //     Destroy(Car);
                //  }

                Debug.Log("rq");
                Application.Quit();

            }
        }


        /*
        if (!gamePaused)
        {
            gameTimer += Time.deltaTime;
        }
        if (player.SetActive(false))
        gamePaused = true;
        */
    }

    
}

/* private float gameTimer;
private bool gamePaused = false;
 
void Update(){
     if(!gamePaused){
          gameTimer += Time.deltaTime;
     }
}


    {
    public GameObject objToDestroy;
//public Text timerText;
//float timeLeft;

// Use this for initialization
void OnTriggerEnter(Collider other)
{
    if (other.gameObject.tag == "Player")

        Destroy(objToDestroy);

    //timeLeft += Time.deltaTime;
    //Debug.Log ("Timer destroyed");
}
}

    */
