
using UnityEngine;

public class Bullet : MonoBehaviour {
    private Transform target;
    public float speed = 70f;
    PlayerHealth carHealth=new PlayerHealth();
   // PlayerHealth playa=new PlayerHealth();
    public GameObject impactEffect;
   // private GameObject player;
    public void seek(Transform _target)
    {
        target = _target;
    }
	// Use this for initialization
	void Start () {
     //   player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;
        if(dir.magnitude<= distanceThisFrame)
        {
            HitTarget();
         
            return;
        }

       transform.Translate(dir.normalized * distanceThisFrame,Space.World);
        
        
    }

    void HitTarget()
    {
        GameObject effectInstance=(GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectInstance, 2f);
        //Debug.Log("PLAYER HEALTH" + playa.health);
        
      
        Destroy(gameObject,1f);

    }

    
}
