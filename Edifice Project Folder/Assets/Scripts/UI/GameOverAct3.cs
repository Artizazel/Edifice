using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverAct3 : MonoBehaviour {



    public void Continue()
    {
        SceneManager.LoadScene("Act3");
    }

    public void GiveUp()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }




    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
