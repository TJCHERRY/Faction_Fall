using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioBG : MonoBehaviour {
   public AudioSource Bgmusic;
  public  AudioClip intervals;
	// Use this for initialization
	void Start () {
      //  Bgmusic = GetComponent<AudioSource>();
       // intervals = GetComponent<AudioClip>();
        Bgmusic.clip = intervals;
        Bgmusic.Play();
    }
	
	// Update is called once per frame
	void Update () {
        
        //Bgmusic.loop = true;
    }
}
