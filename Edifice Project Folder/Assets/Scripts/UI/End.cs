using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour {

    //Used as an event in the finalFadeOut animator to reset the game
	public void EndGame()
    {
        SceneManager.LoadScene("TitleMenu");
    }
	
	
}
