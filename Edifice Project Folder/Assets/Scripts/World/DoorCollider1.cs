using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorCollider1 : MonoBehaviour {
    

    public bool dialogue1End = true;

    bool dialoguePreEnd = true;

    public GameObject dialoguePrefab;

    public GameObject fadeOutPrefab;

    public GameObject trueDialoguePrefab;

    public bool spokenToDave = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {


        GameObject Dave = GameObject.Find("Dave");
        DaveCollider daveColliderScript = Dave.GetComponent<DaveCollider>();



        if (dialoguePreEnd == true && daveColliderScript.dialoguePlayed == false)
        {

            dialoguePreEnd = false;

            Instantiate(dialoguePrefab);

            Invoke("preDialogue", 6f);

        }


        if (dialogue1End == true && daveColliderScript.dialoguePlayed == true)
        {

            dialogue1End = false;

            


            Invoke("fadeOut", 0.5f);
        }


    }

    private void fadeOut()
    {
        Instantiate(fadeOutPrefab);

        Invoke("loadAct2", 3f);
    }


    private void loadAct2()
    {
        SceneManager.LoadScene("Act2");
    }

    private void preDialogue()
    {

        GameObject Dialogue2 = GameObject.Find("Dialogue UI Canvas 2(Clone)");

        Destroy(Dialogue2);




    }




    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        

    }
}
