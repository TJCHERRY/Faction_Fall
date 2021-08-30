using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour {
      GameObject Target;
	// Use this for initialization
	void Start () {
        Target = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
       // LookAt();
	}

    public void LookAt()
    {
        gameObject.transform.LookAt(Target.transform.position);
    }
}
