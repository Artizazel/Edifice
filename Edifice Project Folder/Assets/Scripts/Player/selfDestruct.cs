using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfDestruct : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Invoke("DestroySelf", 0.1f);



	}

    void DestroySelf()
    {

        Destroy(gameObject);


    }


	
	// Update is called once per frame
	void Update () {
		
	}
}
