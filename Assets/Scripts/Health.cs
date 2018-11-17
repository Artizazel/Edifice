using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]


public class OnDamagedEvent : UnityEvent<int> { }

public class Health : MonoBehaviour {


    public int health = 10;

    public UnityEvent onDie;

    public OnDamagedEvent onDamage;


    public void TakeDamage(int damage)
    {
        health -= damage;

        onDamage.Invoke(health);

        if(health < 1)
        {
            onDie.Invoke();
        }
    }





	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
