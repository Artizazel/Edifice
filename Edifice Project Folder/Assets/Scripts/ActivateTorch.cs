using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateTorch : MonoBehaviour {



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

        if(torchBattery < 100)
        {
            torchBattery += 0.05f;
        }



        if(Input.GetMouseButton(1) && Toggled == false && torchBattery > 0)
        {
            ToggleLight();
        }

        if(Flashlight.enabled == true)
        {
            torchBattery -= 0.1f;
        }

        if(torchBattery < 0.01)
        {
            Flashlight.enabled = false;
        }


        batterySlider.value = torchBattery;

		
	}
}
