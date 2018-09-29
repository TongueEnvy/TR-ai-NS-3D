using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_setGrounded : MonoBehaviour {

    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {

        player.GetComponent<player_stats>().grounded = true;
        player.GetComponent<player_stats>().onWall = false;
        player.GetComponent<player_stats>().wallJumpCounter = 0;
        player.GetComponent<player_stats>().manualMove = true;

    }

    private void OnTriggerStay(Collider other)
    {

        player.GetComponent<player_stats>().grounded = true;
        player.GetComponent<player_stats>().onWall = false;
        player.GetComponent<player_stats>().wallJumpCounter = 0;
        player.GetComponent<player_stats>().manualMove = true;

    }

    private void OnTriggerExit(Collider other)
    {

        
        player.GetComponent<player_stats>().grounded = false;

    }

}
