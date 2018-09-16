using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_translate : MonoBehaviour {

    public Vector3 moveSpeed;

	// Use this for initialization
	void Start () {
		


	}
	
	// Update is called once per frame
	void Update () {

        transform.position += moveSpeed;

	}
}
