using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour {
   public GameObject controls;
    bool scenechange = false;
	public void Togame()
    {
        if (Input.GetButtonDown("PS4_X"))
        {
            SceneManager.LoadScene("SPIII");
        }
        
    }
    public void Quit()
    {
        if (Input.GetButtonDown("PS4_O"))
        {
            Application.Quit();
        }
    }

    public void Controls()
    {
        if (Input.GetButton("PS4_Touch"))
        {
            controls.SetActive(true);
            //scenechange = true;
        }
        else
        {
            controls.SetActive(false);
        }

       
    }

    void Update()
    {
        Togame();
        Quit();
        Controls();
    }
}
