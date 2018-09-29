using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_wallJump : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (GetComponent<player_stats>().onWall == true && gameObject.GetComponent<Rigidbody>().velocity.y < GetComponent<player_stats>().wallSlideSpeed)
        {

            GetComponent<Rigidbody>().velocity = new Vector3(gameObject.GetComponent<Rigidbody>().velocity.x, GetComponent<player_stats>().wallSlideSpeed, 0);

        }

        if (Input.GetButtonDown("Jump") && GetComponent<player_stats>().grounded == false && GetComponent<player_stats>().onWall == true)
        {

            GetComponent<player_stats>().manualMove = false;
            GetComponent<player_stats>().wallJumpCounter = GetComponent<player_stats>().wallJumpTimer;
            GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<player_stats>().wallJumpForce.x * GetComponent<player_stats>().wallJumpMod, GetComponent<player_stats>().wallJumpForce.y, 0);

            if(GetComponent<player_stats>().lookingRight == true)
            {

                GetComponent<player_stats>().lookingRight = false;

            }
            else if(GetComponent<player_stats>().lookingRight == false)
            {

                GetComponent<player_stats>().lookingRight = true;

            }

        }

    }

    private void FixedUpdate()
    {

        GetComponent<player_stats>().wallJumpCounter -= Time.deltaTime;

        if(GetComponent<player_stats>().wallJumpCounter <= 0 && GetComponent<player_stats>().manualMove == false)
        {

            GetComponent<player_stats>().manualMove = true;
            GetComponent<player_stats>().wallJumpCounter = 0;

        }

    }
}
