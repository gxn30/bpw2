using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//public GameObject finish;

public class NextScene : MonoBehaviour
{
    private void OnCollisionEnter(Collision finish)
    {

        if (finish.gameObject.tag == "Player")
        {
            Debug.Log("next stage");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}