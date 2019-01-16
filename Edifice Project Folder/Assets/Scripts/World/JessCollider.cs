using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JessCollider : MonoBehaviour
{


    public GameObject zombie;
    public GameObject zombie1;
    public GameObject zombie2;
    public GameObject zombie3;
    public GameObject zombie4;
    public GameObject zombie5;


    public GameObject dialogue;

    public GameObject fadeOut;

    public bool inDialogue = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {


        Destroy(zombie);
        Destroy(zombie1);
        Destroy(zombie2);
        Destroy(zombie3);
        Destroy(zombie4);
        Destroy(zombie5);


        if (inDialogue == false)
        {
            Instantiate(dialogue);
            Invoke("fade", 5);
        }

        inDialogue = true;


        

        


        


        








    }

    private void fade()
    {
        Instantiate(fadeOut);
    }


}
