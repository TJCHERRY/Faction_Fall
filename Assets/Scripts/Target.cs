using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    AudioSource blast;
    public float health = 100;
   // public GameObject DestroyedRom;
    // Use this for initialization
    void Start()
    {
        blast = GetComponent<AudioSource>();
    }
   public void HealthLoss(float amount)
    {
        health -= amount;
        Debug.Log(transform.gameObject.name + "Health" + health);

        if (health == 0f)
        {
            Die();
        }
    }
    void Die()
    {
        //Instantiate(DestroyedRom, transform.position, transform.rotation);
        Destroy(gameObject);
        
    }
}

