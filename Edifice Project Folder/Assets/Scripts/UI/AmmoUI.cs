using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoUI : MonoBehaviour
{
    //Calls all necessary variables
    public Image image;

    public Sprite[] ammoSprites;

    public Animator aniShake;

    private void OnEnable()
    {
        Gun.OnUpdateAmmo += OnUseAmmo;
    }

    private void OnDisable()
    {
        Gun.OnUpdateAmmo -= OnUseAmmo;
    }


    public void OnUseAmmo(int remainingAmmo)
    {
        //Debugging tool
        print(remainingAmmo);

        //Will call the appropriate sprite from an array to display the same number of bullets in a clip ass the ammo value
        image.sprite = ammoSprites[remainingAmmo];

        aniShake.SetTrigger("OnShot");
    }
}
