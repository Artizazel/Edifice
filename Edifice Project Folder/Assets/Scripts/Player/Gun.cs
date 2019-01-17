using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gun : MonoBehaviour {

    public delegate void UpdateAmmo(int newAmmo);
    public static event UpdateAmmo OnUpdateAmmo;

    public GameObject bulletPrefab;

    public Transform bulletSpawn;

    GameObject ammoClip;

    public float fireTime = 0.5f;

    private bool isFiring = false;

    private int ammo = 7;

    public Slider reloadingSlider;

    private bool reloading = false;

	
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



            reloadingSlider.value = 0;

            reloading = true;
           

            Invoke("reload", 1f);



            

            
        }

        //Degubbing tools to skip through levels
        if(Input.GetKeyDown("8"))
        {
            SceneManager.LoadScene("TitleMenu");
        }
        if (Input.GetKeyDown("9"))
        {
            SceneManager.LoadScene("Act 1");
        }
        if (Input.GetKeyDown("0"))
        {
            SceneManager.LoadScene("Act 1.5");
        }
        if (Input.GetKeyDown("-"))
        {
            SceneManager.LoadScene("Act2");
        }
        if (Input.GetKeyDown("="))
        {
            SceneManager.LoadScene("Act3");
        }


    }

    void FixedUpdate()
    {
        if (reloading == true)
        {
            reloadingSlider.value++;
        }
    }



    //Checks if the player isn't already reloading and sets the ammo to 7
    private void reload()
    {

        reloading = false;
        ammo = 7;
        reloadingSlider.value = 0;
        if (OnUpdateAmmo != null) OnUpdateAmmo(ammo);



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
