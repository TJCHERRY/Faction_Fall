using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    public static  float _playerHealth = 100;
    
    
void Start()
    {
        
       //S gameObject.GetComponentInChildren<BoxCollider>();
    }

void Update()
    {
        Debug.Log(_playerHealth);
        if (_playerHealth <= 0)
        {
            
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            _playerHealth -= 4f;
        }
    }
}
