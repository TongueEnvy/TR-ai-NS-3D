using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_horizontalMovement : MonoBehaviour {

    // Update is called once per frame
    void Update()
    {

        if (GetComponent<player_stats>().manualMove == true)
        {

            GetComponent<player_stats>().rb.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * GetComponent<player_stats>().horMoveSpeed, GetComponent<player_stats>().rb.velocity.y, 0);
            if (Input.GetAxisRaw("Horizontal") != 0 && GetComponent<player_stats>().onWall == false)
            {

                if (Input.GetAxisRaw("Horizontal") < 0)
                {

                    GetComponent<player_stats>().lookingRight = false;

                }
                else
                if (Input.GetAxisRaw("Horizontal") > 0)
                {

                    GetComponent<player_stats>().lookingRight = true;

                }

            }

        }

    }

}
