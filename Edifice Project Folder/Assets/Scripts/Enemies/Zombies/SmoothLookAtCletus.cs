﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothLookAtCletus : MonoBehaviour {


    public Transform target;

    public float smoothing = 5f;

    public float adjustmentAngle = 0f;




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	private void Update () {

        GameObject Cone = GameObject.Find("Cone");
        ZombieVision VisionScript = Cone.GetComponent<ZombieVision>();


        GameObject Zombie = GameObject.Find("Zombie");
        Health HealthScript = Zombie.GetComponent<Health>();

        if ((target != null)&&((VisionScript.detected == true) || (HealthScript.TakenDamage == true)))
        {

            Vector3 currentPosition = transform.position;

            Quaternion currentRotation = transform.rotation;

            Vector3 targetPosition = target.position;

            Vector3 difference = targetPosition - currentPosition;


            float angleZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

            Vector3 rotationInDegrees = new Vector3();

            rotationInDegrees.x = 0;
            rotationInDegrees.y = 0;

            rotationInDegrees.z = angleZ + adjustmentAngle;


            Quaternion rotationInRadians = Quaternion.Euler(rotationInDegrees);

            float rotationSpeed = Time.deltaTime * smoothing;

            transform.rotation = Quaternion.Lerp(currentRotation, rotationInRadians, rotationSpeed);




        }

	}
}
