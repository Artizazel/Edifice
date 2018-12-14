using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[System.Serializable]

public class OnDetectedEvent : UnityEvent<bool> { }



public class MoveTowardsCletus : MonoBehaviour {


    public Transform target;

    public float speed = 5f;

    public OnDetectedEvent onDetect;

    

    // Update is called once per frame
    void Update () {

        //Finds the script 'ZombieVision' being use on the game object cone
        GameObject Cone = GameObject.Find("Cone");
        ZombieVision VisionScript = Cone.GetComponent<ZombieVision>();

        GameObject Zombie = GameObject.Find("Zombie");
        Health HealthScript = Zombie.GetComponent<Health>();


        if ((target != null) && ((/*Finds the variable 'detected' in the ZombieVision script and checks if true, or for 'TakenDamage'*/VisionScript.detected == true)||(HealthScript.TakenDamage == true)))
        {
            Vector3 currentPosition = transform.position;

            Vector3 targetPosition = target.position;

            float currentSpeed = speed * 0.01f;


            transform.position = Vector3.MoveTowards(currentPosition, targetPosition, currentSpeed);
        }




		
	}
}
