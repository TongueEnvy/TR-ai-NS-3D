﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_rotate : MonoBehaviour {

    public Vector3 rotSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        gameObject.transform.eulerAngles += rotSpeed;

	}
}
