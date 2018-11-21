using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TopDownMovement2D : MonoBehaviour {

    public float speed = 5.0f;
    Rigidbody2D rigibody;
    private bool isDialogue = false;

    public GameObject FadeOutPrefab;
    
    public GameObject dialoguePrefab;

    public Transform LocationPrefab;

    private bool inDialogue = false;
    

	// Use this for initialization
	void Start () {
        rigibody = GetComponent<Rigidbody2D>();
        
	}

    // Update is called once per frame
    void FixedUpdate()
    {


        if (inDialogue == false)
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");



            rigibody.velocity = new Vector2(x, y) * speed;
            
            rigibody.angularVelocity = 0f;

            if (transform.position.x > 8.5 && transform.position.x < 9 && isDialogue == false)
            {
                Dialogue1();
            }

        }

    }
    private void endDialogue1()
    {
        Vector3 currentPosition = transform.position;
        Vector3 desiredPosition = LocationPrefab.position;
        transform.position = Vector3.MoveTowards(currentPosition, desiredPosition, 0.1f);
        Instantiate(FadeOutPrefab);
        Invoke("NextScene", 4f);

    }
    private void Dialogue1()
    {
        Instantiate(dialoguePrefab);
        inDialogue = true;
        isDialogue = true;
        Invoke("endDialogue1", 15f);

        
    }

    private void NextScene()
    {
        inDialogue = false;
        isDialogue = false;
        SceneManager.LoadScene("Act 1.5");
    }


}

