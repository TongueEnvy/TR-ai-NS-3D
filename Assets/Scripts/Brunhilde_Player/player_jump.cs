using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_jump : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Jump") && GetComponent<player_stats>().grounded == true)
        {

            GetComponent<player_stats>().rb.velocity = new Vector3(GetComponent<player_stats>().rb.velocity.x, GetComponent<player_stats>().jumpForce, 0);
            GetComponent<player_stats>().jumpCounter = GetComponent<player_stats>().jumpTimer;
            GetComponent<player_stats>().isJumping = true;

        }

        if (Input.GetButtonUp("Jump"))
        {

            GetComponent<player_stats>().jumpCounter = 0;
            GetComponent<player_stats>().isJumping = false;

        }

    }

    void FixedUpdate()
    {

        GetComponent<player_stats>().jumpCounter -= Time.deltaTime;

        if (GetComponent<player_stats>().jumpCounter <= 0)
        {

            GetComponent<player_stats>().jumpCounter = 0;
            GetComponent<player_stats>().isJumping = false;

        }

        if (GetComponent<player_stats>().isJumping == true)
        {

            GetComponent<player_stats>().rb.velocity = new Vector3(GetComponent<player_stats>().rb.velocity.x, GetComponent<player_stats>().rb.velocity.y + GetComponent<player_stats>().jumpAccel, 0);

        }

    }
}
