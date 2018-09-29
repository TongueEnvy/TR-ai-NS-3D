using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sript_lockRotation : MonoBehaviour {

    Vector3 lockRotation;

    // Use this for initialization
    void Start () {

        lockRotation = transform.eulerAngles;

	}
	
	// Update is called once per frame
	void Update () {

        transform.eulerAngles = lockRotation;

	}
}
