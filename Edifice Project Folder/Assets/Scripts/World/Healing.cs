using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour {




    private void OnTriggerEnter2D(Collider2D other)
    {



        string methodName = "Heal";


        SendMessageOptions messageOptions = SendMessageOptions.DontRequireReceiver;

        Transform hitObject = other.transform;




        hitObject.SendMessage(methodName, messageOptions);




       


        Destroy(gameObject);
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
