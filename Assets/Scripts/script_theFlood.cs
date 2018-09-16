using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_theFlood : MonoBehaviour {

    public float baseSpeed;
    public float floodAccel;

    float floodSpeed;

	// Use this for initialization
	void Start () {

        floodSpeed = baseSpeed;

	}
	
	// Update is called once per frame
	void Update () {

        floodSpeed += floodAccel;

        transform.position += new Vector3(0, floodSpeed, 0);

	}
}
