using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    public Slider healthBar;

    private void OnEnable()
    {
        PlayerAnimate.OnUpdateHealth += UpdateHealthBar;


    }

    private void OnDisable()
    {
        PlayerAnimate.OnUpdateHealth -= UpdateHealthBar;
    }

    private void UpdateHealthBar(int health)
    {
        healthBar.value = health;
    }

    




	// Use this for initialization
	void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
