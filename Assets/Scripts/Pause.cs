using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Pause : MonoBehaviour {
    bool isPaused = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("PS4_Options"))
        {
            Time.timeScale = 0f;
            isPaused = true;
        }
       // if (isPaused == true)
       // {
            if (Input.GetButtonDown("PS4_Options") && isPaused==true) {

                Time.timeScale = 1;
                isPaused = false;
           }
       // }
	}
}
