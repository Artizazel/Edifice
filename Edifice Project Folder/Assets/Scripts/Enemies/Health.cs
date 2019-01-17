using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]


public class OnDamagedEvent : UnityEvent<int> { }

public class Health : MonoBehaviour {

    //Declares all necessary variables
    public int health = 10;

    public GameObject playerBody;

    public UnityEvent onDie;

    public OnDamagedEvent onDamage;

    public bool TakenDamage = false;

    //Creates a method that changes the health value and will destroy the game object if it runs out of health
    public void TakeDamage(int damage)
    {
        health -= damage;

        TakenDamage = true;

        onDamage.Invoke(health);

        if(health < 1)
        {


            Vector3 rotationInDegrees = transform.eulerAngles;

            Quaternion rotationInRadians = Quaternion.Euler(rotationInDegrees);
            Instantiate(playerBody, transform.position, rotationInRadians);



            onDie.Invoke();


        }
    }



}
