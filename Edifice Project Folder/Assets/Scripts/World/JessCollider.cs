using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JessCollider : MonoBehaviour
{


    public GameObject fadeOut;

    public bool inDialogue = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {


        inDialogue = true;


        

        Instantiate(fadeOut);


        


        








    }
}
