using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    public delegate void UpdateAmmo(int newAmmo);
    public static event UpdateAmmo OnUpdateAmmo;

    public GameObject bulletPrefab;

    public Transform bulletSpawn;

    GameObject ammoClip;

    public float fireTime = 0.5f;

    private bool isFiring = false;

    private int ammo = 7;

	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButton(0) && ammo > 0)
        {
            if(!isFiring){

                Fire();
                
                

            }
        }

        if (Input.GetKeyDown("r") && ammo < 7)
        {
            ammo = 7;

            if (OnUpdateAmmo != null) OnUpdateAmmo(ammo);
        }


    }

    private void Fire()
    {
        isFiring = true;

        ammo--;

        if (OnUpdateAmmo != null) OnUpdateAmmo(ammo);



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
