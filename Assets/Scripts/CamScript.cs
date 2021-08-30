using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour {
    //float pitch;
    float yaw;
    float pitch;
   public float sensitivity;
   public float distance;
   
     //float origDist= 10f
  public static  float origDist = 10f;
   public Transform target;

    //public Transform Turr;
 
    private bool isAiming = false;
   

    Vector3 currentRotation;
    float smoothTime = 0.12f;
    Vector3 rotationSmoothVelocity;

    Vector2 pitchMinMax = new Vector2(-1,30);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        pitch += Input.GetAxis("PS4_RightAnalogVertical") * sensitivity;
        pitch = Mathf.Clamp(pitch, pitchMinMax.x, pitchMinMax.y);
        yaw += Input.GetAxis("PS4_RightAnalogHorizontal") * sensitivity;
        CamPos();
       /* if (Input.GetKey(KeyCode.Mouse1))
        {
            distance = Mathf.Lerp(distance, 5, 5f * Time.deltaTime);
            //transform.position = Vector3.Lerp(transform.position, Aim.position,  Time.deltaTime);
            // transform.rotation = Quaternion.Lerp(transform.rotation, Aim.rotation,  Time.deltaTime);

            aimPoint.rotation = Quaternion.Euler(new Vector3(pitch, yaw, 0));

        }
        else distance = Mathf.Lerp(distance, origDist, 5f * Time.deltaTime); */

	}
  

    void CamPos()
    {
        

            //distance = Mathf.Lerp(distance, origDist, 5f * Time.deltaTime);
            //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0), Time.deltaTime);
            
           

            currentRotation = Vector3.SmoothDamp(currentRotation, new Vector3(pitch, yaw), ref rotationSmoothVelocity, smoothTime);

            transform.eulerAngles = currentRotation;
       
        transform.position = target.position - transform.forward * distance;
            Debug.DrawRay(transform.position, transform.forward*distance, Color.green);
            
        
        
    }
    
}
