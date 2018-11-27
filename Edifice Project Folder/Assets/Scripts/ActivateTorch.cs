using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTorch : MonoBehaviour {



    public Light Flashlight;

    private bool Toggled = false;

    int i = 0;


    private void ToggleLight()
    {
        i = 0;
        Flicker();
        Flashlight.enabled = !Flashlight.enabled;
        Toggled = true;
        Invoke("Wait", 1f);
    }
    private void Wait()
    {
        Toggled = false;
    }
    private void FlickerTrigger()
    {
        i = Flicker();
        Invoke("Flicker", 0.1f);
        
    }
    private int Flicker()
    {

        if (i < 10)
        {
            Flashlight.enabled = !Flashlight.enabled;
        }
        i = i + 1;

        return i;

        


    }




	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        Flicker();


        if(Input.GetMouseButton(1) && Toggled == false)
        {
            ToggleLight();
        }
		
	}
}
