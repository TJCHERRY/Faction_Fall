using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
    public List<AxleInfo> axleInfos;
    
    public float maxmotorTorque;
    public float steeringAngle;
    float motor;

    float steering;
    Rigidbody rb;

    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    

  // Update is called once per frame
    void Update()
    {
        boost();
        
        
        motor = maxmotorTorque * Input.GetAxis("Vertical");
        steering = steeringAngle * Input.GetAxis("Horizontal");

        foreach (AxleInfo axleInfo in axleInfos)
        {
            
           
         

            if (axleInfo.steering)
            {
                axleInfo.leftWheel.steerAngle = steering;
                axleInfo.rightWheel.steerAngle = steering;



            }
            if (axleInfo.motor)
            {
                axleInfo.leftWheel.motorTorque = motor;
                axleInfo.rightWheel.motorTorque = motor;

            }
           

        }
       

    }
    void boost()
    {
        foreach(AxleInfo axleInfo in axleInfos)
        {
            if (axleInfo.leftWheel.isGrounded && Input.GetButtonDown("PS4_X"))
            {
                rb.AddForce(transform.forward *2f, ForceMode.VelocityChange);
                Debug.Log("Boost True");
            }
           
        }
    }
   
}

    

[System.Serializable]
public class AxleInfo
{
    public WheelCollider leftWheel=new WheelCollider();
    public WheelCollider rightWheel= new WheelCollider();
    public bool motor;
    public bool steering;

}



