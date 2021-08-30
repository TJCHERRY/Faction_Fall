using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollOver : MonoBehaviour {
    public Transform player;
   // Vector3 currentRotation= new Vector3();
   // float smoothTime = 0.12f;
   // Vector3 rotationSmoothVelocity;
    // Use this for initialization
    // public WheelCollider[] wheels;
    void Start () {
       // wheels = new WheelCollider[4];
	}

    // Update is called once per frame
    void Update() {
      
    }
    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Ground")
        {
            player.rotation = Quaternion.Euler(0f, 0f, 0f);
            player.transform.position = Vector3.Lerp(player.transform.position, new Vector3(player.position.x, 6f, player.position.z), 0.25f);
        }
    }
}
