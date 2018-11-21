using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {


    public GameObject bulletPrefab;

    public Transform bulletSpawn;

    public float fireTime = 0.5f;

    private bool isFiring = false;



	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButton(0))
        {
            if(!isFiring){

                Fire();
            }
        }
		
	}

    private void Fire()
    {
        isFiring = true;

        Vector3 bulletPosition = bulletSpawn.position;

        Quaternion bulletRotation = bulletSpawn.rotation;


        Instantiate(bulletPrefab, bulletPosition, bulletRotation);


        if (GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().Play();
        }

        //Invoke works as a time in this case, setting isFiring to false every 0.5 seconds
        Invoke("SetFiring", fireTime);

    }


    private void SetFiring()
    {
        isFiring = false;
    }




}
