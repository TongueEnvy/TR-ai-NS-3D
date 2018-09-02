using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_shoot : MonoBehaviour {

    bool canShoot;

    public GameObject bullet;

    public float shotTimer;
    public float shotCounter;
    public float shotSpeed;

	// Use this for initialization
	void Start () {

        

	}
	
	// Update is called once per frame
	void Update () {

        shotCounter -= Time.deltaTime;
        if (shotCounter <= 0)
        {

            var newBullet = Instantiate<GameObject>(bullet);
            newBullet.transform.position = transform.position;
            newBullet.GetComponent<Rigidbody>().velocity = transform.forward * shotSpeed;

            shotCounter = shotTimer;

        }

	}
}
