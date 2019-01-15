using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitCollider : MonoBehaviour {


    public GameObject fadeOutPrefab;


    private void OnTriggerEnter2D(Collider2D collision)
    {




        fadeOut();


        


    }

    private void fadeOut()
    {
        Instantiate(fadeOutPrefab);

        Invoke("loadAct2", 3f);
    }


    private void loadAct2()
    {
        SceneManager.LoadScene("Act3");
    }

    




    
}
