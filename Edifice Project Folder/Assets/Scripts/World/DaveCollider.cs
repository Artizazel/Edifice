using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaveCollider : MonoBehaviour {



    public GameObject dialoguePrefab;

    public bool inDialogue = false;

    public bool dialoguePlayed = false;

    public float dialogueLength = 65f;

    private GameObject dialogueObject;

    public GameObject daveLight;

    public Transform davePos;

    
    

    private void OnTriggerEnter2D(Collider2D collision)
    {

        

        if (dialoguePlayed == false)
        {

            dialoguePrefab.active = true;

            inDialogue = true;

            dialoguePlayed = true;

            Instantiate(dialoguePrefab);


            Instantiate(daveLight);


            dialogueObject = GameObject.Find("Dialogue UI Canvas 3(Clone)");


            Invoke("dialogueEnd", dialogueLength);


        }





    }

    void dialogueEnd()
    {

        

        inDialogue = false;

        dialogueObject.active = false;



    }






	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
