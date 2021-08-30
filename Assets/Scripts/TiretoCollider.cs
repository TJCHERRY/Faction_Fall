using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TiretoCollider : MonoBehaviour {

    public WheelCollider[] wheelCollider = new WheelCollider[4];
    public Transform[] tireMeshes = new Transform[4];
   // Rigidbody rb;
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        //boost();
        Tiretocoll();
        
       

    }
    void Tiretocoll()
    {
        for (int i = 0; i < 4; i++)
        {
            Quaternion quat;
            Vector3 pos;
            wheelCollider[i].GetWorldPose(out pos, out quat);

            tireMeshes[i].position = pos;
            tireMeshes[i].rotation = quat;


        }
    }
   
   // void boost()
    //{
       // for (int i = 0; i < 4; i)
       // {
           // if (Input.GetKeyDown(KeyCode.LeftShift))
           // {
            
               // rb.AddForce(transform.forward * 5, ForceMode.VelocityChange);


         //   }
           // if (Input.GetKeyDown(KeyCode.Space))
           // {
                //rb.AddForce(transform.up * 1000, ForceMode.Impulse);


           // }
       // }
   // }

}
