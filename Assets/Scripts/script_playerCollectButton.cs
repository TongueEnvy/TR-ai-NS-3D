using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_playerCollectButton : MonoBehaviour {

    public int pointValue;

    public GameObject score;

	// Use this for initialization
	void Start () {

        score = GameObject.Find("scoreKeeper");

	}

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "Player")
        {

            score.GetComponent<sript_trackScore>().score += pointValue;
            Destroy(gameObject);

        }

    }
}
