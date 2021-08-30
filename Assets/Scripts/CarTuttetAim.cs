using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTuttetAim : MonoBehaviour {
    // public bool aimPress = false;
    public Transform Camera;
    public Transform Car;
    Vector3 currentRotation = new Vector3();
    Vector3 smoothVelocity;
    float smoothTime = 0.12f;
   
	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
        Aim();
	}
    void Aim()
    {
        if (Input.GetButton("PS4_L1"))
        {
             Vector3 desiredRotation= new Vector3(0f, Camera.eulerAngles.y, Car.eulerAngles.z);
             currentRotation = Vector3.SmoothDamp(currentRotation, desiredRotation, ref smoothVelocity, smoothTime);
            transform.eulerAngles = Vector3.Lerp(transform.eulerAngles,new Vector3(Car.eulerAngles.x, Camera.eulerAngles.y, Car.eulerAngles.z),2f);
            //transform.localRotation = Quaternion.Euler(0f, Camera.eulerAngles.y, 0f);
            //Debug.Log(transform.eulerAngles);
           // transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
        }
     

    }
}
