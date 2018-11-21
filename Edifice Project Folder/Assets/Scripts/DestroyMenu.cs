using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {

        StartCoroutine(Timer());



	}
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(4);

        Destroy(gameObject);
    }


	
	// Update is called once per frame
	void Update () {
		
	}
}
