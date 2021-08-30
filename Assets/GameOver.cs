using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
    GameObject player;
    Animator anim;
    //PlayerHealth healthvalue= new PlayerHealth();
    void Awake()
    {
        anim = GetComponent<Animator>();
    }
 
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(anim);
            Debug.Log(PlayerHealth._playerHealth );
        if (PlayerHealth._playerHealth <= 0)
        {
            Debug.Log("GAMEOVER");
            anim.SetTrigger("GameOver");
        }

        if(player==null && Input.GetButtonDown("PS4_Touch"))
        {
            //Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene("UI");

           // SceneManager.LoadScene("SPIII");
        }
	}
}
