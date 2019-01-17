using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]


public class Typer : MonoBehaviour {

    public string msg = "Replace";
    private Text textComp;
    public float startDelay = 2f;
    public float typeDelay = 0.01f;
    public float endDelay = 4;




	// Use this for initialization
	void Start () {
        StartCoroutine("TypeIn");
	}

    void Awake()
    {
        textComp = GetComponent<Text>();
    }

    //Individually types in each letter to a text box
    public IEnumerator TypeIn()
    {
        yield return new WaitForSeconds(startDelay);

        for (int i = 0; i <msg.Length; i++)
        {
            textComp.text = msg.Substring(0, i);

            yield return new WaitForSeconds(typeDelay);
        }

        yield return new WaitForSeconds(endDelay);






    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
