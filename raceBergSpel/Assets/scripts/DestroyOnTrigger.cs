using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DestroyOnTrigger : MonoBehaviour
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