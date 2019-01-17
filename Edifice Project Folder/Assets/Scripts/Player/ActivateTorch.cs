using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateTorch : MonoBehaviour {


    //Declares all necessary variables
    public Light Flashlight;

    private bool Toggled = false;

    int i = 0;


    float torchBattery = 100;


    public Slider batterySlider;


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

    //Cause the flashlight to flicker when turned on or off
    private int Flicker()
    {

        if (i < 20)
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

        //Will constantly regenerate the torch's battery if it isn't already full
        if(torchBattery < 100)
        {
            torchBattery += 0.1f;
        }


        //Turns the batter on if off and off if on
        if(Input.GetMouseButton(1) && Toggled == false && torchBattery > 0)
        {
            ToggleLight();
        }

        if(Flashlight.enabled == true)
        {
            torchBattery -= 0.12f;
        }

        if(torchBattery < 0.01)
        {
            Flashlight.enabled = false;
        }


        batterySlider.value = torchBattery;

		
	}
}
