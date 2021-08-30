
using UnityEngine;

public class GunScript : MonoBehaviour {
    public Camera carCam;
    public float range = 100f;
    public float damage = 10f;
    public Transform crosshair;
    public ParticleSystem muzzle;

   
    RaycastHit hit;
    CamScript aim;
    AudioSource gunshot;
    public AudioSource Blasting;
    
   // public Transform Starting_point;
  // public  GameObject bulletPrefab;
    //Rigidbody rb;
    // Use this for initialization

    void Start()
    {
        //DestroyedRom = GetComponent<GameObject>();
        gunshot=GetComponent<AudioSource>();
        aim = GetComponent<CamScript>();

        //rb.GetComponent<Rigidbody>();
       // bullet.GetComponent<GameObject>();
        Cursor.visible = false;
    }
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("PS4_L1"))
        {
            aim.distance = Mathf.Lerp(aim.distance, 8f, 5f*Time.deltaTime);
            if (Input.GetButtonDown("PS4_R1"))
            {
                PlayAudio();
                shoot();
                
                


            }
        }
        else
        {
            aim.distance = Mathf.Lerp(aim.distance, CamScript.origDist, 4f*Time.deltaTime);
        }
	}
    void shoot()
    {
        muzzle.Play();
        //RaycastHit hit;

        Ray ray = carCam.ScreenPointToRay(crosshair.position);
        
         Debug.DrawRay(ray.origin, ray.direction * range, Color.yellow);
        if (Physics.Raycast(ray,out hit, range))
        {
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.HealthLoss(damage);
            }
            if (target.health==0)
          {
                //Instantiate(DestroyedRom, target.transform.position, target.transform.rotation);
                Blasting.Play();

            }
        }
            
            
        }

    void PlayAudio()
    {
        gunshot.Play();
        print("gunSHOT PLAY");
    }
    }

