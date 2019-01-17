using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {


    public Transform target;

    public float smoothing = 5f;


	
	// Update is called once per frame
	void FixedUpdate () {


        Vector3 currentPosition = transform.position;

        Vector3 targetPosition = target.position;


        float moveSpeed = smoothing * 0.001f;


        Vector3 newPosition = new Vector3();

        newPosition.x = targetPosition.x;

        newPosition.y = targetPosition.y;


        newPosition.z = currentPosition.z;


        transform.position = Vector3.Lerp(currentPosition, newPosition, moveSpeed);
		
	}
}
