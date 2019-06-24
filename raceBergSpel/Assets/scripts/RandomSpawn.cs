using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject Car;
    public float posX;
    public float posZ;
    

    void Start()
    {
        posX = Random.Range(-22, -5);
        posZ = Random.Range(30, 47);
        
        Car.transform.position = new Vector3(posX, 49, posZ);
    }

   
}
