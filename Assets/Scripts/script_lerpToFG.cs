using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_lerpToFG : MonoBehaviour {

    public float lerpSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y, 0), Time.deltaTime * lerpSpeed);

	}
}
