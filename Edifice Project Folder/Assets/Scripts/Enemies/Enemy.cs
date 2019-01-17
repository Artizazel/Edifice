using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]

public class EnemySpawnedEvent : UnityEvent<Transform> { }

public class Enemy : MonoBehaviour {


    public EnemySpawnedEvent onSpawn;




	// Use this for initialization
	void Start () {

        //Finds the Cletus GameObject to later follow him once detected
        GameObject player = GameObject.FindWithTag("Cletus");

        onSpawn.Invoke(player.transform);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
