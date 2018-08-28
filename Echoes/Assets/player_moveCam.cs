using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_moveCam : MonoBehaviour {

    public Camera cam;

	// Use this for initialization
	void Start () {

        cam = Camera.main;

	}
	
	// Update is called once per frame
	void Update () {

        cam.transform.position = new Vector3(0, transform.position.y + 1.5f, -12);

	}
}
