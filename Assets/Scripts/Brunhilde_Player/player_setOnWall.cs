using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_setOnWall : MonoBehaviour {

    public GameObject player;
    public int wallJumpMod;
    public bool lookingRight;

    private void OnTriggerEnter(Collider other)
    {

        if (player.GetComponent<player_stats>().grounded == false)
        {
            player.GetComponent<player_stats>().onWall = true;
        }
        player.GetComponent<player_stats>().wallJumpMod = wallJumpMod;
        player.GetComponent<player_stats>().wallJumpCounter = 0;
        player.GetComponent<player_stats>().manualMove = true;
        player.GetComponent<player_stats>().lookingRight = lookingRight;

    }

    private void OnTriggerStay(Collider other)
    {

        if (player.GetComponent<player_stats>().grounded == false)
        {
            player.GetComponent<player_stats>().onWall = true;
        }

        player.GetComponent<player_stats>().wallJumpMod = wallJumpMod;

    }

    private void OnTriggerExit(Collider other)
    {

        player.GetComponent<player_stats>().onWall = false;
        

    }
}
