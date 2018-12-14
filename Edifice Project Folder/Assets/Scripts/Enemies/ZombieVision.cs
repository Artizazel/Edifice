using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class ZombieVision : MonoBehaviour {


    public bool detected = false;

    
    //Will check if anything is touching the vision cone and will set detected to true if it is
    private void OnTriggerEnter2D(Collider2D collision)
    {
        detected = true; 
        
    }








	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
