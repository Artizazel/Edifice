using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoUI : MonoBehaviour
{
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
        print(remainingAmmo);
        image.sprite = ammoSprites[remainingAmmo];

        aniShake.SetTrigger("OnShot");
    }
}
