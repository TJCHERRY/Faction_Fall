using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RAIN.Core;
public class Enemy : MonoBehaviour {
    
    float blinkTime = 0.0f;
    float blinkLength = 0.5f;
   public GameObject Torso;
    [Header("Attributes")]
    public float fireRate = 1f;
    public float range = 15f;
    public float fireCountdown = 0f;
    private Transform PlayerTarget;
    public Transform PartToRotate;
    public float waitTime = 500f;
    private float bulletcount=0f;

    public GameObject bulletPrefab;
    public Transform firePoint;
   

   // public GameObject Target;

   // Renderer rend;
    AIRig aiRig = null;
	// Use this for initialization
	void Start () {
        aiRig = GetComponentInChildren<AIRig>();
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
        
        
        //rend = GetComponent<Renderer>();

    }
	
	// Update is called once per frame
	void Update () {
      
        if (PlayerTarget == null)
        {
            return;
        }
        bool isAttacking = aiRig.AI.WorkingMemory.GetItem<bool>("isAttacking");
        if (isAttacking != true)
        {
            Torso.GetComponent<Renderer>().material.color = Color.white;

            return;
        }
       
           
        
       
        blinkTime += Time.deltaTime;
        if(blinkTime> blinkLength)
        {
            blinkTime = -blinkLength;
        }
        Torso.GetComponent<Renderer>().material.color = blinkTime < 0.0f ? Color.red : Color.white;
        //if (isAttacking == true)
        // {


        //    Lookat();
        //    }
        Vector3 dir = PlayerTarget.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = lookRotation.eulerAngles;
        PartToRotate.rotation = Quaternion.Euler(rotation.x, rotation.y,0f);

        
        if (fireCountdown <= 0)
        {
            // InvokeRepeating("Shoot", 0f, 2f);
            Shoot();
            fireCountdown = 1/ fireRate;
            bulletcount += 1f;
        }
        fireCountdown -= Time.deltaTime;
        if (bulletcount >= 5f)
        {
            
            Debug.Log("resetfire");
            
            fireCountdown = 2.5f;


            bulletcount = 0f;
        }
       
    }

    void Shoot()
    {
       GameObject bulletGO= (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletGO.GetComponent<Bullet>();

        if(bullet!= null)
        {
            bullet.seek(PlayerTarget);
        }
    }
    

  // public void Lookat()
  //  {
       // gameObject.transform.LookAt(Target.transform.position);
  //  }
  void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position,range);
        
    }

    void UpdateTarget()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        GameObject detectedPlayer = null;
        float currentDistance = Mathf.Infinity;
        float distancetoPlayer = Vector3.Distance(transform.position, player.transform.position);

        if(distancetoPlayer< currentDistance)
        {
            currentDistance = distancetoPlayer;
            detectedPlayer = player;
        }
        if(detectedPlayer!=null && currentDistance <= range)
        {
            PlayerTarget = detectedPlayer.transform;
            print("Target is player");
        }
        else
        {
            PlayerTarget = null;
           // PartToRotate.rotation = Quaternion.Euler(transform.eulerAngles);
        }
    }
}
