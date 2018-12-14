using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[System.Serializable]


public class OnPlayerDamagedEvent : UnityEvent<int> { }

public class PlayerHealth : MonoBehaviour
{


    public int health = 10;

    public GameObject playerBody;

    public UnityEvent onDie;

    public OnPlayerDamagedEvent onDamage;

    public bool TakenDamage = false;

    public Slider HealthSlider;


    public void TakeDamage(int damage)
    {
        health -= damage;

        TakenDamage = true;

        onDamage.Invoke(health);

        if (health < 1)
        {


            Vector3 rotationInDegrees = transform.eulerAngles;

            Quaternion rotationInRadians = Quaternion.Euler(rotationInDegrees);
            Instantiate(playerBody, transform.position, rotationInRadians);



            onDie.Invoke();


        }
    }


    void Update()
    {
        HealthSlider.value = health;
    }


    // Use this for initialization
    
}









