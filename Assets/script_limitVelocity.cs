using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_limitVelocity : MonoBehaviour {

    public float minVelocity;

    public bool lockZ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(GetComponent<Rigidbody>().velocity.magnitude < minVelocity)
        {

            if(lockZ == true)
            {

                GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, GetComponent<Rigidbody>().velocity.y, 0);


            }

            GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized * minVelocity;

        }

    }
}
