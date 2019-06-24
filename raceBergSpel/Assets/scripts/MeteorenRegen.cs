using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorenRegen : MonoBehaviour
{
    public GameObject Meteoriet;
    public float posX;
    public float posZ;
    public float posY;


    void Start()
    {
        posX = Random.Range(0, 400);
        posZ = Random.Range(-700, -70);
        posY = Random.Range(50, 500);

        Meteoriet.transform.position = new Vector3(posX, posY, posZ);
    }


}
