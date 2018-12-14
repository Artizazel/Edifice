using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Bullet : MonoBehaviour {

    public float moveSpeed = 100;

    public int damage = 1;















	// Use this for initialization
	void Start () {
        Vector3 facingDirection = transform.up;

        Vector3 velocity = facingDirection * moveSpeed;

        GetComponent<Rigidbody2D>().AddForce(velocity);
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        string methodName = "TakeDamage";


        SendMessageOptions messageOptions = SendMessageOptions.DontRequireReceiver;

        Transform hitObject = other.transform;

        hitObject.SendMessage(methodName, damage, messageOptions);

        Destroy(gameObject);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

   








	
	// Update is called once per frame
	void Update () {
		
	}
}
