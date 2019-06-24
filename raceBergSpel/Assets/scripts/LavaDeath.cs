/* using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LavaDeath : MonoBehaviour
{
    public GameObject lava;
    //public Text timerText;
    //float timeLeft;

    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")

            Debug.Log("GameOver()");

        //timeLeft += Time.deltaTime;
        //Debug.Log ("Timer destroyed");
    }
}
*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LavaDeath : MonoBehaviour
{

    public GameObject car;
    //public Vector3 position;


    private void Update()
    {
        if (car.transform.position.y < 0)
        {
            Debug.Log("GameOver()");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }


}