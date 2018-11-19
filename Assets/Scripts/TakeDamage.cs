using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour {

    public int damage;
    public float resetTime = 0.25f;
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);

        






        GetComponent<Collider2D>().enabled = false;

        //Will wait 0.25 seconds
        Invoke("ResetTrigger", resetTime);


    }

    private void ResetTrigger()
    {
        GetComponent<Collider2D>().enabled = true;
    }


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
