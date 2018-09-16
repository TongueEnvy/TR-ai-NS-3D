using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_spawn : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {

        var newPlayer = Instantiate<GameObject>(player);
        newPlayer.transform.position = transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
