using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]


public class OnDamagedEvent : UnityEvent<int> { }

public class Health : MonoBehaviour {


    public int health = 10;

    public GameObject zombieBody;

    public UnityEvent onDie;

    public OnDamagedEvent onDamage;

    public bool TakenDamage = false;


    public void TakeDamage(int damage)
    {
        health -= damage;

        TakenDamage = true;

        onDamage.Invoke(health);

        if(health < 1)
        {


            Vector3 rotationInDegrees = transform.eulerAngles;

            Quaternion rotationInRadians = Quaternion.Euler(rotationInDegrees);
            Instantiate(zombieBody, transform.position, rotationInRadians);



            onDie.Invoke();


        }
    }



}
