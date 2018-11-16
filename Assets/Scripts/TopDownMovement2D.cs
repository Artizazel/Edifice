using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement2D : MonoBehaviour {

    public float speed = 5.0f;
    Rigidbody2D rigibody;


	// Use this for initialization
	void Start () {
        rigibody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rigibody.velocity = new Vector2(x, y) * speed;
        rigibody.angularVelocity = 0f;
	}
}
