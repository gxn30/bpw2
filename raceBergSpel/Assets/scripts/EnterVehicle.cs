using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.SceneManagement;

public class EnterVehicle : MonoBehaviour
{
    private bool inVehicle = false;
    CarUserControl vehicleScript;
    //public GameObject guiObj;
    GameObject player;

    //test:
    public GameObject camera2;
    


    void Start()
    {
        vehicleScript = GetComponent<CarUserControl>();
        player = GameObject.FindWithTag("Player");
        //guiObj.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && inVehicle == false)
        {
            //guiObj.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
               // guiObj.SetActive(false);
                player.transform.parent = gameObject.transform;
                vehicleScript.enabled = true;
                player.SetActive(false);
                inVehicle = true;
                //test:
                camera2.SetActive(true);
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //guiObj.SetActive(false);
        }
    }
    void Update()
    {
        if (inVehicle == true && Input.GetKey(KeyCode.F))
        {
           // vehicleScript.enabled = false;
          //  player.SetActive(true);
           // player.transform.parent = null;
           // inVehicle = false;
           Debug.Log("GameOver()");
            Application.Quit();

        }
    }
}