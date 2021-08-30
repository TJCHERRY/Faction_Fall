using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletcollision : MonoBehaviour {
    public float carhealth = 100;
   public  GameObject car;
    void start()
    {
        car = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        Debug.Log(car);
        if (carhealth <= 0f)
        {
            Destroy(car);
        }
    }
    void OnTriggerEnter(Collider other)
    {
       
            if (other.gameObject.tag == "Player")
            {

                carhealth -= 5f;
                Debug.Log("player health has reduced");

            }
        
    }
}
